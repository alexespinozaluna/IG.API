using API.API.SUNAT.Xml.Constantes;
using System.Xml.Serialization;

namespace API.API.SUNAT.Xml.Base
{/*
    public abstract class BaseComprobante:BaseID
    {
        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces xmlns = new XmlSerializerNamespaces();

        protected BaseComprobante(string defaultNamespace)
        {
            xmlns.Add(string.Empty, defaultNamespace);
            xmlns.Add("cac", UBLNamespaces.cac);
            xmlns.Add("cbc", UBLNamespaces.cbc);
            xmlns.Add("ext", UBLNamespaces.ext);
        }

        [XmlElement(ElementName = "UBLVersionID", Namespace = UBLNamespaces.cbc)]
        public string UBLVersionID { get; set; }

        [XmlElement(ElementName = "CustomizationID", Namespace = UBLNamespaces.cbc)]
        public string CustomizationID { get; set; }

        //[XmlElement(ElementName = "ID", Namespace = UBLNamespaces.cbc)]
        //public BaseAtributoComun ID { get; set; }

        [XmlElement(ElementName = "IssueDate", Namespace = UBLNamespaces.cbc)]
        public string IssueDate { get; set; }

        [XmlElement(ElementName = "IssueTime", Namespace = UBLNamespaces.cbc)]
        public string IssueTime { get; set; }

        [XmlElement(ElementName = "DueDate", Namespace = UBLNamespaces.cbc)]
        public string DueDate { get; set; }

        [XmlElement(ElementName = "InvoiceTypeCode", Namespace = UBLNamespaces.cbc)]
        public BaseAtributoCodeType InvoiceTypeCode { get; set; }

        [XmlElement(ElementName = "Note", Namespace = UBLNamespaces.cbc)]
        public List<Note> Notes { get; set; }

        [XmlElement(ElementName = "DocumentCurrencyCode", Namespace = UBLNamespaces.cbc)]
        public string DocumentCurrencyCode { get; set; }

        [XmlElement(ElementName = "LineCountNumeric", Namespace = UBLNamespaces.cbc)]
        public int LineCountNumeric { get; set; }

        [XmlElement(ElementName = "OrderReference", Namespace = UBLNamespaces.cac)]
        public OrderReference? OrderReference { get; set; }

        [XmlElement(ElementName = "DespatchDocumentReference", Namespace = UBLNamespaces.cac)]
        public List<DespatchDocumentReference> DespatchDocumentReference { get; set; }
        [XmlElement(ElementName = "AdditionalDocumentReference", Namespace = UBLNamespaces.cac)]
        public List<AdditionalDocumentReference> AdditionalDocumentReference { get; set; }
        [XmlElement(ElementName = "AccountingSupplierParty", Namespace = UBLNamespaces.cac)]
        public AccountingSupplierParty AccountingSupplierParty { get; set; }
        [XmlElement(ElementName = "AccountingCustomerParty", Namespace = UBLNamespaces.cac)]
        public AccountingCustomerParty AccountingCustomerParty { get; set; }
        [XmlElement(ElementName = "PaymentMeans", Namespace = UBLNamespaces.cac)]
        public PaymentMeans PaymentMeans { get; set; }
        [XmlElement(ElementName = "PaymentTerms", Namespace = UBLNamespaces.cac)]
        public List<PaymentTerms> PaymentTerms { get; set; }
        [XmlElement(ElementName = "TaxTotal", Namespace = UBLNamespaces.cac)]
        public TaxTotal TaxTotal { get; set; }
        [XmlElement(ElementName = "LegalMonetaryTotal", Namespace = UBLNamespaces.cac)]
        public LegalMonetaryTotal LegalMonetaryTotal { get; set; }
        [XmlElement(ElementName = "InvoiceLine", Namespace = UBLNamespaces.cac)]
        public List<InvoiceLine> InvoiceLines { get; set; }

    }


    public class PaymentMeans : BaseID
    {
        [XmlElement(ElementName = "PaymentMeansCode", Namespace = UBLNamespaces.cac)]
        public string PaymentMeansCode { get; set; }

        [XmlElement(ElementName = "PayeeFinancialAccount", Namespace = UBLNamespaces.cac)]
        public PayeeFinancialAccount PayeeFinancialAccount { get; set; }
    }

    public class PayeeFinancialAccount : BaseID
    {

    }

    public class AdditionalDocumentReference : BaseID
    {



        [XmlElement(ElementName = "DocumentTypeCode", Namespace = UBLNamespaces.cbc)]
        public string DocumentTypeCode { get; set; }

        [XmlElement(ElementName = "DocumentStatusCode", Namespace = UBLNamespaces.cbc)]
        public string DocumentStatusCode { get; set; }

        [XmlElement(ElementName = "IssuerParty", Namespace = UBLNamespaces.cac)]
        public IssuerParty IssuerParty { get; set; }

    }

    public class IssuerParty
    {
        [XmlElement(ElementName = "PartyIdentification", Namespace = UBLNamespaces.cac)]
        public PartyIdentification PartyIdentification { get; set; }
    }

    public class DespatchDocumentReference : BaseID
    {

        [XmlElement(ElementName = "DocumentTypeCode", Namespace = UBLNamespaces.cbc)]
        public string DocumentTypeCode { get; set; }

    }
    public class PaymentTerms : BaseID
    {
        [XmlElement(ElementName = "PaymentMeansID", Namespace = UBLNamespaces.cbc)]
        public string PaymentMeansID { get; set; }
        [XmlElement(ElementName = "Note", Namespace = UBLNamespaces.cbc)]
        public Note Note { get; set; }
        [XmlElement(ElementName = "PaymentPercent", Namespace = UBLNamespaces.cbc)]
        public double? PaymentPercent { get; set; }

        [XmlElement(ElementName = "Amount", Namespace = UBLNamespaces.cbc)]
        public Amount Amount { get; set; }
        [XmlElement(ElementName = "PaymentDueDate", Namespace = UBLNamespaces.cbc)]
        public string PaymentDueDate { get; set; }

    }

    public class Amount
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }

        [XmlText]
        public double Value { get; set; }
    }
    public class OrderReference:BaseID
    {
   
    }
        */
}
