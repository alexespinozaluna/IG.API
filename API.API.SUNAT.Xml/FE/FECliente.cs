namespace API.API.SUNAT.Xml.FE
{
    public class FECliente : FEPersona
    {
        public FECliente(AccountingCustomerParty enty)
        {
            AsignarValoresDesdeEntidad(enty);
        }

        public FECliente() { }
    }
}
