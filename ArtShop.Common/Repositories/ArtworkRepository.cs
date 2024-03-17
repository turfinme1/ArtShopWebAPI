using ArtShop.Data.Common.Contracts;
using ArtShop.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ArtShop.Data.Common.Repositories
{
    internal sealed class ArtworkRepository(ApplicationDbContext context) : RepositoryBase<Artwork>(context), IArtworkRepository
    {
        public async Task<IEnumerable<Artwork>> GetAllArtworksAsync()
        {
            return await this.All().ToListAsync();
        }
    }
}
