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
        CourtReservationRepository = new EFCourtReservationRepository(_dbContext);
        TrainerRepository = new EFTrainerRepository(_dbContext);
        TrainerPhotoRepository = new EFGenericRepository<TrainerPhoto>(_dbContext);
        TrainerReservationRepository = new EFTrainerReservationRepository(_dbContext);
        TrainerReviewRepository = new EFTrainerReviewRepository(_dbContext);
        UserRepository = new EFUserRepository(_dbContext);
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
