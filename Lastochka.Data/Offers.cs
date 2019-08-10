using System.Xml.Serialization;
using System.Collections.Generic;

namespace Lastochka.Data.Xml
{
    [XmlRoot(ElementName = "offers")]
    public class Offers
    {
        [XmlElement(ElementName = "offer")]
        public List<Offer> Offer { get; set; }
    }

}
