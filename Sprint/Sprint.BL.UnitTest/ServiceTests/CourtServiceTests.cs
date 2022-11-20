using AutoMapper;
using FluentAssertions;
using Moq;
using Sprint.BL.Dto.Court;
using Sprint.BL.Dto.CourtReservation;
using Sprint.BL.Services;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.UnitOfWork;

namespace Sprint.BL.UnitTest.ServiceTests;

public class CourtServiceTests
{
    private Mock<IUnitOfWork> _unitOfWorkMock;
    private Mock<IMapper> _mapperMock;
    private Court _court;
    private CourtDto _courtDto;
    private List<CourtReservation> _reservations;

    private Guid _courtGuid = Guid.NewGuid();

    public CourtServiceTests()
    {
        _unitOfWorkMock = new Mock<IUnitOfWork>();
        _mapperMock = new Mock<IMapper>();

        _courtDto = new CourtDto
        {
            HourlyRate = 150,
            CourtNumber = "1",
        };

        _court = new Court
        {
            HourlyRate = 150,
            CourtNumber = "1",
        };

        var courtGoodId0 = new CourtReservation
        {
            CourtId = _courtGuid,
            Court = _court,
            From = new DateTime(2020, 1, 1, 15, 0, 0),
            To = new DateTime(2020, 1, 1, 16, 0, 0),
        };

        var courtGoodId1 = new CourtReservation
        {
            Id = Guid.NewGuid(),
            CourtId = _courtGuid,
            Court = _court,
            From = new DateTime(2020, 1, 1, 16, 0, 0),
            To = new DateTime(2020, 1, 1, 17, 0, 0),
        };

        var courtGoodId2 = new CourtReservation
        {
            Id = Guid.NewGuid(),
            CourtId = _courtGuid,
            Court = _court,
            From = new DateTime(2020, 1, 1, 18, 0, 0),
            To = new DateTime(2020, 1, 1, 19, 0, 0),
        };

        var courtGoodId3 = new CourtReservation
        {
            Id = Guid.NewGuid(),
            CourtId = _courtGuid,
            Court = _court,
            From = new DateTime(2020, 1, 2, 18, 0, 0),
            To = new DateTime(2020, 1, 2, 19, 0, 0),
        };

        var courtBadId0 = new CourtReservation
        {
            Id = Guid.NewGuid(),
            CourtId = Guid.NewGuid(),
            Court = null,
            From = new DateTime(2021, 1, 1, 18, 0, 0),
            To = new DateTime(2021, 1, 1, 19, 0, 0),
        };

        var courtBadId1 = new CourtReservation
        {
            Id = Guid.NewGuid(),
            CourtId = Guid.NewGuid(),
            Court = null,
            From = new DateTime(2022, 1, 1, 18, 0, 0),
            To = new DateTime(2022, 1, 1, 19, 0, 0),
        };


        _reservations = new List<CourtReservation>
        {
            courtGoodId0, courtGoodId1, courtGoodId2, courtGoodId3, courtBadId0, courtBadId1
        };
    }

    [Fact]
    public async Task GetCourtAsync_InvalidId_InvalidOperationException()
    {
        CourtService service = new CourtService(_unitOfWorkMock.Object, _mapperMock.Object);

        _unitOfWorkMock
            .Setup(x => x.CourtRepository.GetByIdAsync(_courtGuid))
            .ReturnsAsync((Court) null);
    
        var action = () => service.GetCourtAsync(_courtGuid);
        await action.Should()
            .ThrowAsync<InvalidOperationException>()
            .WithMessage($"Court with id {_courtGuid} does not exist");
    }
    
    [Fact]
    public async Task GetCourtAsync_Valid_CourtDto()
    {
        _unitOfWorkMock
            .Setup(x => x.CourtRepository.GetByIdAsync(_courtGuid))
            .ReturnsAsync(_court);

        _mapperMock
            .Setup(x => x.Map<CourtDto>(_court))
            .Returns(_courtDto);

        CourtService service = new CourtService(_unitOfWorkMock.Object, _mapperMock.Object);
    
        var courtDtoResult = await service.GetCourtAsync(_courtGuid);
        courtDtoResult.Should().Be(_courtDto);
    }
    
    
    [Fact]
    public async Task AddCourtAsync_InvalidRate_ArgumentException()
    {
        CourtService service = new CourtService(_unitOfWorkMock.Object, _mapperMock.Object);
    
        var action = () => service.AddCourtAsync("1", 0);
        await action.Should().ThrowAsync<ArgumentException>();
    }
    
    
    [Fact]
    public async Task AddCourtAsync_InvalidCourtName_ArgumentException()
    {
        CourtService service = new CourtService(_unitOfWorkMock.Object, _mapperMock.Object);
    
        var action = () => service.AddCourtAsync("     ", 10);
        await action.Should().ThrowAsync<ArgumentException>();
    }


    [Fact]
    public async Task AddCourtAsync_Valid_CourtDto()
    {
        _unitOfWorkMock
            .Setup(x => x.CourtRepository.InsertAsync(_court))
            .ReturnsAsync(_courtGuid);
        _unitOfWorkMock
            .Setup(x => x.CourtRepository.GetByIdAsync(_courtGuid))
            .ReturnsAsync(_court);

        _mapperMock
            .Setup(x => x.Map<CourtDto>(_court))
            .Returns(_courtDto);
        _mapperMock
            .Setup(x => x.Map<Court>(It.Is<CourtDto>(court => 
                    court.HourlyRate == _courtDto.HourlyRate && court.CourtNumber == _courtDto.CourtNumber)))
            .Returns(_court);
            
        CourtService service = new CourtService(_unitOfWorkMock.Object, _mapperMock.Object);
    
        var courtDtoResult = await service.AddCourtAsync("1", 150);
        courtDtoResult.Should().Be(_courtDto);
    }


