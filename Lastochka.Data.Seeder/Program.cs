using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Lastochka.Data.Xml;

namespace Lastochka.Data.Seeder
{
    partial class Program
    {
        internal static readonly string[] arguments = {
            "Server=(LocalDB)\\MSSQLLocalDB;Database=Lastochka.Development;Trusted_Connection=True;"
        };
        static async Task Main(string[] args)
        {

            using (var context = new LastochkaShopDbContextFactory().CreateDbContext(arguments)) {

                /*
                var shop = LastochkaXmlDataReader.ReadFromFile(LastochkaXmlDataReader.Filename);
                var mapper = MapperProfile.Singleton;

                var categories = mapper.Map<List<Category>>(shop.Categories.Category);
                var offers = mapper.Map<List<Offer>>(shop.Offers.Offer);

                await context.AddRangeAsync(categories);
                await context.AddRangeAsync(offers);
                */

                int result = 0;
                try
                {
                    /*
                    var a = context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Categories ON");
                    var b = context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Offers ON");

                    result = await context.SaveChangesAsync();

                    var c = context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Categories OFF");
                    var d = context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Offers OFF");
                    */
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Something went wrong!");
                    Console.WriteLine();
                    Console.WriteLine($"{ex.GetType().Name}: {ex.Message}");
                    Console.WriteLine($"{nameof(ex.StackTrace)}: {ex.StackTrace}");
                    Console.WriteLine();

                    return;
                }

                Console.WriteLine($"{result} record saved.");
            }

        }
        
    }
}
