using ArtShop.Data.Models;

namespace ArtShop.Data.Common.Contracts
{
    public interface ICategoryRepository
    {
        IQueryable<Category> GetAll();

        IQueryable<Category> GetByIdAsync(int id);

        IQueryable<Category> GetByIdAsNoTrackingAsync(int id);

        Task<Category?> GetByNameAsync(string name);

        Task AddAsync(Category entity);

        Task DeleteAsync(int id);
    }
}
