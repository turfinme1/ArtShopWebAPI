using ArtShop.Data.Models;

namespace ArtShop.Data.Common.Contracts
{
    public interface IArtworkRepository
    {
        IQueryable<Artwork> GetAll();

        IQueryable<Artwork> GetByIdAsync(int id);

        Task<Artwork?> GetByIdAsFormDtoAsync(int id);

        Task AddAsync(Artwork model);

        Task UpdateAsync(Artwork model);

        Task DeleteAsync(int id);
    }
}
