namespace IG.API.SUNAT.FE.Dto
{
    public class CertificadoDigital
    {
        public Byte[] Certificado { get; set; }       
        public DateTime FechaInicio { get;  set; }
        public DateTime FechaVencimiento { get;  set; }
        public string Base64 { get;  set; }
    }
}
