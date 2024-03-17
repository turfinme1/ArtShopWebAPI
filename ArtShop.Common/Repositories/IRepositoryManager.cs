namespace ArtShop.Data.Common.Repositories
{
    public interface IRepositoryManager
    {
        IArtworkRepository Artwork { get; }

        IReviewRepository Review { get; }

        Task<int> SaveChangesAsync();
    }
}
