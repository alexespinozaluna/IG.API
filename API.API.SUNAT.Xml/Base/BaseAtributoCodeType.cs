using System.Xml.Serialization;

namespace API.API.SUNAT.Xml.Base
{
    public class BaseAtributoCodeType
    {
        [XmlAttribute("listID")]
        public string ListID { get; set; }

        [XmlAttribute("listSchemeURI")]
        public string ListSchemeURI { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }
        [XmlText]
        public string Value { get; set; }
    }
}
