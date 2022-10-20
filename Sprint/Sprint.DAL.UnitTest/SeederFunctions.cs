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

public class SeederFunctions
{
    public static List<Guid> CreateGuid(int guidCount)
    {
        List<Guid> guids = new List<Guid>();
        for (int i = 0; i < guidCount; i++)
        {
            guids.Add(Guid.NewGuid());
        }

        return guids;
    }
    
    public static List<Court> CourtGenerator(int numOfCourts)
    {
        List<Court> courts = new List<Court>();
        for (int i = 0; i < numOfCourts; i++) 
        {
            courts.Add(new Court
            {
                Id = new Guid(),
                HourlyRate = 1000 + 200 * (i % 5),
                CourtNumber = i.ToString(),
            });
        }

        return courts;
    }
    
    public static Court GetNewCourt(Guid guid)
    {
        var court = CourtGenerator(1)[0];
        court.Id = guid;
        return court;
    }
    
    public static User GetNewUser(Guid guid)
    {
        return new User
        {
            Id = guid,
            FirstName = "Abc",
            LastName = "Def",
            DateOfBirth = new DateTime(2000, 1, 1),
            Email = "random@random.cz",
            PasswordHash = "tbd",
            PhotoPath = "tbd",
        };
    }
}