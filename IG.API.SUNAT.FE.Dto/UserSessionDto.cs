namespace IG.API.SUNAT.Web.Auth
{
    public class UserSessionDto
    {
        public string UserName { get; set; }
        public string Hash { get; set; }
        public string Area { get; set; }
        public string Role { get; set; }
        public int Id { get; set; }
        public bool isAdmin { get; set; }
    }
}
