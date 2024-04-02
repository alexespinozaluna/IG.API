using IG.API.SUNAT.FE.Common;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Data.SqlClient;
using System.Data;
using IG.API.SUNAT.FE.DTO;
using IG.API.SUNAT.FE.DataAccess;
using IG.API.SUNAT.FE.Services;

namespace IG.API.SUNAT.FE.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class SendDocController : ControllerBase
    {
        private readonly IFn _fn;
        private readonly IConexion _conexion;
        private readonly ISQLDataService _SQLData;
        public SendDocController(IFn fn, IConexion conexion, ISQLDataService SQLData)
        {
            _fn = fn;
            _conexion = conexion;
            _SQLData = SQLData;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ComprobanteRequest request)
        {


            var response = new Respuesta();

            try
            {
                string nomArchivo = string.Empty;

            string xmlFirmado = string.Empty;
            var empresa = await _SQLData.GeTEmpresaAsync(request.RUC);
            if (empresa.Data != null)
            {

                var config = empresa.Data;

                var IdComprobante = request.Id;
                bool esResumen = request.EsResumen;

                nomArchivo = request.NomArchivo;
                var encoding = config.nvEncoding;
                var indiceNodoFirma = 0;

                var bytesXml = Convert.FromBase64String(request.XmlBase64);
                string textXml = System.Text.Encoding.UTF8.GetString(bytesXml);
                //FIRMAR
                xmlFirmado = await _fn.FirmarAsync(config.ntCertificadoPfx, config.nvCertificadoPass, textXml, encoding, indiceNodoFirma);
                string firmadoZip = await _fn.ZipAsync(xmlFirmado, nomArchivo);

                config.ntSoapFE = config.ntSoapFE.Replace("@usuario", config.nvUsuarioFE);
                config.ntSoapFE = config.ntSoapFE.Replace("@clave", config.nvClaveFE);

                //ENVIAR DOCUMENTO
                var stringSoap = String.Format(config.ntSoapFE, nomArchivo + ".zip", firmadoZip);
                var SoapResponse = await _fn.enviarSoapAsync(config.nvURLFE, stringSoap);

                if (SoapResponse.Contains("<html>"))
                    throw new ApplicationException(SoapResponse);

                #region LEER_SOAP_RESPUESTA

                string[] espaciodenombre = "soap-env|br".Split('|');
                response = await _fn.ObtenerRespuestaAsync(SoapResponse, espaciodenombre, esResumen, config.nvProveedorFE, null, null);

                #endregion LEER_RESPUESTA
                await _SQLData.InsertComprobante(request.Id, xmlFirmado, nomArchivo, response);


            }
            else
            {
                throw new ApplicationException($"No existe datos a procesar! {request.NomArchivo} : {empresa.ErrorMessage}");
            }

        }
            catch (Exception ex)
            {

                throw ex;
            }

            return Ok(response);
        }
    }
}
