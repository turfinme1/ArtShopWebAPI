using ArtShop.Data.Common.Repositories;
using ArtShop.Data.Models;

namespace ArtShop.Data.Repositories
{
    public class ArtworkRepository(ApplicationDbContext context) : RepositoryBase<Artwork>(context), IArtworkRepository
    {
    }
}
