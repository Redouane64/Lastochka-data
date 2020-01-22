using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

using Lastochka.Data.Domain;

namespace Lastochka.Data.Xml
{
    public static class LastochkaXmlDataReader
    {
        public const string Filename = "Ласточка.xml";
        public const int FileEncodingCodePage = 1251;
       
        public static Shop ParseFile()
        {
            Shop shop = null;

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            try
            {
                var serializer = new XmlSerializer(
                    typeof(Shop), 
                    new[] {
                        typeof(Categories),
                        typeof(Currencies),
                        typeof(Currency),
                        typeof(Category),
                        typeof(Offer),
                        typeof(Offers),
                        typeof(CurrencyType)
                    });

                using (var xmlFileStream = new StreamReader(Filename, Encoding.GetEncoding(FileEncodingCodePage)))
                using (var xmlReader = new XmlTextReader(xmlFileStream))
                {
                    xmlReader.Normalization = true;

                    shop = (Shop)serializer.Deserialize(xmlReader);
                }

            }
            catch (Exception)
            {

                throw;
            }

            return shop;
        }
        
    }
}
