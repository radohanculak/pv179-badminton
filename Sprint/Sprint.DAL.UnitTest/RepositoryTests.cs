using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Sprint.DAL.EFCore.Data;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.EFCore.Repository;

namespace Sprint.DAL.UnitTest;

public class RepositoryTests
{
    private readonly DbContextOptions<SprintDbContext> _options;
    private readonly List<Guid> _guids;

    public RepositoryTests()
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
        _guids = TestDbSeeder.SeedCourtsDb(dbContext);
    }

    [Fact]
    public async void Repository_GetOne_FirstRow()
    {
        using var dbContext = new SprintDbContext(_options);
        var repository = new EFGenericRepository<Court>(dbContext);

        var result = repository.GetOne();
        Assert.True(result.HourlyRate == 1000);
        Assert.True(result.CourtNumber == "A");
        Assert.True(result.Id == _guids[0]);
    }
    
    
    [Fact]
    public async void Repository_GetById_OneExactRow()
    {
        using var dbContext = new SprintDbContext(_options);
        var repository = new EFGenericRepository<Court>(dbContext);

        var result = repository.GetByID(_guids[2]);
        Assert.True(result.HourlyRate == 800);
        Assert.True(result.CourtNumber == "C");
    }
    
    [Fact]
    public async void Repository_GetById_WrongId_Null()
    {
        using var dbContext = new SprintDbContext(_options);
        var repository = new EFGenericRepository<Court>(dbContext);

        var result = repository.GetByID(Guid.NewGuid());
        Assert.True(result == null);
    }
    
    
    [Fact]
    public async void Repository_GetAll_AllRows()
    {
        using var dbContext = new SprintDbContext(_options);
        var repository = new EFGenericRepository<Court>(dbContext);
        var testObj = repository.GetByID(_guids[2]);

        var result = (await repository.GetAllAsync()).ToList();
        
        Assert.True(result.Count == 4);
        var x = result.Select(court => court.CourtNumber);
        Assert.True(result.Select(court => court.CourtNumber)
            .SequenceEqual(new List<string> {"A", "B", "C", "D"}));
        Assert.True(result.Count(court => court.HourlyRate >= 800) == 3);
        Assert.Contains(testObj, result);
    }

    [Fact]
    public async void Repository_Delete_MinusOneRow()
    {
        using var dbContext = new SprintDbContext(_options);
        var repository = new EFGenericRepository<Court>(dbContext);
        var guidToBeDeleted = _guids[0];
        var objToBeDeleted = repository.GetByID(guidToBeDeleted);

        repository.Delete(objToBeDeleted);
        await repository.SaveAsync();

        var result = (await repository.GetAllAsync()).ToList();
        Assert.True(result.Count == 3);
        Assert.Null(repository.GetByID(guidToBeDeleted));
        Assert.DoesNotContain(objToBeDeleted, result);
    }

    private void ClearDb(SprintDbContext dbContext)
    {
        dbContext.Courts.RemoveRange(dbContext.Courts.ToList());
        dbContext.SaveChanges();
    }
    
    [Fact]
    public async void Repository_Delete_ClearingTable()
    {
        using var dbContext = new SprintDbContext(_options);
        var repository = new EFGenericRepository<Court>(dbContext);

        var courts = await repository.GetAllAsync();
        foreach (var court in courts)
        {
            repository.Delete(court);
        }
        await repository.SaveAsync();
        
        Assert.False((await repository.GetAllAsync()).Any());
    }
    
    [Fact]
    public async void Repository_Insert_PlusOneRow()
    {
        using var dbContext = new SprintDbContext(_options);
        var repository = new EFGenericRepository<Court>(dbContext);
        var guidToAdd = Guid.NewGuid();
        var objToAdd = SeederFunctions.GetNewCourt(guidToAdd);
        
        repository.Insert(objToAdd);
        await repository.SaveAsync();

        var testedObj = repository.GetByID(guidToAdd);
        Assert.True(testedObj != null);
        Assert.Equal(testedObj, objToAdd);
        Assert.True((await repository.GetAllAsync()).Count() == 5);
    }
    
    [Fact]
    public async void Repository_InsertIntoClearDb_OneRow()
    {
        using var dbContext = new SprintDbContext(_options);
        var repository = new EFGenericRepository<Court>(dbContext);
        var guidToAdd = Guid.NewGuid();
        var objToAdd = SeederFunctions.GetNewCourt(guidToAdd);
        ClearDb(dbContext);
        
        repository.Insert(objToAdd);
        await repository.SaveAsync();

        var testedObj = repository.GetByID(guidToAdd);
        Assert.True(testedObj != null);
        Assert.Equal(testedObj, objToAdd);
        Assert.True((await repository.GetAllAsync()).Count() == 1);
    }
    
    [Fact]
    public async void Repository_Update_UpdatedRate()
    {
        using var _dbContext = new SprintDbContext(_options);
        var repository = new EFGenericRepository<Court>(_dbContext);
        var guidToBeUpdated = _guids[3];
        var objToBeUpdated = repository.GetByID(guidToBeUpdated);

        objToBeUpdated.HourlyRate = 10000;
        repository.Update(objToBeUpdated);
        await repository.SaveAsync();
        
        var updatedObj = repository.GetByID(guidToBeUpdated);
        Assert.Equal(updatedObj, objToBeUpdated);
        Assert.True(updatedObj.HourlyRate == 10000);
        Assert.True(updatedObj.CourtNumber == "D");
    }
    
    [Fact]
    public async void Repository_Update_UpdatedWhole()
    {
        using var _dbContext = new SprintDbContext(_options);
        var repository = new EFGenericRepository<Court>(_dbContext);
        var guidToBeUpdated = _guids[0];
        var objToBeUpdated = repository.GetByID(guidToBeUpdated);

        objToBeUpdated.HourlyRate = 0;
        objToBeUpdated.CourtNumber = "E";
        repository.Update(objToBeUpdated);
        await repository.SaveAsync();
        
        var updatedObj = repository.GetByID(guidToBeUpdated);
        Assert.Equal(updatedObj, objToBeUpdated);
        Assert.True(updatedObj.HourlyRate == 0);
        Assert.True(updatedObj.CourtNumber == "E");
    }
    
    [Fact]
    public async void Repository_DeleteById_MinusOneRow()
    {
        using var dbContext = new SprintDbContext(_options);
        var repository = new EFGenericRepository<Court>(dbContext);
        var guidToBeDeleted = _guids[0];

        await repository.DeleteByIdAsync(guidToBeDeleted);
        await repository.SaveAsync();
        
        var objToBeDeleted = repository.GetByID(guidToBeDeleted);
        var result = (await repository.GetAllAsync()).ToList();
        Assert.True(result.Count == 3);
        Assert.Null(repository.GetByID(guidToBeDeleted));
        Assert.DoesNotContain(objToBeDeleted, result);
    }
    
    [Fact]
    public async void Repository_DeleteByIdWrongId_Nothing()
    {
        using var dbContext = new SprintDbContext(_options);
        var repository = new EFGenericRepository<Court>(dbContext);

        await repository.DeleteByIdAsync(Guid.NewGuid());
        await repository.SaveAsync();
        
        var result = (await repository.GetAllAsync()).ToList();
        Assert.True(result.Count == 4);
    }
}