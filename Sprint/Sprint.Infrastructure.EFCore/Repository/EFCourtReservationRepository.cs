using Microsoft.EntityFrameworkCore;
using Sprint.DAL.EFCore.Data;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.Repository;

namespace Sprint.Infrastructure.EFCore.Repository;

public class EFCourtReservationRepository : EFGenericRepository<CourtReservation>, ICourtReservationRepository
{
    public EFCourtReservationRepository(SprintDbContext dbContext) : base(dbContext)
    {
    }

    public async virtual Task<CourtReservation?> GetByIdAsync(Guid id)
    {
        return dbSet
            .AsNoTracking()
            .Include(r => r.User)
            .Include(r => r.Court)
            .Include(r => r.TrainerReservation)
            .AsNoTracking()
            .FirstOrDefault(r => r.Id == id);
    }

    public async Task<IEnumerable<CourtReservation>> GetAllAsync()
    {
        return await dbSet
            .AsNoTracking()
            .Include(r => r.User)
            .Include(r => r.Court)
            .Include(r => r.TrainerReservation)
            .AsNoTracking()
            .ToListAsync();
    }
}
