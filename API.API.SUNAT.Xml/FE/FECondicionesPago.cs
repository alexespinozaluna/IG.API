namespace API.API.SUNAT.Xml.FE
{
    public class FECondicionesPago
    {
        public FECondicionesPago() {}
        public string Codigo { get; set; }
        public string Identificador { get; set; }
        public string? Nota { get; set; }
        public double? PorcDetracion { get; set; }
        public string CodMoenda { get; set; }
        public double Importe { get; set; }
        public  string? FechaVencimiento  { get; set; }

        public FECondicionesPago(PaymentTerms  paymentTerms) {

            if (paymentTerms != null)
            {
                Codigo = paymentTerms.ID.Value;
                Identificador = paymentTerms.PaymentMeansID;
                Nota =paymentTerms.Note?.Value;
                CodMoenda = paymentTerms.Amount.CurrencyID;
                PorcDetracion = paymentTerms?.PaymentPercent;
                Importe = paymentTerms.Amount.Value;
                FechaVencimiento=paymentTerms?.PaymentDueDate;
            }
        
        }

    }
}
