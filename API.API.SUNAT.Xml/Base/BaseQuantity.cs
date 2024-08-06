using System.Xml.Serialization;

namespace API.API.SUNAT.Xml.Base
{
    public class BaseQuantity
    {
        [XmlAttribute(AttributeName = "unitCode")]
        public string UnitCode { get; set; }
        [XmlText]
        public double Value { get; set; }
    }
}
