using IG.API.SUNAT.FE.Entity;
using IG.API.SUNAT.FE.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IG.API.SUNAT.FE.Repository
{
    public class MaeEmpresaRepo : RepositoryBase<maeEmpresa>, IMaeEmpresaRepo
    {
     
        public MaeEmpresaRepo(IGAPIFEAppDbContext context) : base(context)
        {
        }

        public async Task<maeEmpresa?> GetEmpresaByRucProdAsync(bool bProduccion, string ruc)
        {
            var response = new maeEmpresa();

            // Codigo
            return  await Context.Set<maeEmpresa>()
                .AsNoTracking()
                .Where(p => p.nvNumDocumentoIdentidad == ruc && p.bProduccion == bProduccion)
                .FirstOrDefaultAsync();

         
        }
    }
}
