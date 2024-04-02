using IG.API.SUNAT.FE.Dto;
using IG.API.SUNAT.FE.Entity;
using IG.API.SUNAT.FE.Services;
using IG.API.SUNAT.FE.Services.Util;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace IG.API.SUNAT.FE.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ApiController : ControllerBase
    {
        private readonly IFEServices _fEServices;
        private readonly IApiUtil _apiUtil;
        public ApiController(

            IFEServices fEServices, IApiUtil apiUtil)
        {
            _fEServices = fEServices;
            _apiUtil = apiUtil;
        }


        [HttpPost]
        public async Task<ActionResult> SendDoc([FromBody] ComprobanteRequest request)
        {
            var response = new BaseResponseGeneric<ComprobanteResponseDto>();

            string nomArchivo = string.Empty;
            string xmlFirmado = string.Empty;
            var empresa = await _fEServices.GetEmpresaAsync(request.bProduccion, request.RUC);
            if (empresa.Data != null)
            {
                var config = empresa.Data;
                var IdmaeEmpresa = config.IdmaeEmpresa;

                nomArchivo = request.NomArchivo;
                var encoding = config.nvEncoding;
                var indiceNodoFirma = 0;
                var bytesXml = Convert.FromBase64String(request.XmlBase64);
                string textXml = System.Text.Encoding.UTF8.GetString(bytesXml);
                //FIRMAR
                xmlFirmado = await _apiUtil.FirmarAsync(config.ntCertificadoPfx, config.nvCertificadoPass, textXml, encoding, indiceNodoFirma);
                var firmadoZip = await _apiUtil.ZipAsync(xmlFirmado, nomArchivo);
                var hashZipXml = await _apiUtil.HashZipAsync(firmadoZip);

                var archivo = new Archivo
                {
                    archivo = new ArchivoBase
                    {
                        nomArchivo = $"{request.NomArchivo}.zip",
                        arcGreZip = firmadoZip,
                        hashZip = hashZipXml
                    }
                };

                var jsonBody = JsonConvert.SerializeObject(archivo);

                request.XmlBase64 = jsonBody;
               var  responseApi = await _fEServices.SendApi(request, config);

                string errors = null;
                if (responseApi.Data?.errors != null)
                    errors = string.Join(",", responseApi.Data?.errors);

                var responseXML = new Respuesta
                {
                    ticket = responseApi.Data?.numTicket,
                    faultstring = responseApi.ErrorMessage ?? errors

                };

             response=   await _fEServices.InsertComprobante(request.Id, xmlFirmado, nomArchivo, IdmaeEmpresa, responseXML, null);

            }

            return response.Success ? Ok(response) : BadRequest(response);
        }
        [HttpPost]
        public async Task<ActionResult> ConsultarTicket([FromBody] GetStatusRequestDto request)
        {
            var response = new BaseResponseGeneric<RespuestaComunComprobanteDto>();
            var responseXmlData = new Respuesta();
            var responseConsultaTicket = new BaseResponseGeneric<ApiGreConsultaDto>();
            var empresa = await _fEServices.GetEmpresaAsync(request.bProduccion, request.RUC);
            if (empresa.Data != null)
            {
                responseConsultaTicket = await _fEServices.ConsultarTicket(request, empresa.Data);

                var data = responseConsultaTicket.Data;

                if (data != null)
                {
                    if (data.arcCdr != null)
                    {
                        var responseXml = await _apiUtil.ObtenerRespuestaAsync(null, null, false, empresa.Data.nvProveedorFE, "getStatusCode", "getStatusBase64", "getStatusBase64", data.arcCdr);
                        responseXmlData = responseXml.Data;
                        response.ErrorMessage = responseXml.ErrorMessage;
                        response.Success = responseXml.Success;
                    }
                    else
                    {
                        var error = string.Join(",", data.error.Text);
                        var dataTicket = new Respuesta
                        {
                            faultcode = data.codRespuesta ?? data.cod,
                            faultstring = (data?.error.Text ?? data?.message) ?? data.msg,

                        };

                        responseXmlData = dataTicket;
                    }

                }
                else
                {
                    responseXmlData.faultstring = response.ErrorMessage;
                }

              var  respData = await _fEServices.InsertComprobante(request.Id, null, null, empresa.Data.IdmaeEmpresa, responseXmlData, request.Ticket);
               
                response.Data = new RespuestaComunComprobanteDto
                {
                    Codigo = respData.Data.Codigo,
                    Mensaje= respData.Data.Mensaje,
                    Descripcion= respData.Data.Descripcion,
                    Observacion= respData.Data.Observacion,
                    XmlCdr= respData.Data.XmlCdr
                };
               
            }
            else
            {
                response.ErrorMessage = responseConsultaTicket.ErrorMessage;

            }
            return response.Success ? Ok(response) : BadRequest(response);

        }
    }
}
