namespace Sprint.DAL.Models
{
    public class TrainerPhoto : BaseEntity
    {
        public string Path { get; set; }

        public bool Hide { get; set; }

        public int TrainerId { get; set; }

        public Trainer Trainer { get; set; }
    }
}