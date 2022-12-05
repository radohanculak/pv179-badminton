using Microsoft.EntityFrameworkCore;
using Sprint.DAL.EFCore.Data;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.Repository;

namespace Sprint.Infrastructure.EFCore.Repository;

public class EFTrainerReservationRepository : EFGenericRepository<TrainerReservation>, ITrainerReservationRepository
{
    public EFTrainerReservationRepository(SprintDbContext dbContext) : base(dbContext)
    {
    }

    public async virtual Task<TrainerReservation?> GetByIdAsync(Guid id)
    {
        return dbSet
            .AsNoTracking()
            .Include(t => t.Trainer)
            .Include(t => t.CourtReservation)
            .Include(t => t.TrainerReview)
            .FirstOrDefault(t => t.Id == id);
    }

    public async Task<IEnumerable<TrainerReservation>> GetAllAsync()
    {
        return await dbSet
            .AsNoTracking()
            .Include(t => t.Trainer)
            .Include(t => t.CourtReservation)
            .Include(t => t.TrainerReview)
            .ToListAsync();
    }
}
