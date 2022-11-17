using Microsoft.EntityFrameworkCore;
using Sprint.DAL.EFCore.Data;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.Repository;

namespace Sprint.Infrastructure.EFCore.Repository;

public class EFTrainerReviewRepository : ITrainerReviewRepository
{
    internal SprintDbContext _dbContext;

    internal DbSet<TrainerReview> dbSet;

    public EFTrainerReviewRepository(SprintDbContext dbContext)
    {
        _dbContext = dbContext;
        dbSet = _dbContext.Set<TrainerReview>();
    }

    public async virtual Task<TrainerReview?> GetByIdAsync(Guid id)
    {
        return dbSet
            .Include(t => t.Reservation)
                .ThenInclude(r => r.Trainer)
            .FirstOrDefault(t => t.Id == id);
    }

    public async Task<IEnumerable<TrainerReview>> GetAllAsync()
    {
        return await dbSet
            .Include(t => t.Reservation)
                .ThenInclude(r => r.Trainer)
            .ToListAsync();
    }

    public async virtual Task<Guid> InsertAsync(TrainerReview entity)
    {
        var entry = await dbSet.AddAsync(entity);

        return entry.Entity.Id;
    }

    public virtual void Delete(TrainerReview entityToDelete)
    {
        if (_dbContext.Entry(entityToDelete).State == EntityState.Detached)
        {
            dbSet.Attach(entityToDelete);
        }

        dbSet.Remove(entityToDelete);
    }

    public virtual void Update(TrainerReview entityToUpdate)
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
