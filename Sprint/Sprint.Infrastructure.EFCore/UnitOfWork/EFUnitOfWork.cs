using Sprint.DAL.EFCore.Data;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.EFCore.Repository;
using Sprint.Infrastructure.Repository;
using Sprint.Infrastructure.UnitOfWork;

namespace Sprint.Infrastructure.EFCore.UnitOfWork;

public class EFUnitOfWork : IUnitOfWork
{
    private readonly SprintDbContext _dbContext;

    private IRepository<Court> CourtRepository { get; }

    private IRepository<CourtReservation> CourtReservationRepository { get; }

    private IRepository<Trainer> TrainerRepository { get; }

    private IRepository<TrainerPhoto> TrainerPhotoRepository { get; }

    private IRepository<TrainerReservation> TrainerReservationRepository { get; }

    private IRepository<TrainerReview> TrainerReviewRepository { get; }

    private IRepository<User> UserRepository { get; }

    public EFUnitOfWork(SprintDbContext dbDbContext)
    {
        _dbContext = dbDbContext;

        CourtRepository = new EFGenericRepository<Court>(_dbContext);
        CourtReservationRepository = new EFGenericRepository<CourtReservation>(_dbContext);
        TrainerRepository = new EFGenericRepository<Trainer>(_dbContext);
        TrainerPhotoRepository = new EFGenericRepository<TrainerPhoto>(_dbContext);
        TrainerReservationRepository = new EFGenericRepository<TrainerReservation>(_dbContext);
        TrainerReviewRepository = new EFGenericRepository<TrainerReview>(_dbContext);
        UserRepository = new EFGenericRepository<User>(_dbContext);
    }

    public async Task Commit()
    {
        await _dbContext.SaveChangesAsync();
    }

    public void Dispose()
    {
        _dbContext.Dispose();
    }
}
