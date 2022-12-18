using AutoMapper;
using FluentAssertions;
using Moq;
using Sprint.BL.Dto.Court;
using Sprint.BL.Dto.CourtReservation;
using Sprint.BL.Dto.User;
using Sprint.BL.Services;
using Sprint.BL.Services.Interfaces;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.Query;
using Sprint.Infrastructure.UnitOfWork;

namespace Sprint.BL.UnitTest.ServiceTests;

public class CourtReservationServiceTests
{
    private Mock<IUnitOfWork> _unitOfWorkMock;
    private Mock<IMapper> _mapperMock;
    private Mock<IUserService> _userServiceMock;
    private Mock<ICourtService> _courtServiceMock;
    private Mock<IQueryObject<CourtReservation>> _queryObjectMock;

    private Court _court;
    private CourtDto _courtDto;
    private List<CourtReservation> _reservations;
    private List<CourtReservationDto> _reservationsDto;
    private UserDto _userDto;
    private Guid _userGuid = Guid.NewGuid();
    private Guid _courtGuid = Guid.NewGuid();
    private Guid _reservationGuid = Guid.NewGuid();
    

    public CourtReservationServiceTests()
    {
        _unitOfWorkMock = new Mock<IUnitOfWork>();
        _mapperMock = new Mock<IMapper>();
        _userServiceMock = new Mock<IUserService>();
        _courtServiceMock = new Mock<ICourtService>();
        _queryObjectMock = new Mock<IQueryObject<CourtReservation>>();

        _userDto = new UserDto
        {
            Id = _userGuid,
            FirstName = "anna",
            LastName = "novakova",
            Email = "anna@gmail.com"
        };

        _court = new Court
        {
            HourlyRate = 150,
            CourtNumber = "1",
        };

        var reservationPast0 = new CourtReservation
        {
            Id = _reservationGuid,
            CourtId = _courtGuid,
            Court = _court,
            From = new DateTime(2020, 1, 1, 15, 0, 0),
            To = new DateTime(2020, 1, 1, 16, 0, 0),
            UserId = _userGuid,
        };

        var reservationPast1 = new CourtReservation
        {
            Id = Guid.NewGuid(),
            CourtId = _courtGuid,
            Court = _court,
            From = new DateTime(2020, 1, 1, 16, 0, 0),
            To = new DateTime(2020, 1, 1, 17, 0, 0),
            UserId = _userGuid,
        };

        var reservationPast2 = new CourtReservation
        {
            Id = Guid.NewGuid(),
            CourtId = _courtGuid,
            Court = _court,
            From = DateTime.Now.AddDays(-5),
            To = DateTime.Now.AddDays(-5),
            UserId = _userGuid,
        };

        var reservationFuture0 = new CourtReservation
        {
            Id = Guid.NewGuid(),
            CourtId = _courtGuid,
            Court = _court,
            From = DateTime.MaxValue,
            To = DateTime.MaxValue,
            UserId = _userGuid,
        };

        var reservationFuture1 = new CourtReservation
        {
            Id = Guid.NewGuid(),
            CourtId = Guid.NewGuid(),
            Court = null,
            From = DateTime.Now.AddDays(5),
            To = DateTime.Now.AddDays(5).AddHours(1),
            UserId = _userGuid,
        };

        var reservationFuture2 = new CourtReservation
        {
            Id = Guid.NewGuid(),
            CourtId = Guid.NewGuid(),
            Court = null,
            From = DateTime.Now.AddHours(1),
            To = DateTime.Now.AddHours(2),
            UserId = _userGuid,
        };


        _reservations = new List<CourtReservation>
        {
            reservationPast0, reservationPast1, reservationPast2,
            reservationFuture0, reservationFuture1, reservationFuture2
        };
        
        _courtDto = new CourtDto
        {
            HourlyRate = 150,
            CourtNumber = "1",
        };

        var reservationPastDto0 = new CourtReservationDto
        {
            Id = _reservations[0].Id,
            CourtId = _reservations[0].CourtId,
            From = _reservations[0].From,
            To = _reservations[0].To,
            UserId = _userGuid,
        };

        var reservationPastDto1 = new CourtReservationDto
        {
            Id = _reservations[1].Id,
            CourtId = _reservations[1].CourtId,
            From = _reservations[1].From,
            To = _reservations[1].To,
            UserId = _userGuid,
        };

        var reservationPastDto2 = new CourtReservationDto
        {
            Id = _reservations[2].Id,
            CourtId = _reservations[2].CourtId,
            From = _reservations[2].From,
            To = _reservations[2].To,
            UserId = _userGuid,
        };

        var reservationFutureDto0 = new CourtReservationDto
        {
            Id = _reservations[3].Id,
            CourtId = _reservations[3].CourtId,
            From = _reservations[3].From,
            To = _reservations[3].To,
            UserId = _userGuid,
        };

        var reservationFutureDto1 = new CourtReservationDto
        {
            Id = _reservations[4].Id,
            CourtId = _reservations[4].CourtId,
            From = _reservations[4].From,
            To = _reservations[4].To,
            UserId = _userGuid,
        };

        var reservationFutureDto2 = new CourtReservationDto
        {
            Id = _reservations[5].Id,
            CourtId = _reservations[5].CourtId,
            From = _reservations[5].From,
            To = _reservations[5].To,
            UserId = _userGuid,
        };
        
        _reservationsDto = new List<CourtReservationDto>
        {
            reservationPastDto0, reservationPastDto1, reservationPastDto2,
            reservationFutureDto0, reservationFutureDto1, reservationFutureDto2
        };
    }

    
    [Fact]
    public async Task GetReservationAsync_ReservationIdInvalidId_InvalidOperationException()
    {
        _unitOfWorkMock
            .Setup(x => x.CourtReservationRepository.GetByIdAsync(_reservationGuid))
            .ReturnsAsync((CourtReservation?) null);
        
        CourtReservationService service = new CourtReservationService(
            _unitOfWorkMock.Object, _mapperMock.Object, _queryObjectMock.Object);
        
        var action = () => service.GetReservationAsync(_reservationGuid);
        await action.Should()
            .ThrowAsync<InvalidOperationException>()
            .WithMessage($"Reservation with id {_reservationGuid} does not exist");
    }
    
    
    [Fact]
    public async Task GetReservationAsync_OnlyIdValid_ReservationDto()
    {
        var wantedCourtRes = _reservations[0];
        var wantedCourtResDto = _reservationsDto[0];
        
        _unitOfWorkMock
            .Setup(x => x.CourtReservationRepository.GetByIdAsync(wantedCourtRes.Id))
            .ReturnsAsync(wantedCourtRes);

        _mapperMock
            .Setup(x => x.Map<CourtReservationDto>(wantedCourtRes))
            .Returns(wantedCourtResDto);
        
        CourtReservationService service = new CourtReservationService(
            _unitOfWorkMock.Object, _mapperMock.Object, _queryObjectMock.Object);
        
        var result = await service.GetReservationAsync(_reservationGuid);
        result.Should().Be(wantedCourtResDto);
    }


