namespace IG.API.SUNAT.Web.Auth
{
    public interface IUserSesionHelper
    {
        Task<UserSessionDto> GetUserSession();
    }
}
