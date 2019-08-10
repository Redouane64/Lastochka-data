using System.Xml.Serialization;

namespace Lastochka.Data.Xml
{
    [XmlRoot(ElementName = "currency")]
    public class Currency
    {
        [XmlAttribute(AttributeName = "id")]
        public CurrencyTypes Id { get; set; }

        [XmlAttribute(AttributeName = "rate")]
        public double Rate { get; set; }

    }
}
