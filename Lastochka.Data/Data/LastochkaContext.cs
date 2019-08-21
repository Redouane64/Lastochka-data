using System.Collections.Generic;

using Lastochka.Data.Xml;

using Microsoft.EntityFrameworkCore;

namespace Lastochka.Data
{
    public class LastochkaContext : DbContext
    {
        public LastochkaContext(DbContextOptions<LastochkaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Offer> Offers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Offer>(entity =>
            {
                entity.HasIndex(e => e.CategoryId);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Offers)
                    .HasForeignKey(d => d.CategoryId);

            });

            modelBuilder.Entity<Category>()
                .Property(c => c.Id).ValueGeneratedNever();

            modelBuilder.Entity<Offer>()
                .Property(o => o.Id).ValueGeneratedNever();

            var shop = LastochkaXmlDataReader.ReadFromFile(LastochkaXmlDataReader.Filename);
            var mapper = MapperProfile.Singleton;

            var categories = mapper.Map<List<Category>>(shop.Categories.Category);
            var offers = mapper.Map<List<Offer>>(shop.Offers.Offer);


            modelBuilder.Entity<Category>()
                .HasData(categories);

            modelBuilder.Entity<Offer>()
                .HasData(offers);
        }

    }
}