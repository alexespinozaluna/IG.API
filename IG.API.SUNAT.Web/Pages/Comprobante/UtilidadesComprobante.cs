namespace IG.API.SUNAT.Web.Pages.Comprobante
{
    public class UtilidadesComprobante
    {
        public static string DocumentoTipo(string tipo)
        {
            return tipo switch
            {
                "01" => "FACTURA ELECTRÓNICA",
                "03" => "BOLETA DE VENTA ELECTRÓNICA",
                "07" => "NOTA DE CRÉDITO ELECTRÓNICA",
                "08" => "NOTA DE DÉBITO ELECTRÓNICA",
                "09" => "GUÍA DE REMISIÓN REMITENTE ELECTRÓNICA",
                _ => throw new InvalidOperationException($"Tipo de documento no soportado : {tipo}")
            };
        }
    }
}
