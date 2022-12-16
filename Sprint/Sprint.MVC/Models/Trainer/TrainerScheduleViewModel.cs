namespace Sprint.MVC.Models.Trainer;

public class TrainerScheduleViewModel
{
    public Guid TrainerId { get; set; }
    public DateTime Date { get; set; }

    public TrainerScheduleViewModel(Guid trainerId)
    {
        TrainerId = trainerId;
    }

    public TrainerScheduleViewModel()
    {
        
    }
}