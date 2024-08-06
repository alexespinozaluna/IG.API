namespace API.API.SUNAT.Xml.FE
{
    public class FENotas
    {
        public string CodigoLeyenda { get; set; }
        public string Leyendas { get; set; }
        public string LeyendasGratuita { get; set; }
        public string NotaFormaPago { get; set; }
        public string NotaObservacion { get; set; }

        public string Det_Glosa { get; set; }

        // Constructor to initialize FENotas from a list of notes
        public FENotas(List<Note> notes)
        {
            foreach (var item in notes)
            {
                switch (item.LanguageLocaleID)
                {
                    case "1000":
                        CodigoLeyenda = item.LanguageLocaleID;
                        Leyendas = item.Value;
                        break;
                    case "2006":
                        Det_Glosa = item.Value;
                        break;
                    case "1002":
                        LeyendasGratuita = item.Value;
                        break;
                    default:
                        if (item.LanguageID == "L")
                        {
                            NotaFormaPago = item.Value;
                        }
                        else
                        {
                            NotaObservacion = item.Value;
                        }
                        break;
                }
            }
        }
        public FENotas() { }    
    }
}
