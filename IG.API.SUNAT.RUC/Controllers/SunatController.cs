using IG.API.SUNAT.RUC.Model;
using IG.API.SUNAT.RUC.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace IG.API.SUNAT.RUC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SunatController : Controller
    {
        private readonly ContribuyenteService _contribuyenteService;
        private readonly IConfiguration _configuration;
        protected ApiRespose _response;
        public SunatController(ContribuyenteService contribuyenteService, IConfiguration configuration)
        {
            _contribuyenteService = contribuyenteService;
            _configuration = configuration;
            _response = new();
        }
        [HttpGet]
        public Contribuyente ConsultarRuc()
        {
            return new Contribuyente
            {
                RUC = "Este es mi RUC",
                NombreVia = "Nobre de Via"
            };
        }

        [HttpGet("ruc")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<ApiRespose>> ConsultarRuc(string ruc)
        {
            var _MesajeError = string.Empty;
            var _ruc = ruc.TrimStart().TrimEnd();
            var _Carac = 11;
            Contribuyente _contribuyente = null;
            try
            {
                if (_ruc.Length > _Carac)
                    _MesajeError = $"RUC '{ruc}': Maximo de Caracteres es {_Carac}.";
                else
                {
                    // Accede a la configuración
                    string separador = _configuration.GetSection("Config")["SepardorData"] ?? "|";
                    string RutaGuardar = _configuration.GetSection("Config")["RutaGuardar"] ?? "";
                    string NombreArchivoTxt = _configuration.GetSection("Config")["NombreArchivoTxt"] ?? "";
                    var filePath = Path.Combine(RutaGuardar, NombreArchivoTxt);
                    if (!System.IO.File.Exists(filePath))
                    {
                        if (!System.IO.Directory.Exists(RutaGuardar))
                            System.IO.Directory.CreateDirectory(RutaGuardar);
                        var URLDescarga = _configuration.GetSection("Config")["URLDescarga"] ?? "http://www2.sunat.gob.pe/padron_reducido_ruc.zip";
                        var nombreArchivoZip = _configuration.GetSection("Config")["nombreArchivoZip"] ?? "padron_reducido_ruc.zip";
                        await _contribuyenteService.DescargarAsync(URLDescarga, RutaGuardar, nombreArchivoZip);
                    }

                    _contribuyente = await _contribuyenteService.ObtenerContribuyentePorRucAsync(filePath, _ruc.ToUpper(), separador.ToCharArray()[0]);

                    if (_contribuyente == null)
                        _MesajeError = $"El RUC '{ruc}' no fue encontrado en el archivo.";
                }
                if (!string.IsNullOrEmpty(_MesajeError))
                {
                    _response.ErrorMessages = new List<string>() { _MesajeError };
                    _response.statusCode = HttpStatusCode.NotFound;
                    _response.esExito = false;
                    return NotFound(_response);
                }
                else
                {
                    _response.Response = _contribuyente;
                    _response.statusCode = HttpStatusCode.OK;
                    return Ok(_response);
                }
            }
            catch (Exception ex)
            {

                _response.esExito = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;

        }

        [HttpGet("Descargar")]
        public async Task<ActionResult> DescargarPadron()
        {
            // Accede a la configuración
            string RutaGuardar = _configuration.GetSection("Config")["RutaGuardar"] ?? "";
            string NombreArchivoTxt = _configuration.GetSection("Config")["NombreArchivoTxt"] ?? "";

            if (!System.IO.Directory.Exists(RutaGuardar))
                System.IO.Directory.CreateDirectory(RutaGuardar);
            var URLDescarga = _configuration.GetSection("Config")["URLDescarga"] ?? "http://www2.sunat.gob.pe/padron_reducido_ruc.zip";
            var nombreArchivoZip = _configuration.GetSection("Config")["nombreArchivoZip"] ?? "padron_reducido_ruc.zip";
            await _contribuyenteService.DescargarAsync(URLDescarga, RutaGuardar, nombreArchivoZip);

            return Ok();
        }

    }

}