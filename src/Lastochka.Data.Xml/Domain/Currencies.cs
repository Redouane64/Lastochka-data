using System.Collections.Generic;
using System.Xml.Serialization;

namespace Lastochka.Data.Domain
{
    [XmlRoot(ElementName = "currencies")]
    public class Currencies
    {
        [XmlElement(ElementName = "currency")]
        public List<Currency> Currency { get; set; }
    }
}