    [Fact]
    public async Task GetDailyScheduleAsync_InvalidId_EmptyList()
    {
        _unitOfWorkMock
            .Setup(x => x.CourtReservationRepository.GetAllAsync())
            .ReturnsAsync(_reservations);

        _mapperMock
            .Setup(x => x.Map<List<CourtReservationDto>>(
                It.Is<IEnumerable<CourtReservation>>(x => !x.Any())))
            .Returns(new List<CourtReservationDto>());
        
        
        CourtService service = new CourtService(_unitOfWorkMock.Object, _mapperMock.Object);
        var result = await service.GetDailyScheduleAsync(Guid.NewGuid(), DateTime.Today);

        result.Should().HaveCount(0);
    }
    
    [Fact]
    public async Task GetDailyScheduleAsync_ValidId_OneElem()
    {
        Guid specialGuid = Guid.NewGuid();
        CourtReservation specialReservation = new CourtReservation
        {
            Id = Guid.NewGuid(),
            CourtId = specialGuid,
            Court = null,
            From = DateTime.Now,
            To = DateTime.Now,
        };
        
        CourtReservationDto specialReservationDto = new CourtReservationDto
        {
            Id = Guid.NewGuid(),
            CourtId = specialGuid,
            From = DateTime.Now,
            To = DateTime.Now,
        };
        
        _unitOfWorkMock
            .Setup(x => x.CourtReservationRepository.GetAllAsync())
            .ReturnsAsync(_reservations);

        _mapperMock
            .Setup(x => x.Map<List<CourtReservationDto>>(It.Is<IEnumerable<CourtReservation>>
                    (x => x.Count() == 1 && x.First() == specialReservation)))
            .Returns(new List<CourtReservationDto> {specialReservationDto});
        
        
        CourtService service = new CourtService(_unitOfWorkMock.Object, _mapperMock.Object);
        // opravit to, lebo ked pustim vsetky testy, moze to spadnut na race condition
        _reservations.Add(specialReservation);
        var result = (await service.GetDailyScheduleAsync(specialGuid, DateTime.Today)).ToList();
        _reservations.Remove(specialReservation);
        
        result.Should().HaveCount(1);
        result.Should().Contain(specialReservationDto).Should();
    }
    
    [Fact]
    public async Task GetDailyScheduleAsync_ValidIdZeroInDay_EmptyList()
    {
        _unitOfWorkMock
            .Setup(x => x.CourtReservationRepository.GetAllAsync())
            .ReturnsAsync(_reservations);

        _mapperMock
            .Setup(x => x.Map<List<CourtReservationDto>>(It.Is<IEnumerable<CourtReservation>>
                (x => !x.Any())))
            .Returns(new List<CourtReservationDto>());
        
        
        CourtService service = new CourtService(_unitOfWorkMock.Object, _mapperMock.Object);
        var result = (await service.GetDailyScheduleAsync
            (_courtGuid, DateTime.Today)).ToList();

        result.Should().HaveCount(0);
    }
    
    [Fact]
    public async Task GetDailyScheduleAsync_ValidIdOneInDay_EmptyList()
    {
        var wantedCourtRes = _reservations[3];
        var wantedCourtResDto = new CourtReservationDto
        {
            Id = wantedCourtRes.Id,
            CourtId = wantedCourtRes.CourtId,
            From = wantedCourtRes.From,
            To = wantedCourtRes.To,
        };
        
        _unitOfWorkMock
            .Setup(x => x.CourtReservationRepository.GetAllAsync())
            .ReturnsAsync(_reservations);

        _mapperMock
            .Setup(x => x.Map<List<CourtReservationDto>>(It.Is<IEnumerable<CourtReservation>>
                (x => x.Count() == 1 && x.First() == wantedCourtRes)))
            .Returns(new List<CourtReservationDto> {wantedCourtResDto});
        
        
        CourtService service = new CourtService(_unitOfWorkMock.Object, _mapperMock.Object);
        var result = (await service.GetDailyScheduleAsync
            (_courtGuid, new DateTime(2020, 1, 2))).ToList();

        result.Should().HaveCount(1);
        result.Should().Contain(wantedCourtResDto);
    }
    
    [Fact]
    public async Task GetDailyScheduleAsync_ValidIdMoreInDay_ListOfLength3()
    {
        _unitOfWorkMock
            .Setup(x => x.CourtReservationRepository.GetAllAsync())
            .ReturnsAsync(_reservations);

        _mapperMock
            .Setup(x => x.Map<List<CourtReservationDto>>(It.Is<IEnumerable<CourtReservation>>
                (x =>
                    x.Count() == 3 && x.Contains(_reservations[0]) &&
                    x.Contains(_reservations[1]) && x.Contains(_reservations[2]))))
            
            .Returns(new List<CourtReservationDto> {new CourtReservationDto(),
                new CourtReservationDto(), new CourtReservationDto()});
        
        
        CourtService service = new CourtService(_unitOfWorkMock.Object, _mapperMock.Object);
        var result = (await service.GetDailyScheduleAsync
            (_courtGuid, new DateTime(2020, 1, 1))).ToList();

        result.Should().HaveCount(3);
    }
}