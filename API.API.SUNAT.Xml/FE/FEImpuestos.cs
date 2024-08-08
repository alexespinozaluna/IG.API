namespace API.API.SUNAT.Xml.FE
{
    public class FEImpuestos
    {
        public FEImpuestos() { }
        public string CodImpuesto { get; set; }
        public string? Nombre { get; set; }
        public string TipoImpuesto { get; set; }
        public double MontoBase { get; set; }
        public double MontoImpuesto { get; set; }
        public double? Porcentaje { get; set; }
        public string? CodISC { get; set; }
        public string CodAfectacionIGV { get; set; }
        public string? CodigoTipo { get; set; }

        public FEImpuestos(TaxSubtotal taxSubtotal)
        {


            var taxCategory = taxSubtotal.TaxCategory;
            var taxScheme = taxCategory?.TaxScheme;

            MontoBase = taxSubtotal.TaxableAmount;
            MontoImpuesto = taxSubtotal.TaxAmount;

            Porcentaje = taxCategory.Percent;
            CodISC = taxCategory?.TierRange;
            CodAfectacionIGV = taxCategory.TaxExemptionReasonCode;


            CodigoTipo = taxCategory?.ID?.Value;

            CodImpuesto = taxScheme?.ID?.Value;
            Nombre = taxScheme?.Name;



        }

    }
}
