using ArtShop.Data.Common.Contracts;
using ArtShop.Services.Common.Contracts;
using ArtShop.Services.Models.Artwork;
using ArtShop.Services.Models.Review;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ArtShop.Services.Artwork
{
    internal sealed class ArtworkService(IRepositoryManager repositoryManager, ILogger<ArtworkService> logger)
        : IArtworkService
    {
        public async Task<IEnumerable<ArtworkDto>> GetAllAsync()
        {
            try
            {
                return await repositoryManager.Artwork.GetAll().Select(a => new ArtworkDto()
                {
                    Id = a.Id,
                    Name = a.Name,
                    CreatorName = a.Creator.UserName,
                    Description = a.Description,
                    Style = a.Style.Name,
                    Subject = a.Subject.Name,
                    Summary = a.Summary,
                    CreatedOn = a.CreatedOn,
                    Depth = a.Depth,
                    Height = a.Height,
                    IsFramed = a.IsFramed,
                    Price = a.Price,
                    Quantity = a.Quantity,
                    Reviews = a.Reviews.Select(r => new ReviewDto()
                    {
                        Id = r.Id,
                        CreatorId = r.CreatorId,
                        CreatedOn = r.CreatedOn,
                        ArtworkId = r.ArtworkId,
                        Comment = r.Comment,
                        Rating = r.Rating
                    }).ToList(),
                    Width = a.Width,
                    YearMade = a.YearMade,
                    Categories = a.ArtworksCategories.Select(ac => new ArtworkCategoriesDto()
                    {
                        Id = ac.Category.Id,
                        Name = ac.Category.Name,
                        Description = ac.Category.Description
                    }).ToList()

                }).ToListAsync();
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(GetAllAsync)}");
                throw;
            }
        }

        public async Task<ArtworkDto?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ArtworkFormDto?> GetByIdAsFormDtoAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task AddAsync(ArtworkFormDto model)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(ArtworkFormDto model)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
