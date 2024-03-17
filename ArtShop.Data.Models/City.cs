using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static ArtShop.Data.Models.Constants.ValidationConstants.CityValidationConstants;

namespace ArtShop.Data.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public required string Name { get; set; }

        [Required]
        public int CountryId { get; set; }

        [ForeignKey(nameof(CountryId))]
        public required Country Country { get; set; }

        public List<Address> Addresses { get; set; } = [];
    }
}

