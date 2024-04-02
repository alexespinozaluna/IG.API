namespace IG.API.SUNAT.FE.Dto
{
    public class ApiEndPointInfo
    {
        public int Id { get; set; }
        public int IdmaeEmpresa { get; set; }
        public string CodApiEndPoint { get; set; } = default!;
        public string Method { get; set; } = default!;
        public string ApiURL { get; set; } = default!;
        public string? RequestBody { get; set; }
        public string? ContentType { get; set; } 
        public string? Authorization { get; set; }
        public string? ResponseType { get; set; }
    }
}
