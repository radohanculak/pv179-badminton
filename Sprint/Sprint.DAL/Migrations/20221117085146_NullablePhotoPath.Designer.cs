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
    [Migration("20221117085146_NullablePhotoPath")]
    partial class NullablePhotoPath
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
                            Id = new Guid("c1af8f98-d28a-4606-bf7d-d58ce5175e79"),
                            CourtNumber = "A",
                            HourlyRate = 1000m
                        },
                        new
                        {
                            Id = new Guid("9e1c3d6b-b08b-41a6-b0ff-483f74291f09"),
                            CourtNumber = "B",
                            HourlyRate = 800m
                        },
                        new
                        {
                            Id = new Guid("d1bb58ce-9fcb-468d-8be3-1d931dcf7086"),
                            CourtNumber = "C",
                            HourlyRate = 800m
                        },
                        new
                        {
                            Id = new Guid("c6238797-61ec-4dfc-a31e-26db0e5db49d"),
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
                            Id = new Guid("a75f3832-36df-48c1-9f9d-d9eacde5881c"),
                            CourtId = new Guid("c1af8f98-d28a-4606-bf7d-d58ce5175e79"),
                            Created = new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 9, 29, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("9cc77071-18f4-4c37-8fb4-f8510a1e8c9d")
                        },
                        new
                        {
                            Id = new Guid("ecbeb3f9-372b-42f3-afcf-c388b354bf02"),
                            CourtId = new Guid("d1bb58ce-9fcb-468d-8be3-1d931dcf7086"),
                            Created = new DateTime(2022, 9, 21, 6, 51, 34, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 9, 30, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 9, 30, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("9cc77071-18f4-4c37-8fb4-f8510a1e8c9d")
                        },
                        new
                        {
                            Id = new Guid("77b86c47-5b62-4a0a-9838-1dd52e46d105"),
                            CourtId = new Guid("d1bb58ce-9fcb-468d-8be3-1d931dcf7086"),
                            Created = new DateTime(2022, 9, 5, 23, 59, 59, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = true,
                            To = new DateTime(2022, 11, 17, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("9cc77071-18f4-4c37-8fb4-f8510a1e8c9d")
                        },
                        new
                        {
                            Id = new Guid("7b208b55-2104-484e-9d3b-dd171e731d9f"),
                            CourtId = new Guid("c1af8f98-d28a-4606-bf7d-d58ce5175e79"),
                            Created = new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 9, 29, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("4f077246-8c57-4856-8c70-bc8c030554ca")
                        },
                        new
                        {
                            Id = new Guid("32d15c84-726d-4233-95ef-5c09ff05f7e4"),
                            CourtId = new Guid("c1af8f98-d28a-4606-bf7d-d58ce5175e79"),
                            Created = new DateTime(2022, 9, 28, 19, 19, 19, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 10, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 10, 1, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("4f077246-8c57-4856-8c70-bc8c030554ca")
                        },
                        new
                        {
                            Id = new Guid("47a0db10-972b-4466-bca2-f9025522d3d4"),
                            CourtId = new Guid("9e1c3d6b-b08b-41a6-b0ff-483f74291f09"),
                            Created = new DateTime(2022, 9, 15, 18, 4, 4, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 9, 16, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 9, 16, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("3ca99934-a42b-430a-bf9b-51c5ae9b88d1")
                        },
                        new
                        {
                            Id = new Guid("0c5b1d2e-b005-439a-88ab-35cf54560a25"),
                            CourtId = new Guid("9e1c3d6b-b08b-41a6-b0ff-483f74291f09"),
                            Created = new DateTime(2022, 9, 16, 9, 53, 34, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 9, 17, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = true,
                            To = new DateTime(2022, 9, 17, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("3ca99934-a42b-430a-bf9b-51c5ae9b88d1")
                        },
                        new
                        {
                            Id = new Guid("c58cface-a29f-45d3-974c-0f0191cbf5c4"),
                            CourtId = new Guid("c6238797-61ec-4dfc-a31e-26db0e5db49d"),
                            Created = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 12, 31, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 12, 31, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("b725f74a-21b4-4887-a22e-93796013f020")
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
                            Id = new Guid("6208ded4-3aa9-47ab-b5b5-72c82239fe20"),
                            Description = "I know how to play, that's all",
                            HourlyRate = 2000m,
                            UserId = new Guid("fa95c41f-e449-46aa-b4f4-61af47c6d6f5")
                        },
                        new
                        {
                            Id = new Guid("36093406-e64b-4b5d-92ff-7cae8c26a418"),
                            Description = "I know how to play even better, that's all",
                            HourlyRate = 3485m,
                            UserId = new Guid("ff690b73-633b-4f41-8413-60afabb15c08")
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
                            Id = new Guid("0b3d1a31-02c3-411a-9a64-ef91374756e0"),
                            Hide = false,
                            Path = "tbd",
                            TrainerId = new Guid("6208ded4-3aa9-47ab-b5b5-72c82239fe20")
                        },
                        new
                        {
                            Id = new Guid("24b3f86e-562d-4244-80c4-16185982eddb"),
                            Hide = false,
                            Path = "tbd",
                            TrainerId = new Guid("6208ded4-3aa9-47ab-b5b5-72c82239fe20")
                        },
                        new
                        {
                            Id = new Guid("0f2ec1ee-0ad2-488a-8955-a37f56f65beb"),
                            Hide = true,
                            Path = "tbd",
                            TrainerId = new Guid("36093406-e64b-4b5d-92ff-7cae8c26a418")
                        },
                        new
                        {
                            Id = new Guid("4d14fadf-2f16-4400-9ead-dcaec82e68ae"),
                            Hide = true,
                            Path = "tbd",
                            TrainerId = new Guid("36093406-e64b-4b5d-92ff-7cae8c26a418")
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
                            Id = new Guid("7d5360d0-9c41-4f02-9a5d-1780d3b60c42"),
                            CourtReservationId = new Guid("0c5b1d2e-b005-439a-88ab-35cf54560a25"),
                            IsDeleted = true,
                            TrainerId = new Guid("6208ded4-3aa9-47ab-b5b5-72c82239fe20")
                        },
                        new
                        {
                            Id = new Guid("480d615b-a7e4-441c-804c-e75d995c812e"),
                            CourtReservationId = new Guid("47a0db10-972b-4466-bca2-f9025522d3d4"),
                            IsDeleted = false,
                            TrainerId = new Guid("6208ded4-3aa9-47ab-b5b5-72c82239fe20")
                        },
                        new
                        {
                            Id = new Guid("bc5d2725-45fa-45b8-adeb-641929929488"),
                            CourtReservationId = new Guid("c58cface-a29f-45d3-974c-0f0191cbf5c4"),
                            IsDeleted = false,
                            TrainerId = new Guid("36093406-e64b-4b5d-92ff-7cae8c26a418"),
                            TrainerReviewId = new Guid("a26c86fa-5f35-40d3-9751-8b7ddd3a101b")
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
                            Id = new Guid("a26c86fa-5f35-40d3-9751-8b7ddd3a101b"),
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
                        .HasColumnType("TEXT");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9cc77071-18f4-4c37-8fb4-f8510a1e8c9d"),
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
                            Id = new Guid("4f077246-8c57-4856-8c70-bc8c030554ca"),
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
                            Id = new Guid("b725f74a-21b4-4887-a22e-93796013f020"),
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
                            Id = new Guid("3ca99934-a42b-430a-bf9b-51c5ae9b88d1"),
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
                            Id = new Guid("fa95c41f-e449-46aa-b4f4-61af47c6d6f5"),
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
                            Id = new Guid("ff690b73-633b-4f41-8413-60afabb15c08"),
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
