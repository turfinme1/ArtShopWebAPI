namespace ArtShop.Services.Common.Contracts
{
    public interface IServiceManager
    {
        IArtworkService ArtworkService { get; }
        IReviewService ReviewService { get; }
    }
}
