using API.API.SUNAT.Xml.Constantes;
using System.Xml.Serialization;

namespace API.API.SUNAT.Xml.Base
{
    public abstract class BaseComprobanteLine : BaseID
    {

        [XmlElement(ElementName = "Note", Namespace = UBLNamespaces.cbc)]
        public Note Note { get; set; }
        [XmlElement(ElementName = "PricingReference", Namespace = UBLNamespaces.cac)]
        public PricingReference PricingReference { get; set; }


        [XmlElement(ElementName = "LineExtensionAmount", Namespace = UBLNamespaces.cbc)]
        public double LineExtensionAmount { get; set; }

        [XmlElement(ElementName = "TaxTotal", Namespace = UBLNamespaces.cac)]
        public TaxTotal TaxTotal { get; set; }

        [XmlElement(ElementName = "Item", Namespace = UBLNamespaces.cac)]
        public Item Item { get; set; }

        [XmlElement(ElementName = "Price", Namespace = UBLNamespaces.cac)]
        public Price Price { get; set; }

    }

    public class PricingReference
    {
        [XmlElement(ElementName = "AlternativeConditionPrice", Namespace = UBLNamespaces.cac)]
        public AlternativeConditionPrice AlternativeConditionPrice { get; set; }
    }

    public class AlternativeConditionPrice
    {
        [XmlElement(ElementName = "PriceAmount", Namespace = UBLNamespaces.cbc)]
        public double PriceAmount { get; set; }
        [XmlElement(ElementName = "PriceTypeCode", Namespace = UBLNamespaces.cbc)]
        public string PriceTypeCode { get; set; }
    }
}
