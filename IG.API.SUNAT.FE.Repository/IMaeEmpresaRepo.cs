using IG.API.SUNAT.FE.Entity;

namespace IG.API.SUNAT.FE.Repository
{
    public interface IMaeEmpresaRepo : IRepositoryBase<maeEmpresa>
    {
        Task<maeEmpresa?> GetEmpresaByRucProdAsync(bool bProduccion, string ruc);
    }
}
