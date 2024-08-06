namespace API.API.SUNAT.Xml.FE
{
    public class FEComprobanteVenta : FENotas
    {
        public int IdComprobanteVenta { get; set; }
        public string VerUBL { get; set; }
        public string VerEstDocumento { get; set; }
        public string? TipoOperacion { get; set; }
        public string NumSerieCorrelativo { get; set; }
        public string FechaEmision { get; set; }
        public string HoraEmision { get; set; }
        public string FechaVencimiento { get; set; }
        public string? CodTipoDocumento { get; set; }
        public int Cantidad_Item { get; set; }
        public string? NumOrdenCompra { get; set; }
        public string TipoMoneda { get; set; }
        public FEPersona Emisor { get; set; }
        public FEPersona Cliente { get; set; }
        public double TotalImpuestos { get; set; }
        public List<FEImpuestos> Impuestos { get; set; } = new List<FEImpuestos>();
        public double DescuentosGlobales { get; set; }
        public double TotalAnticipo { get; set; }
        public double CargosGlobales { get; set; }
        public double? TotalDescuentos { get; set; }
        public double? TotalCargos { get; set; }
        public double? MontoAnticipo { get; set; }
        public double? ImporteTotal { get; set; }
        public double? TotalValorVenta { get; set; }
        public double? TotalPrecioVenta { get; set; }
        public double? MontoRedondeo { get; set; }
        public string FormaDePago { get; set; }
        public string? Det_Cod_Medio_Pago { get; set; }
        public string? Det_Num_Banco { get; set; }
        public string? Det_Codigo { get; set; }
        public double? Det_Monto_Afecto { get; set; }
        public double? Det_Tasa { get; set; }
        public string? Det_Moneda { get; set; }
        public double? Det_Monto { get; set; }
        public string? Ret_Codigo { get; set; }
        public double? Ret_Factor { get; set; }
        public double? Ret_Monto { get; set; }
        public double? Ret_Monto_Afecto { get; set; }
        public double? Ret_Neto_Pagar { get; set; }
        public string? CorreoCliente { get; set; }
        public string? NumSerieCorrelativoMod { get; set; }
        public string? CodTipoDocumentoMod { get; set; }
        public string? CodTipoNota { get; set; }
        public string? MotivoNota { get; set; }
        public List<FEComprobanteVentaItem> Lines { get; set; } = new List<FEComprobanteVentaItem>();


        public FEComprobanteVenta()
        {

        }
        public FEComprobanteVenta(BaseDocument baseDoc)
        {

            ProcessPaymentTerms(baseDoc.PaymentTerms, out var paymentTermsDet, out var paymentTermsFp);
            var paymentMeans = baseDoc?.PaymentMeans;

            // Asignar propiedades
            VerUBL = baseDoc.UBLVersionID;
            VerEstDocumento = baseDoc.CustomizationID;
            NumSerieCorrelativo = baseDoc.ID.Value;
            FechaEmision = baseDoc.IssueDate;
            HoraEmision = baseDoc.IssueTime;
            FechaVencimiento = baseDoc.DueDate;

            TipoOperacion = baseDoc?.InvoiceTypeCode?.ListID;
            CodTipoDocumento = baseDoc?.InvoiceTypeCode?.Value;

            // Asignar propiedades de notas
            var notas = new FENotas(baseDoc.Notes);
            CodigoLeyenda = notas.CodigoLeyenda;
            Leyendas = notas.Leyendas;
            Det_Glosa = notas.Det_Glosa;
            LeyendasGratuita = notas.LeyendasGratuita;
            NotaFormaPago = notas.NotaFormaPago;
            NotaObservacion = notas.NotaObservacion;

            TipoMoneda = baseDoc.DocumentCurrencyCode;
            Cantidad_Item = (int)baseDoc.LineCountNumeric;

            //Motivo NC, ND
            var _motivoNota = baseDoc?.DiscrepancyResponse;
            if (_motivoNota != null)
            {
                CodTipoNota = _motivoNota.ResponseCode;
                MotivoNota = _motivoNota.Description;
            }
            //Referencia NC, ND
            var _referenciaNota = baseDoc?.BillingReference;
            if (_referenciaNota != null)
            {
                var _docTipoRef = _referenciaNota?.InvoiceDocumentReference;
                if (_docTipoRef != null)
                {
                    NumSerieCorrelativoMod = _docTipoRef?.ID?.Value;
                    CodTipoDocumentoMod = _docTipoRef?.DocumentTypeCode;
                }
            }

            NumOrdenCompra = baseDoc?.OrderReference?.ID?.Value;

            // Asignar propiedades de medios de pago
            if (paymentMeans != null)
            {
                Det_Cod_Medio_Pago = paymentMeans.PaymentMeansCode;
                Det_Num_Banco = paymentMeans?.PayeeFinancialAccount?.ID?.Value;
            }
            //Detracion
            Det_Monto_Afecto = double.TryParse(paymentTermsDet?.Note?.Value, out var detMontoAfecto) ? (double?)detMontoAfecto : null;
            Det_Tasa = paymentTermsDet?.PaymentPercent;
            Det_Moneda = paymentTermsDet?.Amount?.CurrencyID;
            Det_Monto = paymentTermsDet?.Amount?.Value;

            Emisor = new FEEmisor(baseDoc.AccountingSupplierParty);
            Cliente = new FECliente(baseDoc.AccountingCustomerParty);

            if (paymentTermsFp.Any())
            {
                FormaDePago = paymentTermsFp[0].PaymentMeansID;
            }

            TotalImpuestos = baseDoc.TaxTotal.TaxAmount;
            foreach (var taxSubtotal in baseDoc.TaxTotal.TaxSubtotals)
            {
                Impuestos.Add(new FEImpuestos(taxSubtotal));
            }

            // Asignar totales monetarios
            var legalMonetaryTotal = baseDoc.LegalMonetaryTotal;
            TotalValorVenta = legalMonetaryTotal?.LineExtensionAmount;
            TotalPrecioVenta = legalMonetaryTotal?.TaxInclusiveAmount;
            TotalDescuentos = legalMonetaryTotal?.AllowanceTotalAmount;
            TotalCargos = legalMonetaryTotal?.ChargeTotalAmount;
            MontoAnticipo = legalMonetaryTotal?.PrepaidAmount;
            ImporteTotal = legalMonetaryTotal?.PayableAmount;



            // Procesar líneas

            var _invoiceLine = baseDoc.InvoiceLines;
            var _crediLIne = baseDoc.CreditNoteLines;
            var _debitLine = baseDoc.CreditNoteLines;
            foreach (var line in _invoiceLine)
            {
                Lines.Add(new FEComprobanteVentaItem(line));
            }
            foreach (var line in _crediLIne)
            {
                Lines.Add(new FEComprobanteVentaItem(line));
            }
            foreach (var line in _debitLine)
            {
                Lines.Add(new FEComprobanteVentaItem(line));
            }

        }
        private void ProcessPaymentTerms(List<PaymentTerms> paymentTerms, out PaymentTerms paymentTermsDet, out List<PaymentTerms> paymentTermsFp)
        {
            paymentTermsDet = new PaymentTerms();
            paymentTermsFp = new List<PaymentTerms>();
            foreach (var item in paymentTerms)
            {
                if (item.ID.Value == "Detraccion")
                {
                    paymentTermsDet = item;
                }
                else
                {
                    paymentTermsFp.Add(item);
                }
            }
        }

    }
}
