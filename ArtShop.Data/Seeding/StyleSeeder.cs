using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtShop.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArtShop.Data.Seeding
{
    internal class StyleSeeder : IEntityTypeConfiguration<Style>
    {
        public void Configure(EntityTypeBuilder<Style> builder)
        {
            builder.HasData(GetStyles());
        }

        private static Style[] GetStyles()
        {
            return
            [
                new Style()
                {
                    Id = 1,
                    Name = "Abstract",
                },
                new Style()
                {
                    Id = 2,
                    Name = "Collage",
                },
                new Style()
                {
                    Id = 3,
                    Name = "Expressive and Gestural",
                },
                new Style()
                {
                    Id = 4,
                    Name = "Graphic, Typographic",
                },
                new Style()
                {
                    Id = 5,
                    Name = "Impressionistic",
                },
                new Style()
                {
                    Id = 6,
                    Name = "Photorealistic",
                },
                new Style()
                {
                    Id = 7,
                    Name = "Naive",
                },
                new Style()
                {
                    Id = 8,
                    Name = "Surrealistic",
                },
                new Style()
                {
                    Id = 9,
                    Name = "Urban and Pop",
                },
                new Style()
                {
                    Id = 10,
                    Name = "Unspecified",
                },
            ];
        }
    }
}
