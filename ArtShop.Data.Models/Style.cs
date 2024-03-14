using System.ComponentModel.DataAnnotations;
using static ArtShop.Data.Common.Constants.ValidationConstants.StyleValidationConstants;


namespace ArtShop.Data.Models
{
    public class Style
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public required string Name { get; set; }

        public List<Artwork> Artworks { get; set; } = [];
    }
}
