using ArtShop.Data.Common.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ArtShop.Data.Repositories
{
    public class Repository<TEntity>(ApplicationDbContext context) : IRepository<TEntity>
        where TEntity : class
    {
        private readonly ApplicationDbContext _context = context ?? throw new ArgumentNullException(nameof(context));
        private readonly DbSet<TEntity> _dbSet = context.Set<TEntity>();

        public IQueryable<TEntity> All()
        {
            return _dbSet;
        }

        public IQueryable<TEntity> AllNoTracking()
        {
            return _dbSet.AsNoTracking();
        }

        public Task AddAsync(TEntity entity)
        {
            return _dbSet.AddAsync(entity).AsTask();
        }

        public void Update(TEntity entity)
        {
            var entry = _context.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }

            entry.State = EntityState.Modified;
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
