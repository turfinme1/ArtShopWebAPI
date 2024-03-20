using ArtShop.Data.Common.Contracts;
using ArtShop.Data.Models;

namespace ArtShop.Data.Common.Repositories
{
    internal sealed class ReviewRepository(ApplicationDbContext context) : RepositoryBase<Review>(context), IReviewRepository
    {
    }
}
