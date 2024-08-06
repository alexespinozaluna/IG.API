using IG.API.SUNAT.FE.Dto;
using IG.API.SUNAT.FE.Entity;
using IG.API.SUNAT.FE.Services;
using IG.API.SUNAT.FE.Services.Util;
using Microsoft.AspNetCore.Mvc;

namespace IG.API.SUNAT.FE.Controllers
{

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class SoapController : ControllerBase
    {
        private readonly IFEServices _fEServices;
        private readonly IApiUtil _apiUtil;
        public SoapController(

            IFEServices fEServices, IApiUtil apiUtil)
        {
            _fEServices = fEServices;
            _apiUtil = apiUtil;
        }

        [HttpPost]
        public async Task<ActionResult> SendDoc([FromBody] ComprobanteRequest request)
        {
            var response = new BaseResponseGeneric<ComprobanteResponseDto>();
            try
            {
                string nomArchivo = string.Empty;

                string xmlFirmado = string.Empty;
                var empresa = await _fEServices.GetEmpresaAsync(request.bProduccion, request.RUC);
                if (empresa.Data != null)
                {

                    var config = empresa.Data;
                    var IdmaeEmpresa = empresa.Data.IdmaeEmpresa;

                    var IdComprobante = request.Id;
                    bool esResumen = request.EsResumen;

                    nomArchivo = request.NomArchivo;
                    var encoding = config.nvEncoding;
                    var indiceNodoFirma = 0;

                    var bytesXml = Convert.FromBase64String(request.XmlBase64);
                    string textXml = System.Text.Encoding.UTF8.GetString(bytesXml);
                    //FIRMAR
                    xmlFirmado = await _apiUtil.FirmarAsync(config.ntCertificadoPfx, config.nvCertificadoPass, textXml, encoding, indiceNodoFirma);
                    string firmadoZip = await _apiUtil.ZipAsync(xmlFirmado, nomArchivo);

                    config.ntSoapFE = config.ntSoapFE.Replace("@usuario", config.nvUsuarioFE);
                    config.ntSoapFE = config.ntSoapFE.Replace("@clave", config.nvClaveFE);
                    if (request.EsResumen)
                        config.ntSoapFE = config.ntSoapFE.Replace("ser:sendBill", "ser:sendSummary");
                    //ENVIAR DOCUMENTO
                    var stringSoap = String.Format(config.ntSoapFE, nomArchivo + ".zip", firmadoZip);
                    var SoapResponse = await _apiUtil.EnviarSoapAsync(config.nvURLFE, stringSoap);

                    if (SoapResponse.Contains("<html>"))
                        throw new ApplicationException(SoapResponse);

                    #region LEER_SOAP_RESPUESTA

                    string[] espaciodenombre = "soap-env|br".Split('|');
                    var responseXML = await _apiUtil.ObtenerRespuestaAsync(SoapResponse, espaciodenombre, esResumen, config.nvProveedorFE, null, null);
                    var responseXMLData = responseXML.Data;
                    #endregion LEER_RESPUESTA

                    response = await _fEServices.InsertComprobante(request.Id, xmlFirmado, nomArchivo, IdmaeEmpresa, responseXMLData, null  );
                }
                else
                {
                    throw new ApplicationException($"No existe datos a procesar! {request.NomArchivo} : {empresa.ErrorMessage}");
                }

            }
            catch (Exception ex)
            {

                response.ErrorMessage = ex.Message;
            }

            return response.Success ? Ok(response) : BadRequest(response);
        }

        [HttpPost]
        public async Task<ActionResult> GetStatus([FromBody] GetStatusRequestDto request)
        {
            var response = new BaseResponseGeneric<GetStatusDto>();
            try
            {
                string nomArchivo = string.Empty;
                var arcCdr = string.Empty;

                string xmlFirmado = string.Empty;
                var empresa = await _fEServices.GetEmpresaAsync(request.bProduccion, request.RUC);
                if (empresa.Data != null)
                {
                    var config = empresa.Data;
                    var IdmaeEmpresa = empresa.Data.IdmaeEmpresa;
                    var IdComprobante = request.Id;
                    var proveedor = config.nvProveedorFE;

                    //nomArchivo = request.NomArchivo;
                    var encoding = config.nvEncoding;

                    config.ntSoapFE = config.ntSoapFE.Replace("@usuario", config.nvUsuarioFE);
                    config.ntSoapFE = config.ntSoapFE.Replace("@clave", config.nvClaveFE);
                    config.ntSoapFE = config.ntSoapFE.Replace("ser:sendBill", "ser:getStatus");
                    config.ntSoapFE = config.ntSoapFE.Replace("<fileName>{0}</fileName>", "<ticket>{0}</ticket>");
                    config.ntSoapFE = config.ntSoapFE.Replace("<contentFile>{1}</contentFile>", "");

                    //ENVIAR DOCUMENTO
                    var stringSoap = String.Format(config.ntSoapFE, request.Ticket);
                    var SoapResponse = await _apiUtil.EnviarSoapAsync(config.nvURLFE, stringSoap);

                    if (SoapResponse.Contains("<html>"))
                        throw new ApplicationException(SoapResponse);


                    var espaciodenombre = "br|soap-env".Split("|");

                    var responseTicket = await _apiUtil.ObtenerRespuestaAsync(SoapResponse, espaciodenombre, false, proveedor, "getStatusCode", "getStatusBase64", "getStatusBase64", arcCdr);
                    var responseTicketData = responseTicket.Data;
                    string _Mensaje = responseTicketData.faultstring ?? responseTicketData.status;

                    if (!string.IsNullOrEmpty(responseTicketData.detail) & !string.IsNullOrEmpty(_Mensaje))
                        _Mensaje = responseTicketData.faultstring + ":" + responseTicketData.detail;

                    var getStatus = new GetStatusDto
                    {
                        Codigo = responseTicketData.faultcode,
                        Mensaje = _Mensaje,
                        Descripcion = responseTicketData.Description,
                        Observacion = responseTicketData.Notes,
                        XmlCdr = responseTicketData.XMLCdr,
                        URLDocumento = responseTicketData.URLDocument
                    };

                    response.Data = getStatus;
                }
                else
                {
                    throw new ApplicationException($"No existe datos a procesar! {request.Ticket} : {empresa.ErrorMessage}");
                }

            }
            catch (Exception ex)
            {

                response.ErrorMessage = ex.Message;
            }

            return response.Success ? Ok(response) : BadRequest(response);
        }

        [HttpPost]
        public async Task<ActionResult> GetStatusCdr([FromBody] GetStatusCdrDto request)
        {
            var response = new BaseResponseGeneric<GetStatusDto>();
            try
            {
                string nomArchivo = string.Empty;
                var arcCdr = string.Empty;

                string xmlFirmado = string.Empty;
                var empresa = await _fEServices.GetEmpresaAsync(request.bProduccion, request.RUC);
                if (empresa.Data != null)
                {
                    var config = empresa.Data;
                    var IdmaeEmpresa = empresa.Data.IdmaeEmpresa;
                    var IdComprobante = request.Id;
                    var proveedor = config.nvProveedorFE;

                    //nomArchivo = request.NomArchivo;
                    var encoding = config.nvEncoding;

                    var parametros = $"<rucComprobante>{request.rucComprobante}</rucComprobante> <tipoComprobante>{request.tipoComprobante}</tipoComprobante><serieComprobante>{request.serieComprobante}</serieComprobante><numeroComprobante>{request.numeroComprobante}</numeroComprobante>";

                    config.ntSoapFE = config.ntSoapFE.Replace("@usuario", config.nvUsuarioFE);
                    config.ntSoapFE = config.ntSoapFE.Replace("@clave", config.nvClaveFE);
                    config.ntSoapFE = config.ntSoapFE.Replace("ser:sendBill", "ser:getStatusCdr");
                    config.ntSoapFE = config.ntSoapFE.Replace("<fileName>{0}</fileName>", "{0}");
                    config.ntSoapFE = config.ntSoapFE.Replace("<contentFile>{1}</contentFile>", "");

                    //ENVIAR DOCUMENTO
                    var stringSoap = String.Format(config.ntSoapFE, parametros);
                    var SoapResponse = await _apiUtil.EnviarSoapAsync(config.nvURLFECDR, stringSoap);

                    if (SoapResponse.Contains("<html>"))
                        throw new ApplicationException(SoapResponse);


                    var espaciodenombre = "br|soap-env".Split("|");

                    var responseTicket = await _apiUtil.ObtenerRespuestaAsync(SoapResponse, espaciodenombre, false, proveedor, "getstatusCdrCode", "getstatusCdrMessage", "getStatusCdrBase64");
                    var responseTicketData = responseTicket.Data;
                    string _Mensaje = responseTicketData.faultstring ?? responseTicketData.status;

                    if (!string.IsNullOrEmpty(responseTicketData.detail) & !string.IsNullOrEmpty(_Mensaje))
                        _Mensaje = responseTicketData.faultstring + ":" + responseTicketData.detail;

                    var getStatus = new GetStatusDto
                    {
                        Codigo = responseTicketData.faultcode,
                        Mensaje = _Mensaje,
                        Descripcion = responseTicketData.Description,
                        Observacion = responseTicketData.Notes,
                        XmlCdr = responseTicketData.XMLCdr,
                        URLDocumento = responseTicketData.URLDocument
                    };

                    response.Data = getStatus;
                }
                else
                {
                    throw new ApplicationException($"No existe datos a procesar! {request.serieComprobante}-{request.numeroComprobante}: {empresa.ErrorMessage}");
                }

            }
            catch (Exception ex)
            {

                response.ErrorMessage = ex.Message;
            }

            return response.Success ? Ok(response) : BadRequest(response);
        }
    }
}
