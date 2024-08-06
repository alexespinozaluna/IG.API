using System.Xml.Serialization;

namespace API.API.SUNAT.Xml.Base
{
    public class BaseAtributoComun
    {
        [XmlAttribute("schemeAgencyName")]
        public string SchemeAgencyName { get; set; }

        [XmlAttribute("schemeID")]
        public string SchemeID { get; set; }

        [XmlAttribute("schemeName")]
        public string SchemeName { get; set; }

        [XmlAttribute("schemeURI")]
        public string SchemeURI { get; set; }
        [XmlText]
        public string Value { get; set; }
    }
}
