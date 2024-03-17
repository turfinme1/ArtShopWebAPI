using System.ComponentModel.DataAnnotations;
using static ArtShop.Data.Models.Constants.ValidationConstants.CategoryValidationConstants;

namespace ArtShop.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public required string Name { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public required string Description { get; set; }
        
        public List<ArtworkCategory> ArtworksCategories { get; } = [];
    }
}
