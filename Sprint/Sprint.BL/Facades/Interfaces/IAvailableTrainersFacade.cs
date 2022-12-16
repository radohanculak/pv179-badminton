using Sprint.BL.Dto.Trainer;

namespace Sprint.BL.Facades.Interfaces;

public interface IAvailableTrainersFacade
{
    Task<IEnumerable<TrainerDto>> GetAllAvailableTrainers(DateTime timeFrom, int minRating, int minPrice, int maxPrice);
}