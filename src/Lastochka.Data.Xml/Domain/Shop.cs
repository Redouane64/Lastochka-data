using System.Xml.Serialization;

namespace Lastochka.Data.Domain
{
    [XmlRoot(ElementName = "shop")]
    public class Shop
    {

        [XmlElement(ElementName = "currencies")]
        public Currencies Currencies { get; set; }

        [XmlElement(ElementName = "categories")]
        public Categories Categories { get; set; }

        [XmlElement(ElementName = "offers")]
        public Offers Offers { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
    }
}
