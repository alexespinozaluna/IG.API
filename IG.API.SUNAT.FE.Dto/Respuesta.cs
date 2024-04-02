namespace IG.API.SUNAT.FE.Dto
{
    public class Respuesta
    {
        //sincreono
        public string? applicationResponse { get; set; }
        public string? faultcode { get; set; }
        public string? faultstring { get; set; }
        public string? detail { get; set; }
        public string? status { get; set; }
        // asincrono
        public string? ticket { get; set; }
        public string? statusCode { get; set; }
        //leer xml respuesta
        public string? ResponseCode { get; set; }
        public string? Description { get; set; }
        public string? Notes { get; set; }
        public string? XMLSingned { get; set; }
        public string? XMLCdr { get; set; }
        public string? URLDocument { get; set; }
    }
}
