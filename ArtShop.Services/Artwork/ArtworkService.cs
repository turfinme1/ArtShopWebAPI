using ArtShop.Data.Common.Contracts;
using ArtShop.Services.Common.Contracts;
using Microsoft.Extensions.Logging;

namespace ArtShop.Services.Artwork
{
    internal sealed class ArtworkService(IRepositoryManager repositoryManager, ILogger<ArtworkService> logger)
        : IArtworkService
    {
        public async Task<IEnumerable<Data.Models.Artwork>> GetAllArtworksAsync()
        {
            try
            {
                var artworks = await repositoryManager.Artwork.GetAllArtworksAsync();
                return artworks;
            }
            catch (Exception e)
            {
                logger.LogError(e, "Error");
                throw;
            }
        }
    }
}
