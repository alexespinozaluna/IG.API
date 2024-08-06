using System.Xml.Serialization;

namespace API.API.SUNAT.Xml
{
    public class XmlDeserializer
    {
        public static Type GetDocumentType(string tipo)
        {
            return tipo switch
            {
                "01" => typeof(Invoice),
                "03" => typeof(Invoice),
                "07" => typeof(CreditNote),
                "08" => typeof(DebitNote),
                _ => throw new InvalidOperationException($"Tipo de documento no soportado : {tipo}")
            };
        }
        public static BaseDocument DeserializeXml(string xml, string tipo)
        {
            if (!string.IsNullOrEmpty(xml))
            {
                Type documentType = GetDocumentType(tipo);
                XmlSerializer serializer = new XmlSerializer(documentType);

                using (StringReader reader = new StringReader(xml))
                {
                    return (BaseDocument)serializer.Deserialize(reader);
                }
            }
            else
            {
                throw new InvalidOperationException($"Nose puede serializar el documento tipo: {tipo}");
            }
        }

    }
}
