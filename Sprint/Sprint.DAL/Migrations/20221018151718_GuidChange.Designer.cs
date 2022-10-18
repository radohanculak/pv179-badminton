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
    [Migration("20221018151718_GuidChange")]
    partial class GuidChange
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("Sprint.DAL.Models.Court", b =>
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
                            Id = new Guid("307d4080-7dba-4567-b359-f0222341e3a7"),
                            CourtNumber = "A",
                            HourlyRate = 1000m
                        },
                        new
                        {
                            Id = new Guid("c7c1a907-8d7e-4ece-a63d-a4ad9f464a9d"),
                            CourtNumber = "B",
                            HourlyRate = 800m
                        },
                        new
                        {
                            Id = new Guid("ce384bc6-9139-4ccc-9716-3ddbfce01022"),
                            CourtNumber = "C",
                            HourlyRate = 800m
                        },
                        new
                        {
                            Id = new Guid("a5cc0b56-fc9b-43c2-9278-957b8380451c"),
                            CourtNumber = "D",
                            HourlyRate = 500m
                        });
                });

            modelBuilder.Entity("Sprint.DAL.Models.CourtReservation", b =>
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
                            Id = new Guid("502530e5-7d30-43ac-a53c-8bb8b15d3ff5"),
                            CourtId = new Guid("307d4080-7dba-4567-b359-f0222341e3a7"),
                            Created = new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 9, 29, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("77237c69-7a31-4777-993b-477183f3541e")
                        },
                        new
                        {
                            Id = new Guid("a5ec885d-9c2a-4ad3-bbf0-af602fcd6943"),
                            CourtId = new Guid("ce384bc6-9139-4ccc-9716-3ddbfce01022"),
                            Created = new DateTime(2022, 9, 21, 6, 51, 34, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 9, 30, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 9, 30, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("77237c69-7a31-4777-993b-477183f3541e")
                        },
                        new
                        {
                            Id = new Guid("32af9051-c940-4777-b340-a706590f4dc5"),
                            CourtId = new Guid("ce384bc6-9139-4ccc-9716-3ddbfce01022"),
                            Created = new DateTime(2022, 9, 5, 23, 59, 59, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = true,
                            To = new DateTime(2022, 11, 17, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("77237c69-7a31-4777-993b-477183f3541e")
                        },
                        new
                        {
                            Id = new Guid("e290db1a-37a7-428a-9062-ed93b330c7b8"),
                            CourtId = new Guid("307d4080-7dba-4567-b359-f0222341e3a7"),
                            Created = new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 9, 29, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("aa480908-5712-4dab-a843-c9150dbe5870")
                        },
                        new
                        {
                            Id = new Guid("a3ace0c7-0dbb-46f7-99c1-8c655b0d3d59"),
                            CourtId = new Guid("307d4080-7dba-4567-b359-f0222341e3a7"),
                            Created = new DateTime(2022, 9, 28, 19, 19, 19, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 10, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 10, 1, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("aa480908-5712-4dab-a843-c9150dbe5870")
                        },
                        new
                        {
                            Id = new Guid("98c6e6ed-d4f0-4b58-a580-9b4144e55e97"),
                            CourtId = new Guid("c7c1a907-8d7e-4ece-a63d-a4ad9f464a9d"),
                            Created = new DateTime(2022, 9, 15, 18, 4, 4, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 9, 16, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 9, 16, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("9051a943-c1d9-4e4b-80d4-b169947c3f50")
                        },
                        new
                        {
                            Id = new Guid("3d9a3f7f-851d-42a8-850d-9a467b15babc"),
                            CourtId = new Guid("c7c1a907-8d7e-4ece-a63d-a4ad9f464a9d"),
                            Created = new DateTime(2022, 9, 16, 9, 53, 34, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 9, 17, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = true,
                            To = new DateTime(2022, 9, 17, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("9051a943-c1d9-4e4b-80d4-b169947c3f50")
                        },
                        new
                        {
                            Id = new Guid("abfc6696-9eed-4703-8b4d-9c34eec7795a"),
                            CourtId = new Guid("a5cc0b56-fc9b-43c2-9278-957b8380451c"),
                            Created = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 12, 31, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 12, 31, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("81ca6b64-6721-4c1e-ba7d-a2198b7e0e50")
                        });
                });

            modelBuilder.Entity("Sprint.DAL.Models.Trainer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("HourlyRate")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Trainers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("45d75ad8-10f0-4e66-8212-783bafe50d16"),
                            Description = "I know how to play, that's all",
                            Email = "rhanculak@mail.muni.cz",
                            FirstName = "Radovan",
                            HourlyRate = 2000m,
                            LastName = "Hančuľák",
                            PasswordHash = "tbd"
                        },
                        new
                        {
                            Id = new Guid("2aa44892-ba41-40fd-b058-2cfad3ea9644"),
                            Description = "I know how to play even better, that's all",
                            Email = "493352@mail.muni.cz",
                            FirstName = "Jitka",
                            HourlyRate = 3485m,
                            LastName = "Viceníková",
                            PasswordHash = "tbd"
                        });
                });

            modelBuilder.Entity("Sprint.DAL.Models.TrainerPhoto", b =>
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
                            Id = new Guid("270df941-caff-4073-a04f-4c15e33d7b51"),
                            Hide = false,
                            Path = "tbd",
                            TrainerId = new Guid("45d75ad8-10f0-4e66-8212-783bafe50d16")
                        },
                        new
                        {
                            Id = new Guid("eca699b6-fd97-40e5-a4f5-21ab5ebad248"),
                            Hide = false,
                            Path = "tbd",
                            TrainerId = new Guid("45d75ad8-10f0-4e66-8212-783bafe50d16")
                        },
                        new
                        {
                            Id = new Guid("8518a4ac-00a5-4350-8322-125ce5beaa35"),
                            Hide = true,
                            Path = "tbd",
                            TrainerId = new Guid("2aa44892-ba41-40fd-b058-2cfad3ea9644")
                        },
                        new
                        {
                            Id = new Guid("e30979b2-0802-4067-a034-60739a5429fc"),
                            Hide = true,
                            Path = "tbd",
                            TrainerId = new Guid("2aa44892-ba41-40fd-b058-2cfad3ea9644")
                        });
                });

            modelBuilder.Entity("Sprint.DAL.Models.TrainerReservation", b =>
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
                            Id = new Guid("a6ebf392-bb1e-4d36-ac28-d64c40a4f87a"),
                            CourtReservationId = new Guid("3d9a3f7f-851d-42a8-850d-9a467b15babc"),
                            IsDeleted = true,
                            TrainerId = new Guid("45d75ad8-10f0-4e66-8212-783bafe50d16")
                        },
                        new
                        {
                            Id = new Guid("6caa3663-590d-4dea-be23-8aa7ca7ba8ca"),
                            CourtReservationId = new Guid("98c6e6ed-d4f0-4b58-a580-9b4144e55e97"),
                            IsDeleted = false,
                            TrainerId = new Guid("45d75ad8-10f0-4e66-8212-783bafe50d16")
                        },
                        new
                        {
                            Id = new Guid("5a97a3e8-1255-4746-a292-8e8110359051"),
                            CourtReservationId = new Guid("abfc6696-9eed-4703-8b4d-9c34eec7795a"),
                            IsDeleted = false,
                            TrainerId = new Guid("2aa44892-ba41-40fd-b058-2cfad3ea9644"),
                            TrainerReviewId = new Guid("102cbf9f-80e4-4ac5-ba89-6a5da6dce1f1")
                        });
                });

            modelBuilder.Entity("Sprint.DAL.Models.TrainerReview", b =>
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
                            Id = new Guid("102cbf9f-80e4-4ac5-ba89-6a5da6dce1f1"),
                            Hide = false,
                            Rating = 5,
                            Text = "tbd"
                        });
                });

            modelBuilder.Entity("Sprint.DAL.Models.User", b =>
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

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("77237c69-7a31-4777-993b-477183f3541e"),
                            DateOfBirth = new DateTime(2001, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "514329@mail.muni.cz",
                            FirstName = "Adam",
                            LastName = "Mydla",
                            PasswordHash = "tbd",
                            PhotoPath = "tbd"
                        },
                        new
                        {
                            Id = new Guid("aa480908-5712-4dab-a843-c9150dbe5870"),
                            DateOfBirth = new DateTime(1995, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "pppeter@nonexistentmail.com",
                            FirstName = "Peter",
                            LastName = "Griffin",
                            PasswordHash = "tbd",
                            PhotoPath = "tbd"
                        },
                        new
                        {
                            Id = new Guid("81ca6b64-6721-4c1e-ba7d-a2198b7e0e50"),
                            DateOfBirth = new DateTime(1955, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "monic@nonexistentmail.com",
                            FirstName = "Monica",
                            LastName = "Bellucci",
                            PasswordHash = "tbd",
                            PhotoPath = "tbd"
                        },
                        new
                        {
                            Id = new Guid("9051a943-c1d9-4e4b-80d4-b169947c3f50"),
                            DateOfBirth = new DateTime(1993, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "rntr@nonexistentmail.com",
                            FirstName = "Roman",
                            LastName = "NieTenRoman",
                            PasswordHash = "tbd",
                            PhotoPath = "tbd"
                        });
                });

            modelBuilder.Entity("Sprint.DAL.Models.CourtReservation", b =>
                {
                    b.HasOne("Sprint.DAL.Models.Court", "Court")
                        .WithMany("Reservations")
                        .HasForeignKey("CourtId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sprint.DAL.Models.User", "User")
                        .WithMany("CourtReservations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Court");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Sprint.DAL.Models.TrainerPhoto", b =>
                {
                    b.HasOne("Sprint.DAL.Models.Trainer", "Trainer")
                        .WithMany("Photos")
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("Sprint.DAL.Models.TrainerReservation", b =>
                {
                    b.HasOne("Sprint.DAL.Models.CourtReservation", "CourtReservation")
                        .WithOne("TrainerReservation")
                        .HasForeignKey("Sprint.DAL.Models.TrainerReservation", "CourtReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sprint.DAL.Models.Trainer", "Trainer")
                        .WithMany("Reservations")
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sprint.DAL.Models.TrainerReview", "TrainerReview")
                        .WithMany()
                        .HasForeignKey("TrainerReviewId");

                    b.Navigation("CourtReservation");

                    b.Navigation("Trainer");

                    b.Navigation("TrainerReview");
                });

            modelBuilder.Entity("Sprint.DAL.Models.Court", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Sprint.DAL.Models.CourtReservation", b =>
                {
                    b.Navigation("TrainerReservation")
                        .IsRequired();
                });

            modelBuilder.Entity("Sprint.DAL.Models.Trainer", b =>
                {
                    b.Navigation("Photos");

                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Sprint.DAL.Models.User", b =>
                {
                    b.Navigation("CourtReservations");
                });
#pragma warning restore 612, 618
        }
    }
}