using IG.API.SUNAT.RUC.Common;
using IG.API.SUNAT.RUC.Model;
using IG.API.SUNAT.RUC.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;

namespace IG.API.SUNAT.RUC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SunatController : Controller
    {
        private readonly ContribuyenteService _contribuyenteService;
        private readonly IConfiguration _configuration;

        public SunatController(ContribuyenteService contribuyenteService, IConfiguration configuration)
        {
            _contribuyenteService = contribuyenteService;
            _configuration = configuration;
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
        public async Task<ActionResult<Contribuyente>> ConsultarRuc(string ruc)
        {
            var _MesajeError = string.Empty;
            var _ruc = ruc.TrimStart().TrimEnd();
            var _Carac = 11;
            if (_ruc.Length > 11)
                _MesajeError = $"RUC '{ruc}': Maximo de Caracteres es {_Carac}.";

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

            var contribuyente = await _contribuyenteService.ObtenerContribuyentePorRucAsync(filePath, _ruc.ToUpper(), separador.ToCharArray()[0]);

            if (contribuyente == null)
                _MesajeError = $"El RUC '{ruc}' no fue encontrado en el archivo. Comunica con su Adminstrador";

            if (!string.IsNullOrEmpty(_MesajeError))
                return NotFound(_MesajeError);
            else
                return Ok(contribuyente);
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