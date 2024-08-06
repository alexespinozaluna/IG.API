namespace IG.API.SUNAT.FE.Entity
{
    public class SistemaUsuario : EntityBase
    {
        public int IdSistemaUsuario { get; set; }
        public string CodSistemaUsuario { get; set; }
        public string NomSistemaUsuario { get; set; }     
        public string PassUsuario { get; set; }
        public bool EsAdministrador { get; set; }
        public bool Desactivado { get; set; }
        public bool CambiarPass { get; set; }
        public int IdEmpresa { get; set; }
        public  maeEmpresa Empresa { get; set; } = default!;
    }
}
