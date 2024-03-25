using ArtShop.Data.Common.Contracts;
using ArtShop.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ArtShop.Data.Common.Repositories
{
    internal sealed class CategoryRepository(ApplicationDbContext context) : RepositoryBase<Category>(context), ICategoryRepository
    {
        public IQueryable<Category> GetAll()
        {
            return this.AllAsNoTracking();
        }

        public IQueryable<Category> GetByIdAsync(int id)
        {
            return this.All().Where(c => c.Id == id);
        }

        public IQueryable<Category> GetByIdAsNoTrackingAsync(int id)
        {
            return this.AllAsNoTracking().Where(c => c.Id == id);
        }

        public Task<Category?> GetByNameAsync(string name)
        {
            return this.AllAsNoTracking().Where(c => c.Name == name).FirstOrDefaultAsync();
        }

        public async Task AddAsync(Category entity)
        {
            await this.CreateAsync(entity);
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
