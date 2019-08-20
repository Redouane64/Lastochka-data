using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Lastochka.Data.Xml;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Lastochka.Data.Seeder
{
    class Program
    {
        internal static readonly string[] arguments = {
            "Server=(LocalDB)\\MSSQLLocalDB;Database=Lastochka.Development;Trusted_Connection=True;"
        };
        static async Task Main(string[] args)
        {

            using (var context = new LastochkaShopDbContextFactory().CreateDbContext(arguments)) {

                
                var shop = LastochkaXmlDataReader.ReadFromFile(LastochkaXmlDataReader.Filename);
                var mapper = MapperProfile.Singleton;

                var categories = mapper.Map<List<Category>>(shop.Categories.Category);
                var offers = mapper.Map<List<Offer>>(shop.Offers.Offer);

                await context.AddRangeAsync(categories);
                await context.AddRangeAsync(offers);

                int result = 0;
                try
                {
                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Categories ON");
                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Offers ON");

                    result = await context.SaveChangesAsync();

                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Categories OFF");
                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Offers OFF");

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

        
        public class LastochkaShopDbContextFactory : IDesignTimeDbContextFactory<LastochkaContext>
        {

            public LastochkaContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<LastochkaContext>();
                optionsBuilder.UseSqlServer(args.Length > 0 ? args[0] : arguments[0]);

                return new LastochkaContext(optionsBuilder.Options);
            }
        }
        
    }
}
