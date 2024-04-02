using IG.API.SUNAT.RUC.Service;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;

namespace IG.API.SUNAT.RUC.Security
{
    public class BasicAuthHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly UserService _userService;
        public BasicAuthHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder enconder,
            ISystemClock clock,
            UserService userService
            ) : base(options, logger, enconder, clock)
        {
            _userService = userService;
        }
        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            var authBasic = "Authorization";
            var msError = string.Empty;
            if (!Request.Headers.ContainsKey(authBasic))
            {
                msError = $"Nose puede procesar {authBasic}";
                return AuthenticateResult.Fail(msError);
                //throw new AuthenticationFailureException(msError);
            }
            bool resul = false;
            var cod = string.Empty;
            var pwd = string.Empty;
            try
            {
                msError = string.Empty;
                var authHeader = AuthenticationHeaderValue.Parse(Request.Headers[authBasic]);
                var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
                var credentials = Encoding.UTF8.GetString(credentialBytes).Split(new[] { ':' }, 2);
                cod = credentials[0];
                pwd = credentials[1];
                var user = await _userService.GetUserCredentialsAsync(cod);

                if (user == null)
                {
                    msError = "Usuaro No existe";
                }
                else
                {
                    if (user?.Password == pwd)
                        resul = true;
                    else
                        msError = "Contraseña Invalida";
                }

            }
            catch (Exception ex)
            {

                msError = $"Error {authBasic} => {ex.Message}";
            }
            if (!resul)
            {
                //throw new Exception(msError);
                return AuthenticateResult.Fail(msError);
            }

            var claims = new Claim[]
            {
                    new Claim(ClaimTypes.Name, cod),
                    new Claim(ClaimTypes.Sid, pwd)
            };
            var identity = new ClaimsIdentity(claims, Scheme.Name);
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, Scheme.Name);
            return AuthenticateResult.Success(ticket);

        }
    }
}
