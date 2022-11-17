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
    [Migration("20221116165738_AddUserRole")]
    partial class AddUserRole
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

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

                    b.HasKey("Id");

                    b.ToTable("Courts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f26f4994-d745-46e1-9490-ca92a2b06fef"),
                            CourtNumber = "A",
                            HourlyRate = 1000m
                        },
                        new
                        {
                            Id = new Guid("dd9296d4-44c3-4062-a1da-07c41f01e4ba"),
                            CourtNumber = "B",
                            HourlyRate = 800m
                        },
                        new
                        {
                            Id = new Guid("1bd0d071-c2c4-4016-9b69-bbc132a15102"),
                            CourtNumber = "C",
                            HourlyRate = 800m
                        },
                        new
                        {
                            Id = new Guid("5ad00c60-d894-4f3b-b008-3189de1e65a6"),
                            CourtNumber = "D",
                            HourlyRate = 500m
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
                            Id = new Guid("6a2616f4-b04b-4518-b6ac-2afe83f1ccf4"),
                            CourtId = new Guid("f26f4994-d745-46e1-9490-ca92a2b06fef"),
                            Created = new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 9, 29, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("22d00d08-346f-4b2f-bcb1-9e0b8f111473")
                        },
                        new
                        {
                            Id = new Guid("52e368cf-700a-412e-b461-ffe67fa2f0c0"),
                            CourtId = new Guid("1bd0d071-c2c4-4016-9b69-bbc132a15102"),
                            Created = new DateTime(2022, 9, 21, 6, 51, 34, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 9, 30, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 9, 30, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("22d00d08-346f-4b2f-bcb1-9e0b8f111473")
                        },
                        new
                        {
                            Id = new Guid("630c4627-ba8e-4df5-80d6-6806dc84a6d3"),
                            CourtId = new Guid("1bd0d071-c2c4-4016-9b69-bbc132a15102"),
                            Created = new DateTime(2022, 9, 5, 23, 59, 59, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = true,
                            To = new DateTime(2022, 11, 17, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("22d00d08-346f-4b2f-bcb1-9e0b8f111473")
                        },
                        new
                        {
                            Id = new Guid("049522ad-16e0-4f6f-b485-8f41629a672f"),
                            CourtId = new Guid("f26f4994-d745-46e1-9490-ca92a2b06fef"),
                            Created = new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 9, 29, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("55c262c7-b0ad-4ba2-8e1d-0cd55960bbbb")
                        },
                        new
                        {
                            Id = new Guid("f50cdc59-d9c8-4eb3-b43b-bd67fcf80120"),
                            CourtId = new Guid("f26f4994-d745-46e1-9490-ca92a2b06fef"),
                            Created = new DateTime(2022, 9, 28, 19, 19, 19, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 10, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 10, 1, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("55c262c7-b0ad-4ba2-8e1d-0cd55960bbbb")
                        },
                        new
                        {
                            Id = new Guid("8817d241-03ee-42ff-b570-43b67320eddb"),
                            CourtId = new Guid("dd9296d4-44c3-4062-a1da-07c41f01e4ba"),
                            Created = new DateTime(2022, 9, 15, 18, 4, 4, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 9, 16, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 9, 16, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("4dd5b0aa-de5d-48f8-9077-08cbe759adc7")
                        },
                        new
                        {
                            Id = new Guid("238463f3-38f6-446d-ac72-75e4ece5c33e"),
                            CourtId = new Guid("dd9296d4-44c3-4062-a1da-07c41f01e4ba"),
                            Created = new DateTime(2022, 9, 16, 9, 53, 34, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 9, 17, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = true,
                            To = new DateTime(2022, 9, 17, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("4dd5b0aa-de5d-48f8-9077-08cbe759adc7")
                        },
                        new
                        {
                            Id = new Guid("068fac4a-34d5-40a2-a9c0-a43d02a004cc"),
                            CourtId = new Guid("5ad00c60-d894-4f3b-b008-3189de1e65a6"),
                            Created = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 12, 31, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 12, 31, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("0e1d88b0-e364-426e-8936-99098e5b5615")
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

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Trainers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d62d13ee-250a-4269-ade2-5170a2e00dee"),
                            Description = "I know how to play, that's all",
                            HourlyRate = 2000m,
                            UserId = new Guid("6fb59675-4eef-4975-bbbc-542ee80eddd1")
                        },
                        new
                        {
                            Id = new Guid("37e681f2-085b-4fd6-8b4b-f3d4a4575027"),
                            Description = "I know how to play even better, that's all",
                            HourlyRate = 3485m,
                            UserId = new Guid("75059c6a-a984-478a-97dc-f4a8284349e8")
                        });
                });

            modelBuilder.Entity("Sprint.DAL.EFCore.Models.TrainerPhoto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Hide")
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
                            Id = new Guid("6cd74a00-be41-4da6-9347-bcb30825571d"),
                            Hide = false,
                            Path = "tbd",
                            TrainerId = new Guid("d62d13ee-250a-4269-ade2-5170a2e00dee")
                        },
                        new
                        {
                            Id = new Guid("3add0837-1d31-41e8-a1b3-06f3d4db00d2"),
                            Hide = false,
                            Path = "tbd",
                            TrainerId = new Guid("d62d13ee-250a-4269-ade2-5170a2e00dee")
                        },
                        new
                        {
                            Id = new Guid("27f453ea-3b8e-49ce-96d7-a3c27bb9222e"),
                            Hide = true,
                            Path = "tbd",
                            TrainerId = new Guid("37e681f2-085b-4fd6-8b4b-f3d4a4575027")
                        },
                        new
                        {
                            Id = new Guid("5f65ada2-57d3-4b87-bf59-b54114882c38"),
                            Hide = true,
                            Path = "tbd",
                            TrainerId = new Guid("37e681f2-085b-4fd6-8b4b-f3d4a4575027")
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

                    b.Property<Guid?>("TrainerReviewId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CourtReservationId")
                        .IsUnique();

                    b.HasIndex("TrainerId");

                    b.HasIndex("TrainerReviewId");

                    b.ToTable("TrainerReservations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("af3f766e-6fe5-4be1-864c-db6936f5908e"),
                            CourtReservationId = new Guid("238463f3-38f6-446d-ac72-75e4ece5c33e"),
                            IsDeleted = true,
                            TrainerId = new Guid("d62d13ee-250a-4269-ade2-5170a2e00dee")
                        },
                        new
                        {
                            Id = new Guid("4efa2767-2e5f-4b4d-a099-ec1744de7a94"),
                            CourtReservationId = new Guid("8817d241-03ee-42ff-b570-43b67320eddb"),
                            IsDeleted = false,
                            TrainerId = new Guid("d62d13ee-250a-4269-ade2-5170a2e00dee")
                        },
                        new
                        {
                            Id = new Guid("8d2830a9-6316-4abe-8fdd-10afddc0d4fe"),
                            CourtReservationId = new Guid("068fac4a-34d5-40a2-a9c0-a43d02a004cc"),
                            IsDeleted = false,
                            TrainerId = new Guid("37e681f2-085b-4fd6-8b4b-f3d4a4575027"),
                            TrainerReviewId = new Guid("2f048d4a-9a45-41af-94aa-f68ce994d8b5")
                        });
                });

            modelBuilder.Entity("Sprint.DAL.EFCore.Models.TrainerReview", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Hide")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Rating")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TrainerReviews");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2f048d4a-9a45-41af-94aa-f68ce994d8b5"),
                            Hide = false,
                            Rating = 5,
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

                    b.Property<bool>("IsTrainer")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("22d00d08-346f-4b2f-bcb1-9e0b8f111473"),
                            DateOfBirth = new DateTime(2001, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "514329@mail.muni.cz",
                            FirstName = "Adam",
                            IsTrainer = false,
                            LastName = "Mydla",
                            PasswordHash = "tbd",
                            PhotoPath = "tbd",
                            Role = 0
                        },
                        new
                        {
                            Id = new Guid("55c262c7-b0ad-4ba2-8e1d-0cd55960bbbb"),
                            DateOfBirth = new DateTime(1995, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "pppeter@nonexistentmail.com",
                            FirstName = "Peter",
                            IsTrainer = false,
                            LastName = "Griffin",
                            PasswordHash = "tbd",
                            PhotoPath = "tbd",
                            Role = 0
                        },
                        new
                        {
                            Id = new Guid("0e1d88b0-e364-426e-8936-99098e5b5615"),
                            DateOfBirth = new DateTime(1955, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "monic@nonexistentmail.com",
                            FirstName = "Monica",
                            IsTrainer = false,
                            LastName = "Bellucci",
                            PasswordHash = "tbd",
                            PhotoPath = "tbd",
                            Role = 0
                        },
                        new
                        {
                            Id = new Guid("4dd5b0aa-de5d-48f8-9077-08cbe759adc7"),
                            DateOfBirth = new DateTime(1993, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "rntr@nonexistentmail.com",
                            FirstName = "Roman",
                            IsTrainer = false,
                            LastName = "NieTenRoman",
                            PasswordHash = "tbd",
                            PhotoPath = "tbd",
                            Role = 0
                        },
                        new
                        {
                            Id = new Guid("6fb59675-4eef-4975-bbbc-542ee80eddd1"),
                            DateOfBirth = new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "rhanculak@mail.muni.cz",
                            FirstName = "Radovan",
                            IsTrainer = true,
                            LastName = "Hančuľák",
                            PasswordHash = "tbd",
                            PhotoPath = "tbd",
                            Role = 0
                        },
                        new
                        {
                            Id = new Guid("75059c6a-a984-478a-97dc-f4a8284349e8"),
                            DateOfBirth = new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "493352@mail.muni.cz",
                            FirstName = "Jitka",
                            IsTrainer = true,
                            LastName = "Viceníková",
                            PasswordHash = "tbd",
                            PhotoPath = "tbd",
                            Role = 0
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

                    b.HasOne("Sprint.DAL.EFCore.Models.TrainerReview", "TrainerReview")
                        .WithMany()
                        .HasForeignKey("TrainerReviewId");

                    b.Navigation("CourtReservation");

                    b.Navigation("Trainer");

                    b.Navigation("TrainerReview");
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

            modelBuilder.Entity("Sprint.DAL.EFCore.Models.User", b =>
                {
                    b.Navigation("CourtReservations");

                    b.Navigation("Trainer");
                });
#pragma warning restore 612, 618
        }
    }
}