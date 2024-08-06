using API.API.SUNAT.Xml.Constantes;
using System.Xml.Serialization;

namespace API.API.SUNAT.Xml
{
    public class AccountingCustomerParty
    {
        [XmlElement(ElementName = "Party", Namespace = UBLNamespaces.cac)]
        public Party Party { get; set; }
    }
}
