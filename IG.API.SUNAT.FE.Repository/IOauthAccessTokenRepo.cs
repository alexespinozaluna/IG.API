using IG.API.SUNAT.FE.Entity;

namespace IG.API.SUNAT.FE.Repository
{
    public interface IOauthAccessTokenRepo:IRepositoryBase<OauthAccessToken>
    {
        Task<OauthAccessToken> GetTokenDb(int IdmaeEmpresa);
    }
}
