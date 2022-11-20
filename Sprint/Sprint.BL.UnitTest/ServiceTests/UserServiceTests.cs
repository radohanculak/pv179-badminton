using AutoMapper;
using FluentAssertions;
using Moq;
using Sprint.BL.Dto.User;
using Sprint.BL.Services;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.UnitOfWork;

namespace Sprint.BL.UnitTest.ServiceTests;

public class UserServiceTests
{
    private Mock<IUnitOfWork> _unitOfWorkMock;
    private Mock<IMapper> _mapperMock;
    private User _user;
    private UserDto _userDto;
    
    private string _firstName = "Joe";
    private string _lastName = "Biden";
    private string _email = "asd@asd.com";
    private DateTime _dateOfBirth = new DateTime(2000, 1, 1);
    private Guid _userGuid = Guid.NewGuid();
    
    public UserServiceTests()
    {
        _unitOfWorkMock = new Mock<IUnitOfWork>();
        _mapperMock = new Mock<IMapper>();

        _user = new User
        {
            Id = _userGuid,
            FirstName = _firstName,
            LastName = _lastName,
            Email = _email,
            DateOfBirth = _dateOfBirth,
            Role = Common.Enums.UserRole.User,
        };

        _userDto = new UserDto
        {
            Id = _userGuid,
            FirstName = _firstName,
            LastName = _lastName,
            Email = _email
        };
    }
    
    [Fact]
    public async Task AddUserAsync_InvalidFirstName_ArgumentException()
    {
        UserService service = new UserService(_unitOfWorkMock.Object, _mapperMock.Object);
    
        var action = () => service.AddUserAsync("  ", "Biden", "asd@asd.com", DateTime.Now);
        await action.Should().ThrowAsync<ArgumentException>();
    }
    
    [Fact]
    public async Task AddUserAsync_InvalidLastName_ArgumentException()
    {
        UserService service = new UserService(_unitOfWorkMock.Object, _mapperMock.Object);
    
        var action = () => service.AddUserAsync("Joe", "\n", "asd@asd.com", DateTime.Now);
        await action.Should().ThrowAsync<ArgumentException>();
    }
    
    [Fact]
    public async Task AddUserAsync_InvalidMail_ArgumentException()
    {
        UserService service = new UserService(_unitOfWorkMock.Object, _mapperMock.Object);
    
        var action = () => service.AddUserAsync("Joe", "Biden", "asd@asdcom", DateTime.Now);
        await action.Should().ThrowAsync<ArgumentException>();
        
        action = () => service.AddUserAsync("Joe", "Biden", "asdasd.com", DateTime.Now);
        await action.Should().ThrowAsync<ArgumentException>();
        
        action = () => service.AddUserAsync("Joe", "Biden", "asdasdcom", DateTime.Now);
        await action.Should().ThrowAsync<ArgumentException>();
        
        action = () => service.AddUserAsync("Joe", "Biden", "asd@", DateTime.Now);
        await action.Should().ThrowAsync<ArgumentException>();
        
        action = () => service.AddUserAsync("Joe", "Biden", "asd@asd.", DateTime.Now);
        await action.Should().ThrowAsync<ArgumentException>();
        
        action = () => service.AddUserAsync("Joe", "Biden", "@asd.com", DateTime.Now);
        await action.Should().ThrowAsync<ArgumentException>();
        
        action = () => service.AddUserAsync("Joe", "Biden", "asd@.com", DateTime.Now);
        await action.Should().ThrowAsync<ArgumentException>();
    }
    
    [Fact]
    public async Task AddUserAsync_Valid_NewUser()
    {
        _unitOfWorkMock
            .Setup(x => x.UserRepository.GetByIdAsync(_userGuid))
            .ReturnsAsync(_user);
        _unitOfWorkMock
            .Setup(x => x.UserRepository.InsertAsync(It.IsAny<User>()))
            .ReturnsAsync(_userGuid);

        _mapperMock
            .Setup(x => x.Map<UserDto>(_user))
            .Returns(_userDto);
        
        UserService service = new UserService(_unitOfWorkMock.Object, _mapperMock.Object);
    
        var returnUser = await service.AddUserAsync(_firstName, _lastName, _email, _dateOfBirth);
        returnUser.Should().Be(_userDto);
    }


    [Fact]
    public async Task GetUserAsync_InvalidId_InvalidOperationException()
    {
        _unitOfWorkMock
            .Setup(x => x.UserRepository.GetByIdAsync(_userGuid))
            .ReturnsAsync((User?)null);
        
        UserService service = new UserService(_unitOfWorkMock.Object, _mapperMock.Object);
    
        var action = () => service.GetUserAsync(_userGuid);
        await action.Should()
            .ThrowAsync<InvalidOperationException>()
            .WithMessage($"User with id {_userGuid} does not exist");
    }
    
    [Fact]
    public async Task GetUserAsync_Valid_UserDto()
    {
        _unitOfWorkMock
            .Setup(x => x.UserRepository.GetByIdAsync(_userGuid))
            .ReturnsAsync(_user);

        _mapperMock
            .Setup(x => x.Map<UserDto>(_user))
            .Returns(_userDto);
        
        UserService service = new UserService(_unitOfWorkMock.Object, _mapperMock.Object);
    
        var returnUser = await service.GetUserAsync(_userGuid);
        returnUser.Should().Be(_userDto);
    }
}