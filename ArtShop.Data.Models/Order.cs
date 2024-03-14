using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ArtShop.Data.Common.Models;

namespace ArtShop.Data.Models
{
    public class Order : BaseModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }
        
        [Required]
        public required string UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public required IdentityUser User { get; set; }

        [Required]
        public int AddressId { get; set; }

        [ForeignKey(nameof(AddressId))]
        public required Address Address { get; set; }

        public List<ArtworkOrder> ArtworksOrders { get; } = [];
    }
}
