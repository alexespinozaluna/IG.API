using IG.API.SUNAT.FE.Entity;
using IG.API.SUNAT.FE.Persistence;

namespace IG.API.SUNAT.FE.Repository
{
    public class tdHTMLRepo : RepositoryBase<tdHTML>, ItdHTMLRepo
    {
        public tdHTMLRepo(IGAPIFEAppDbContext context) : base(context)
        {
        }
    }
}
