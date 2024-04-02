using System.Net;

namespace IG.API.SUNAT.RUC.Controllers
{
    public class ApiRespose
    {
        public HttpStatusCode statusCode { get; set; }
        public bool esExito { get; set; }  =true;
        public List<string> ErrorMessages { get; set; }
        public object Response { get; set; }

    }
}
