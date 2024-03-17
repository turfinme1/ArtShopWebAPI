using ArtShop.Data.Common.Repositories;
using ArtShop.Services.Common.Contracts;
using Microsoft.Extensions.Logging;

namespace ArtShop.Services.Review
{
    internal sealed class ReviewService(IRepositoryManager repositoryManager, ILogger<ReviewService> logger)
        : IReviewService
    {
        private readonly IRepositoryManager _repositoryManager = repositoryManager;
        private readonly ILogger<ReviewService> _logger = logger;
    }
}
