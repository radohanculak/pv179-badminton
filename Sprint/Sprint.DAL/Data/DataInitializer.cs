﻿using Microsoft.EntityFrameworkCore;
using Sprint.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint.DAL.Data
{
    public static class DataInitializer
    {
        public static void Seeder(this ModelBuilder modelBuilder)
        {
            var Adam = new User
            {
                Id = 1,
                FirstName = "Adam",
                LastName = "Mydla",
                DateOfBirth = new DateTime(31, 5, 1),
                Email = "514329@mail.muni.cz",
                PasswordHash = "tbd",
                PhotoPath = "tbd",
                IsTrainer = false
            };
            var Rado = new User
            {
                Id = 2,
                FirstName = "Radovan",
                LastName = "Hančuľák",
                DateOfBirth = new DateTime(0, 0, 0),
                Email = "rhanculak@mail.muni.cz",
                PasswordHash = "tbd",
                PhotoPath = "tbd",
                IsTrainer = true
            };
            var Jitka = new User
            {
                Id = 3,
                FirstName = "Jitka",
                LastName = "Viceníková",
                DateOfBirth = new DateTime(0, 0, 0),
                Email = "493352@mail.muni.cz",
                PasswordHash = "tbd",
                PhotoPath = "tbd",
                IsTrainer = true
            };

            var Petko = new User
            {
                Id = 4,
                FirstName = "Peter",
                LastName = "Griffin",
                DateOfBirth = new DateTime(5, 5, 1955),
                Email = "pppeter@nonexistentmail.com",
                PasswordHash = "tbd",
                PhotoPath = "tbd",
                IsTrainer = false
            };

            var Roman = new User
            {
                Id = 5,
                FirstName = "Roman",
                LastName = "NieTenRoman",
                DateOfBirth = new DateTime(1, 9, 1993),
                Email = "rntr@nonexistentmail.com",
                PasswordHash = "tbd",
                PhotoPath = "tbd",
                IsTrainer = false
            };

            var Monica = new User
            {
                Id = 6,
                FirstName = "Monica",
                LastName = "Bellucci",
                DateOfBirth = new DateTime(5, 5, 1955),
                Email = "monic@nonexistentmail.com",
                PasswordHash = "tbd",
                PhotoPath = "tbd",
                IsTrainer = false
            };


            var RadoTrainer = new Trainer
            {
                Id = 1,
                HourlyRate = 2000,
                Description = "I know how to play, that's all",
                UserId = 2,
            };

            var JitkaTrainer = new Trainer
            {
                Id = 2,
                HourlyRate = 3485,
                Description = "I know how to play even better, that's all",
                UserId = 3,
            };

            var court1 = new Court
            {
                Id = 1,
                HourlyRate = 1000,
                CourtNumber = "A",
            };

            var court2 = new Court
            {
                Id = 2,
                HourlyRate = 800,
                CourtNumber = "A",
            };

            var court3 = new Court
            {
                Id = 3,
                HourlyRate = 800,
                CourtNumber = "A",
            };

            var court4 = new Court
            {
                Id = 4,
                HourlyRate = 500,
                CourtNumber = "A",
            };

            var RadoTrainerPhoto1 = new TrainerPhoto
            {
                Id = 1,
                Path = "tbd",
                Hide = false,
                TrainerId = 1,
            };

            var RadoTrainerPhoto2 = new TrainerPhoto
            {
                Id = 2,
                Path = "tbd",
                Hide = false,
                TrainerId = 1,
            };

            var JitkaTrainerPhoto1 = new TrainerPhoto
            {
                Id = 3,
                Path = "tbd",
                Hide = true,
                TrainerId = 2,
            };

            var JitkaTrainerPhoto2 = new TrainerPhoto
            {
                Id = 4,
                Path = "tbd",
                Hide = true,
                TrainerId = 2,
            };


            var courtReservationAdam1 = new CourtReservation
            {
                Id = 1,
                Created = new DateTime(2022, 9, 20, 9, 53, 34),
                From = new DateTime(2022, 9, 29, 10, 0, 0),
                To = new DateTime(2022, 9, 29, 11, 0, 0),
                IsDeleted = false,
                UserId = 1,
                CourtId = 1,
            };

            var courtReservationAdam2 = new CourtReservation
            {
                Id = 2,
                Created = new DateTime(2022, 9, 21, 6, 51, 34),
                From = new DateTime(2022, 9, 30, 8, 0, 0),
                To = new DateTime(2022, 9, 30, 13, 0, 0),
                IsDeleted = false,
                UserId = 1,
                CourtId = 3,
            };

            var courtReservationAdam3 = new CourtReservation
            {
                Id = 3,
                Created = new DateTime(2022, 9, 5, 23, 59, 59),
                From = new DateTime(2022, 11, 17, 8, 0, 0),
                To = new DateTime(2022, 11, 17, 16, 0, 0),
                IsDeleted = true,
                UserId = 1,
                CourtId = 3,
            };

            var courtReservationPetko1 = new CourtReservation
            {
                Id = 4,
                Created = new DateTime(2022, 9, 20, 9, 53, 34),
                From = new DateTime(2022, 9, 29, 11, 0, 0),
                To = new DateTime(2022, 9, 29, 12, 0, 0),
                IsDeleted = false,
                UserId = 4,
                CourtId = 1,
            };

            var courtReservationPetko2 = new CourtReservation
            {
                Id = 5,
                Created = new DateTime(2022, 9, 28, 19, 19, 19),
                From = new DateTime(2022, 10, 1, 10, 0, 0),
                To = new DateTime(2022, 10, 1, 11, 0, 0),
                IsDeleted = false,
                UserId = 4,
                CourtId = 1,
            };

            var courtReservationRoman1 = new CourtReservation
            {
                Id = 6,
                Created = new DateTime(2022, 9, 15, 18, 4, 4),
                From = new DateTime(2022, 9, 16, 13, 0, 0),
                To = new DateTime(2022, 9, 16, 17, 0, 0),
                IsDeleted = false,
                UserId = 5,
                CourtId = 2,
            };

            var courtReservationRoman2 = new CourtReservation
            {
                Id = 7,
                Created = new DateTime(2022, 9, 16, 9, 53, 34),
                From = new DateTime(2022, 9, 17, 10, 0, 0),
                To = new DateTime(2022, 9, 17, 11, 0, 0),
                IsDeleted = true,
                UserId = 5,
                CourtId = 2,
            };

            var courtReservationMonica1 = new CourtReservation
            {
                Id = 8,
                Created = new DateTime(2022, 1, 1, 0, 0, 0),
                From = new DateTime(2022, 31, 12, 10, 0, 0),
                To = new DateTime(2022, 31, 12, 11, 0, 0),
                IsDeleted = false,
                UserId = 6,
                CourtId = 4,
            };

            var RadoRoman2 = new TrainerReservation
            {
                Id = 1,
                IsDeleted = true,
                CourtReservationId = 7,
                TrainerId = 1,
            };

            var RadoRoman1 = new TrainerReservation
            {
                Id = 2,
                IsDeleted = false,
                CourtReservationId = 6,
                TrainerId = 1,
            };

            var JitkaMonicaReview = new TrainerReview
            {
                Id = 1,
                Rating = 5,
                Text = "tbd",
                Hide = false,
                UserId = 6,
                TrainerId = 2,
            };

            var JitkaMonica = new TrainerReservation
            {
                Id = 3,
                IsDeleted = false,
                CourtReservationId = 8,
                TrainerId = 2,
                TrainerReviewId = 1,
            };
        }
    }
}
