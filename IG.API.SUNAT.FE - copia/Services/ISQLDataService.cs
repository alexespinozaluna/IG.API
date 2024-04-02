using IG.API.SUNAT.FE.DTO;
using IG.API.SUNAT.FE.Entity;

namespace IG.API.SUNAT.FE.Services
{
    public interface ISQLDataService
    {
        Task<BaseResponseGeneric<maeEmpresa>> GeTEmpresaAsync(string DocumentoIdentidad);
        Task InsertComprobante(string Id, string XmlBase64, string NomArchivo, Respuesta response);

    }
}
