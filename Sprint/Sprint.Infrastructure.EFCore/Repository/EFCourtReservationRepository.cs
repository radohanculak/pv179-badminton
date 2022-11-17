using Microsoft.EntityFrameworkCore;
using Sprint.DAL.EFCore.Data;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.Repository;

namespace Sprint.Infrastructure.EFCore.Repository;

public class EFCourtReservationRepository : ICourtReservationRepository
{
    internal SprintDbContext _dbContext;

    internal DbSet<CourtReservation> dbSet;

    public EFCourtReservationRepository(SprintDbContext dbContext)
    {
        _dbContext = dbContext;
        dbSet = _dbContext.Set<CourtReservation>();
    }

    public async virtual Task<CourtReservation?> GetByIdAsync(Guid id)
    {
        return dbSet
            .Include(r => r.User)
            .Include(r => r.Court)
            .Include(r => r.TrainerReservation)
            .AsNoTracking()
            .FirstOrDefault(r => r.Id == id);
    }

    public async Task<IEnumerable<CourtReservation>> GetAllAsync()
    {
        return await dbSet
            .Include(r => r.User)
            .Include(r => r.Court)
            .Include(r => r.TrainerReservation)
            .AsNoTracking()
            .ToListAsync();
    }

    public async virtual Task<Guid> InsertAsync(CourtReservation entity)
    {
        var entry = await dbSet.AddAsync(entity);

        return entry.Entity.Id;
    }

    public virtual void Delete(CourtReservation entityToDelete)
    {
        if (_dbContext.Entry(entityToDelete).State == EntityState.Detached)
        {
            dbSet.Attach(entityToDelete);
        }

        dbSet.Remove(entityToDelete);
    }

    public virtual void Update(CourtReservation entityToUpdate)
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

    public virtual CourtReservation GetOne()
    {
        return dbSet.First();
    }
}
