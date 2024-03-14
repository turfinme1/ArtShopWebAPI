using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ArtShop.Data.Common.Models;
using static ArtShop.Data.Common.Constants.ValidationConstants.AddressValidationConstants;

namespace ArtShop.Data.Models
{
    public class Address : BaseModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(StreetNameMaxLength)]
        public required string StreetName { get; set; }

        [MaxLength(ZipCodeMaxLength)]
        public string? ZipCode { get; set; }

        [Required]
        public int CityId { get; set; }

        [ForeignKey(nameof(CityId))]
        public required City City { get; set; }

        public List<Order> Orders { get; set; } = [];
    }
}
