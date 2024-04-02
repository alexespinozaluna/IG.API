namespace IG.API.SUNAT.FE.Dto
{
    public class ApiGreSendDto : ApiComun
    {
        public string numTicket { get; set; }
        public DateTime fecRecepcion { get; set; }
        public List<ErrorComun> errors { get; set; }
    }

    public class ErrorComun
    {
        public string cod { get; set; }
        public string msg { get; set; }

        public string Text => $"{cod}: {msg}";
    }
}
