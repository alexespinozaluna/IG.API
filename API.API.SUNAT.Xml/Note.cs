using System.Xml.Serialization;

namespace API.API.SUNAT.Xml
{
    public class Note
    {
        [XmlAttribute("languageLocaleID")]
        public string LanguageLocaleID { get; set; }

        [XmlAttribute("languageID")]
        public string LanguageID { get; set; }

        [XmlText]
        public string Value { get; set; }
    }

}
