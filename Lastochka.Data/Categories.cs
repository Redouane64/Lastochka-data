using System.Xml.Serialization;
using System.Collections.Generic;

namespace Lastochka.Data.Xml
{
    [XmlRoot(ElementName = "categories")]
    public class Categories
    {
        [XmlElement(ElementName = "category")]
        public List<Category> Category { get; set; }
    }

}
