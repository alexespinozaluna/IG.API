using IG.API.SUNAT.FE.Entity;

namespace IG.API.SUNAT.FE.Repository
{
    public interface ISUNATFEXMLEspacioNombreTagRepo:IRepositoryBase<SUNATFEXMLEspacioNombreTag>
    {
        Task<string?> GetByCodAndProveedor(string Codigo, string proveedor);
    }
}
