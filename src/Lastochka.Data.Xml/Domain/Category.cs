using System.Xml.Serialization;

namespace Lastochka.Data.Domain
{
    [XmlRoot(ElementName = "category")]
    public class Category
    {
        [XmlAttribute(AttributeName = "id")]
        public int Id { get; set; }
        [XmlText]
        public string Text { get; set; }
        [XmlAttribute(AttributeName = "parentId")]
        public int ParentId { get; set; }
    }
}
