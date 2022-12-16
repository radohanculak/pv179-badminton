using Microsoft.EntityFrameworkCore;
using Sprint.DAL.EFCore.Data;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.Query;

namespace Sprint.Infrastructure.EFCore.Query;

public class EFTrainerQueryObject : EFCoreQueryObject<Trainer>, ITrainerQueryObject
{
    private readonly SprintDbContext _dbContext;

    public EFTrainerQueryObject(SprintDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
        _query = _dbContext.Set<Trainer>()
            .Include(t => t.User)
            .Include(t => t.Reservations)
                .ThenInclude(reservations => reservations.CourtReservation)
            .Include(t => t.Reservations)
                .ThenInclude(t => t.TrainerReview)
            .Include(t => t.Photos)
            .AsNoTracking()
            .AsQueryable();
    }

    public override async Task<IEnumerable<Trainer>> ExecuteAsync()
    {
        return await _query.ToListAsync();
    }
}
