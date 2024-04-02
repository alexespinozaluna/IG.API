namespace IG.API.SUNAT.FE.Entity
{
    public class SUNAT_FE_Comprobante : EntityBase
    {
        public string? nomArchivo { get; set; }
        public string? xmlFirmado { get; set; }
        public string? IdComprobante { get; set; }
        public bool? bProcesado { get; set; }

        public string? Codigo { get; set; }
        public string? Mensaje { get; set; }
        public string? Descripcion { get; set; }
        public string? Observacion { get; set; }
        public string? XmlCdr { get; set; }
        public string? URLDocumento { get; set; }
        public string? Ticket { get; set; }

        public DateTime? dtFechaHoraProceso { get; set; }
        public int? IdmaeEmpresa { get; set; }

    }
}
