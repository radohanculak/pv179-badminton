namespace Sprint.Infrastructure.Repository;

public interface IRepository<TEntity> where TEntity : class
{
    TEntity GetByID(object id);

    void Insert(TEntity entity);

    Task DeleteAsync(object id);

    void Delete(TEntity entityToDelete);

    void Update(TEntity entityToUpdate);

    Task<IEnumerable<TEntity>> GetAll();

    TEntity GetOne();

    Task Save();
}
