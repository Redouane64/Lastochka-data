using System.Collections.Generic;
using System.Xml.Serialization;

namespace Lastochka.Data.Domain
{
    [XmlRoot(ElementName = "offers")]
    public class Offers
    {
        [XmlElement(ElementName = "offer")]
        public List<Offer> Offer { get; set; }
    }
}
