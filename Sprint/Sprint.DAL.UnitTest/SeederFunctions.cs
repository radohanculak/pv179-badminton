using Sprint.DAL.EFCore.Models;

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
                Id = Guid.NewGuid(),
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
            SecurityStamp = "testing",
        };
    }
}