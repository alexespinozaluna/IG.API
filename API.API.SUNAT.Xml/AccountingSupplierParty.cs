using API.API.SUNAT.Xml.Base;
using API.API.SUNAT.Xml.Constantes;
using System.Xml.Serialization;

namespace API.API.SUNAT.Xml
{
    public class AccountingSupplierParty
    {
        [XmlElement(ElementName = "Party", Namespace = UBLNamespaces.cac)]
        public Party Party { get; set; }


    }

    public class Party
    {
        [XmlElement(ElementName = "PartyIdentification", Namespace = UBLNamespaces.cac)]
        public PartyIdentification PartyIdentification { get; set; }

        [XmlElement(ElementName = "PartyName", Namespace = UBLNamespaces.cac)]
        public PartyName PartyName { get; set; }

        [XmlElement(ElementName = "PartyLegalEntity", Namespace = UBLNamespaces.cac)]
        public PartyLegalEntity PartyLegalEntity { get; set; }

        [XmlElement(ElementName = "Contact", Namespace = UBLNamespaces.cac)]
        public Contact Contact { get; set; }
    }

    public class Contact
    {
        [XmlElement(ElementName = "ElectronicMail", Namespace = UBLNamespaces.cbc)]
        public string ElectronicMail { get; set; }
    }

    public  class PartyIdentification:BaseID
    {
   
    }

 

    public class PartyName
    {
        [XmlElement(ElementName = "Name", Namespace = UBLNamespaces.cbc)]
        public string Name { get; set; }
    }

    public class PartyLegalEntity
    {
        [XmlElement(ElementName = "RegistrationName", Namespace = UBLNamespaces.cbc)]
        public string RegistrationName { get; set; }

        [XmlElement(ElementName = "RegistrationAddress", Namespace = UBLNamespaces.cac)]
        public RegistrationAddress RegistrationAddress { get; set; }
    }

    public class RegistrationAddress:BaseID
    {

        [XmlElement(ElementName = "AddressTypeCode", Namespace = UBLNamespaces.cbc)]
        public string AddressTypeCode { get; set; }


        [XmlElement(ElementName = "CitySubdivisionName", Namespace = UBLNamespaces.cbc)]
        public string CitySubdivisionName { get; set; }

        [XmlElement(ElementName = "CityName", Namespace = UBLNamespaces.cbc)]
        public string CityName { get; set; }

        [XmlElement(ElementName = "CountrySubentity", Namespace = UBLNamespaces.cbc)]
        public string CountrySubentity { get; set; }

        [XmlElement(ElementName = "District", Namespace = UBLNamespaces.cbc)]
        public string District { get; set; }

        [XmlElement(ElementName = "AddressLine", Namespace = UBLNamespaces.cac)]
        public AddressLine AddressLine { get; set; }

        [XmlElement(ElementName = "Country", Namespace = UBLNamespaces.cac)]
        public Country Country { get; set; }
    }
    public class AddressLine
    {
        [XmlElement(ElementName = "Line", Namespace = UBLNamespaces.cbc)]
        public string Line { get; set; }
    }

    public class Country
    {
        [XmlElement(ElementName = "IdentificationCode", Namespace = UBLNamespaces.cbc)]
        public string IdentificationCode { get; set; }
    }

}
