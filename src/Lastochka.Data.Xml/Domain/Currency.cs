using System.Xml.Serialization;

namespace Lastochka.Data.Domain
{
    /* 
     Licensed under the Apache License, Version 2.0

     http://www.apache.org/licenses/LICENSE-2.0
     */

    [XmlRoot(ElementName = "currency")]
    public class Currency
    {
        [XmlAttribute(AttributeName = "id")]
        public CurrencyType Id { get; set; }
        [XmlAttribute(AttributeName = "rate")]
        public float Rate { get; set; }
    }
}
