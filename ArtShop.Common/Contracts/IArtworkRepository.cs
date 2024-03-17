using ArtShop.Data.Models;

namespace ArtShop.Data.Common.Contracts
{
    public interface IArtworkRepository
    {
        Task<IEnumerable<Artwork>> GetAllArtworksAsync();
    }
}
