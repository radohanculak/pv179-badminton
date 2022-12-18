using AutoMapper;
using FluentAssertions;
using Moq;
using Sprint.BL.Dto.TrainerReservation;
using Sprint.BL.Dto.TrainerReview;
using Sprint.BL.Services;
using Sprint.BL.Services.Interfaces;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.UnitOfWork;

namespace Sprint.BL.UnitTest.ServiceTests;

public class TrainerReviewServiceTests
{
    private Mock<IUnitOfWork> _unitOfWorkMock;
    private Mock<IMapper> _mapperMock;
    private Mock<ITrainerService> _trainerServiceMock;
    private Mock<IUserService> _userServiceMock;
    private Mock<ITrainerReservationService> _trainerReservationMock;

    private List<TrainerReview> _reviews;
    private List<TrainerReviewDto> _reviewsDto;
    private TrainerReservationDto _trainerReservationDto;
    private TrainerReview _trainerReview;
    private TrainerReviewDto _trainerReviewDto;
    private Guid _trainerGuid = Guid.NewGuid();
    private Guid _trainerReservationGuid = Guid.NewGuid();
    private Guid _reviewGuid = Guid.NewGuid();


    public TrainerReviewServiceTests()
    {
        _unitOfWorkMock = new Mock<IUnitOfWork>();
        _mapperMock = new Mock<IMapper>();
        _trainerServiceMock = new Mock<ITrainerService>();
        _userServiceMock = new Mock<IUserService>();
        _trainerReservationMock = new Mock<ITrainerReservationService>();

        _trainerReservationDto = new TrainerReservationDto
        {
            Id = _trainerReservationGuid
        };

        _trainerReview = new TrainerReview
        {
            Id = _reviewGuid,
            Rating = 5,
            Text = "abcd",
            Hide = false,
            ReservationId = _trainerReservationGuid,
            Reservation = new TrainerReservation
            {
                Id = _trainerReservationGuid,
                TrainerId = Guid.NewGuid(),
            }
        };

        _trainerReviewDto = new TrainerReviewDto
        {
            Id = _trainerReview.Id,
            Rating = _trainerReview.Rating,
            Text = _trainerReview.Text,
            Hide = _trainerReview.Hide,
            ReservationId = _trainerReview.ReservationId,
        };
        
        var review1 = new TrainerReview
        {
            Id = Guid.NewGuid(),
            Rating = 3,
            Text = "abcd",
            Hide = false,
            Reservation = new TrainerReservation
            {
                Id = Guid.NewGuid(),
                TrainerId = _trainerGuid
            }
        };
        review1.ReservationId = review1.Reservation.Id;

        var review2 = new TrainerReview
        {
            Id = Guid.NewGuid(),
            Rating = 10,
            Text = "abcd",
            Hide = false,
            Reservation = new TrainerReservation
            {
                Id = Guid.NewGuid(),
                TrainerId = _trainerGuid
            }
        };
        review2.ReservationId = review2.Reservation.Id;

        var review3 = new TrainerReview
        {
            Id = Guid.NewGuid(),
            Rating = 0,
            Text = "abcd",
            Hide = false,
            Reservation = new TrainerReservation
            {
                Id = Guid.NewGuid(),
                TrainerId = _trainerGuid
            }
        };
        review3.ReservationId = review3.Reservation.Id;
        
        var review4 = new TrainerReview
        {
            Id = Guid.NewGuid(),
            Rating = 5,
            Text = "abcd",
            Hide = false,
            Reservation = new TrainerReservation
            {
                Id = Guid.NewGuid(),
                TrainerId = Guid.NewGuid(),
            }
        };
        review4.ReservationId = review4.Reservation.Id;

        _reviews = new List<TrainerReview>
        {
            _trainerReview, review1, review2, review3, review4
        };

        var reviewDto1 = new TrainerReviewDto
        {
            Id = review1.Id,
            Rating = review1.Rating,
            Text = review1.Text,
            Hide = false,
            ReservationId = review1.ReservationId,
        };
        
        var reviewDto2 = new TrainerReviewDto
        {
            Id = review2.Id,
            Rating = review2.Rating,
            Text = review2.Text,
            Hide = false,
            ReservationId = review2.ReservationId,
        };
        
        var reviewDto3 = new TrainerReviewDto
        {
            Id = review3.Id,
            Rating = review3.Rating,
            Text = review3.Text,
            Hide = false,
            ReservationId = review3.ReservationId,
        };
        
        var reviewDto4 = new TrainerReviewDto
        {
            Id = review4.Id,
            Rating = review4.Rating,
            Text = review4.Text,
            Hide = false,
            ReservationId = review4.ReservationId,
        };

        _reviewsDto = new List<TrainerReviewDto>
        {
            _trainerReviewDto, reviewDto1, reviewDto2, reviewDto3, reviewDto4
        };
    }


