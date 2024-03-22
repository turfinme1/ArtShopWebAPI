using ArtShop.Services.Models.Review;

namespace ArtShop.Services.Models.Artwork
{
    public class ArtworkDto
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string Summary { get; set; }

        public required string Description { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public int YearMade { get; set; }

        public double Height { get; set; }

        public double Width { get; set; }

        public double? Depth { get; set; }

        public bool IsFramed { get; set; }

        public required string Style { get; set; }

        public required string Subject { get; set; }

        public required string CreatorName { get; set; }

        public List<ArtworkCategoriesDto> Categories { get; set; } = [];

        public List<ReviewDto> Reviews { get; set; } = [];

        public DateTime CreatedOn { get; set; }

        // TODO: orders model
    }
}
