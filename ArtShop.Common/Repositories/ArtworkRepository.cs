using ArtShop.Data.Common.Contracts;
using ArtShop.Data.Models;

namespace ArtShop.Data.Common.Repositories
{
    internal sealed class ArtworkRepository(ApplicationDbContext context) : RepositoryBase<Artwork>(context), IArtworkRepository
    {
        public IQueryable<Artwork> GetAll()
        {
            return this.All();
        }

        public IQueryable<Artwork> GetByIdAsync(int id)
        {
            return this.All().Where(a => a.Id == id);
        }

        public async Task<Artwork?> GetByIdAsFormDtoAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task AddAsync(Artwork model)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Artwork model)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
