using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Sprint.Common.Enums;
using Sprint.DAL.EFCore.Models;

namespace Sprint.DAL.EFCore.Data;

public static class DataInitializer
{
    public static void Seeder(this ModelBuilder modelBuilder)
    {
        var hasher = new PasswordHasher<User>();
        var passwordHash = hasher.HashPassword(null, "password");
        const string photo = "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg";

        var Adam = new User
        {
            Id = Guid.NewGuid(),
            FirstName = "Adam",
            LastName = "Mydla",
            DateOfBirth = new DateTime(2001, 5, 31),
            Email = "514329@mail.muni.cz",
            PasswordHash = passwordHash,
            PhotoPath = photo,
            IsTrainer = false,
            SecurityStamp = "1abcdef",
            Role = UserRole.User,
            IsDeleted = false
        };

        var Petko = new User
        {
            Id = Guid.NewGuid(),
            FirstName = "Peter",
            LastName = "Griffin",
            DateOfBirth = new DateTime(1995, 5, 31),
            Email = "pppeter@nonexistentmail.com",
            PasswordHash = passwordHash,
            PhotoPath = photo,
            IsTrainer = false,
            SecurityStamp = "2abcdef",
            Role = UserRole.User,
            IsDeleted = false
        };

        var Roman = new User
        {
            Id = Guid.NewGuid(),
            FirstName = "Roman",
            LastName = "NieTenRoman",
            DateOfBirth = new DateTime(1993, 9, 1),
            Email = "rntr@nonexistentmail.com",
            PasswordHash = passwordHash,
            PhotoPath = photo,
            IsTrainer = false,
            SecurityStamp = "3abcdef",
            Role = UserRole.User,
            IsDeleted = false
        };

        var Monica = new User
        {
            Id = Guid.NewGuid(),
            FirstName = "Monica",
            LastName = "Bellucci",
            DateOfBirth = new DateTime(1955, 5, 5),
            Email = "monic@nonexistentmail.com",
            PasswordHash = passwordHash,
            PhotoPath = photo,
            IsTrainer = false,
            SecurityStamp = "4abcdef",
            Role = UserRole.User,
            IsDeleted = false
        };

        var Rado = new User
        {
            Id = Guid.NewGuid(),
            FirstName = "Radovan",
            LastName = "Hančuľák",
            DateOfBirth = new DateTime(1995, 5, 5),
            Email = "rhanculak@mail.muni.cz",
            PasswordHash = passwordHash,
            PhotoPath = photo,
            IsTrainer = true,
            SecurityStamp = "5abcdef",
            Role = UserRole.Trainer,
            IsDeleted = false
        };

        var Jitka = new User
        {
            Id = Guid.NewGuid(),
            FirstName = "Jitka",
            LastName = "Viceníková",
            DateOfBirth = new DateTime(1995, 5, 5),
            Email = "493352@mail.muni.cz",
            PasswordHash = passwordHash,
            PhotoPath = photo,
            IsTrainer = true,
            SecurityStamp = "6abcdef",
            Role = UserRole.Trainer,
            IsDeleted = false
        };
        
        var admin = new User
        {
            Id = Guid.NewGuid(),
            FirstName = "Admin",
            LastName = "Admin",
            DateOfBirth = new DateTime(1995, 5, 5),
            Email = "admin@sprint.cz",
            PasswordHash = passwordHash,
            PhotoPath = photo,
            IsTrainer = true,
            SecurityStamp = "6abcdef",
            Role = UserRole.Admin,
            IsDeleted = false
        };

        modelBuilder.Entity<User>().HasData(Adam);
        modelBuilder.Entity<User>().HasData(Petko);
        modelBuilder.Entity<User>().HasData(Monica);
        modelBuilder.Entity<User>().HasData(Roman);
        modelBuilder.Entity<User>().HasData(Rado);
        modelBuilder.Entity<User>().HasData(Jitka);
        modelBuilder.Entity<User>().HasData(admin);

        var RadoTrainer = new Trainer
        {
            Id = Guid.NewGuid(),
            HourlyRate = 2000,
            Description = "I know how to play, that's all",
            UserId = Rado.Id,
            IsDeleted = false
        };
        var JitkaTrainer = new Trainer
        {
            Id = Guid.NewGuid(),
            HourlyRate = 3485,
            Description = "I know how to play even better, that's all",
            UserId = Jitka.Id,
            IsDeleted = false
        };

        modelBuilder.Entity<Trainer>().HasData(RadoTrainer);
        modelBuilder.Entity<Trainer>().HasData(JitkaTrainer);


        var courtA = new Court
        {
            Id = Guid.NewGuid(),
            HourlyRate = 1000,
            CourtNumber = "A",
            IsDeleted = false
        };

        var courtB = new Court
        {
            Id = Guid.NewGuid(),
            HourlyRate = 800,
            CourtNumber = "B",
            IsDeleted = false
        };

        var courtC = new Court
        {
            Id = Guid.NewGuid(),
            HourlyRate = 800,
            CourtNumber = "C",
            IsDeleted = false
        };

        var courtD = new Court
        {
            Id = Guid.NewGuid(),
            HourlyRate = 500,
            CourtNumber = "D",
            IsDeleted = false
        };

        modelBuilder.Entity<Court>().HasData(courtA);
        modelBuilder.Entity<Court>().HasData(courtB);
        modelBuilder.Entity<Court>().HasData(courtC);
        modelBuilder.Entity<Court>().HasData(courtD);

        const string trainerPhotoPath =
            "https://static8.depositphotos.com/1460388/938/i/600/depositphotos_9388060-stock-photo-next-rally.jpg";
        
        var RadoTrainerPhoto1 = new TrainerPhoto
        {
            Id = Guid.NewGuid(),
            Path = trainerPhotoPath,
            Hide = false,
            TrainerId = RadoTrainer.Id,
            IsDeleted = false
        };

        var RadoTrainerPhoto2 = new TrainerPhoto
        {
            Id = Guid.NewGuid(),
            Path = trainerPhotoPath,
            Hide = false,
            TrainerId = RadoTrainer.Id,
            IsDeleted = false
        };

        var JitkaTrainerPhoto1 = new TrainerPhoto
        {
            Id = Guid.NewGuid(),
            Path = trainerPhotoPath,
            Hide = true,
            TrainerId = JitkaTrainer.Id,
            IsDeleted = false
        };

        var JitkaTrainerPhoto2 = new TrainerPhoto
        {
            Id = Guid.NewGuid(),
            Path = trainerPhotoPath,
            Hide = true,
            TrainerId = JitkaTrainer.Id,
            IsDeleted = false
        };

        modelBuilder.Entity<TrainerPhoto>().HasData(RadoTrainerPhoto1);
        modelBuilder.Entity<TrainerPhoto>().HasData(RadoTrainerPhoto2);
        modelBuilder.Entity<TrainerPhoto>().HasData(JitkaTrainerPhoto1);
        modelBuilder.Entity<TrainerPhoto>().HasData(JitkaTrainerPhoto2);

        var courtReservationAdam1 = new CourtReservation
        {
            Id = Guid.NewGuid(),
            Created = new DateTime(2022, 9, 20, 9, 53, 34),
            From = new DateTime(2022, 9, 29, 10, 0, 0),
            To = new DateTime(2022, 9, 29, 11, 0, 0),
            IsDeleted = false,
            UserId = Adam.Id,
            CourtId = courtA.Id,
        };

        var courtReservationAdam2 = new CourtReservation
        {
            Id = Guid.NewGuid(),
            Created = new DateTime(2022, 9, 21, 6, 51, 34),
            From = new DateTime(2022, 9, 30, 8, 0, 0),
            To = new DateTime(2022, 9, 30, 13, 0, 0),
            IsDeleted = false,
            UserId = Adam.Id,
            CourtId = courtC.Id,
        };

        var courtReservationAdam3 = new CourtReservation
        {
            Id = Guid.NewGuid(),
            Created = new DateTime(2022, 9, 5, 23, 59, 59),
            From = new DateTime(2022, 11, 17, 8, 0, 0),
            To = new DateTime(2022, 11, 17, 16, 0, 0),
            IsDeleted = true,
            UserId = Adam.Id,
            CourtId = courtC.Id,
        };

        var courtReservationPetko1 = new CourtReservation
        {
            Id = Guid.NewGuid(),
            Created = new DateTime(2022, 9, 20, 9, 53, 34),
            From = new DateTime(2022, 9, 29, 11, 0, 0),
            To = new DateTime(2022, 9, 29, 12, 0, 0),
            IsDeleted = false,
            UserId = Petko.Id,
            CourtId = courtA.Id,
        };

        var courtReservationPetko2 = new CourtReservation
        {
            Id = Guid.NewGuid(),
            Created = new DateTime(2022, 9, 28, 19, 19, 19),
            From = new DateTime(2022, 10, 1, 10, 0, 0),
            To = new DateTime(2022, 10, 1, 11, 0, 0),
            IsDeleted = false,
            UserId = Petko.Id,
            CourtId = courtA.Id,
        };

        var courtReservationRoman1 = new CourtReservation
        {
            Id = Guid.NewGuid(),
            Created = new DateTime(2022, 9, 15, 18, 4, 4),
            From = new DateTime(2022, 9, 16, 13, 0, 0),
            To = new DateTime(2022, 9, 16, 17, 0, 0),
            IsDeleted = false,
            UserId = Roman.Id,
            CourtId = courtB.Id,
        };

        var courtReservationRoman2 = new CourtReservation
        {
            Id = Guid.NewGuid(),
            Created = new DateTime(2022, 9, 16, 9, 53, 34),
            From = new DateTime(2022, 9, 17, 10, 0, 0),
            To = new DateTime(2022, 9, 17, 11, 0, 0),
            IsDeleted = true,
            UserId = Roman.Id,
            CourtId = courtB.Id,
        };

        var courtReservationMonica1 = new CourtReservation
        {
            Id = Guid.NewGuid(),
            Created = new DateTime(2022, 1, 1, 0, 0, 0),
            From = new DateTime(2022, 12, 31, 10, 0, 0),
            To = new DateTime(2022, 12, 31, 11, 0, 0),
            IsDeleted = false,
            UserId = Monica.Id,
            CourtId = courtD.Id,
        };

        modelBuilder.Entity<CourtReservation>().HasData(courtReservationAdam1);
        modelBuilder.Entity<CourtReservation>().HasData(courtReservationAdam2);
        modelBuilder.Entity<CourtReservation>().HasData(courtReservationAdam3);
        modelBuilder.Entity<CourtReservation>().HasData(courtReservationPetko1);
        modelBuilder.Entity<CourtReservation>().HasData(courtReservationPetko2);
        modelBuilder.Entity<CourtReservation>().HasData(courtReservationRoman1);
        modelBuilder.Entity<CourtReservation>().HasData(courtReservationRoman2);
        modelBuilder.Entity<CourtReservation>().HasData(courtReservationMonica1);

        var RadoRoman1 = new TrainerReservation
        {
            Id = Guid.NewGuid(),
            IsDeleted = true,
            CourtReservationId = courtReservationRoman2.Id,
            TrainerId = RadoTrainer.Id
        };

        var RadoRoman2 = new TrainerReservation
        {
            Id = Guid.NewGuid(),
            IsDeleted = false,
            CourtReservationId = courtReservationRoman1.Id,
            TrainerId = RadoTrainer.Id
        };

        

        var JitkaMonica = new TrainerReservation
        {
            Id = Guid.NewGuid(),
            IsDeleted = false,
            CourtReservationId = courtReservationMonica1.Id,
            TrainerId = JitkaTrainer.Id
        };
        
        modelBuilder.Entity<TrainerReservation>().HasData(RadoRoman1);
        modelBuilder.Entity<TrainerReservation>().HasData(RadoRoman2);
        modelBuilder.Entity<TrainerReservation>().HasData(JitkaMonica);
        
        var JitkaMonicaReview = new TrainerReview
        {
            Id = Guid.NewGuid(),
            Rating = 5,
            Text = "Awesome!",
            Hide = false,
            ReservationId = JitkaMonica.Id,
            IsDeleted = false
        };
        
        modelBuilder.Entity<TrainerReview>().HasData(JitkaMonicaReview);
    }
}
