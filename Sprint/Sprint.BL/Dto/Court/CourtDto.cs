using Sprint.BL.Dto.CourtReservation;

namespace Sprint.BL.Dto.Court;

public class CourtDto
{
    public Guid Id { get; set; }

    public decimal HourlyRate { get; set; }

    public string CourtNumber { get; set; }

    public virtual List<CourtReservationDto> Reservations { get; set; }
}
