using System.Xml.Serialization;
using System.Collections.Generic;

namespace Lastochka.Data.Xml
{
    [XmlRoot(ElementName = "currencies")]
    public class Currencies
    {
        [XmlElement(ElementName = "currency")]
        public List<Currency> Currency { get; set; }
    }

}
