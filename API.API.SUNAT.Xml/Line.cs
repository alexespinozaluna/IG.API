using API.API.SUNAT.Xml.Base;
using API.API.SUNAT.Xml.Constantes;
using System.Xml.Serialization;

namespace API.API.SUNAT.Xml
{

    public class InvoiceLine : BaseComprobanteLine
    {
        [XmlElement(ElementName = "InvoicedQuantity", Namespace = UBLNamespaces.cbc)]
        public InvoicedQuantity? InvoicedQuantity { get; set; }
    }
    public class CreditNoteLine : BaseComprobanteLine
    {
        [XmlElement(ElementName = "CreditedQuantity", Namespace = UBLNamespaces.cbc)]
        public CreditedQuantity? InvoicedQuantity { get; set; }
    }
    public class DebitNoteLine : BaseComprobanteLine
    {
        [XmlElement(ElementName = "DebitedQuantity", Namespace = UBLNamespaces.cbc)]
        public DebitedQuantity? InvoicedQuantity { get; set; }
    }
    public class InvoicedQuantity: BaseQuantity    {}
    public class CreditedQuantity: BaseQuantity    {}
    public class DebitedQuantity: BaseQuantity    { }

    public class Item
    {
        [XmlElement(ElementName = "Description", Namespace = UBLNamespaces.cbc)]
        public string Description { get; set; }

        [XmlElement(ElementName = "Name", Namespace = UBLNamespaces.cbc)]
        public string Name { get; set; }

        [XmlElement(ElementName = "SellersItemIdentification", Namespace = UBLNamespaces.cac)]
        public SellersItemIdentification SellersItemIdentification { get; set; }

        [XmlElement(ElementName = "CommodityClassification", Namespace = UBLNamespaces.cac)]
        public CommodityClassification CommodityClassification { get; set; }
    }

    public class CommodityClassification
    {
        [XmlElement(ElementName = "ItemClassificationCode", Namespace = UBLNamespaces.cbc)]
        public string ItemClassificationCode { get; set; }
    }

    public class SellersItemIdentification:BaseID
    {
        
    }

    public class Price
    {
        [XmlElement(ElementName = "PriceAmount", Namespace = UBLNamespaces.cbc)]
        public double PriceAmount { get; set; }
    }
}
