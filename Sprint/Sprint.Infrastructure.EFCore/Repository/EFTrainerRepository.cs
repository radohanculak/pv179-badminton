using Microsoft.EntityFrameworkCore;
using Sprint.DAL.EFCore.Data;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.Repository;

namespace Sprint.Infrastructure.EFCore.Repository;

public class EFTrainerRepository : EFGenericRepository<Trainer>, ITrainerRepository
{
    public EFTrainerRepository(SprintDbContext dbContext) : base(dbContext)
    {
    }

    public async virtual Task<Trainer?> GetByIdAsync(Guid id)
    {
        return dbSet
            .Include(t => t.User)
            .Include(t => t.Reservations)
                .ThenInclude(reservations => reservations.CourtReservation)
            .Include(t => t.Reservations)
                .ThenInclude(t => t.TrainerReview)
            .Include(t => t.Photos)
            .AsNoTracking()
            .FirstOrDefault(t => t.Id == id);
    }

    public async Task<IEnumerable<Trainer>> GetAllAsync()
    {
        return await dbSet
            .Include(t => t.User)
            .Include(t => t.Reservations)
                .ThenInclude(reservations => reservations.CourtReservation)
            .Include(t => t.Reservations)
                .ThenInclude(t => t.TrainerReview)
            .Include(t => t.Photos)
            .AsNoTracking()
            .ToListAsync();
    }
}
