using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

using Lastochka.Data.Xml;
using Microsoft.EntityFrameworkCore;

namespace Lastochka.Data
{
    public class LastochkaXmlDataReader
    {
        public const string Filename = "Ласточка.xml";
        public const int FileEncodingCodePage = 1251;

        public static Shop ReadFromFile(string filename)
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
                        typeof(CurrencyTypes),
                        typeof(int?)
                    });

                using (var xmlFileStream = new StreamReader(filename, Encoding.GetEncoding(FileEncodingCodePage)))
                using (var xmlReader = new XmlTextReader(xmlFileStream))
                {
                    xmlReader.Normalization = false;

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
