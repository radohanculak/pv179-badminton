﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sprint.DAL.EFCore.Data;

#nullable disable

namespace Sprint.DAL.EFCore.Migrations
{
    [DbContext(typeof(SprintDbContext))]
    [Migration("20221218132622_AddPhotos")]
    partial class AddPhotos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("4c74390d-31bd-431e-bec5-7478d8bc067a"),
                            CourtNumber = "A",
                            HourlyRate = 1000m,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("0cdbbff1-2588-4d06-acdb-c9c765763ecd"),
                            CourtNumber = "B",
                            HourlyRate = 800m,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("21582987-8c62-4c0e-8baa-c9b17bef04a9"),
                            CourtNumber = "C",
                            HourlyRate = 800m,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("08270c26-6799-4270-a319-533bee854927"),
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
                            Id = new Guid("1c4199b5-dffa-4d91-a5d8-b9b7a45ad9f8"),
                            CourtId = new Guid("4c74390d-31bd-431e-bec5-7478d8bc067a"),
                            Created = new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 9, 29, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("f48f6bc9-42f1-4eeb-b234-e58711a87103")
                        },
                        new
                        {
                            Id = new Guid("60f7e6bc-ceac-4a89-9ed6-e4822ece7d96"),
                            CourtId = new Guid("21582987-8c62-4c0e-8baa-c9b17bef04a9"),
                            Created = new DateTime(2022, 9, 21, 6, 51, 34, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 9, 30, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 9, 30, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("f48f6bc9-42f1-4eeb-b234-e58711a87103")
                        },
                        new
                        {
                            Id = new Guid("46ca34a1-d8b2-45bd-98dd-c75dc3593e58"),
                            CourtId = new Guid("21582987-8c62-4c0e-8baa-c9b17bef04a9"),
                            Created = new DateTime(2022, 9, 5, 23, 59, 59, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = true,
                            To = new DateTime(2022, 11, 17, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("f48f6bc9-42f1-4eeb-b234-e58711a87103")
                        },
                        new
                        {
                            Id = new Guid("df96fece-4bd0-46d9-ada9-d1ea7b39bec1"),
                            CourtId = new Guid("4c74390d-31bd-431e-bec5-7478d8bc067a"),
                            Created = new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 9, 29, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("02414384-5f04-4c71-817e-84c9401489af")
                        },
                        new
                        {
                            Id = new Guid("0d6f904c-09e3-46bb-96a3-71225fc687dd"),
                            CourtId = new Guid("4c74390d-31bd-431e-bec5-7478d8bc067a"),
                            Created = new DateTime(2022, 9, 28, 19, 19, 19, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 10, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 10, 1, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("02414384-5f04-4c71-817e-84c9401489af")
                        },
                        new
                        {
                            Id = new Guid("4970864a-7db3-4d37-bf25-9136d2ac9852"),
                            CourtId = new Guid("0cdbbff1-2588-4d06-acdb-c9c765763ecd"),
                            Created = new DateTime(2022, 9, 15, 18, 4, 4, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 9, 16, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 9, 16, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("bcbcb6f0-6f36-4bf4-b44b-81f539030b8d")
                        },
                        new
                        {
                            Id = new Guid("4869f2a5-5283-4aac-9286-07ffdf64e4b1"),
                            CourtId = new Guid("0cdbbff1-2588-4d06-acdb-c9c765763ecd"),
                            Created = new DateTime(2022, 9, 16, 9, 53, 34, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 9, 17, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = true,
                            To = new DateTime(2022, 9, 17, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("bcbcb6f0-6f36-4bf4-b44b-81f539030b8d")
                        },
                        new
                        {
                            Id = new Guid("dafc2fa5-40a9-48fc-8864-b99b3bbbcdfa"),
                            CourtId = new Guid("08270c26-6799-4270-a319-533bee854927"),
                            Created = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 12, 31, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 12, 31, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("4386b2d9-89ff-453d-8d1e-f8d5ba2eb87b")
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
                            Id = new Guid("dfdb5acc-aeb2-4465-a859-8ba250311e38"),
                            Description = "I know how to play, that's all",
                            HourlyRate = 2000m,
                            IsDeleted = false,
                            UserId = new Guid("9a14dd6e-6198-4b43-ba4e-f15319cb66a7")
                        },
                        new
                        {
                            Id = new Guid("e97aaae7-f306-418a-bbb0-8172600ca28b"),
                            Description = "I know how to play even better, that's all",
                            HourlyRate = 3485m,
                            IsDeleted = false,
                            UserId = new Guid("b2d6a26e-8cb5-4301-9d6f-6acbd4cdba52")
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
                            Id = new Guid("ff161d88-213e-4958-8059-d97798c69d19"),
                            Hide = false,
                            IsDeleted = false,
                            Path = "tbd",
                            TrainerId = new Guid("dfdb5acc-aeb2-4465-a859-8ba250311e38")
                        },
                        new
                        {
                            Id = new Guid("8bd0b742-4183-4cfa-9704-889d45f9197c"),
                            Hide = false,
                            IsDeleted = false,
                            Path = "tbd",
                            TrainerId = new Guid("dfdb5acc-aeb2-4465-a859-8ba250311e38")
                        },
                        new
                        {
                            Id = new Guid("b26b93fc-f4c5-4dbf-b35b-1fa94db26273"),
                            Hide = true,
                            IsDeleted = false,
                            Path = "tbd",
                            TrainerId = new Guid("e97aaae7-f306-418a-bbb0-8172600ca28b")
                        },
                        new
                        {
                            Id = new Guid("81ed96c7-f207-4952-a889-53ccc5ca0783"),
                            Hide = true,
                            IsDeleted = false,
                            Path = "tbd",
                            TrainerId = new Guid("e97aaae7-f306-418a-bbb0-8172600ca28b")
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
                            Id = new Guid("0d3198ef-53c1-45aa-8ae8-670d4e08bf36"),
                            CourtReservationId = new Guid("4869f2a5-5283-4aac-9286-07ffdf64e4b1"),
                            IsDeleted = true,
                            TrainerId = new Guid("dfdb5acc-aeb2-4465-a859-8ba250311e38")
                        },
                        new
                        {
                            Id = new Guid("cd658e1a-9056-4966-9af8-9a2b66b293af"),
                            CourtReservationId = new Guid("4970864a-7db3-4d37-bf25-9136d2ac9852"),
                            IsDeleted = false,
                            TrainerId = new Guid("dfdb5acc-aeb2-4465-a859-8ba250311e38")
                        },
                        new
                        {
                            Id = new Guid("e6c1928a-e4ca-43df-be38-7beb3596f9dd"),
                            CourtReservationId = new Guid("dafc2fa5-40a9-48fc-8864-b99b3bbbcdfa"),
                            IsDeleted = false,
                            TrainerId = new Guid("e97aaae7-f306-418a-bbb0-8172600ca28b")
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
                            Id = new Guid("c86327ad-29f0-4fa4-82f9-fc7b234cabfa"),
                            Hide = false,
                            IsDeleted = false,
                            Rating = 5,
                            ReservationId = new Guid("e6c1928a-e4ca-43df-be38-7beb3596f9dd"),
                            Text = "tbd"
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
                            Id = new Guid("f48f6bc9-42f1-4eeb-b234-e58711a87103"),
                            DateOfBirth = new DateTime(2001, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "514329@mail.muni.cz",
                            FirstName = "Adam",
                            IsDeleted = false,
                            IsTrainer = false,
                            LastName = "Mydla",
                            PasswordHash = "AQAAAAEAACcQAAAAEHXEV2HCDjz7mVo6WFzIKS1rWts0VQwNFiYGj8JnBHlmD3xeqwMBBYvH4RhQITs5qQ==",
                            PhotoPath = "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg",
                            Role = 0,
                            SecurityStamp = "1abcdef"
                        },
                        new
                        {
                            Id = new Guid("02414384-5f04-4c71-817e-84c9401489af"),
                            DateOfBirth = new DateTime(1995, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "pppeter@nonexistentmail.com",
                            FirstName = "Peter",
                            IsDeleted = false,
                            IsTrainer = false,
                            LastName = "Griffin",
                            PasswordHash = "AQAAAAEAACcQAAAAEHXEV2HCDjz7mVo6WFzIKS1rWts0VQwNFiYGj8JnBHlmD3xeqwMBBYvH4RhQITs5qQ==",
                            PhotoPath = "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg",
                            Role = 0,
                            SecurityStamp = "2abcdef"
                        },
                        new
                        {
                            Id = new Guid("4386b2d9-89ff-453d-8d1e-f8d5ba2eb87b"),
                            DateOfBirth = new DateTime(1955, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "monic@nonexistentmail.com",
                            FirstName = "Monica",
                            IsDeleted = false,
                            IsTrainer = false,
                            LastName = "Bellucci",
                            PasswordHash = "AQAAAAEAACcQAAAAEHXEV2HCDjz7mVo6WFzIKS1rWts0VQwNFiYGj8JnBHlmD3xeqwMBBYvH4RhQITs5qQ==",
                            PhotoPath = "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg",
                            Role = 0,
                            SecurityStamp = "4abcdef"
                        },
                        new
                        {
                            Id = new Guid("bcbcb6f0-6f36-4bf4-b44b-81f539030b8d"),
                            DateOfBirth = new DateTime(1993, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "rntr@nonexistentmail.com",
                            FirstName = "Roman",
                            IsDeleted = false,
                            IsTrainer = false,
                            LastName = "NieTenRoman",
                            PasswordHash = "AQAAAAEAACcQAAAAEHXEV2HCDjz7mVo6WFzIKS1rWts0VQwNFiYGj8JnBHlmD3xeqwMBBYvH4RhQITs5qQ==",
                            PhotoPath = "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg",
                            Role = 0,
                            SecurityStamp = "3abcdef"
                        },
                        new
                        {
                            Id = new Guid("9a14dd6e-6198-4b43-ba4e-f15319cb66a7"),
                            DateOfBirth = new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "rhanculak@mail.muni.cz",
                            FirstName = "Radovan",
                            IsDeleted = false,
                            IsTrainer = true,
                            LastName = "Hančuľák",
                            PasswordHash = "AQAAAAEAACcQAAAAEHXEV2HCDjz7mVo6WFzIKS1rWts0VQwNFiYGj8JnBHlmD3xeqwMBBYvH4RhQITs5qQ==",
                            PhotoPath = "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg",
                            Role = 1,
                            SecurityStamp = "5abcdef"
                        },
                        new
                        {
                            Id = new Guid("b2d6a26e-8cb5-4301-9d6f-6acbd4cdba52"),
                            DateOfBirth = new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "493352@mail.muni.cz",
                            FirstName = "Jitka",
                            IsDeleted = false,
                            IsTrainer = true,
                            LastName = "Viceníková",
                            PasswordHash = "AQAAAAEAACcQAAAAEHXEV2HCDjz7mVo6WFzIKS1rWts0VQwNFiYGj8JnBHlmD3xeqwMBBYvH4RhQITs5qQ==",
                            PhotoPath = "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg",
                            Role = 1,
                            SecurityStamp = "6abcdef"
                        },
                        new
                        {
                            Id = new Guid("2b4f490b-78c6-4d78-8052-14095a47a7dd"),
                            DateOfBirth = new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@sprint.cz",
                            FirstName = "Admin",
                            IsDeleted = false,
                            IsTrainer = true,
                            LastName = "Admin",
                            PasswordHash = "AQAAAAEAACcQAAAAEHXEV2HCDjz7mVo6WFzIKS1rWts0VQwNFiYGj8JnBHlmD3xeqwMBBYvH4RhQITs5qQ==",
                            PhotoPath = "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg",
                            Role = 1,
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
