using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtShop.Data.Models
{
    [PrimaryKey(nameof(OrderId), nameof(ArtworkId))]
    public class ArtworkOrder
    {
        public int OrderId { get; set; }

        [ForeignKey(nameof(OrderId))]
        public required Order Order { get; set; }

        public int ArtworkId { get; set; }

        [ForeignKey(nameof(ArtworkId))]
        public required Artwork Artwork { get; set; }
    }
}
