using Microsoft.EntityFrameworkCore;
using Sprint.DAL.EFCore.Data;
using Sprint.DAL.EFCore.Models.Base;
using Sprint.Infrastructure.Repository;

namespace Sprint.Infrastructure.EFCore.Repository;

public class EFGenericRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
{
    internal SprintDbContext _dbContext;

    internal DbSet<TEntity> dbSet;

    public EFGenericRepository(SprintDbContext dbContext)
    {
        _dbContext = dbContext;
        dbSet = _dbContext.Set<TEntity>();
    }

    public async virtual Task<TEntity?> GetByIdAsync(Guid id)
    {
        return await dbSet.FindAsync(id);
    }

    public async virtual Task<Guid> InsertAsync(TEntity entity)
    {
        var entry = await dbSet.AddAsync(entity);

        return entry.Entity.Id;
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

    public virtual async Task DeleteByIdAsync(Guid id)
    {
        var entityToDelete = await dbSet.FindAsync(id);
        if (entityToDelete is not null)
        {
            Delete(entityToDelete);
        }
    }

    public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await dbSet.ToListAsync();
    }
    
    public virtual async Task Detach(Guid id)
    {
        var entity = await dbSet.FindAsync(id);
        if (entity is not null)
        {
            _dbContext.Entry(entity).State = EntityState.Detached;
        }
    }

    public virtual void ClearTracking()
    {
        _dbContext.ChangeTracker.Clear();
    }

    public virtual async Task SaveAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}
