using ArtShop.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArtShop.Data.Configurations
{
    public class ArtworkCategoryModelConfiguration : IEntityTypeConfiguration<ArtworkCategory>
    {
        public void Configure(EntityTypeBuilder<ArtworkCategory> builder)
        {
            builder
                .HasOne(a => a.Category)
                .WithMany(a => a.ArtworksCategories)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
