using Sprint.BL.Dto.Trainer;
using Sprint.BL.Dto.TrainerReservation;

namespace Sprint.BL.Services.Interfaces;

public interface ITrainerService
{
    Task<bool> AddTrainer(Guid userId);
    Task<TrainerDto> GetTrainer(Guid userId);
    Task<List<TrainerReservationDto>> GetDailySchedule(Guid trainerId);
}
