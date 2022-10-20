using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Sprint.DAL.EFCore.Data;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.EFCore.Query;

namespace Sprint.DAL.UnitTest;

public class QueryTests
{
    private readonly DbContextOptions<SprintDbContext> _options;
    private readonly List<Guid> _userGuids;
    private readonly List<Guid> _courtGuids;
    private readonly List<Guid> _courtResGuids;

    public QueryTests()
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
    public async Task Query_Filter_Filtered()
    {
        using var dbContext = new SprintDbContext(_options);
        var query = new EFCoreQueryObject<Court>(dbContext);

        query.Filter(court => court.HourlyRate >= 800);

        var result = await query.ExecuteAsync();
        Assert.True(result.Count() == 3);
    }
    
    [Fact]
    public async Task Query_TwoFilters_Filtered()
    {
        using var dbContext = new SprintDbContext(_options);
        var query = new EFCoreQueryObject<Court>(dbContext);

        query
            .Filter(court => court.HourlyRate >= 800)
            .Filter(court => court.Reservations.Count == 0);

        var result = await query.ExecuteAsync();
        Assert.True(result.Count() == 0);
    }

    [Fact]
    public async Task Query_Page_Paged()
    {
        using var dbContext = new SprintDbContext(_options);
        var query = new EFCoreQueryObject<Court>(dbContext);
        TestDbSeeder.ReseedCourtsDb(dbContext);

        query.Page(3, 10);

        var result = (await query.ExecuteAsync()).ToList();
        Assert.True(result.Count == 10);
        Assert.True(result[0].CourtNumber == "20");
        Assert.True(result[9].CourtNumber == "29");
        Assert.True(result[5].CourtNumber == "25");
    }
    
    [Fact]
    public async Task Query_PageFilter_FilteredPaged()
    {
        using var dbContext = new SprintDbContext(_options);
        var query = new EFCoreQueryObject<Court>(dbContext);
        TestDbSeeder.ReseedCourtsDb(dbContext);

        query
            .Page(3, 5)
            .Filter(court => court.HourlyRate >= 1800);

        var result = (await query.ExecuteAsync()).ToList();
        Assert.True(result.Count == 1);
        Assert.True(result[0].CourtNumber == "14");
    }
    
    [Fact]
    public async Task Query_FilterPage_FilteredPaged()
    {
        using var dbContext = new SprintDbContext(_options);
        var query = new EFCoreQueryObject<Court>(dbContext);
        TestDbSeeder.ReseedCourtsDb(dbContext);

        query
            .Page(3, 5)
            .Filter(court => court.HourlyRate >= 1800);

        var result = (await query.ExecuteAsync()).ToList();
        Assert.True(result.Count == 1);
        Assert.True(result[0].CourtNumber == "14");
    }
    
    [Fact]
    public async Task Query_TripleFilter_Filtered()
    {
        using var dbContext = new SprintDbContext(_options);
        var query = new EFCoreQueryObject<Court>(dbContext);
        TestDbSeeder.ReseedCourtsDb(dbContext);

        query
            .Filter(court => court.CourtNumber.StartsWith('1'))
            .Filter(court => court.HourlyRate >= 1600)
            .Filter(court => court.Reservations.Count == 0);

        var result = (await query.ExecuteAsync()).ToList();
        Assert.True(result.Count == 4);
        Assert.True(result[0].CourtNumber == "13");
        Assert.True(result[3].CourtNumber == "19");
    }
    
    [Fact]
    public async Task Query_InvalidFilter_Nothing()
    {
        using var dbContext = new SprintDbContext(_options);
        var query = new EFCoreQueryObject<Court>(dbContext);
        TestDbSeeder.ReseedCourtsDb(dbContext);

        query.Filter(court => court.HourlyRate >= 2000);

        var result = (await query.ExecuteAsync()).ToList();
        Assert.True(result.Count == 0);
    }
    
    [Fact]
    public async Task Query_OrderByDescending_Ordered()
    {
        using var dbContext = new SprintDbContext(_options);
        var query = new EFCoreQueryObject<Court>(dbContext);
        TestDbSeeder.ReseedCourtsDb(dbContext);

        query.OrderBy(court => court.CourtNumber, false);

        var result = (await query.ExecuteAsync()).ToList();
        Assert.True(result.Count == 30);
        Assert.True(result[0].CourtNumber == "9");
        Assert.True(result[0].HourlyRate == 1800);
        Assert.True(result[29].CourtNumber == "0");
        Assert.True(result[29].HourlyRate == 1000);
    }
    
