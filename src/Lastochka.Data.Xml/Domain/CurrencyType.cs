using System.Xml.Serialization;

namespace Lastochka.Data.Domain
{

    public enum CurrencyType
    {
        [XmlEnum(Name = "RUB")] RUB,
        [XmlEnum(Name = "EUR")] EUR,
        [XmlEnum(Name = "USD")] USD,
        [XmlEnum(Name = "UAH")] UAH,
        [XmlEnum(Name = "BYN")] BYN
    }
}
