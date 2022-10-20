using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Sprint.DAL.EFCore.Data;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.EFCore.Repository;
using Sprint.Infrastructure.EFCore.UnitOfWork;

namespace Sprint.DAL.UnitTest;

public class UoWTests
{
    private readonly DbContextOptions<SprintDbContext> _options;
    private readonly List<Guid> _userGuids;
    private readonly List<Guid> _courtGuids;
    private readonly List<Guid> _courtResGuids;

    public UoWTests()
    {
        // This is needed to have fresh in-memory database with each new DbContext
        // Kudos to Nate Barbettini: https://stackoverflow.com/a/38897560 
        var serviceProvider = new ServiceCollection()
            .AddEntityFrameworkInMemoryDatabase()
            .BuildServiceProvider();

        _options = new DbContextOptionsBuilder<SprintDbContext>()
            .UseInMemoryDatabase($"test_db_{Guid.NewGuid()}")
            .UseInternalServiceProvider(serviceProvider)
            .Options;

        using var dbContext = new SprintDbContext(_options);
        _courtGuids = TestDbSeeder.SeedCourtsDb(dbContext);
        _userGuids = TestDbSeeder.SeedUserDb(dbContext);
        _courtResGuids = TestDbSeeder.SeedCourtResDb(dbContext, _courtGuids, _userGuids);
    }
    
    [Fact]
    public async void UoW_CreateDeleteUser_NewUserDeletedUser()
    {
        using var dbContext = new SprintDbContext(_options);
        var uow = new EFUnitOfWork(dbContext);
        var userGuidToAdd = Guid.NewGuid();
        var userToAdd = SeederFunctions.GetNewUser(userGuidToAdd);
        
        //uow.
    }
}