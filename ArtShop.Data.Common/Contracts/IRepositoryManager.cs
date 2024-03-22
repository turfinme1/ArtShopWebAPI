namespace ArtShop.Data.Common.Contracts
{
    public interface IRepositoryManager
    {
        IArtworkRepository Artwork { get; }

        IReviewRepository Review { get; }

        Task<int> SaveChangesAsync();
    }
}
