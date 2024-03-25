using ArtShop.Data.Common.Contracts;
using ArtShop.Data.Models;
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
            return await repositoryManager.Artwork.GetAll()
                .Where(a => a.Id == id)
                .Select(a => new ArtworkDto()
                {
                    Id = a.Id,
                    Name = a.Name,
                    Summary = a.Summary,
                    Description = a.Description,
                    Price = a.Price,
                    Quantity = a.Quantity,
                    YearMade = a.YearMade,
                    Height = a.Height,
                    Width = a.Width,
                    Depth = a.Depth,
                    IsFramed = a.IsFramed,
                    Subject = a.Subject.Name,
                    Style = a.Style.Name,
                    CreatorName = a.Creator.UserName,
                    CreatedOn = a.CreatedOn,
                    Reviews = a.Reviews.Select(r => new ReviewDto()
                    {
                        Id = r.Id,
                        CreatorId = r.CreatorId,
                        CreatedOn = r.CreatedOn,
                        ArtworkId = r.ArtworkId,
                        Comment = r.Comment,
                        Rating = r.Rating
                    }).ToList(),
                    Categories = a.ArtworksCategories.Select(ac => new ArtworkCategoriesDto()
                    {
                        Id = ac.Category.Id,
                        Name = ac.Category.Name,
                    }).ToList(),
                })
                .FirstOrDefaultAsync();
        }

        public async Task<ArtworkFormDto?> GetByIdAsFormDtoAsync(int id)
        {
            return await repositoryManager.Artwork.GetAll()
                .Where(a => a.Id == id)
                .Select(a => new ArtworkFormDto()
                {
                    Id = a.Id,
                    Name = a.Name,
                    Summary = a.Summary,
                    Description = a.Description,
                    Price = a.Price,
                    Quantity = a.Quantity,
                    YearMade = a.YearMade,
                    Height = a.Height,
                    Width = a.Width,
                    Depth = a.Depth,
                    IsFramed = a.IsFramed,
                    StyleId = a.StyleId,
                    SubjectId = a.SubjectId,
                })
                .FirstOrDefaultAsync();
            // TODO: Categories list??
        }

        public async Task<int> AddAsync(ArtworkFormDto model)
        {
            var entity = new Data.Models.Artwork()
            {
                Name = model.Name,
                Summary = model.Summary,
                Description = model.Description,
                Price = model.Price,
                Quantity = model.Quantity,
                CreatedOn = DateTime.Now,
                YearMade = model.YearMade,
                Height = model.Height,
                Width = model.Width,
                Depth = model.Depth,
                IsFramed = model.IsFramed,
                StyleId = model.StyleId,
                SubjectId = model.SubjectId,
                CreatorId = model.CreatorId,
                IsDeleted = false,
            };

            var artworkCategories = new List<ArtworkCategory>();
            foreach (var categoryName in model.Categories)
            {
                var category = await repositoryManager.Category.GetByNameAsync(categoryName);

                if (category is not null)
                {
                    var artworkCategory = new ArtworkCategory()
                    {
                        Category = category,
                        Artwork = entity,
                    };
                    artworkCategories.Add(artworkCategory);
                }
                else
                {
                    var artworkCategory = new ArtworkCategory()
                    {
                        Category = new Category()
                        {
                            Name = categoryName
                        },
                        Artwork = entity
                    };
                    artworkCategories.Add(artworkCategory);
                }
            }

            entity.ArtworksCategories = artworkCategories;

            await repositoryManager.Artwork.AddAsync(entity);
            await repositoryManager.SaveChangesAsync();

            return entity.Id;
        }

        public async Task UpdateAsync(ArtworkFormDto model)
        {
            try
            {
                var entity = await repositoryManager.Artwork.GetByIdAsync(model.Id).FirstOrDefaultAsync();
                
                entity.Name = model.Name;
                entity.Summary = model.Summary;
                entity.Description = model.Description;
                entity.Price = model.Price;
                entity.Quantity = model.Quantity;
                entity.YearMade = model.YearMade;
                entity.Height = model.Height;
                entity.Width = model.Width;
                entity.Depth = model.Depth;
                entity.IsFramed = model.IsFramed;
                entity.StyleId = model.StyleId;
                entity.SubjectId = model.SubjectId;
                entity.ModifiedOn = DateTime.Now;

                await repositoryManager.SaveChangesAsync();
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(UpdateAsync)}");
                throw;
            }

            // TODO: entity already in memory with tracking why use Update() ?
        }

        public async Task DeleteAsync(int id)
        {
            await repositoryManager.Artwork.DeleteAsync(id);
            await repositoryManager.SaveChangesAsync();

            // TODO: soft delete
        }
    }
}
