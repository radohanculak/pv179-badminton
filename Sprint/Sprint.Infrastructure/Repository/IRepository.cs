﻿namespace Sprint.Infrastructure.Repository;

public interface IRepository<TEntity> where TEntity : class
{
    TEntity GetByID(object id);

    void Insert(TEntity entity);

    Task DeleteByIdAsync(object id);

    void Delete(TEntity entityToDelete);

    void Update(TEntity entityToUpdate);

    Task<IEnumerable<TEntity>> GetAllAsync();

    TEntity GetOne();

    Task SaveAsync();
}
