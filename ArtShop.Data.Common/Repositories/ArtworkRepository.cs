using ArtShop.Data.Common.Contracts;
using ArtShop.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ArtShop.Data.Common.Repositories
{
    internal sealed class ArtworkRepository(ApplicationDbContext context) : RepositoryBase<Artwork>(context), IArtworkRepository
    {
        public IQueryable<Artwork> GetAll()
        {
            return this.AllAsNoTracking();
        }

        public IQueryable<Artwork> GetByIdAsync(int id)
        {
            return this.All().Where(a => a.Id == id);
        }

        public IQueryable<Artwork> GetByIdAsNoTrackingAsync(int id)
        {
            return this.AllAsNoTracking().Where(a => a.Id == id);
        }

        public async Task AddAsync(Artwork entity)
        {
            await this.CreateAsync(entity);
        }

        public void Update(Artwork entity)
        {
            base.Update(entity);
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id).FirstOrDefaultAsync();

            if (entity is not null)
            {
                this.Delete(entity);
            }
        }
    }
}
