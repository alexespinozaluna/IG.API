namespace IG.API.SUNAT.FE.Dto
{
    public class ComprobanteRequest:BaseComprobante
    {
    
        public string NomArchivo { get; set; }
        public bool EsResumen { get; set; }
        public string XmlBase64 { get; set; }

    }
}
