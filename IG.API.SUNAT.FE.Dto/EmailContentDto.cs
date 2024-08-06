namespace IG.API.SUNAT.FE.Dto
{
    public class EmailContentDto
    {
        public string Content { get; set; }
        public bool IsHtml { get; set; }
        public string Subject { get; set; }
        public string EmailTo { get; set; }
        public string EmailCC { get; set; }
        public string EmailBcc { get; set; }
    }
}
