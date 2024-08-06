using System.ComponentModel.DataAnnotations;

namespace IG.API.SUNAT.FE.Entity
{
    public class maeEmpresa : EntityBase
    {
        public int IdmaeEmpresa { get; set; }

        [Display(Name = "Es Prod.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public bool bProduccion { get; set; } = false;

        [Display(Name = "Nombre de Empresa")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string NommaeEmpresa { get; set; }

        [Display(Name = "Nro. de Documento")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string? nvNumDocumentoIdentidad { get; set; }

        [Display(Name = "Codigo Documento")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string nvCodTipoDocumentoIdentidad { get; set; }

        [Display(Name = "Encoding")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string? nvEncoding { get; set; }

        [Display(Name = "Certificado Pfx")]
        public string? ntCertificadoPfx { get; set; }

        [Display(Name = "Clave Certificado")]
        public string? nvCertificadoPass { get; set; }

        [Display(Name = "Url FE SOAP")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string nvURLFE { get; set; } = default!;

        [Display(Name = "Usuario FE")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string nvUsuarioFE { get; set; } = default!;
        [Display(Name = "Clave FE")]
        [Required(ErrorMessage = "El {0} es obligatorio")]

        public string nvClaveFE { get; set; } = default!;
        [Display(Name = "Provedor FE")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string nvProveedorFE { get; set; }

        [Display(Name = "Soap")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string ntSoapFE { get; set; }
        [Display(Name = "Scope Api")]

        public string? nvScopeApiFE { get; set; }
        [Display(Name = "ClienteId Api")]
        public string? nvClientIdApiFE { get; set; }
        [Display(Name = "ClientSecret Api")]
        public string? nvClientSecretApiFE { get; set; }
        public string? nvURLTokenApiFE { get; set; }
        public string? nvURLEnvioApiFE { get; set; }
        public string? nvURLConsultaApiFE { get; set; }
        public string? nvURLFECDR { get; set; }
        public byte[]? imLogo { get; set; } 
        public OauthAccessToken? Token { get; set; }
        public SistemaUsuario? Usuario { get; set; }
        public ICollection<EmailConfig> Emails { get; set; }
    }
}
