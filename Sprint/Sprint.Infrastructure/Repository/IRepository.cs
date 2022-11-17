namespace Sprint.Infrastructure.Repository;

public interface IRepository<TEntity> where TEntity : class
{
    Task<TEntity> GetByIdAsync(Guid id);

    Task<Guid> InsertAsync(TEntity entity);

    Task DeleteByIdAsync(Guid id);

    void Delete(TEntity entityToDelete);

    void Update(TEntity entityToUpdate);

    Task<IEnumerable<TEntity>> GetAllAsync();

    TEntity GetOne();

    Task SaveAsync();
}
