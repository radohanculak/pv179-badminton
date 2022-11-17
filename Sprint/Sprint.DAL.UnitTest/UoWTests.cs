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
        
        await uow.CourtRepository.InsertAsync(courtToAdd);
        var toBeDeleted = await uow.CourtRepository.GetByIdAsync(guidToBeDeleted);
         uow.CourtRepository.Delete(toBeDeleted);
        await uow.CommitAsync();
        
        var repository = new EFGenericRepository<Court>(dbContext);
        var all = (await repository.GetAllAsync()).ToList();
        Assert.True(all.Count == 4);
        Assert.DoesNotContain(toBeDeleted, all);
        Assert.Contains(courtToAdd, all);
    }

    [Fact]
    public async void UoW_DeleteTable_EmptyTable()
    {
        using var dbContext = new SprintDbContext(_options);
        using var uow = new EFUnitOfWork(dbContext);
        
        var allCourts = await uow.CourtRepository.GetAllAsync();
        foreach (var court in allCourts)
        {
            uow.CourtRepository.Delete(court);
        }
        await uow.CommitAsync();
        
        var repository = new EFGenericRepository<Court>(dbContext);
        var all = (await repository.GetAllAsync()).ToList();
        Assert.True(all.Count == 0);
    }
    
    [Fact]
    public async void UoW_NotCommitedChanges_AnyChanges()
    {
        using var dbContext = new SprintDbContext(_options);
        using var uow = new EFUnitOfWork(dbContext);
        
        var allCourts = await uow.CourtRepository.GetAllAsync();
        foreach (var court in allCourts)
        {
            uow.CourtRepository.Delete(court);
        }

        var repository = new EFGenericRepository<Court>(dbContext);
        var all = (await repository.GetAllAsync()).ToList();
        Assert.True(all.Count == 4);
    }
    
    [Fact]
    public async void UoW_UpdateAllCourts_ChangedCourts()
    {
        using var dbContext = new SprintDbContext(_options);
        using var uow = new EFUnitOfWork(dbContext);
        
        var allCourts = await uow.CourtRepository.GetAllAsync();
        foreach (var court in allCourts)
        {
            court.HourlyRate = 0;
            uow.CourtRepository.Update(court);
        }
        await uow.CommitAsync();

        var repository = new EFGenericRepository<Court>(dbContext);
        var all = (await repository.GetAllAsync()).ToList();
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


        await uow.UserRepository.InsertAsync(userToAdd);
        var user = await uow.UserRepository.GetByIdAsync(userGuidToUpdate);
        user.FirstName = "Mike";

        await uow.CourtRepository.InsertAsync(courtToAdd);
        var court = await uow.CourtRepository.GetByIdAsync(courtGuidToUpdate);
        court.CourtNumber = "123";
        
        await uow.CommitAsync();

        
        var repositoryUser = new EFGenericRepository<User>(dbContext);
        var repositoryCourt = new EFGenericRepository<Court>(dbContext);
        Assert.Equal(await repositoryUser.GetByIdAsync(userGuidToAdd), userToAdd);
        Assert.True((await repositoryUser.GetByIdAsync(userGuidToUpdate)).FirstName == "Mike");
        Assert.Equal(await repositoryCourt.GetByIdAsync(courtGuidToAdd), courtToAdd);
        Assert.True((await repositoryCourt.GetByIdAsync(courtGuidToUpdate)).CourtNumber == "123");
    }
}