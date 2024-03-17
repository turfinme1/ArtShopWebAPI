using System.ComponentModel.DataAnnotations;
using static ArtShop.Data.Models.Constants.ValidationConstants.CountryValidationConstants;

namespace ArtShop.Data.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public required string Name { get; set; }

        public List<City> Cities { get; set; } = [];
    }
}

