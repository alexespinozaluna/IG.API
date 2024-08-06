using API.API.SUNAT.Xml.Base;
using API.API.SUNAT.Xml.Constantes;
using System.Xml.Serialization;

namespace API.API.SUNAT.Xml
{
    public class LegalMonetaryTotal
    {
        [XmlElement(ElementName = "LineExtensionAmount", Namespace = UBLNamespaces.cbc)]
        public double LineExtensionAmount { get; set; }

        [XmlElement(ElementName = "TaxInclusiveAmount", Namespace = UBLNamespaces.cbc)]
        public double TaxInclusiveAmount { get; set; }

        [XmlElement(ElementName = "AllowanceTotalAmount", Namespace = UBLNamespaces.cbc)]
        public double AllowanceTotalAmount { get; set; }

        [XmlElement(ElementName = "ChargeTotalAmount", Namespace = UBLNamespaces.cbc)]
        public double ChargeTotalAmount { get; set; }

        [XmlElement(ElementName = "PrepaidAmount", Namespace = UBLNamespaces.cbc)]
        public double PrepaidAmount { get; set; }

        [XmlElement(ElementName = "PayableAmount", Namespace = UBLNamespaces.cbc)]
        public double PayableAmount { get; set; }
    }
}
