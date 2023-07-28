using IG.API.SUNAT.RUC.Common;
using IG.API.SUNAT.RUC.Model;

namespace IG.API.SUNAT.RUC.Service
{
    public class ContribuyenteService
    {
        public async Task<Contribuyente> ObtenerContribuyentePorRucAsync(string filePath, string ruc, char separador)
        {
            BuscarTexto sear = new BuscarTexto();
            var contribuyente = sear.Buscar(filePath, ruc.ToUpper(), separador);
            return await contribuyente;
        }

        public async Task DescargarAsync(string urlDescargar, string rutaGuardar, string nombreArchivo)
        {
            DescargarArchivo down = new DescargarArchivo();
            await down.Descargar(urlDescargar, rutaGuardar, nombreArchivo);
        }
    }
}
