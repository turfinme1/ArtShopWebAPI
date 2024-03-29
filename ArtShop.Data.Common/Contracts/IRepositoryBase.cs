﻿namespace ArtShop.Data.Common.Contracts
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        IQueryable<TEntity> All();

        IQueryable<TEntity> AllAsNoTracking();

        Task CreateAsync(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity id);
    }
}
