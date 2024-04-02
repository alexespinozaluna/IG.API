namespace IG.API.SUNAT.FE.Dto
{
    public abstract class RespuestaComunDto
    {
        public string? Codigo { get; set; }
        public string? Mensaje { get; set; }
        public string? Descripcion { get; set; }
        public string? Observacion { get; set; }
        public string? XmlCdr { get; set; }
        public string? URLDocumento { get; set; }
        public string? Ticket { get; set; }
    }
}
