using System.Collections.Generic;
using System.Xml.Serialization;

namespace Lastochka.Data.Xml
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
    

    [XmlRoot(ElementName = "currencies")]
    public class Currencies
    {
        [XmlElement(ElementName = "currency")]
        public List<CurrencyType> Currency { get; set; }
    }

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

    [XmlRoot(ElementName = "categories")]
    public class Categories
    {
        [XmlElement(ElementName = "category")]
        public List<Category> Category { get; set; }
    }

    [XmlRoot(ElementName = "offer")]
    public class Offer
    {
        [XmlElement(ElementName = "url")]
        public string Url { get; set; }
        [XmlElement(ElementName = "price")]
        public decimal Price { get; set; }
        [XmlElement(ElementName = "oldprice")]
        public decimal Oldprice { get; set; }
        /*
        [XmlElement(ElementName = "currencyId")]
        public CurrencyType CurrencyId { get; set; }
        */
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

    [XmlRoot(ElementName = "offers")]
    public class Offers
    {
        [XmlElement(ElementName = "offer")]
        public List<Offer> Offer { get; set; }
    }

    [XmlRoot(ElementName = "shop")]
    public class Shop
    {
        /*
        [XmlElement(ElementName = "currencies")]
        public Currencies Currencies { get; set; }
        */

        [XmlElement(ElementName = "categories")]
        public Categories Categories { get; set; }

        [XmlElement(ElementName = "offers")]
        public Offers Offers { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
    }

    public enum CurrencyType
    {
        [XmlEnum(Name = "RUB")]RUB,
        [XmlEnum(Name = "EUR")]EUR,
        [XmlEnum(Name = "USD")]USD,
        [XmlEnum(Name = "UAH")]UAH,
        [XmlEnum(Name = "BYN")]BYN
    }
}
