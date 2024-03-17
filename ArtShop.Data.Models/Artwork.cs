using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ArtShop.Data.Models.BaseEntity;
using static ArtShop.Data.Models.Constants.ValidationConstants.ArtworkValidationConstants;

namespace ArtShop.Data.Models
{
    public class Artwork : BaseModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public required string Name { get; set; }

        [Required]
        [MaxLength(SummaryMaxLength)]
        public required string Summary { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public required string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Quantity { get; set; }
        
        [Required]
        public int YearMade { get; set; }

        [Required]
        public double Height { get; set; }

        [Required]
        public double Width { get; set; }

        public double? Depth { get; set; }

        [Required]
        public bool IsFramed { get; set; }

        [Required]
        public int StyleId { get; set; }

        [ForeignKey(nameof(StyleId))]
        public Style Style { get; set; } = null!;

        [Required]
        public int SubjectId { get; set; }

        [ForeignKey(nameof(SubjectId))]
        public Subject Subject { get; set; } = null!;
        
        [Required]
        public required string CreatorId { get; set; }

        [ForeignKey(nameof(CreatorId))] 
        public IdentityUser Creator { get; set; } = null!;

        public List<ArtworkCategory> ArtworksCategories { get; set; } = [];
        
        public List<ArtworkOrder> ArtworksOrders { get; set; } = [];

        public List<Review> Reviews { get; set; } = [];
    }
}
