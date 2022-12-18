using AutoMapper;
using FluentAssertions;
using Moq;
using Sprint.BL.Dto.User;
using Sprint.BL.Services;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.Query;
using Sprint.Infrastructure.UnitOfWork;

namespace Sprint.BL.UnitTest.ServiceTests;

public class UserServiceTests
{
    private Mock<IUnitOfWork> _unitOfWorkMock;
    private Mock<IMapper> _mapperMock;
    private Mock<IQueryObject<User>> _queryObjectMock;
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
        _queryObjectMock = new Mock<IQueryObject<User>>();

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
        UserService service = new UserService(_unitOfWorkMock.Object, _mapperMock.Object, _queryObjectMock.Object);

        var userDto = new UserDto
        {
            FirstName = "  ",
            LastName = "Biden",
            Email = "asd@asd.com",
            DateOfBirth = DateTime.Now,
        };
        
        var action = () => service.AddUserAsync(userDto);
        await action.Should().ThrowAsync<ArgumentException>();
    }
    
    [Fact]
    public async Task AddUserAsync_InvalidLastName_ArgumentException()
    {
        UserService service = new UserService(_unitOfWorkMock.Object, _mapperMock.Object, _queryObjectMock.Object);
    
        var userDto = new UserDto
        {
            FirstName = "Joe",
            LastName = "\n",
            Email = "asd@asd.com",
            DateOfBirth = DateTime.Now,
        };
        
        var action = () => service.AddUserAsync(userDto);
        await action.Should().ThrowAsync<ArgumentException>();
    }
    
    [Fact]
    public async Task AddUserAsync_InvalidMail_ArgumentException()
    {
        UserService service = new UserService(_unitOfWorkMock.Object, _mapperMock.Object, _queryObjectMock.Object);
    
        var userDto = new UserDto
        {
            FirstName = "Joe",
            LastName = "Biden",
            Email = "asd@asdcom",
            DateOfBirth = DateTime.Now,
        };
        
        var action = () => service.AddUserAsync(userDto);
        await action.Should().ThrowAsync<ArgumentException>();

        userDto.Email = "asdasd.com";
        action = () => service.AddUserAsync(userDto);
        await action.Should().ThrowAsync<ArgumentException>();

        userDto.Email = "asdasdcom";
        action = () => service.AddUserAsync(userDto);
        await action.Should().ThrowAsync<ArgumentException>();

        userDto.Email = "asd@";
        action = () => service.AddUserAsync(userDto);
        await action.Should().ThrowAsync<ArgumentException>();

        userDto.Email = "asd@asd.";
        action = () => service.AddUserAsync(userDto);
        await action.Should().ThrowAsync<ArgumentException>();

        userDto.Email = "@asd.com";
        action = () => service.AddUserAsync(userDto);
        await action.Should().ThrowAsync<ArgumentException>();

        userDto.Email = "asd@.com";
        action = () => service.AddUserAsync(userDto);
        await action.Should().ThrowAsync<ArgumentException>();
    }
    
    
    
    [Fact]
    public async Task AddUserAsync_Valid_NewUser()
    {
        var userDto = new UserDto
        {
            FirstName = _firstName,
            LastName = _lastName,
            Email = _email,
            DateOfBirth = _dateOfBirth,
        };

        _unitOfWorkMock
            .Setup(x => x.UserRepository.GetByIdAsync(_userGuid))
            .ReturnsAsync(_user);
        _unitOfWorkMock
            .Setup(x => x.UserRepository.InsertAsync(It.IsAny<User>()))
            .ReturnsAsync(_userGuid);

        _mapperMock
            .Setup(x => x.Map<UserDto>(_user))
            .Returns(_userDto);
        
        UserService service = new UserService(_unitOfWorkMock.Object, _mapperMock.Object, _queryObjectMock.Object);
    
        var returnUser = await service.AddUserAsync(userDto);
        returnUser.Should().Be(_userDto);
    }
    
    


    [Fact]
    public async Task GetUserAsync_InvalidId_InvalidOperationException()
    {
        _unitOfWorkMock
            .Setup(x => x.UserRepository.GetByIdAsync(_userGuid))
            .ReturnsAsync((User?)null);
        
        UserService service = new UserService(_unitOfWorkMock.Object, _mapperMock.Object, _queryObjectMock.Object);
    
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
        
        UserService service = new UserService(_unitOfWorkMock.Object, _mapperMock.Object, _queryObjectMock.Object);
    
        var returnUser = await service.GetUserAsync(_userGuid);
        returnUser.Should().Be(_userDto);
    }
}