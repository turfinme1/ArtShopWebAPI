using ArtShop.Data.Common.Contracts;
using Microsoft.EntityFrameworkCore;

namespace ArtShop.Data.Common.Repositories
{
    public abstract class RepositoryBase<TEntity>(ApplicationDbContext context) : IRepositoryBase<TEntity>
        where TEntity : class
    {
        private readonly DbSet<TEntity> _dbSet = context.Set<TEntity>();

        public IQueryable<TEntity> All()
            => _dbSet;

        public IQueryable<TEntity> AllAsNoTracking()
            => _dbSet.AsNoTracking();

        public async Task CreateAsync(TEntity entity)
            => await _dbSet.AddAsync(entity);

        public void Update(TEntity entity)
            => _dbSet.Update(entity);

        public void Delete(TEntity entity)
            => _dbSet.Remove(entity);
    }
}
