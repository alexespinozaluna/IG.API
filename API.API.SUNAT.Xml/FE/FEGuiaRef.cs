namespace API.API.SUNAT.Xml.FE
{
    public class FEGuiaRef
    {
        public FEGuiaRef() { }

        public string? SerieNro { get; set; }
        public string? CodTipo { get; set; }
        public FEGuiaRef(DespatchDocumentReference despatch) {
            if(despatch != null)
            {
                SerieNro = despatch.ID.Value;
                CodTipo = despatch.DocumentTypeCode;
            }
        }
    }
}
