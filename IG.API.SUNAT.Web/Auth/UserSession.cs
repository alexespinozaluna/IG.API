namespace IG.API.SUNAT.Web.Auth
{
    public class UserSession
    {
        public string UserName { get; set; }
        public string Hash { get; set; }
        public string Area { get; set; }
        public string Role { get; set; }
        public int Id { get; set; }
        public bool IsAdmin { get; set; }
    }
}
