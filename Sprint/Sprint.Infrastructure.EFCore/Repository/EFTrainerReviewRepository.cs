using Microsoft.EntityFrameworkCore;
using Sprint.DAL.EFCore.Data;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.Repository;

namespace Sprint.Infrastructure.EFCore.Repository;

public class EFTrainerReviewRepository : EFGenericRepository<TrainerReview>, ITrainerReviewRepository
{
    public EFTrainerReviewRepository(SprintDbContext dbContext) : base(dbContext)
    {
    }

    public async virtual Task<TrainerReview?> GetByIdAsync(Guid id)
    {
        return dbSet
            .AsNoTracking()
            .Include(t => t.Reservation)
                .ThenInclude(r => r.Trainer)
            .FirstOrDefault(t => t.Id == id);
    }

    public async Task<IEnumerable<TrainerReview>> GetAllAsync()
    {
        return await dbSet
            .AsNoTracking()
            .Include(t => t.Reservation)
                .ThenInclude(r => r.Trainer)
            .ToListAsync();
    }
}
