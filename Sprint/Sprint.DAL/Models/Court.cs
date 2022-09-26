namespace Sprint.DAL.Models
{
    public class Court : BaseEntity
    {
        public decimal HourlyRate { get; set; }

        public string CourtNumber { get; set; }

        public virtual List<CourtReservation> Reservations { get; set; }
    }
}
