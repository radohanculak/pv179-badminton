using AutoMapper;
using FluentAssertions;
using Moq;
using Sprint.BL.Dto.Trainer;
using Sprint.BL.Dto.User;
using Sprint.BL.Services;
using Sprint.BL.Services.Interfaces;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.Query;
using Sprint.Infrastructure.UnitOfWork;

namespace Sprint.BL.UnitTest.ServiceTests;

public class TrainerServiceTests
{
    private Mock<IUnitOfWork> _unitOfWorkMock;
    private Mock<IMapper> _mapperMock;
    private Mock<IUserService> _userServiceMock;
    private Mock<ITrainerQueryObject> _queryObjectMock;
    private User _user;
    private UserDto _userDto;
    private Trainer _trainer;
    private TrainerDto _trainerDto;

    private int _hourlyRate = 150;
    private string _descrtiption = "smh";
    private Guid _userGuid = Guid.NewGuid();
    private Guid _trainerGuid = Guid.NewGuid();

    public TrainerServiceTests()
    {
        _unitOfWorkMock = new Mock<IUnitOfWork>();
        _mapperMock = new Mock<IMapper>();
        _userServiceMock = new Mock<IUserService>();
        _queryObjectMock = new Mock<ITrainerQueryObject>();
        
        _user = new User
        {
            Id = _userGuid,
            Role = Common.Enums.UserRole.User,
        };
        
        _trainer = new Trainer
        {
            UserId = _userGuid,
            Description = _descrtiption,
            HourlyRate = _hourlyRate,
            Photos = new List<TrainerPhoto>(),
            Reservations = new List<TrainerReservation>(),
        };

        _user.Trainer = _trainer;
        _trainer.User = _user;

        _trainerDto = new TrainerDto
        {
            Id = _trainerGuid,
            HourlyRate = _hourlyRate,
            Description = _descrtiption,
            Photos = null,
        };
        
        _userDto = new UserDto
        {
            Id = _userGuid,
            Role = Common.Enums.UserRole.Trainer,
        };

        _trainerDto.User = _userDto;
        _userDto.Trainer = _trainerDto;
    }

    [Fact]
    public async Task AddTrainerAsync_InvalidRate_ArgumentException()
    {
        TrainerService service = new TrainerService(_unitOfWorkMock.Object, _mapperMock.Object, _queryObjectMock.Object);
    
        var action = () => service.AddTrainerAsync(Guid.NewGuid(), _descrtiption, 0);
        await action.Should().ThrowAsync<ArgumentException>();
    }

    [Fact]
    public async Task AddTrainerAsync_InvalidId_InvalidOperationException()
    {
        _unitOfWorkMock
            .Setup(x => x.UserRepository.GetByIdAsync(_userGuid))
            .ReturnsAsync((User)null);
        
        TrainerService service = new TrainerService(_unitOfWorkMock.Object, _mapperMock.Object, _queryObjectMock.Object);
    
        var action = () => service.AddTrainerAsync(_userGuid, _descrtiption, _hourlyRate);
        await action.Should()
            .ThrowAsync<InvalidOperationException>()
            .WithMessage($"User with id {_userGuid} does not exist");
    }
    
    [Fact]
    public async Task AddTrainerAsync_AlreadyTrainer_InvalidOperationException()
    {
        var userTrainer = new User
        {
            Id = _userGuid,
            Role = Common.Enums.UserRole.Trainer,
        };
        
        _unitOfWorkMock
            .Setup(x => x.UserRepository.GetByIdAsync(_userGuid))
            .ReturnsAsync(userTrainer);
        
        TrainerService service = new TrainerService(_unitOfWorkMock.Object, _mapperMock.Object, _queryObjectMock.Object);
    
        var action = () => service.AddTrainerAsync(_userGuid, _descrtiption, _hourlyRate);
        await action.Should()
            .ThrowAsync<InvalidOperationException>()
            .WithMessage($"User with id {_userGuid} is already a trainer");
    }
    
