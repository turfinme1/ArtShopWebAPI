namespace ArtShop.Services.Models.Artwork
{
    public class ArtworkCategoriesDto
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string Description { get; set; }
    }
}
