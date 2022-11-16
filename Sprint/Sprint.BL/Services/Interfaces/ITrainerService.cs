using Sprint.BL.Dto.Trainer;
using Sprint.BL.Dto.TrainerReservation;

namespace Sprint.BL.Services.Interfaces;

public interface ITrainerService
{
    Task<TrainerDto> GetTrainer(Guid user);
    Task<List<TrainerReservationDto>> GetDailySchedule(Guid trainerId);
}
