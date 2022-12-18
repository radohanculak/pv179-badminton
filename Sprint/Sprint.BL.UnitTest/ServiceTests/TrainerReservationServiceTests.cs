using AutoMapper;
using FluentAssertions;
using Moq;
using Sprint.BL.Dto.CourtReservation;
using Sprint.BL.Dto.TrainerReservation;
using Sprint.BL.Services;
using Sprint.BL.Services.Interfaces;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.UnitOfWork;

namespace Sprint.BL.UnitTest.ServiceTests;

public class TrainerReservationServiceTests
{
    private Mock<IUnitOfWork> _unitOfWorkMock;
    private Mock<IMapper> _mapperMock;
    private Mock<ITrainerService> _trainerServiceMock;
    private Mock<ICourtReservationService> _courtReservationServiceMock;

    private List<CourtReservationDto> _courtResDtos;
    private TrainerReservation _trainerRes;
    private TrainerReservationDto _trainerResDto;
    private Guid _userGuid = Guid.NewGuid();
    private Guid _trainerGuid = Guid.NewGuid();
    private Guid _trainerResGuid = Guid.NewGuid();

    public TrainerReservationServiceTests()
    {
        _unitOfWorkMock = new Mock<IUnitOfWork>();
        _mapperMock = new Mock<IMapper>();
        _trainerServiceMock = new Mock<ITrainerService>();
        _courtReservationServiceMock = new Mock<ICourtReservationService>();

        var courtResPast0 = new CourtReservationDto
        {
            Id = Guid.NewGuid(),
            From = new DateTime(2020, 1, 1, 15, 0, 0),
            To = new DateTime(2020, 1, 1, 16, 0, 0),
            UserId = _userGuid,
        };

        var courtResPast1 = new CourtReservationDto
        {
            Id = Guid.NewGuid(),
            From = new DateTime(2020, 1, 1, 16, 0, 0),
            To = new DateTime(2020, 1, 1, 17, 0, 0),
            UserId = _userGuid,
        };

        var courtResPast2 = new CourtReservationDto
        {
            Id = Guid.NewGuid(),
            From = DateTime.Now.AddDays(-5),
            To = DateTime.Now.AddDays(-5),
            UserId = _userGuid,
        };

        var courtResFuture0 = new CourtReservationDto
        {
            Id = Guid.NewGuid(),
            From = DateTime.MaxValue,
            To = DateTime.MaxValue,
            UserId = _userGuid,
        };

        var courtResFuture1 = new CourtReservationDto
        {
            Id = Guid.NewGuid(),
            From = DateTime.Now.AddDays(5),
            To = DateTime.Now.AddDays(5).AddHours(1),
            UserId = _userGuid,
        };

        var courtResFuture2 = new CourtReservationDto
        {
            Id = Guid.NewGuid(),
            From = DateTime.Now.AddHours(1),
            To = DateTime.Now.AddHours(2),
            UserId = _userGuid,
        };
        
        _courtResDtos = new List<CourtReservationDto>
        {
            courtResPast0, courtResPast1, courtResPast2,
            courtResFuture0, courtResFuture1, courtResFuture2
        };
        
        var courtReservation = new CourtReservation
        {
            Id = Guid.NewGuid(),
            From = new DateTime(2020, 1, 1, 15, 0, 0),
            To = new DateTime(2020, 1, 1, 16, 0, 0),
            UserId = _userGuid,
        };

        _trainerRes = new TrainerReservation
        {
            Id = Guid.NewGuid(),
            CourtReservation = courtReservation,
            CourtReservationId = courtReservation.Id,
            IsDeleted = false,
        };
        
        _trainerResDto = new TrainerReservationDto
        {
            Id = Guid.NewGuid(),
            CourtReservation = courtResPast0,
            IsDeleted = false,
        };
    }

    
    [Fact]
    public async Task GetReservationAsync_InvalidId_InvalidOperationException()
    {
        _unitOfWorkMock
            .Setup(x => x.TrainerReservationRepository.GetByIdAsync(_trainerResGuid))
            .ReturnsAsync((TrainerReservation?) null);

        TrainerReservationService service = new TrainerReservationService(
            _unitOfWorkMock.Object, _mapperMock.Object);

        var action = () => service.GetReservationAsync(_trainerResGuid);
        await action.Should()
            .ThrowAsync<InvalidOperationException>()
            .WithMessage($"Trainer reservation with id {_trainerResGuid} does not exist");
    }
    
    
    [Fact]
    public async Task GetReservationAsync_Valid_TrainerReservationDto()
    {
        _unitOfWorkMock
            .Setup(x => x.TrainerReservationRepository.GetByIdAsync(_trainerResGuid))
            .ReturnsAsync(_trainerRes);

        _mapperMock
            .Setup(x => x.Map<TrainerReservationDto>(_trainerRes))
            .Returns(_trainerResDto);

        TrainerReservationService service = new TrainerReservationService(
            _unitOfWorkMock.Object, _mapperMock.Object);

        var result = await service.GetReservationAsync(_trainerResGuid);
        result.Should().Be(_trainerResDto);
    }


    [Fact]
    public async Task AddReservationAsync_Valid_NewReservation()
    {
        var courtResGuid = Guid.NewGuid();

        _unitOfWorkMock
            .Setup(x => x.TrainerReservationRepository.InsertAsync(_trainerRes))
            .ReturnsAsync(_trainerResGuid);

        _mapperMock
            .Setup(x => x.Map<TrainerReservation>(It.Is<TrainerReservationCreateDto>
                (x => x.TrainerId == _trainerResDto.Id && x.CourtReservationId == _trainerResDto.CourtReservation.Id)))
            .Returns(_trainerRes);

        _unitOfWorkMock
            .Setup(x => x.TrainerReservationRepository.GetByIdAsync(_trainerResGuid))
            .ReturnsAsync(_trainerRes);

        _mapperMock
            .Setup(x => x.Map<TrainerReservationDto>(_trainerRes))
            .Returns(_trainerResDto);
        
        
        TrainerReservationService service = new TrainerReservationService(
            _unitOfWorkMock.Object, _mapperMock.Object);

        var result = await service.AddReservationAsync(_courtResDtos.First(), _trainerGuid);

        result.Should().Be(_trainerResDto);
    }
}