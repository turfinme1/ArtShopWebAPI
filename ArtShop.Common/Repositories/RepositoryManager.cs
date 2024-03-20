﻿using ArtShop.Data.Common.Contracts;

namespace ArtShop.Data.Common.Repositories
{
    public sealed class RepositoryManager(ApplicationDbContext context) : IRepositoryManager
    {
        private readonly Lazy<IArtworkRepository> _artworkRepository = new Lazy<IArtworkRepository>(() => new ArtworkRepository(context));
        private readonly Lazy<IReviewRepository> _reviewRepository = new Lazy<IReviewRepository>(() => new ReviewRepository(context));

        public IArtworkRepository Artwork => _artworkRepository.Value;

        public IReviewRepository Review => _reviewRepository.Value;

        public async Task<int> SaveChangesAsync()
        {
            return await context.SaveChangesAsync();
        }
    }
}
