using Microsoft.EntityFrameworkCore;
using Sprint.DAL.EFCore.Data;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.Repository;

namespace Sprint.Infrastructure.EFCore.Repository;

public class EFUserRepository : IUserRepository
{
    internal SprintDbContext _dbContext;

    internal DbSet<User> dbSet;

    public EFUserRepository(SprintDbContext dbContext)
    {
        _dbContext = dbContext;
        dbSet = _dbContext.Set<User>();
    }

    public async virtual Task<User?> GetByIdAsync(Guid id)
    {
        return dbSet
            .Include(t => t.CourtReservations)
            .FirstOrDefault(t => t.Id == id);
    }

    public async Task<IEnumerable<User>> GetAllAsync()
    {
        return await dbSet
            .Include(t => t.CourtReservations)
            .ToListAsync();
    }

    public async virtual Task<Guid> InsertAsync(User entity)
    {
        var entry = await dbSet.AddAsync(entity);

        return entry.Entity.Id;
    }

    public virtual void Delete(User entityToDelete)
    {
        if (_dbContext.Entry(entityToDelete).State == EntityState.Detached)
        {
            dbSet.Attach(entityToDelete);
        }

        dbSet.Remove(entityToDelete);
    }

    public virtual void Update(User entityToUpdate)
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
