namespace IG.API.SUNAT.Web.Auth
{
    public interface IUserSesionHelper
    {
        Task<UserSession> GetUserSession();
    }
}