    [Fact]
    public async Task AddTrainerAsync_Valid_NewTrainer()
    {
        _unitOfWorkMock
            .Setup(x => x.TrainerRepository.InsertAsync(It.IsAny<Trainer>()))
            .ReturnsAsync(_trainerGuid);
        
        _trainer.Id = _trainerGuid;
        _unitOfWorkMock
            .Setup(x => x.TrainerRepository.GetByIdAsync(_trainerGuid))
            .ReturnsAsync(_trainer);
        
        _unitOfWorkMock
            .Setup(x => x.UserRepository.GetByIdAsync(_userGuid))
            .ReturnsAsync(_user);
        _unitOfWorkMock
            .Setup(x => x.UserRepository.Update(_user));
        _unitOfWorkMock
            .Setup(x => x.UserRepository.Update(It.Is<User>(tested => tested != _user)))
            .Throws(new ArgumentException());

        _mapperMock
            .Setup(x => x.Map<TrainerDto>(_trainer))
            .Returns(_trainerDto);
        
        TrainerService service = new TrainerService(_unitOfWorkMock.Object, _mapperMock.Object, _queryObjectMock.Object);
    
        var returnTrainer = await service.AddTrainerAsync(_userGuid, _descrtiption, _hourlyRate);
        returnTrainer.Should().Be(_trainerDto);
    }
    
    [Fact]
    public async Task GetTrainerAsync_InvalidId_InvalidOperationException()
    {
        _unitOfWorkMock
            .Setup(x => x.TrainerRepository.GetByIdAsync(_trainerGuid))
            .ReturnsAsync((Trainer)null);
        
        TrainerService service = new TrainerService(_unitOfWorkMock.Object, _mapperMock.Object, _queryObjectMock.Object);
    
        var action = () => service.GetTrainerAsync(_trainerGuid);
        await action.Should()
            .ThrowAsync<InvalidOperationException>()
            .WithMessage($"Trainer with id {_trainerGuid} does not exist");
    }
    
    
    [Fact]
    public async Task GetTrainerAsync_Valid_TrainerDto()
    {
        _unitOfWorkMock
            .Setup(x => x.TrainerRepository.GetByIdAsync(_trainerGuid))
            .ReturnsAsync(_trainer);

        _mapperMock
            .Setup(x => x.Map<TrainerDto>(_trainer))
            .Returns(_trainerDto);

        TrainerService service = new TrainerService(_unitOfWorkMock.Object, _mapperMock.Object, _queryObjectMock.Object);
    
        var returnDto = await service.GetTrainerAsync(_trainerGuid);
        returnDto.Should().Be(_trainerDto);
    }

    
    [Fact]
    public async Task GetTrainerByUserAsync_NotTrainer_InvalidOperationException()
    {
        UserDto userNotTrainer = new UserDto
        {
            Id = _userGuid,
            Role = Common.Enums.UserRole.User,
            Trainer = null,
        };
        
        _userServiceMock
            .Setup(x => x.GetUserAsync(_userGuid))
            .ReturnsAsync(userNotTrainer);
        
        TrainerService service = new TrainerService(_unitOfWorkMock.Object, _mapperMock.Object, _queryObjectMock.Object);
    
        var action = () => service.GetTrainerByUser(userNotTrainer);
        action.Should()
            .Throw<InvalidOperationException>()
            .WithMessage($"User with id {userNotTrainer.Id} is not trainer");
    }
    
    [Fact]
    public async Task GetTrainerByUserAsync_Valid_TrainerDto()
    {
        _userServiceMock
            .Setup(x => x.GetUserAsync(_userGuid))
            .ReturnsAsync(_userDto);

        TrainerService service = new TrainerService(_unitOfWorkMock.Object, _mapperMock.Object, _queryObjectMock.Object);
    
        var returnDto = service.GetTrainerByUser(_userDto);
        returnDto.Should().Be(_trainerDto);
    }
}