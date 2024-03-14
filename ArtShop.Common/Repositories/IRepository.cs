namespace ArtShop.Data.Common.Repositories
{
    public interface IRepository<TEntity> 
        where TEntity : class
    {
        IQueryable<TEntity> All();

        IQueryable<TEntity> AllNoTracking();

        Task AddAsync(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        Task<int> SaveChangesAsync();
    }
}