    [Fact]
    public async Task GetReservationAsync_UserPast_SixReservations()
    {
        var user = new UserDto
        {
            Id = _userGuid,
            CourtReservations = _reservationsDto,
        };
            
        _userServiceMock
            .Setup(x => x.GetUserAsync(_userGuid))
            .ReturnsAsync(user);

        CourtReservationService service = new CourtReservationService(
            _unitOfWorkMock.Object, _mapperMock.Object, _queryObjectMock.Object);
        
        var result = service.GetReservations(user, true, true);
        result.Should().HaveCount(6);
        result.Should().Contain(_reservationsDto[0]);
        result.Should().Contain(_reservationsDto[5]);
    }
    
    [Fact]
    public async Task GetReservationAsync_UserNotPast_SixReservations()
    {
        var user = new UserDto
        {
            Id = _userGuid,
            CourtReservations = _reservationsDto,
        };
            
        _userServiceMock
            .Setup(x => x.GetUserAsync(_userGuid))
            .ReturnsAsync(user);

        CourtReservationService service = new CourtReservationService(
            _unitOfWorkMock.Object, _mapperMock.Object, _queryObjectMock.Object);
        
        var result = service.GetReservations(user, false, true);
        result.Should().HaveCount(3);
        result.Should().NotContain(_reservationsDto[0]);
        result.Should().Contain(_reservationsDto[5]);
    }
    
    
    [Fact]
    public async Task GetReservationAsync_UserTimespan_ThreeReservations()
    {
        var user = new UserDto
        {
            Id = _userGuid,
            CourtReservations = _reservationsDto,
        };
            
        _userServiceMock
            .Setup(x => x.GetUserAsync(_userGuid))
            .ReturnsAsync(user);

        CourtReservationService service = new CourtReservationService(
            _unitOfWorkMock.Object, _mapperMock.Object, _queryObjectMock.Object);
        
        var result = service.GetReservations(user,false, true);
        
        result.Should().HaveCount(3);
        result.Should().NotContain(_reservationsDto[0]);
        result.Should().NotContain(_reservationsDto[1]);
        result.Should().NotContain(_reservationsDto[2]);
        result.Should().Contain(_reservationsDto[3]);
        result.Should().Contain(_reservationsDto[4]);
        result.Should().Contain(_reservationsDto[5]);
    }
}