using ArtShop.Data.Common.Repositories;
using ArtShop.Data.Models;

namespace ArtShop.Data.Repositories
{
    public class ReviewRepository(ApplicationDbContext context) : RepositoryBase<Review>(context), IReviewRepository
    {
    }
}
