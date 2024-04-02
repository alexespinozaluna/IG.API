namespace IG.API.SUNAT.FE.DTO
{
    public class ComprobanteRequest
    {
        public string Id { get; set; }
        public string NomArchivo { get; set; }
        public bool EsResumen { get; set; }
        public string RUC { get; set; }
        public string XmlBase64 { get; set; }

    }
}
