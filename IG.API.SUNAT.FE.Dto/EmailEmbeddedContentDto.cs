namespace IG.API.SUNAT.FE.Dto
{
    public class EmailEmbeddedContentDto
    {
        public string Cod { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public object Content { get; set; }
        public string MediaType { get; set; }
    }
}
