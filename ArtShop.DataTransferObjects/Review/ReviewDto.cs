namespace ArtShop.Services.Models.Review
{
    public class ReviewDto
    {
        public int Id { get; set; }

        public string? Comment { get; set; }

        public int Rating { get; set; }

        public required string CreatorId { get; set; }

        public int ArtworkId { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
