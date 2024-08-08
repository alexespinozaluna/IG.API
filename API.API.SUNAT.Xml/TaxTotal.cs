using API.API.SUNAT.Xml.Base;
using API.API.SUNAT.Xml.Constantes;
using System.Xml.Serialization;

namespace API.API.SUNAT.Xml
{


    public class TaxTotal
    {
        [XmlElement(ElementName = "TaxAmount", Namespace = UBLNamespaces.cbc)]
        public double TaxAmount { get; set; }

        [XmlElement(ElementName = "TaxSubtotal", Namespace = UBLNamespaces.cac)]
        public List<TaxSubtotal> TaxSubtotals { get; set; }
    }

    public class TaxSubtotal
    {
        [XmlElement(ElementName = "TaxableAmount", Namespace = UBLNamespaces.cbc)]
        public double TaxableAmount { get; set; }

        [XmlElement(ElementName = "TaxAmount", Namespace = UBLNamespaces.cbc)]
        public double TaxAmount { get; set; }
        [XmlElement(ElementName = "BaseUnitMeasure", Namespace = UBLNamespaces.cbc)]
        public BaseUnitMeasure BaseUnitMeasure { get; set; }

        [XmlElement(ElementName = "TaxCategory", Namespace = UBLNamespaces.cac)]
        public TaxCategory TaxCategory { get; set; }
    }

    public class BaseUnitMeasure
    {
        [XmlAttribute("unitCode")]
        public string UnitCode { get; set; }
        [XmlText]
        public string Value { get; set; }
    }

    public class TaxCategory : BaseID
    {
        [XmlElement(ElementName = "Percent", Namespace = UBLNamespaces.cbc)]
        public double Percent { get; set; }
        [XmlElement(ElementName = "TierRange", Namespace = UBLNamespaces.cbc)]
        public string TierRange { get; set; }
        [XmlElement(ElementName = "TaxExemptionReasonCode", Namespace = UBLNamespaces.cbc)]
        public string TaxExemptionReasonCode { get; set; }
        [XmlElement(ElementName = "PerUnitAmount", Namespace = UBLNamespaces.cbc)]
        public double PerUnitAmount { get; set; }
        [XmlElement(ElementName = "TaxScheme", Namespace = UBLNamespaces.cac)]
        public TaxScheme TaxScheme { get; set; }
    }

    public class TaxScheme : BaseID
    {


        [XmlElement(ElementName = "Name", Namespace = UBLNamespaces.cbc)]
        public string Name { get; set; }

        [XmlElement(ElementName = "TaxTypeCode", Namespace = UBLNamespaces.cbc)]
        public string TaxTypeCode { get; set; }
    }

}
