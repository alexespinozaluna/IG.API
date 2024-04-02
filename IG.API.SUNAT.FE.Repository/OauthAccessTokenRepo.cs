using IG.API.SUNAT.FE.Entity;
using IG.API.SUNAT.FE.Persistence;
using IG.API.SUNAT.FE.Repository.Util;
using Microsoft.EntityFrameworkCore;

namespace IG.API.SUNAT.FE.Repository
{
    public class OauthAccessTokenRepo:RepositoryBase<OauthAccessToken>, IOauthAccessTokenRepo
    {
        private readonly IFnDb _fnDb;

    public OauthAccessTokenRepo(IGAPIFEAppDbContext context, IFnDb fnDb) : base(context)
    {
        _fnDb = fnDb;
    }

    public async Task<OauthAccessToken> GetTokenDb( int IdmaeEmpresa)
    {
        var responseList = new List<OauthAccessToken>();
        var response = new OauthAccessToken();

        // Codigo
        responseList = await Context.Set<OauthAccessToken>()
            .AsNoTracking()
            .Where(p => p.Empresa.IdmaeEmpresa == IdmaeEmpresa)
            .ToListAsync();

        if (responseList is not null)
        {
            foreach (var item in responseList)
            {
                if (item.date_expires_in > await _fnDb.GetDateTimeDb())
                {
                    response = item;
                }
                else
                {
                    await DeleteAsync(item.Id);
                }
            }
        }
        return response;

    }
    
    }
}
