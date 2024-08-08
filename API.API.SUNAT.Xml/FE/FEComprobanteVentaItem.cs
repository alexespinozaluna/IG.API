using API.API.SUNAT.Xml.Base;
using System;

namespace API.API.SUNAT.Xml.FE
{
    public class FEComprobanteVentaItem
    {
        public int IdComprobanteVenta { get; set; }
        public double NumeroOrden { get; set; }
        public double Cantidad { get; set; }
        public string? UM { get; set; }
        public string Nota { get; set; }
        public double TotalValor { get; set; }
        public double TotalValorBase { get; set; }
        public double PrecioUnitario { get; set; }
        public string ValorReferencialUnitario { get; set; }

        //public string CodDescuento { get; set; }
        //public double MontoDescuento { get; set; }
        //public double PorcDescuento { get; set; }
        //public double MontoBaseDescuento { get; set; }
        public double MontoImpuestos { get; set; }
        public FECargoDescuento CargoDescuento{ get; set; }
        //public double MontoIgv { get; set; }
        //public string CodAfectacionIGV { get; set; }
        //public int MontoBaseISC { get; set; }
        //public int MontoISC { get; set; }
        //public int PorcISC { get; set; }
        //public int CodTributoISC { get; set; }
        //public int CodTipoISC { get; set; }
        //public int MontoICBPER { get; set; }
        //public int MontoBaseCargo { get; set; }
        //public int MontoCargo { get; set; }
        //public int PorcCargo { get; set; }
        //public int CodCargo { get; set; }
        public List<FEImpuestos> Impuestos { get; set; } = new List<FEImpuestos>();
        public string Descripcion { get; set; }
        public string? CodProductoSUNAT { get; set; }
        public string CodProducto { get; set; }
        public double ValorUnitario { get; set; }


        public FEComprobanteVentaItem() { }
        public FEComprobanteVentaItem(dynamic line)
        {

            // var impuestos = new FEImpuestos(line.TaxTotal.TaxSubtotals);
            var alternativePrice = line?.PricingReference?.AlternativeConditionPrice;


            NumeroOrden = double.Parse(line.ID.Value);
            Nota = line.Note.Value;

            UM = line.InvoicedQuantity?.UnitCode
                ?? line.CreditedQuantity?.UnitCode
                ?? line.DebitedQuantity?.UnitCode;

            Cantidad = line.InvoicedQuantity?.Value
                       ?? line.CreditedQuantity?.Value
                       ?? line.DebitedQuantity?.Value;


            PrecioUnitario = alternativePrice.PriceAmount;
            ValorReferencialUnitario = alternativePrice.PriceTypeCode;

            MontoImpuestos = line.TaxTotal.TaxAmount;
            foreach (var taxSubtotal in line.TaxTotal.TaxSubtotals)
            {
                Impuestos.Add(new FEImpuestos(taxSubtotal));
            }

            CargoDescuento =     new FECargoDescuento(line.AllowanceCharge);

            Descripcion = line.Item?.Description;
            CodProducto = line.Item?.SellersItemIdentification?.ID?.Value;
            CodProductoSUNAT = line.Item?.CommodityClassification?.ItemClassificationCode;

            ValorUnitario = line.Price.PriceAmount;


        }
    }
}
