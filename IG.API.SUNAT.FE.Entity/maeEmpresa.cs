namespace IG.API.SUNAT.FE.Entity
{
    public class maeEmpresa:EntityBase
    {
        public int IdmaeEmpresa { get; set; }
        public bool? bProduccion { get; set; }
        public string NommaeEmpresa { get; set; } 
        public string? nvNumDocumentoIdentidad { get; set; } 
        public string nvCodTipoDocumentoIdentidad { get; set; } 
        public string? nvEncoding { get; set; } 
        public string ntCertificadoPfx { get; set; } 
        public string nvCertificadoPass { get; set; } 
        public string nvURLFE { get; set; } = default!;
        public string nvUsuarioFE { get; set; } = default!;
        public string nvClaveFE { get; set; } = default!;
        public string nvProveedorFE { get; set; }
        public string ntSoapFE { get; set; } = default!;
        public string? nvScopeApiFE { get; set; } 
        public string? nvClientIdApiFE { get; set; } 
        public string? nvClientSecretApiFE { get; set; } 
        public string? nvURLTokenApiFE { get; set; }
        public string? nvURLEnvioApiFE { get; set; } 
        public string? nvURLConsultaApiFE { get; set; }
        public string? nvURLFECDR { get; set; }

        public OauthAccessToken Token { get; set; }
    }
}
