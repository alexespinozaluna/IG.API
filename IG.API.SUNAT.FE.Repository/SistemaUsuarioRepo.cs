using IG.API.SUNAT.FE.Entity;
using IG.API.SUNAT.FE.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IG.API.SUNAT.FE.Repository
{
    public class SistemaUsuarioRepo : RepositoryBase<SistemaUsuario>, ISistemaUsuarioRepo
    {

        public SistemaUsuarioRepo(IGAPIFEAppDbContext context) : base(context)
        {
        }

        public async Task<SistemaUsuario> GetUsuario(string CodUsuario)
        {
            var response = new SistemaUsuario();

            // Codigo
            return await Context.Set<SistemaUsuario>()
                .AsNoTracking()
                .Where(p => p.CodSistemaUsuario == CodUsuario)
                .FirstOrDefaultAsync();
        }

        public override async Task<ICollection<SistemaUsuario>> ListAsync()
        {

            //return base.ListAsync();
            return await Context.Set<SistemaUsuario>()
                .Include( p=>p.Empresa)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
