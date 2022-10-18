using Microsoft.EntityFrameworkCore;
using Sprint.DAL.Data;
using Sprint.Infrastructure.Repository;

namespace Sprint.Infrastructure.EFCore.Repository;

public class EFGenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
{
    internal SprintDbContext _dbContext;

    internal DbSet<TEntity> dbSet;

    public EFGenericRepository(SprintDbContext dbContext)
    {
        _dbContext = dbContext;
        dbSet = _dbContext.Set<TEntity>();
    }

    public virtual TEntity GetByID(object id)
    {
        return dbSet.Find(id);
    }

    public virtual void Insert(TEntity entity)
    {
        dbSet.Add(entity);
    }

    public virtual void Delete(TEntity entityToDelete)
    {
        if (_dbContext.Entry(entityToDelete).State == EntityState.Detached)
        {
            dbSet.Attach(entityToDelete);
        }

        dbSet.Remove(entityToDelete);
    }

    public virtual void Update(TEntity entityToUpdate)
    {
        dbSet.Attach(entityToUpdate);
        _dbContext.Entry(entityToUpdate).State = EntityState.Modified;
    }

    public virtual async Task DeleteAsync(object id)
    {
        var entityToDelete = await dbSet.FindAsync(id);
        Delete(entityToDelete);
    }

    public virtual async Task<IEnumerable<TEntity>> GetAll()
    {
        return await dbSet.ToListAsync();
    }

    public virtual async Task Save()
    {
        await _dbContext.SaveChangesAsync();
    }

    public virtual TEntity GetOne()
    {
        return dbSet.First();
    }
}
