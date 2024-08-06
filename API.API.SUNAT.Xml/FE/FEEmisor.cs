namespace API.API.SUNAT.Xml.FE
{
    public class FEEmisor : FEPersona
    {
        public string NombreComercial { get; set; }
        public string CodEstablecimiento { get; set; }

        public FEEmisor(AccountingSupplierParty enty)
        {
            AsignarValoresDesdeEntidad(enty);
            NombreComercial = enty?.Party?.PartyName?.Name;

            var partyEntityAddress = enty?.Party?.PartyLegalEntity?.RegistrationAddress;
            if (partyEntityAddress != null)
            {
                CodEstablecimiento = partyEntityAddress.AddressTypeCode;
            }
        }

        public FEEmisor() { }
    }
}
