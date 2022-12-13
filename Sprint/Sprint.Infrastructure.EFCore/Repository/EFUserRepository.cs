using Microsoft.EntityFrameworkCore;
using Sprint.DAL.EFCore.Data;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.Repository;

namespace Sprint.Infrastructure.EFCore.Repository;

public class EFUserRepository : EFGenericRepository<User>, IUserRepository
{
    public EFUserRepository(SprintDbContext dbContext) : base(dbContext)
    {
    }

    public async override Task<User?> GetByIdAsync(Guid id)
    {
        return dbSet
            .AsNoTracking()
            .Include(t => t.CourtReservations)
                .ThenInclude(t => t.TrainerReservation)
                    .ThenInclude(t => t.Trainer)
                        .ThenInclude(t => t.User)
            .Include(t => t.CourtReservations)
                .ThenInclude(t => t.TrainerReservation)
                    .ThenInclude(t => t.TrainerReview)
            .Include(t => t.Trainer)
            .FirstOrDefault(t => t.Id == id);
    }

    public async override Task<IEnumerable<User>> GetAllAsync()
    {
        return await dbSet
            .AsNoTracking()
            .Include(t => t.CourtReservations)
                .ThenInclude(t => t.TrainerReservation)
                    .ThenInclude(t => t.Trainer)
                        .ThenInclude(t => t.User)
            .Include(t => t.CourtReservations)
                .ThenInclude(t => t.TrainerReservation)
                    .ThenInclude(t => t.TrainerReview)
            .Include(t => t.Trainer)
            .ToListAsync();
    }
}
