using AutoMapper;
using Sprint.BL.Dto.CourtReservation;
using Sprint.BL.Dto.Trainer;
using Sprint.BL.Dto.TrainerReservation;
using Sprint.BL.Services.Interfaces;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.UnitOfWork;

namespace Sprint.BL.Services;

public class TrainerReservationService : ITrainerReservationService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public TrainerReservationService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<TrainerReservationDto> AddReservationAsync(CourtReservationDto courtReservation, Guid trainerId)
    {
        var newTrainerReservation = new TrainerReservationCreateDto
        {
            TrainerId = trainerId,
            CourtReservationId = courtReservation.Id
        };

        var trainerReservationId = await _unitOfWork.TrainerReservationRepository
            .InsertAsync(_mapper.Map<TrainerReservation>(newTrainerReservation));
        await _unitOfWork.CommitAsync();
        _unitOfWork.TrainerReservationRepository.ClearTracking();
        
        return await GetReservationAsync(trainerReservationId);
    }

    public async Task<TrainerReservationDto> GetReservationAsync(Guid reservationId)
    {
        var reservation = await _unitOfWork.TrainerReservationRepository.GetByIdAsync(reservationId);

        if (reservation == null)
        {
            throw new InvalidOperationException($"Trainer reservation with id {reservationId} does not exist");
        }

        return _mapper.Map<TrainerReservationDto>(reservation);
    }

    public async Task<List<TrainerReservationDto>> GetAllReservationsAsync(bool alsoDeleted)
    {
        var reservations = await _unitOfWork.TrainerReservationRepository.GetAllAsync();
        
        if (!alsoDeleted)
        {
            return _mapper.Map<List<TrainerReservationDto>>(reservations.Where(r => !r.IsDeleted));
        }

        return _mapper.Map<List<TrainerReservationDto>>(reservations);
    }

    public List<TrainerReservationDto> GetReservationsForTrainer(TrainerDto trainer, bool inPast, bool alsoDeleted)
    {
        IEnumerable<TrainerReservationDto> reservations = trainer.Reservations;
        if (!alsoDeleted)
        {
            reservations = reservations.Where(r => !r.IsDeleted);
        }

        if (inPast)
        {
            return reservations.ToList();
        }

        return reservations
            .Where(r => r.CourtReservation.From.Date >= DateTime.Now.Date)
            .ToList();
    }

    public List<TrainerReservationDto> GetDailyReservationsForTrainer(TrainerDto trainer, DateTime date)
    {
        IEnumerable<TrainerReservationDto> reservations = trainer.Reservations;

        return reservations
            .Where(r => r.CourtReservation.From.Date == date.Date)
            .ToList();
    }

    public async Task<List<TrainerReservationDto>> GetReservationsForUserAsync(Guid userId, bool inPast, bool alsoDeleted)
    {
        var reservations = (await GetAllReservationsAsync(alsoDeleted))
            .Where(r => r.CourtReservation.UserId == userId);

        if (inPast)
        {
            return reservations.ToList();
        }

        return reservations.Where(r => r.CourtReservation.From.Date >= DateTime.Now.Date).ToList();
    }

    public List<TrainerReservationDto>? GetTrainerDailySchedule(TrainerDto trainer, DateTime date)
    {
        return trainer.Reservations?
            .Where(r => !r.IsDeleted)
            .Where(r => r.CourtReservation.From.Date == date.Date)
            .OrderBy(r => r.CourtReservation.From)
            .ToList();
    }

    public async Task DeleteReservationAsync(TrainerReservationDto reservation)
    {
        reservation.IsDeleted = true;

        _unitOfWork.TrainerReservationRepository.Update(_mapper.Map<TrainerReservation>(reservation));
        await _unitOfWork.CommitAsync();
        _unitOfWork.TrainerReservationRepository.ClearTracking();
    }
}
