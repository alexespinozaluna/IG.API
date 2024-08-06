namespace API.API.SUNAT.Xml.FE
{
    public class FEPersona
    {
        public string Documento { get; set; }
        public string NombreCompleto { get; set; }
        public string TipoDocumento { get; set; }
        public string Correo { get; set; }
        public string CodUbigeo { get; set; }
        public string Urbanizacion { get; set; }
        public string NomProvincia { get; set; }
        public string NomDepartamento { get; set; }
        public string NomDistrito { get; set; }
        public string DireccionCompleta { get; set; }
        public string CodPais { get; set; }

        protected void AsignarValoresDesdeEntidad(dynamic enty)
        {
            var partyIden = enty?.Party?.PartyIdentification;
            if (partyIden != null)
            {
                Documento = partyIden.ID.Value;
                TipoDocumento = partyIden.ID.SchemeID;
            }

            var partyEntity = enty?.Party?.PartyLegalEntity;
            if (partyEntity != null)
            {
                NombreCompleto = partyEntity.RegistrationName;

                var partyEntityAddress = partyEntity.RegistrationAddress;
                if (partyEntityAddress != null)
                {
                    CodUbigeo = partyEntityAddress.ID?.Value;
                    Urbanizacion = partyEntityAddress.CitySubdivisionName;
                    NomProvincia = partyEntityAddress.CityName;
                    NomDepartamento = partyEntityAddress.CountrySubentity;
                    NomDistrito = partyEntityAddress.District;
                    DireccionCompleta = partyEntityAddress.AddressLine?.Line;
                    CodPais = partyEntityAddress.Country?.IdentificationCode;
                }
            }

            Correo = enty?.Party?.Contact?.ElectronicMail;
        }
    }
}
