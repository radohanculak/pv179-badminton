using Sprint.DAL.EFCore.Data;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.EFCore.Repository;
using Sprint.Infrastructure.Repository;
using Sprint.Infrastructure.UnitOfWork;

namespace Sprint.Infrastructure.EFCore.UnitOfWork;

public class EFUnitOfWork : IUnitOfWork
{
    private readonly SprintDbContext _dbContext;

    public IRepository<Court> CourtRepository { get; }

    public IRepository<CourtReservation> CourtReservationRepository { get; }

    public IRepository<Trainer> TrainerRepository { get; }

    public IRepository<TrainerPhoto> TrainerPhotoRepository { get; }

    public IRepository<TrainerReservation> TrainerReservationRepository { get; }

    public IRepository<TrainerReview> TrainerReviewRepository { get; }

    public IRepository<User> UserRepository { get; }

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

    public async Task CommitAsync()
    {
        await _dbContext.SaveChangesAsync();
    }

    public void Dispose()
    {
        _dbContext.Dispose();
    }
}
