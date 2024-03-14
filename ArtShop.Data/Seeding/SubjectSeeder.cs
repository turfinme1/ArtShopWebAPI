using ArtShop.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArtShop.Data.Seeding
{
    internal class SubjectSeeder : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasData(GetSubjects());
        }

        private static Subject[] GetSubjects()
        {
            return
           [
               new Subject()
               {
                   Id = 1,
                   Name = "Abstract and Non-Figurative",
               },
               new Subject()
               {
                   Id = 2,
                   Name = "Animals And Birds",
               },
               new Subject()
               {
                   Id = 3,
                   Name = "Architecture and Cityscapes",
               },
               new Subject()
               {
                   Id = 4,
                   Name = "Flowers and Plants",
               },
               new Subject()
               {
                   Id = 5,
                   Name = "Landscapes, Sea and Sky",
               },
               new Subject()
               {
                   Id = 6,
                   Name = "Nudes and Erotic",
               },
               new Subject()
               {
                   Id = 7,
                   Name = "People and Portraits",
               },
               new Subject()
               {
                   Id = 8,
                   Name = "Still Life",
               },
               new Subject()
               {
                   Id = 9,
                   Name = "Transportation and Maps",
               },
           ];
        }

    }
}
