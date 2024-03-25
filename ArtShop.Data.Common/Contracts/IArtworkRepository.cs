using ArtShop.Data.Models;

namespace ArtShop.Data.Common.Contracts
{
    public interface IArtworkRepository
    {
        IQueryable<Artwork> GetAll();

        IQueryable<Artwork> GetByIdAsync(int id);

        IQueryable<Artwork> GetByIdAsNoTrackingAsync(int id);

        Task AddAsync(Artwork entity);

        void Update(Artwork entity);

        Task DeleteAsync(int id);
    }
}
