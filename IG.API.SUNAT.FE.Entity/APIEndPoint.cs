namespace IG.API.SUNAT.FE.Entity
{
    public class APIEndPoint : EntityBase
    {
        public string CodApiEndPoint { get; set; }
        public string ApiURL { get; set; }
        public string ContentType { get; set; }
        public string BodyRequest { get; set; }
        public string Method { get; set; }
        public string Descripcion { get; set; }
    }
}