    [Fact]
    public async Task Query_OrderByAscending_Ordered()
    {
        using var dbContext = new SprintDbContext(_options);
        var query = new EFCoreQueryObject<Court>(dbContext);

        query.OrderBy(court => court.HourlyRate);

        var result = (await query.ExecuteAsync()).ToList();
        Assert.True(result.Count == 4);
        Assert.True(result[0].CourtNumber == "D");
        Assert.True(result[0].HourlyRate == 500);
        Assert.True(result[3].CourtNumber == "A");
        Assert.True(result[3].HourlyRate == 1000);
    }
    
    [Fact]
    public async Task Query_PageOutOfRange_Nothing()
    {
        using var dbContext = new SprintDbContext(_options);
        var query = new EFCoreQueryObject<Court>(dbContext);

        query.Page(5, 10);

        var result = (await query.ExecuteAsync()).ToList();
        Assert.True(result.Count == 0);
    }
    
    [Fact]
    public async Task Query_PageSizeZero_Nothing()
    {
        using var dbContext = new SprintDbContext(_options);
        var query = new EFCoreQueryObject<Court>(dbContext);

        query.Page(25, 0);

        var result = (await query.ExecuteAsync()).ToList();
        Assert.True(result.Count == 0);
    }
    
    [Fact]
    public async Task Query_FilterPageOrderBy_FilteredPagedOrdered()
    {
        using var dbContext = new SprintDbContext(_options);
        var query = new EFCoreQueryObject<Court>(dbContext);
        dbContext.Courts.Add(SeederFunctions.GetNewCourt(Guid.NewGuid()));
        await dbContext.SaveChangesAsync();

        query
            .Filter(court => court.HourlyRate <= 800)
            .Page(1, 2)
            .OrderBy(court => court.Reservations.Count);

        var result = (await query.ExecuteAsync()).ToList();
        Assert.True(result.Count == 2);
        Assert.True(result[0].CourtNumber == "C");
        Assert.True(result[0].HourlyRate == 800);
        Assert.True(result[1].CourtNumber == "B");
        Assert.True(result[1].HourlyRate == 800);
    }
    
    [Fact]
    public async Task Query_DoublePage_Paged()
    {
        using var dbContext = new SprintDbContext(_options);
        var query = new EFCoreQueryObject<Court>(dbContext);
        TestDbSeeder.ReseedCourtsDb(dbContext);

        query
            .Page(2, 10)
            .Page(2, 3);

        var result = (await query.ExecuteAsync()).ToList();
        Assert.True(result.Count == 3);
        Assert.True(result[0].CourtNumber == "13");
        Assert.True(result[0].HourlyRate == 1600);
        Assert.True(result[2].CourtNumber == "15");
        Assert.True(result[2].HourlyRate == 1000);
    }
    
    [Fact]
    public async Task Query_User_Filter_Filtered()
    {
        using var dbContext = new SprintDbContext(_options);
        var query = new EFCoreQueryObject<User>(dbContext);

        query.Filter(user => user.DateOfBirth < new DateTime(2000, 1, 1));

        var result = (await query.ExecuteAsync()).ToList();
        Assert.True(result.Count == 3);
        var firstNames = result.Select(user => user.FirstName);
        Assert.Contains("Monica", firstNames);
        Assert.Contains("Peter", firstNames);
        Assert.Contains("Roman", firstNames);
    }
    
    [Fact]
    public async Task Query_User_FilterOrderBy_FilteredOrdered()
    {
        using var dbContext = new SprintDbContext(_options);
        var query = new EFCoreQueryObject<User>(dbContext);

        query
            .Filter(user => user.CourtReservations.Count == 0)
            .OrderBy(user => user.LastName);

        var result = (await query.ExecuteAsync()).ToList();
        Assert.True(result.Count == 2);
        Assert.True(result[0].LastName == "Bellucci");
        Assert.True(result[1].LastName == "NieTenRoman");
    }
}