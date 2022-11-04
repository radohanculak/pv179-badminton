using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.Repository;

namespace Sprint.Infrastructure.UnitOfWork;

public interface IUnitOfWork : IDisposable
{
    public IRepository<Court> CourtRepository { get; }

    public IRepository<CourtReservation> CourtReservationRepository { get; }

    public IRepository<Trainer> TrainerRepository { get; }

    public IRepository<TrainerPhoto> TrainerPhotoRepository { get; }

    public IRepository<TrainerReservation> TrainerReservationRepository { get; }

    public IRepository<TrainerReview> TrainerReviewRepository { get; }

    public IRepository<User> UserRepository { get; }
    
    Task CommitAsync();
}
