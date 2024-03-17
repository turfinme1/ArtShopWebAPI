using ArtShop.Data.Configurations;
using ArtShop.Data.Models;
using ArtShop.Data.Seeding;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ArtShop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ArtworkOrderModelConfiguration());
            builder.ApplyConfiguration(new ArtworkCategoryModelConfiguration());
            builder.ApplyConfiguration(new ReviewModelConfiguration());
            builder.ApplyConfiguration(new CountrySeeder());
            builder.ApplyConfiguration(new SubjectSeeder());
            builder.ApplyConfiguration(new StyleSeeder());

            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                var connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Artwork> Artworks { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<ArtworkOrder> ArtworksOrders { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ArtworkCategory> ArtworksCategories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Style> Styles { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}
