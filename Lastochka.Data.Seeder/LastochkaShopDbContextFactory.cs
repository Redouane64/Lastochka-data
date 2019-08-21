
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Lastochka.Data.Seeder
{
    partial class Program
    {
        public class LastochkaShopDbContextFactory : IDesignTimeDbContextFactory<LastochkaContext>
        {

            public LastochkaContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<LastochkaContext>();
                optionsBuilder.UseSqlServer(args.Length > 0 ? args[0] : arguments[0], b => b.MigrationsAssembly("Lastochka.Data.Seeder"));

                return new LastochkaContext(optionsBuilder.Options);
            }
        }
        
    }
}
