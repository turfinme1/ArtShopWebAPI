using ArtShop.Data.Common.Repositories;
using ArtShop.Services.Artwork;
using ArtShop.Services.Common.Contracts;
using ArtShop.Services.Review;
using Microsoft.Extensions.Logging;

namespace ArtShop.Services.ServiceManager
{
    public sealed class ServiceManager(IRepositoryManager repositoryManager, ILoggerFactory loggerFactory)
        : IServiceManager
    {
        private readonly Lazy<IArtworkService> _artworkService = new Lazy<IArtworkService>(() =>
            new ArtworkService(repositoryManager, loggerFactory.CreateLogger<ArtworkService>()));
        private readonly Lazy<IReviewService> _reviewService = new Lazy<IReviewService>(() =>
            new ReviewService(repositoryManager, loggerFactory.CreateLogger<ReviewService>()));

        public IArtworkService ArtworkService => _artworkService.Value;
        
        public IReviewService ReviewService => _reviewService.Value;
    }
}
