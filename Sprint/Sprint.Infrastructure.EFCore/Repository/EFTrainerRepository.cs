using Microsoft.EntityFrameworkCore;
using Sprint.DAL.EFCore.Data;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.Repository;

namespace Sprint.Infrastructure.EFCore.Repository;

public class EFTrainerRepository : ITrainerRepository
{
    internal SprintDbContext _dbContext;

    internal DbSet<Trainer> dbSet;

    public EFTrainerRepository(SprintDbContext dbContext)
    {
        _dbContext = dbContext;
        dbSet = _dbContext.Set<Trainer>();
    }

    public async virtual Task<Trainer?> GetByIdAsync(Guid id)
    {
        return dbSet
            .Include(t => t.User)
            .Include(t => t.Reservations)
            .FirstOrDefault(t => t.Id == id);
    }

    public async Task<IEnumerable<Trainer>> GetAllAsync()
    {
        return await dbSet
            .Include(t => t.User)
            .Include(t => t.Reservations)
            .ToListAsync();
    }

    public async virtual Task<Guid> InsertAsync(Trainer entity)
    {
        var entry = await dbSet.AddAsync(entity);

        return entry.Entity.Id;
    }

    public virtual void Delete(Trainer entityToDelete)
    {
        if (_dbContext.Entry(entityToDelete).State == EntityState.Detached)
        {
            dbSet.Attach(entityToDelete);
        }

        dbSet.Remove(entityToDelete);
    }

    public virtual void Update(Trainer entityToUpdate)
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

    public virtual async Task SaveAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}
