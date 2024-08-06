using IG.API.SUNAT.FE.Dto;
using IG.API.SUNAT.FE.Services.Util;
using IG.API.SUNAT.FE.Services;
using Microsoft.AspNetCore.Mvc;

namespace IG.API.SUNAT.FE.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FirmarController : ControllerBase
    {
        private readonly IFEServices _fEServices;
        private readonly IApiUtil _apiUtil;
        public FirmarController(

            IFEServices fEServices, IApiUtil apiUtil)
        {
            _fEServices = fEServices;
            _apiUtil = apiUtil;
        }

        [HttpPost]
        public async Task<ActionResult> Firmar([FromBody] ComprobanteRequest request)
        {
            var response = new BaseResponseGeneric<FirmarXmlDto>();
            try
            {
                var empresa = await _fEServices.GetEmpresaAsync(request.bProduccion, request.RUC);
                if (empresa.Data != null)
                {
                    var config = empresa.Data;
                    var IdmaeEmpresa = config.IdmaeEmpresa;

                    var nomArchivo = request.NomArchivo;
                    var encoding = config.nvEncoding;
                    var indiceNodoFirma = 0;
                    var bytesXml = Convert.FromBase64String(request.XmlBase64);
                    string textXml = System.Text.Encoding.UTF8.GetString(bytesXml);
                    //FIRMAR
                    var xmlFirmado = await _apiUtil.FirmarAsync(config.ntCertificadoPfx, config.nvCertificadoPass, textXml, encoding, indiceNodoFirma);
                    var firmadoZip = await _apiUtil.ZipAsync(xmlFirmado, nomArchivo);
                    var hashZipXml = await _apiUtil.HashZipAsync(firmadoZip);

                    var xmlZipData = new FirmarXmlDto
                    {
                        XmlFirmadoZip = firmadoZip,
                        XmlZipHash=hashZipXml
                    };
                    response.Data=xmlZipData;
                    response.Success = response.Data != null;

                }
                else
                {
                    response.Data = null;
                    response.ErrorMessage = empresa.ErrorMessage;
                }
            }
            catch (Exception ex)
            {

                response.ErrorMessage = $"Firmar XML {ex.Message}";
            }
            return response.Success ? Ok(response) : BadRequest(response);
        }
    }
}
