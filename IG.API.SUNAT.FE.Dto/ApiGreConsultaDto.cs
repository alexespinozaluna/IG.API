namespace IG.API.SUNAT.FE.Dto
{
    public class ApiGreConsultaDto:ApiComun
    {
        public string codRespuesta { get; set; }
        public string arcCdr { get; set; }
        public string indCdrGenerado { get; set; }
        public ErrorConsulta error { get; set; }
    }

    public class ErrorConsulta
    {
        public string numError { get; set; }
        public string desError { get; set; }

        public string Text => $"{numError} : {desError}";

    }
}
