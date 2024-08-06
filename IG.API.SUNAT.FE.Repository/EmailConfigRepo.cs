using IG.API.SUNAT.FE.Entity;
using IG.API.SUNAT.FE.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IG.API.SUNAT.FE.Repository
{
    public class EmailConfigRepo : RepositoryBase<EmailConfig>, IEmailConfigRepo
    {
        public EmailConfigRepo(IGAPIFEAppDbContext context) : base(context)
        {
        }

        public override  async Task<ICollection<EmailConfig>> ListAsync()
        {
            return await Context.Set<EmailConfig>()
               .Include(p => p.Empresa)
               .AsNoTracking()
               .ToListAsync();
        }
    }
}
