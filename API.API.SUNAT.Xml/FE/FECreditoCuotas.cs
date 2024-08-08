namespace API.API.SUNAT.Xml.FE
{
    public class FECreditoCuotas
    {
        public FECreditoCuotas() {}
        public string Codigo { get; set; }
        public string Identificador { get; set; }
        public string? Nota { get; set; }
        public double Importe { get; set; }
        public  string? FechaVencimiento  { get; set; }

        public FECreditoCuotas(PaymentTerms  paymentTerms) {

            if (paymentTerms != null)
            {
                Codigo = paymentTerms.ID.Value;
                Identificador = paymentTerms.PaymentMeansID;
                Nota =paymentTerms.Note?.Value;
                Importe = paymentTerms.Amount.Value;
                FechaVencimiento=paymentTerms?.PaymentDueDate;
            }
        
        }

    }
}
