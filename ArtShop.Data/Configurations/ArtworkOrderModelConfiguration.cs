using ArtShop.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArtShop.Data.Configurations
{
    public class ArtworkOrderModelConfiguration : IEntityTypeConfiguration<ArtworkOrder>
    {
        public void Configure(EntityTypeBuilder<ArtworkOrder> builder)
        {
            builder
                .HasOne(a => a.Order)
                .WithMany(a => a.ArtworksOrders)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
