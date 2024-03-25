using ArtShop.Services.Models.Artwork;

namespace ArtShop.Services.Common.Contracts
{
    public interface IArtworkService
    {
        Task<IEnumerable<ArtworkDto>> GetAllAsync();

        Task<ArtworkDto?> GetByIdAsync(int id);

        Task<ArtworkFormDto?> GetByIdAsFormDtoAsync(int id);

        Task<int> AddAsync(ArtworkFormDto model);

        Task UpdateAsync(ArtworkFormDto model);

        Task DeleteAsync(int id);
    }
}