    [Fact]
    public async Task GetReviewAsync_InvalidId_InvalidOperationException()
    {
        _unitOfWorkMock
            .Setup(x => x.TrainerReviewRepository.GetByIdAsync(_reviewGuid))
            .ReturnsAsync((TrainerReview)null);

        var service = new TrainerReviewService(_unitOfWorkMock.Object, _mapperMock.Object);
        
        var action = () => service.GetReviewAsync(_reviewGuid);
        await action.Should().ThrowAsync<InvalidOperationException>()
            .WithMessage($"Trainer review with id {_reviewGuid} does not exist");
    }

    
    [Fact]
    public async Task GetReviewAsync_Valid_ReviewDto()
    {
        _unitOfWorkMock
            .Setup(x => x.TrainerReviewRepository.GetByIdAsync(_reviewGuid))
            .ReturnsAsync(_trainerReview);

        _mapperMock
            .Setup(x => x.Map<TrainerReviewDto>(_trainerReview))
            .Returns(_trainerReviewDto);

        var service = new TrainerReviewService(_unitOfWorkMock.Object, _mapperMock.Object);
        
        var result = await service.GetReviewAsync(_reviewGuid);
        result.Should().Be(_trainerReviewDto);
    }


    [Fact]
    public async Task AddReviewAsync_InvalidText_ArgumentException()
    {
        var service = new TrainerReviewService(_unitOfWorkMock.Object, _mapperMock.Object);
        
        var action = () => service.AddReviewAsync(_trainerReservationDto, 1, "\t\t");
        await action.Should().ThrowAsync<ArgumentException>();
    }
    
    
    [Fact]
    public async Task AddReviewAsync_InvalidRatingUnder_ArgumentException()
    {
        var service = new TrainerReviewService(_unitOfWorkMock.Object, _mapperMock.Object);
        
        var action = () => service.AddReviewAsync(_trainerReservationDto, -1, "text");
        await action.Should().ThrowAsync<ArgumentException>();
    }
    
    [Fact]
    public async Task AddReviewAsync_Valid_ArgumentException()
    {
        _unitOfWorkMock
            .Setup(x => x.TrainerReviewRepository.InsertAsync(_trainerReview))
            .ReturnsAsync(_reviewGuid);
        
        _unitOfWorkMock
            .Setup(x => x.TrainerReviewRepository.GetByIdAsync(_reviewGuid))
            .ReturnsAsync(_trainerReview);

        _mapperMock
            .Setup(x => x.Map<TrainerReview>(
                It.Is<TrainerReviewDto>(review => review.ReservationId == _trainerReservationDto.Id)))
            .Returns(_trainerReview);
        
        _mapperMock
            .Setup(x => x.Map<TrainerReviewDto>(_trainerReview))
            .Returns(_trainerReviewDto);

        _trainerReservationMock
            .Setup(x => x.GetReservationAsync(_trainerReservationGuid))
            .ReturnsAsync(_trainerReservationDto);

        var service = new TrainerReviewService(_unitOfWorkMock.Object, _mapperMock.Object);
        
        var action = () => service.AddReviewAsync(_trainerReservationDto, -1, "text");
        await action.Should().ThrowAsync<ArgumentException>();
    }
    
