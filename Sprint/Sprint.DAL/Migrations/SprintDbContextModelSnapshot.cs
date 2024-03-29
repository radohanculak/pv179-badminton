﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sprint.DAL.EFCore.Data;

#nullable disable

namespace Sprint.DAL.EFCore.Migrations
{
    [DbContext(typeof(SprintDbContext))]
    partial class SprintDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("Sprint.DAL.EFCore.Models.Court", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CourtNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("HourlyRate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Courts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9f3191c6-1e26-4b7b-8e72-ab567cfffd6a"),
                            CourtNumber = "A",
                            HourlyRate = 1000m,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("ddbc951b-4266-45fb-a251-2f95a790a70d"),
                            CourtNumber = "B",
                            HourlyRate = 800m,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("355a1a58-e4eb-4ae7-8288-a4ddc36a0134"),
                            CourtNumber = "C",
                            HourlyRate = 800m,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("794d2012-dc07-42c9-a2d8-a685b15f3786"),
                            CourtNumber = "D",
                            HourlyRate = 500m,
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("Sprint.DAL.EFCore.Models.CourtReservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CourtId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("From")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("To")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CourtId");

                    b.HasIndex("UserId");

                    b.ToTable("CourtReservations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("dae9a42b-fd8a-47d2-9d38-bd88d0ca1120"),
                            CourtId = new Guid("9f3191c6-1e26-4b7b-8e72-ab567cfffd6a"),
                            Created = new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 9, 29, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("885b4e04-a384-4e97-b7bb-8ba2c5a498c6")
                        },
                        new
                        {
                            Id = new Guid("7de69e84-3663-450e-8d93-d3b27ca680f5"),
                            CourtId = new Guid("355a1a58-e4eb-4ae7-8288-a4ddc36a0134"),
                            Created = new DateTime(2022, 9, 21, 6, 51, 34, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 9, 30, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 9, 30, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("885b4e04-a384-4e97-b7bb-8ba2c5a498c6")
                        },
                        new
                        {
                            Id = new Guid("bc67b007-02d9-4c84-8cad-13d0f058908d"),
                            CourtId = new Guid("355a1a58-e4eb-4ae7-8288-a4ddc36a0134"),
                            Created = new DateTime(2022, 9, 5, 23, 59, 59, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = true,
                            To = new DateTime(2022, 11, 17, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("885b4e04-a384-4e97-b7bb-8ba2c5a498c6")
                        },
                        new
                        {
                            Id = new Guid("a25e935c-b835-4595-9578-eea7ecb4ffe2"),
                            CourtId = new Guid("9f3191c6-1e26-4b7b-8e72-ab567cfffd6a"),
                            Created = new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 9, 29, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("1b2d9929-0ded-41c5-ab02-2ea77b034b14")
                        },
                        new
                        {
                            Id = new Guid("d42de53a-7788-49ea-a7ba-c07dd5eda7ff"),
                            CourtId = new Guid("9f3191c6-1e26-4b7b-8e72-ab567cfffd6a"),
                            Created = new DateTime(2022, 9, 28, 19, 19, 19, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 10, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 10, 1, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("1b2d9929-0ded-41c5-ab02-2ea77b034b14")
                        },
                        new
                        {
                            Id = new Guid("daf53428-11a8-45db-8ed0-36b15551e519"),
                            CourtId = new Guid("ddbc951b-4266-45fb-a251-2f95a790a70d"),
                            Created = new DateTime(2022, 9, 15, 18, 4, 4, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 9, 16, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 9, 16, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("8a2d90eb-2022-48d9-8382-14cde71351a5")
                        },
                        new
                        {
                            Id = new Guid("c83ae353-1c6d-4010-9195-0d9fae4bc521"),
                            CourtId = new Guid("ddbc951b-4266-45fb-a251-2f95a790a70d"),
                            Created = new DateTime(2022, 9, 16, 9, 53, 34, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 9, 17, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = true,
                            To = new DateTime(2022, 9, 17, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("8a2d90eb-2022-48d9-8382-14cde71351a5")
                        },
                        new
                        {
                            Id = new Guid("198b0f1e-11ab-474a-aa44-ae9d3661fd5e"),
                            CourtId = new Guid("794d2012-dc07-42c9-a2d8-a685b15f3786"),
                            Created = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 12, 31, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 12, 31, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("aa411737-fd41-4870-83a6-e8dc4044e3b7")
                        });
                });

            modelBuilder.Entity("Sprint.DAL.EFCore.Models.Trainer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("HourlyRate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Trainers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d4fbc9d5-1145-4ed9-a73e-c24b0f6374a0"),
                            Description = "I know how to play, that's all",
                            HourlyRate = 2000m,
                            IsDeleted = false,
                            UserId = new Guid("01e782c1-5410-4679-a6a0-9b4aa8f29b21")
                        },
                        new
                        {
                            Id = new Guid("d5d48bf1-dd40-4bf1-a359-49d1294d1b3f"),
                            Description = "I know how to play even better, that's all",
                            HourlyRate = 3485m,
                            IsDeleted = false,
                            UserId = new Guid("1b0fadba-d4c0-4dda-be29-070698133b26")
                        });
                });

            modelBuilder.Entity("Sprint.DAL.EFCore.Models.TrainerPhoto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Hide")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("TrainerId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("TrainerId");

                    b.ToTable("TrainerPhotos");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b36fc384-f8d0-42aa-a352-7b6d9d32ee14"),
                            Hide = false,
                            IsDeleted = false,
                            Path = "https://static8.depositphotos.com/1460388/938/i/600/depositphotos_9388060-stock-photo-next-rally.jpg",
                            TrainerId = new Guid("d4fbc9d5-1145-4ed9-a73e-c24b0f6374a0")
                        },
                        new
                        {
                            Id = new Guid("b772b3a7-238f-487a-bf58-b391cd67ad00"),
                            Hide = false,
                            IsDeleted = false,
                            Path = "https://static8.depositphotos.com/1460388/938/i/600/depositphotos_9388060-stock-photo-next-rally.jpg",
                            TrainerId = new Guid("d4fbc9d5-1145-4ed9-a73e-c24b0f6374a0")
                        },
                        new
                        {
                            Id = new Guid("2cfb41fa-f5d7-4804-be96-7c1aea18885d"),
                            Hide = true,
                            IsDeleted = false,
                            Path = "https://static8.depositphotos.com/1460388/938/i/600/depositphotos_9388060-stock-photo-next-rally.jpg",
                            TrainerId = new Guid("d5d48bf1-dd40-4bf1-a359-49d1294d1b3f")
                        },
                        new
                        {
                            Id = new Guid("f3a7c39c-c819-4ab4-8000-978e8d4f5704"),
                            Hide = true,
                            IsDeleted = false,
                            Path = "https://static8.depositphotos.com/1460388/938/i/600/depositphotos_9388060-stock-photo-next-rally.jpg",
                            TrainerId = new Guid("d5d48bf1-dd40-4bf1-a359-49d1294d1b3f")
                        });
                });

            modelBuilder.Entity("Sprint.DAL.EFCore.Models.TrainerReservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CourtReservationId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("TrainerId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CourtReservationId")
                        .IsUnique();

                    b.HasIndex("TrainerId");

                    b.ToTable("TrainerReservations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("59320dac-3a78-41d2-a962-0252ee865176"),
                            CourtReservationId = new Guid("c83ae353-1c6d-4010-9195-0d9fae4bc521"),
                            IsDeleted = true,
                            TrainerId = new Guid("d4fbc9d5-1145-4ed9-a73e-c24b0f6374a0")
                        },
                        new
                        {
                            Id = new Guid("4e66c4d2-f30b-4ff3-8178-e42a0f03fa18"),
                            CourtReservationId = new Guid("daf53428-11a8-45db-8ed0-36b15551e519"),
                            IsDeleted = false,
                            TrainerId = new Guid("d4fbc9d5-1145-4ed9-a73e-c24b0f6374a0")
                        },
                        new
                        {
                            Id = new Guid("187d320f-e01c-44d5-ab32-9fc344c15888"),
                            CourtReservationId = new Guid("198b0f1e-11ab-474a-aa44-ae9d3661fd5e"),
                            IsDeleted = false,
                            TrainerId = new Guid("d5d48bf1-dd40-4bf1-a359-49d1294d1b3f")
                        });
                });

            modelBuilder.Entity("Sprint.DAL.EFCore.Models.TrainerReview", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Hide")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Rating")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("ReservationId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId")
                        .IsUnique();

                    b.ToTable("TrainerReviews");

                    b.HasData(
                        new
                        {
                            Id = new Guid("05c529ba-e3e1-46ad-9d86-67e00c3db32c"),
                            Hide = false,
                            IsDeleted = false,
                            Rating = 5,
                            ReservationId = new Guid("187d320f-e01c-44d5-ab32-9fc344c15888"),
                            Text = "Awesome!"
                        });
                });

            modelBuilder.Entity("Sprint.DAL.EFCore.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsTrainer")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("TEXT");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("885b4e04-a384-4e97-b7bb-8ba2c5a498c6"),
                            DateOfBirth = new DateTime(2001, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "514329@mail.muni.cz",
                            FirstName = "Adam",
                            IsDeleted = false,
                            IsTrainer = false,
                            LastName = "Mydla",
                            PasswordHash = "AQAAAAEAACcQAAAAEDYvse/qqhU35jl44zZBhM9bCpnX2o80uv2Q7NpynUUcTSL+TO6dSU258h/1muym4g==",
                            PhotoPath = "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg",
                            Role = 0,
                            SecurityStamp = "1abcdef"
                        },
                        new
                        {
                            Id = new Guid("1b2d9929-0ded-41c5-ab02-2ea77b034b14"),
                            DateOfBirth = new DateTime(1995, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "pppeter@nonexistentmail.com",
                            FirstName = "Peter",
                            IsDeleted = false,
                            IsTrainer = false,
                            LastName = "Griffin",
                            PasswordHash = "AQAAAAEAACcQAAAAEDYvse/qqhU35jl44zZBhM9bCpnX2o80uv2Q7NpynUUcTSL+TO6dSU258h/1muym4g==",
                            PhotoPath = "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg",
                            Role = 0,
                            SecurityStamp = "2abcdef"
                        },
                        new
                        {
                            Id = new Guid("aa411737-fd41-4870-83a6-e8dc4044e3b7"),
                            DateOfBirth = new DateTime(1955, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "monic@nonexistentmail.com",
                            FirstName = "Monica",
                            IsDeleted = false,
                            IsTrainer = false,
                            LastName = "Bellucci",
                            PasswordHash = "AQAAAAEAACcQAAAAEDYvse/qqhU35jl44zZBhM9bCpnX2o80uv2Q7NpynUUcTSL+TO6dSU258h/1muym4g==",
                            PhotoPath = "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg",
                            Role = 0,
                            SecurityStamp = "4abcdef"
                        },
                        new
                        {
                            Id = new Guid("8a2d90eb-2022-48d9-8382-14cde71351a5"),
                            DateOfBirth = new DateTime(1993, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "rntr@nonexistentmail.com",
                            FirstName = "Roman",
                            IsDeleted = false,
                            IsTrainer = false,
                            LastName = "NieTenRoman",
                            PasswordHash = "AQAAAAEAACcQAAAAEDYvse/qqhU35jl44zZBhM9bCpnX2o80uv2Q7NpynUUcTSL+TO6dSU258h/1muym4g==",
                            PhotoPath = "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg",
                            Role = 0,
                            SecurityStamp = "3abcdef"
                        },
                        new
                        {
                            Id = new Guid("01e782c1-5410-4679-a6a0-9b4aa8f29b21"),
                            DateOfBirth = new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "rhanculak@mail.muni.cz",
                            FirstName = "Radovan",
                            IsDeleted = false,
                            IsTrainer = true,
                            LastName = "Hančuľák",
                            PasswordHash = "AQAAAAEAACcQAAAAEDYvse/qqhU35jl44zZBhM9bCpnX2o80uv2Q7NpynUUcTSL+TO6dSU258h/1muym4g==",
                            PhotoPath = "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg",
                            Role = 1,
                            SecurityStamp = "5abcdef"
                        },
                        new
                        {
                            Id = new Guid("1b0fadba-d4c0-4dda-be29-070698133b26"),
                            DateOfBirth = new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "493352@mail.muni.cz",
                            FirstName = "Jitka",
                            IsDeleted = false,
                            IsTrainer = true,
                            LastName = "Viceníková",
                            PasswordHash = "AQAAAAEAACcQAAAAEDYvse/qqhU35jl44zZBhM9bCpnX2o80uv2Q7NpynUUcTSL+TO6dSU258h/1muym4g==",
                            PhotoPath = "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg",
                            Role = 1,
                            SecurityStamp = "6abcdef"
                        },
                        new
                        {
                            Id = new Guid("38a0f66e-4357-4d08-90bc-6c001fab8248"),
                            DateOfBirth = new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@sprint.cz",
                            FirstName = "Admin",
                            IsDeleted = false,
                            IsTrainer = true,
                            LastName = "Admin",
                            PasswordHash = "AQAAAAEAACcQAAAAEDYvse/qqhU35jl44zZBhM9bCpnX2o80uv2Q7NpynUUcTSL+TO6dSU258h/1muym4g==",
                            PhotoPath = "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg",
                            Role = 2,
                            SecurityStamp = "6abcdef"
                        });
                });

            modelBuilder.Entity("Sprint.DAL.EFCore.Models.CourtReservation", b =>
                {
                    b.HasOne("Sprint.DAL.EFCore.Models.Court", "Court")
                        .WithMany("Reservations")
                        .HasForeignKey("CourtId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sprint.DAL.EFCore.Models.User", "User")
                        .WithMany("CourtReservations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Court");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Sprint.DAL.EFCore.Models.Trainer", b =>
                {
                    b.HasOne("Sprint.DAL.EFCore.Models.User", "User")
                        .WithOne("Trainer")
                        .HasForeignKey("Sprint.DAL.EFCore.Models.Trainer", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Sprint.DAL.EFCore.Models.TrainerPhoto", b =>
                {
                    b.HasOne("Sprint.DAL.EFCore.Models.Trainer", "Trainer")
                        .WithMany("Photos")
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("Sprint.DAL.EFCore.Models.TrainerReservation", b =>
                {
                    b.HasOne("Sprint.DAL.EFCore.Models.CourtReservation", "CourtReservation")
                        .WithOne("TrainerReservation")
                        .HasForeignKey("Sprint.DAL.EFCore.Models.TrainerReservation", "CourtReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sprint.DAL.EFCore.Models.Trainer", "Trainer")
                        .WithMany("Reservations")
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CourtReservation");

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("Sprint.DAL.EFCore.Models.TrainerReview", b =>
                {
                    b.HasOne("Sprint.DAL.EFCore.Models.TrainerReservation", "Reservation")
                        .WithOne("TrainerReview")
                        .HasForeignKey("Sprint.DAL.EFCore.Models.TrainerReview", "ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("Sprint.DAL.EFCore.Models.Court", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Sprint.DAL.EFCore.Models.CourtReservation", b =>
                {
                    b.Navigation("TrainerReservation");
                });

            modelBuilder.Entity("Sprint.DAL.EFCore.Models.Trainer", b =>
                {
                    b.Navigation("Photos");

                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Sprint.DAL.EFCore.Models.TrainerReservation", b =>
                {
                    b.Navigation("TrainerReview");
                });

            modelBuilder.Entity("Sprint.DAL.EFCore.Models.User", b =>
                {
                    b.Navigation("CourtReservations");

                    b.Navigation("Trainer");
                });
#pragma warning restore 612, 618
        }
    }
}
