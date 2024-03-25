using System.ComponentModel.DataAnnotations;
using ArtShop.Services.Models.Style;
using ArtShop.Services.Models.Subject;
using static ArtShop.Data.Models.Constants.ValidationConstants.ArtworkValidationConstants;
using static ArtShop.Data.Models.Constants.ValidationConstants.ErrorMessages;

namespace ArtShop.Services.Models.Artwork
{
    public class ArtworkFormDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(NameMaxLength,
            MinimumLength = NameMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(SummaryMaxLength,
            MinimumLength = SummaryMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        public string Summary { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(DescriptionMaxLength,
            MinimumLength = DescriptionMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Range(PriceMinValue,
            PriceMaxValue,
            ErrorMessage = NumberValueErrorMessage)]
        public decimal Price { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int Quantity { get; set; }

        [Required]
        [Range(YearMadeMinValue, YearMadeMaxValue)]
        public int YearMade { get; set; }

        [Required]
        [Range(DimensionMinValue, DimensionMaxValue)]
        public double Height { get; set; }

        [Required]
        [Range(DimensionMinValue, DimensionMaxValue)]
        public double Width { get; set; }

        [Range(DimensionMinValue, DimensionMaxValue)]
        public double? Depth { get; set; }

        [Required]
        public bool IsFramed { get; set; }

        public string CreatorId { get; set; } = string.Empty;

        [Required]
        public int StyleId { get; set; }

        public IEnumerable<StyleDto> Styles { get; set; } = [];

        [Required]
        public int SubjectId { get; set; }

        public IEnumerable<SubjectDto> Subjects { get; set; } = [];

        public IEnumerable<string> Categories = [];
    }
}
