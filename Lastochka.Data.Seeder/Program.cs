using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Internal;

namespace Lastochka.Data.Seeder
{
    class Program
    {
        internal static readonly string[] arguments = {
            "User ID=postgres;Password=postgres;Host=localhost;Port=5432;Database=Lastochka;Pooling=true;"
        };
        /*
        static async Task Main(string[] args)
        {

            using (var context = new LastochkaShopDbContextFactory().CreateDbContext(arguments)) {

                
                var shop = LastochkaXmlDataReader.ReadFromFile(LastochkaXmlDataReader.Filename);

                await context.AddRangeAsync(shop.Categories.Category);
                await context.AddRangeAsync(shop.Offers.Offer);

                var r = await context.SaveChangesAsync();
                
            }
            
        }

        public class LastochkaShopDbContextFactory : IDesignTimeDbContextFactory<LastochkaShopDbContext>
        {

            public LastochkaShopDbContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<LastochkaShopDbContext>();
                optionsBuilder.UseNpgsql(args.Length > 0 ? args[0] : arguments[0]);

                return new LastochkaShopDbContext(optionsBuilder.Options);
            }
        }
        */
    }
}