    [Fact]
    public async Task GetReviewForReservationAsync_Valid_ReviewDto()
    {
        _unitOfWorkMock
            .Setup(x => x.TrainerReviewRepository.GetAllAsync())
            .ReturnsAsync(_reviews);
        
        _trainerReservationMock
            .Setup(x => x.GetReservationAsync(_trainerReservationGuid))
            .ReturnsAsync(_trainerReservationDto);

        _mapperMock
            .Setup(x => x.Map<TrainerReviewDto>(_trainerReview))
            .Returns(_trainerReviewDto);
        
        var service = new TrainerReviewService(_unitOfWorkMock.Object, _mapperMock.Object);
        
        var result = await service.GetReviewForReservationAsync(_trainerReservationGuid);
        result.Should().Be(_trainerReviewDto);
    }

    [Fact]
    public async Task GetTrainerReviewsAsync_InvalidTrainerId_InvalidOperationException()
    {
        _unitOfWorkMock
            .Setup(x => x.TrainerReviewRepository.GetAllAsync())
            .ReturnsAsync(_reviews);
        
        _mapperMock
            .Setup(x => x.Map<IEnumerable<TrainerReviewDto>>(new List<TrainerReview>()))
            .Returns(new List<TrainerReviewDto>());

        var service = new TrainerReviewService(_unitOfWorkMock.Object, _mapperMock.Object);
        
        var result = await service.GetTrainerReviewsAsync(new Guid());
        result.Should().BeEmpty();
    }
    
    
    [Fact]
    public async Task GetTrainerReviewsAsync_Valid_ReviewDtoList()
    {
        _unitOfWorkMock
            .Setup(x => x.TrainerReviewRepository.GetAllAsync())
            .ReturnsAsync(_reviews);

        _mapperMock
            .Setup(x => x.Map<List<TrainerReviewDto>>(It.Is<List<TrainerReview>>(x => x.Count == 3)))
            .Returns(new List<TrainerReviewDto> {_reviewsDto[1], _reviewsDto[2], _reviewsDto[3]});
        
        var service = new TrainerReviewService(_unitOfWorkMock.Object, _mapperMock.Object);
        
        var result = await service.GetTrainerReviewsAsync(_trainerGuid);
        result.Should().HaveCount(3);
        result.Should().Contain(_reviewsDto[1]);
        result.Should().Contain(_reviewsDto[3]);
        result.Should().NotContain(_reviewsDto[0]);
    }
    
    [Fact]
    public async Task GetTrainerReviewsAsync_ValidAnyReview_EmptyList()
    {
        _unitOfWorkMock
            .Setup(x => x.TrainerReviewRepository.GetAllAsync())
            .ReturnsAsync(_reviews);

        _mapperMock
            .Setup(x => x.Map<List<TrainerReviewDto>>(It.Is<List<TrainerReview>>(x => x.Count == 0)))
            .Returns(new List<TrainerReviewDto> ());
        
        var service = new TrainerReviewService(_unitOfWorkMock.Object, _mapperMock.Object);
        
        // we avoid id control by mocking into null (real function will throw exception)
        var result = await service.GetTrainerReviewsAsync(Guid.NewGuid());
        result.Should().HaveCount(0);
    }
    
    [Fact]
    public async Task GetRatingAsync_EmptyList_DefaultValue()
    {
        _unitOfWorkMock
            .Setup(x => x.TrainerReviewRepository.GetAllAsync())
            .ReturnsAsync(_reviews);

        _mapperMock
            .Setup(x => x.Map<List<TrainerReviewDto>>(It.Is<List<TrainerReview>>(x => x.Count == 0)))
            .Returns(new List<TrainerReviewDto>());
        
        var service = new TrainerReviewService(_unitOfWorkMock.Object, _mapperMock.Object);
        
        var result = await service.GetRatingAsync(Guid.NewGuid());
        result.Should().Be(null);
    }
    
    [Fact]
    public async Task GetRatingAsync_Valid_Rating()
    {
        _unitOfWorkMock
            .Setup(x => x.TrainerReviewRepository.GetAllAsync())
            .ReturnsAsync(_reviews);

        _mapperMock
            .Setup(x => x.Map<List<TrainerReviewDto>>(It.Is<List<TrainerReview>>(x => x.Count == 3)))
            .Returns(new List<TrainerReviewDto> {_reviewsDto[1], _reviewsDto[2], _reviewsDto[3]});
        
        var service = new TrainerReviewService(_unitOfWorkMock.Object, _mapperMock.Object);
        
        var result = await service.GetRatingAsync(_trainerGuid);
        result.Should().Be(13 / 3);
    }
}