using Sprint.DAL.EFCore.Data;
using Sprint.DAL.EFCore.Models;

namespace Sprint.Infrastructure.EFCore.Repository;

public class EFTrainerReservationRepository : EFGenericRepository<TrainerReservation>
{
    public EFTrainerReservationRepository(SprintDbContext dbContext) : base(dbContext)
    {
    }
}
