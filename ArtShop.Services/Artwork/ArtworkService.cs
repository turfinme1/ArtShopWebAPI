using ArtShop.Data.Common.Repositories;
using ArtShop.Services.Common.Contracts;
using Microsoft.Extensions.Logging;

namespace ArtShop.Services.Artwork
{
    internal sealed class ArtworkService(IRepositoryManager repositoryManager, ILogger<ArtworkService> logger)
        : IArtworkService
    {
        private readonly IRepositoryManager _repositoryManager = repositoryManager;
        private readonly ILogger<ArtworkService> _logger = logger;
    }
}
