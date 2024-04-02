namespace IG.API.SUNAT.FE.Entity
{
    public class ApiResponse : EntityBase
    {
        public string Identificador { get; set; } = default!;
        public string ApiUrlSend { get; set; } = default!;
        public APIEndPoint ApiEndPoint { get; set; } = default!;
        public int ApiEndPointId { get; set; }
        public maeEmpresa Empresa { get; set; } = default!;
        public int EmpresaId { get; set; }
        public string? JsonResponse { get; set; }
        public string? FileContent { get; set; }
        public string? FileName { get; set; }
        public string? MenssageError { get; set; }
    }
}
