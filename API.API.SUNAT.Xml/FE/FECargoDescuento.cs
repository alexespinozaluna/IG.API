namespace API.API.SUNAT.Xml.FE
{
    public class FECargoDescuento
    {
        public FECargoDescuento() { }
        public bool? Indicador { get; set; }
        public string? Codigo { get; set; }
        public double? Factor { get; set; }
        public double? Importe { get; set; }
        public double? ImporteBase { get; set; }

        public FECargoDescuento(AllowanceCharge allowanceCharge)
        {
            if (allowanceCharge != null)
            {
                Indicador = allowanceCharge.ChargeIndicator;
                Codigo = allowanceCharge.AllowanceChargeReasonCode;
                Factor = allowanceCharge.MultiplierFactorNumeric;
                Importe = allowanceCharge.Amount.Value;
                ImporteBase = allowanceCharge.BaseAmount;
            }
        }

    }
}
