using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ArtShop.Data.Models
{
    [PrimaryKey(nameof(CategoryId), nameof(ArtworkId))]
    public class ArtworkCategory
    {
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public required Category Category { get; set; }

        public int ArtworkId { get; set; }

        [ForeignKey(nameof(ArtworkId))]
        public required Artwork Artwork { get; set; }
    }
}
