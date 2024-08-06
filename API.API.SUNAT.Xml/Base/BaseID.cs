using API.API.SUNAT.Xml.Constantes;
using System.Xml.Serialization;

namespace API.API.SUNAT.Xml.Base
{
    public class BaseID
    {
        [XmlElement(ElementName = "ID", Namespace = UBLNamespaces.cbc)]
        public BaseAtributoComun? ID { get; set; }
    }
}
