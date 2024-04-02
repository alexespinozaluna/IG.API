namespace IG.API.SUNAT.FE.Dto
{
    public class ComprobanteResponseDto:RespuestaComunComprobanteDto
    {
        public string? xmlFirmado { get; set; }
        public string? IdComprobante { get; set; }
        public bool? bProcesado { get; set; }
        public string? Ticket { get; set; }



    }
}
