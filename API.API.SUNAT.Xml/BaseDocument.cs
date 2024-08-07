using API.API.SUNAT.Xml.Base;
using API.API.SUNAT.Xml.Constantes;
using System.Xml.Serialization;

namespace API.API.SUNAT.Xml
{
    public class BaseDocument : BaseID
    {
        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces xmlns = new XmlSerializerNamespaces();

        protected BaseDocument(string defaultNamespace)
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
        [XmlElement(ElementName = "DiscrepancyResponse", Namespace = UBLNamespaces.cac)]
        public DiscrepancyResponse? DiscrepancyResponse { get; set; }
        [XmlElement(ElementName = "BillingReference", Namespace = UBLNamespaces.cac)]
        public BillingReference? BillingReference { get; set; }

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
        [XmlElement(ElementName = "AllowanceCharge", Namespace = UBLNamespaces.cac)]
        public AllowanceCharge AllowanceCharge { get; set; }

        [XmlElement(ElementName = "TaxTotal", Namespace = UBLNamespaces.cac)]
        public TaxTotal TaxTotal { get; set; }
        [XmlElement(ElementName = "LegalMonetaryTotal", Namespace = UBLNamespaces.cac)]
        public LegalMonetaryTotal LegalMonetaryTotal { get; set; }
        [XmlElement(ElementName = "InvoiceLine", Namespace = UBLNamespaces.cac)]
        public List<InvoiceLine>? InvoiceLines { get; set; }
        [XmlElement(ElementName = "DebitNoteLine", Namespace = UBLNamespaces.cac)]
        public List<DebitNoteLine>? DebitNoteLines { get; set; }
        [XmlElement(ElementName = "CreditNoteLine", Namespace = UBLNamespaces.cac)]
        public List<CreditNoteLine>? CreditNoteLines { get; set; }

    }

    public class AllowanceCharge
    {
        [XmlElement(ElementName = "ChargeIndicator", Namespace = UBLNamespaces.cbc)]
        public bool ChargeIndicator { get; set; }
        [XmlElement(ElementName = "AllowanceChargeReasonCode", Namespace = UBLNamespaces.cbc)]
        public string AllowanceChargeReasonCode { get; set; }
        [XmlElement(ElementName = "MultiplierFactorNumeric", Namespace = UBLNamespaces.cbc)]
        public double MultiplierFactorNumeric { get; set; }
        [XmlElement(ElementName = "Amount", Namespace = UBLNamespaces.cbc)]
        public Amount Amount { get; set; }
        [XmlElement(ElementName = "BaseAmount", Namespace =UBLNamespaces.cbc)]
        public double BaseAmount { get; set; }
    }

    public class DiscrepancyResponse
    {
        [XmlElement(ElementName = "ReferenceID", Namespace = UBLNamespaces.cbc)]
        public string ReferenceID { get; set; }
        [XmlElement(ElementName = "ResponseCode", Namespace = UBLNamespaces.cbc)]
        public string ResponseCode { get; set; }
        [XmlElement(ElementName = "Description", Namespace = UBLNamespaces.cbc)]
        public string Description { get; set; }
    }

    public class BillingReference
    {
        [XmlElement(ElementName = "InvoiceDocumentReference", Namespace = UBLNamespaces.cac)]
        public InvoiceDocumentReference InvoiceDocumentReference { get; set; }
    }

    public class InvoiceDocumentReference:BaseID
    {
        [XmlElement(ElementName = "IssueDate", Namespace = UBLNamespaces.cbc)]
        public string IssueDate { get; set; }
        [XmlElement(ElementName = "DocumentTypeCode", Namespace = UBLNamespaces.cbc)]
        public string DocumentTypeCode { get; set; }

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
    public class OrderReference : BaseID
    {

    }


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
