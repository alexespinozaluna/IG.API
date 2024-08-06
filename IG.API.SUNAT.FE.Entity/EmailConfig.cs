namespace IG.API.SUNAT.FE.Entity
{
    public class EmailConfig:EntityBase
    {
        public string Host { get; set; }
        public int Port { get; set; } 
        public bool EnableSsl { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string DisplayName { get; set; }
        public int IdEmpresa { get; set; }
        public maeEmpresa Empresa { get; set; } = default!;

    }
}
