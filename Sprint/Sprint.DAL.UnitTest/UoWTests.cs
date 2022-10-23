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
    public async void UoW_CreateFindDeleteCourt_SameCourtCount()
    {
        using var dbContext = new SprintDbContext(_options);
        using var uow = new EFUnitOfWork(dbContext);
        var courtGuidToAdd = Guid.NewGuid();
        var courtToAdd = SeederFunctions.GetNewCourt(courtGuidToAdd);
        var guidToBeDeleted = _courtGuids[0];
        
        uow.CourtRepository.Insert(courtToAdd);
        var toBeDeleted = uow.CourtRepository.GetByID(guidToBeDeleted);
         uow.CourtRepository.Delete(toBeDeleted);
        await uow.Commit();
        
        var repository = new EFGenericRepository<Court>(dbContext);
        var all = (await repository.GetAll()).ToList();
        Assert.True(all.Count == 4);
        Assert.DoesNotContain(toBeDeleted, all);
        Assert.Contains(courtToAdd, all);
    }

    [Fact]
    public async void UoW_DeleteTable_EmptyTable()
    {
        using var dbContext = new SprintDbContext(_options);
        using var uow = new EFUnitOfWork(dbContext);
        
        var allCourts = await uow.CourtRepository.GetAll();
        foreach (var court in allCourts)
        {
            uow.CourtRepository.Delete(court);
        }
        await uow.Commit();
        
        var repository = new EFGenericRepository<Court>(dbContext);
        var all = (await repository.GetAll()).ToList();
        Assert.True(all.Count == 0);
    }
    
    [Fact]
    public async void UoW_NotCommitedChanges_AnyChanges()
    {
        using var dbContext = new SprintDbContext(_options);
        using var uow = new EFUnitOfWork(dbContext);
        
        var allCourts = await uow.CourtRepository.GetAll();
        foreach (var court in allCourts)
        {
            uow.CourtRepository.Delete(court);
        }

        var repository = new EFGenericRepository<Court>(dbContext);
        var all = (await repository.GetAll()).ToList();
        Assert.True(all.Count == 4);
    }
    
    [Fact]
    public async void UoW_UpdateAllCourts_ChangedCourts()
    {
        using var dbContext = new SprintDbContext(_options);
        using var uow = new EFUnitOfWork(dbContext);
        
        var allCourts = await uow.CourtRepository.GetAll();
        foreach (var court in allCourts)
        {
            court.HourlyRate = 0;
            uow.CourtRepository.Update(court);
        }
        await uow.Commit();

        var repository = new EFGenericRepository<Court>(dbContext);
        var all = (await repository.GetAll()).ToList();
        Assert.True(all.Count(court => court.HourlyRate == 0) == 4);
    }
    
    [Fact]
    public async void UoW_InsertUpdateCourtUser_InsertedChangedCourtUser()
    {   
        using var dbContext = new SprintDbContext(_options);
        using var uow = new EFUnitOfWork(dbContext);
        var courtGuidToAdd = Guid.NewGuid();
        var courtToAdd = SeederFunctions.GetNewCourt(courtGuidToAdd);
        var userGuidToAdd = Guid.NewGuid();
        var userToAdd = SeederFunctions.GetNewUser(userGuidToAdd);
        var courtGuidToUpdate = _courtGuids[0];
        var userGuidToUpdate = _userGuids[0];
        
        
        uow.UserRepository.Insert(userToAdd);
        var user = uow.UserRepository.GetByID(userGuidToUpdate);
        user.FirstName = "Mike";
        
        uow.CourtRepository.Insert(courtToAdd);
        var court = uow.CourtRepository.GetByID(courtGuidToUpdate);
        court.CourtNumber = "123";
        
        await uow.Commit();

        
        var repositoryUser = new EFGenericRepository<User>(dbContext);
        var repositoryCourt = new EFGenericRepository<Court>(dbContext);
        Assert.Equal(repositoryUser.GetByID(userGuidToAdd), userToAdd);
        Assert.True(repositoryUser.GetByID(userGuidToUpdate).FirstName == "Mike");
        Assert.Equal(repositoryCourt.GetByID(courtGuidToAdd), courtToAdd);
        Assert.True(repositoryCourt.GetByID(courtGuidToUpdate).CourtNumber == "123");
    }
}