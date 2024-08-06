using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using System.Security.Claims;

namespace IG.API.SUNAT.Web.Auth
{
    public class ProveedorAutenticacion : AuthenticationStateProvider
    {
        private readonly ProtectedSessionStorage _sessionStorage;
        private ClaimsPrincipal _anonymous = new ClaimsPrincipal(new ClaimsIdentity());
        private ClaimsPrincipal _currentUser = null;

        public ProveedorAutenticacion(ProtectedSessionStorage sessionStorage)
        {
            _sessionStorage = sessionStorage;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            try
            {
                var userSessionStorageResult = await _sessionStorage.GetAsync<UserSession>("UserSession");
                var userSession = userSessionStorageResult.Success ? userSessionStorageResult.Value : null;

                if (userSession == null)
                {
                    _currentUser = _anonymous;
                    return new AuthenticationState(_anonymous);
                }

                var claims = CreateClaims(userSession);
                _currentUser = new ClaimsPrincipal(new ClaimsIdentity(claims, "CustomAuth"));
                return new AuthenticationState(_currentUser);
            }
            catch (Exception)
            {
                _currentUser = _anonymous;
                return new AuthenticationState(_anonymous);
            }
        }

        public async Task UpdateAuthenticationState(UserSession userSession)
        {
            if (userSession != null)
            {
                await _sessionStorage.SetAsync("UserSession", userSession);
                var claims = CreateClaims(userSession);
                _currentUser = new ClaimsPrincipal(new ClaimsIdentity(claims, "CustomAuth"));
            }
            else
            {
                await _sessionStorage.DeleteAsync("UserSession");
                _currentUser = _anonymous;
            }

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(_currentUser)));
        }

        public UserSession GetUserSession()
        {
            return GetUserOfClaims(_currentUser?.Claims.ToList() ?? new List<Claim>());
        }

        private List<Claim> CreateClaims(UserSession userSession)
        {
            return new List<Claim>
            {
                new Claim(ClaimTypes.Name, userSession.UserName),
                new Claim(ClaimTypes.Hash, userSession.Hash),
                new Claim(ClaimTypes.Role, userSession.Role),
                new Claim("Area", userSession.Area),
                new Claim("Id", userSession.Id.ToString()),
                new Claim("IsAdmin", userSession.IsAdmin.ToString())
            };
        }

        private UserSession GetUserOfClaims(List<Claim> claims)
        {
            var userSession = new UserSession();

            foreach (var claim in claims)
            {
                switch (claim.Type)
                {
                    case ClaimTypes.Name:
                        userSession.UserName = claim.Value;
                        break;
                    case ClaimTypes.Hash:
                        userSession.Hash = claim.Value;
                        break;
                    case ClaimTypes.Role:
                        userSession.Role = claim.Value;
                        break;
                    case "Area":
                        userSession.Area = claim.Value;
                        break;
                    case "Id":
                        userSession.Id = int.Parse(claim.Value);
                        break;
                    case "IsAdmin":
                        userSession.IsAdmin = bool.Parse(claim.Value);
                        break;
                }
            }

            return userSession;
        }
    }
}
