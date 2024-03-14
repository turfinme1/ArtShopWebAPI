using ArtShop.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArtShop.Data.Configurations
{
    public class ReviewModelConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder
                .HasOne(e => e.Creator)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
