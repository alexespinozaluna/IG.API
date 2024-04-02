using System.ComponentModel.DataAnnotations.Schema;

namespace IG.API.SUNAT.FE.Entity
{
    public class OauthAccessToken : EntityBase
    {
        //public string ruc { get; set; }
        public string access_token { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
        public string username { get; set; }
        public DateTime date_expires_in { get; set; }
        public int IdmaeEmpresa { get; set; }
        public maeEmpresa Empresa { get; set; } = default!;


    }
}
