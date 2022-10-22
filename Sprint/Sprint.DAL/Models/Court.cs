using Sprint.DAL.EFCore.Models.Base;

namespace Sprint.DAL.EFCore.Models;

public class Court : BaseEntity
{
    public decimal HourlyRate { get; set; }

    public string CourtNumber { get; set; }

    public virtual List<CourtReservation> Reservations { get; set; }
}
