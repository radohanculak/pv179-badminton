using Sprint.BL.Dto.CourtReservation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint.BL.Facades.Interfaces;

public interface ICourtReservationFacade
{
    Task<CourtReservationDto> AddReservationAsync(Guid userId, Guid courtId, DateTime from, DateTime to);
    Task<List<CourtReservationDto>> GetAllReservationsAsync();
    Task<CourtReservationDto> GetReservationAsync(Guid reservationId);
    Task<List<CourtReservationDto>> GetReservationsAsync(Guid userId, bool inPast);
    Task<List<CourtReservationDto>> GetReservationsAsync(Guid userId, DateTime from, DateTime to);
    Task DeleteReservationAsync(Guid reservationId);
}
