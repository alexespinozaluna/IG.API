using API.API.SUNAT.Xml.Constantes;
using System.Xml.Serialization;

namespace API.API.SUNAT.Xml
{
    public class GenericDocument
    {
        [XmlRoot(ElementName = "Invoice", Namespace = UBLNamespaces.xmlnsInvoice)]
        public class Invoice : BaseDocument
        {
            public Invoice() : base(UBLNamespaces.xmlnsInvoice) { }
        }

        [XmlRoot(ElementName = "CreditNote", Namespace = UBLNamespaces.xmlnsCreditNote)]
        public class CreditNote : BaseDocument
        {
            public CreditNote() : base(UBLNamespaces.xmlnsCreditNote) { }
        }

        [XmlRoot(ElementName = "DebitNote", Namespace = UBLNamespaces.xmlnsDebitNote)]
        public class DebitNote : BaseDocument
        {
            public DebitNote() : base(UBLNamespaces.xmlnsDebitNote) { }
        }

    }
}
