namespace IG.API.SUNAT.FE.Dto
{
    public class GetStatusCdrDto : BaseComprobante
    {
        public string rucComprobante { get; set; }
        public string tipoComprobante { get; set; }
        public string serieComprobante { get; set; }
        public string numeroComprobante { get; set; }
    }
}
