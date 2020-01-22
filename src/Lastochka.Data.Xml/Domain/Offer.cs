using System.Xml.Serialization;

namespace Lastochka.Data.Domain
{
    [XmlRoot(ElementName = "offer")]
    public class Offer
    {
        [XmlElement(ElementName = "url")]
        public string Url { get; set; }
        [XmlElement(ElementName = "price")]
        public decimal Price { get; set; }
        [XmlElement(ElementName = "oldprice")]
        public decimal Oldprice { get; set; }

        [XmlElement(ElementName = "currencyId")]
        public CurrencyType CurrencyId { get; set; }

        [XmlElement(ElementName = "categoryId")]
        public int CategoryId { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public int Id { get; set; }
        [XmlAttribute(AttributeName = "available")]
        public bool Available { get; set; }
        [XmlElement(ElementName = "picture")]
        public string Picture { get; set; }
    }
}
