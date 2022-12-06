using Sprint.DAL.EFCore;
using Sprint.Infrastructure;
using Sprint.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Sprint.DAL.EFCore.Data;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.EFCore.Query;
using Sprint.Infrastructure.EFCore.Repository;
namespace Sprint.DAL.UnitTest;

public class TestDbSeeder
{
    public static List<Guid> SeedCourtsDb(SprintDbContext dbContext)
    {
        List<Guid> guids = SeederFunctions.CreateGuid(4);

        dbContext.Courts.Add(new Court
        {
            Id = guids[0],
            HourlyRate = 1000,
            CourtNumber = "A",
        });

        dbContext.Courts.Add(new Court
        {
            Id = guids[1],
            HourlyRate = 800,
            CourtNumber = "B",
        });

        dbContext.Courts.Add(new Court
        {
            Id = guids[2],
            HourlyRate = 800,
            CourtNumber = "C",
        });

        dbContext.Courts.Add(new Court
        {
            Id = guids[3],
            HourlyRate = 500,
            CourtNumber = "D",
        });

        dbContext.SaveChanges();

        return guids;
    }

    public static async void ReseedCourtsDb(SprintDbContext dbContext)
    {
        dbContext.Courts.RemoveRange(dbContext.Courts.ToList());
        await dbContext.Courts.AddRangeAsync(SeederFunctions.CourtGenerator(30));
        await dbContext.SaveChangesAsync();
    }

    public static List<Guid> SeedUserDb(SprintDbContext dbContext)
    {
        List<Guid> guids = SeederFunctions.CreateGuid(4);
        
        dbContext.Users.Add(new User
        {
            Id = guids[0],
            FirstName = "Adam",
            LastName = "Mydla",
            DateOfBirth = new DateTime(2001, 5, 31),
            Email = "514329@mail.muni.cz",
            PasswordHash = "tbd",
            PhotoPath = "tbd",
            SecurityStamp = "testing1",
        });

        dbContext.Users.Add(new User
        {
            Id = guids[1],
            FirstName = "Peter",
            LastName = "Griffin",
            DateOfBirth = new DateTime(1995, 5, 31),
            Email = "pppeter@nonexistentmail.com",
            PasswordHash = "tbd",
            PhotoPath = "tbd",
            SecurityStamp = "testing2",
        });

        dbContext.Users.Add(new User
        {
            Id = guids[2],
            FirstName = "Roman",
            LastName = "NieTenRoman",
            DateOfBirth = new DateTime(1993, 9, 1),
            Email = "rntr@nonexistentmail.com",
            PasswordHash = "tbd",
            PhotoPath = "tbd",
            SecurityStamp = "testing3",

        });

        dbContext.Users.Add(new User
        {
            Id = guids[3],
            FirstName = "Monica",
            LastName = "Bellucci",
            DateOfBirth = new DateTime(1955, 5, 5),
            Email = "monic@nonexistentmail.com",
            PasswordHash = "tbd",
            PhotoPath = "tbd",
            SecurityStamp = "testing4",
        });
        
        dbContext.SaveChanges();

        return guids;
    }

    public static List<Guid> SeedCourtResDb(SprintDbContext dbContext,
        List<Guid> courtGuids, List<Guid> userGuids)
    {
        List<Guid> guids = SeederFunctions.CreateGuid(4);
        
        dbContext.CourtReservations.Add(new CourtReservation
        {
            Id = guids[0],
            Created = new DateTime(2022, 9, 20, 9, 53, 34),
            From = new DateTime(2022, 9, 29, 10, 0, 0),
            To = new DateTime(2022, 9, 29, 11, 0, 0),
            IsDeleted = false,
            UserId = userGuids[0],
            CourtId = courtGuids[0],
        });

        dbContext.CourtReservations.Add(new CourtReservation
        {
            Id = guids[1],
            Created = new DateTime(2022, 9, 21, 6, 51, 34),
            From = new DateTime(2022, 9, 30, 8, 0, 0),
            To = new DateTime(2022, 9, 30, 13, 0, 0),
            IsDeleted = false,
            UserId = userGuids[0],
            CourtId = courtGuids[2],
        });

        dbContext.CourtReservations.Add(new CourtReservation
        {
            Id = guids[2],
            Created = new DateTime(2022, 9, 5, 23, 59, 59),
            From = new DateTime(2022, 11, 17, 8, 0, 0),
            To = new DateTime(2022, 11, 17, 16, 0, 0),
            IsDeleted = true,
            UserId = userGuids[1],
            CourtId = courtGuids[1],
        });

        dbContext.CourtReservations.Add( new CourtReservation
        {
            Id = guids[3],
            Created = new DateTime(2022, 9, 20, 9, 53, 34),
            From = new DateTime(2022, 9, 29, 11, 0, 0),
            To = new DateTime(2022, 9, 29, 12, 0, 0),
            IsDeleted = false,
            UserId = userGuids[1],
            CourtId = courtGuids[1],
        });

        dbContext.SaveChanges();
        
        return guids;
    }
}