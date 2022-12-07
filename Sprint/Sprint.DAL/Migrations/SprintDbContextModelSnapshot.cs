﻿using System;
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

                    b.HasKey("Id");

                    b.ToTable("Courts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4ecb7510-a1e8-4ac4-b033-1d98b1457693"),
                            CourtNumber = "A",
                            HourlyRate = 1000m
                        },
                        new
                        {
                            Id = new Guid("5cad9183-60bb-44b5-99f9-96260f71cc7c"),
                            CourtNumber = "B",
                            HourlyRate = 800m
                        },
                        new
                        {
                            Id = new Guid("948a513c-dcc9-4d31-bfcd-73555429810b"),
                            CourtNumber = "C",
                            HourlyRate = 800m
                        },
                        new
                        {
                            Id = new Guid("c9652d89-d860-45ea-b6c5-feb63f6a94e2"),
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
                            Id = new Guid("eeaee8cf-7579-4d3c-a81d-60e65a25cb3d"),
                            CourtId = new Guid("4ecb7510-a1e8-4ac4-b033-1d98b1457693"),
                            Created = new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 9, 29, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("a71850ce-6719-4ed4-ae31-b20c62a8f931")
                        },
                        new
                        {
                            Id = new Guid("f0ff7ead-2fa7-4b59-aa24-0d6371b8ca70"),
                            CourtId = new Guid("948a513c-dcc9-4d31-bfcd-73555429810b"),
                            Created = new DateTime(2022, 9, 21, 6, 51, 34, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 9, 30, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 9, 30, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("a71850ce-6719-4ed4-ae31-b20c62a8f931")
                        },
                        new
                        {
                            Id = new Guid("1312c777-ab11-46d3-bc8f-deabd7b88ac0"),
                            CourtId = new Guid("948a513c-dcc9-4d31-bfcd-73555429810b"),
                            Created = new DateTime(2022, 9, 5, 23, 59, 59, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = true,
                            To = new DateTime(2022, 11, 17, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("a71850ce-6719-4ed4-ae31-b20c62a8f931")
                        },
                        new
                        {
                            Id = new Guid("f9a96b21-978c-41f6-b859-e6451be08ffb"),
                            CourtId = new Guid("4ecb7510-a1e8-4ac4-b033-1d98b1457693"),
                            Created = new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 9, 29, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("706dce76-bb9d-4ad2-91a4-0e144f824f88")
                        },
                        new
                        {
                            Id = new Guid("3994328e-292b-4505-bee2-e7ee5df55fc5"),
                            CourtId = new Guid("4ecb7510-a1e8-4ac4-b033-1d98b1457693"),
                            Created = new DateTime(2022, 9, 28, 19, 19, 19, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 10, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 10, 1, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("706dce76-bb9d-4ad2-91a4-0e144f824f88")
                        },
                        new
                        {
                            Id = new Guid("4279b61a-9d6f-4091-b042-260f9e138f16"),
                            CourtId = new Guid("5cad9183-60bb-44b5-99f9-96260f71cc7c"),
                            Created = new DateTime(2022, 9, 15, 18, 4, 4, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 9, 16, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 9, 16, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("b69e9a6f-6b23-4d77-b3b6-7390259197f7")
                        },
                        new
                        {
                            Id = new Guid("ca91c6a8-3c2f-4439-952a-8a676efae005"),
                            CourtId = new Guid("5cad9183-60bb-44b5-99f9-96260f71cc7c"),
                            Created = new DateTime(2022, 9, 16, 9, 53, 34, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 9, 17, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = true,
                            To = new DateTime(2022, 9, 17, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("b69e9a6f-6b23-4d77-b3b6-7390259197f7")
                        },
                        new
                        {
                            Id = new Guid("77bad34a-2689-4745-8464-98e325922256"),
                            CourtId = new Guid("c9652d89-d860-45ea-b6c5-feb63f6a94e2"),
                            Created = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            From = new DateTime(2022, 12, 31, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            To = new DateTime(2022, 12, 31, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("6c804cbf-85b0-43e0-894b-a70ebf50dbee")
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
                            Id = new Guid("12947f7a-a38b-4636-b3c7-1e878f09577e"),
                            Description = "I know how to play, that's all",
                            HourlyRate = 2000m,
                            UserId = new Guid("01b7e1f2-53f3-4708-b30c-e0474cc3a004")
                        },
                        new
                        {
                            Id = new Guid("b7b260c8-bdad-4fe0-8fc0-01949318e999"),
                            Description = "I know how to play even better, that's all",
                            HourlyRate = 3485m,
                            UserId = new Guid("766d4249-db85-4c9c-a275-f43dbd67869e")
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
                            Id = new Guid("452b0f52-9c3d-4af4-9e12-3eb3e7406973"),
                            Hide = false,
                            Path = "tbd",
                            TrainerId = new Guid("12947f7a-a38b-4636-b3c7-1e878f09577e")
                        },
                        new
                        {
                            Id = new Guid("b88c5cd2-c268-406d-a864-daad8025d6a3"),
                            Hide = false,
                            Path = "tbd",
                            TrainerId = new Guid("12947f7a-a38b-4636-b3c7-1e878f09577e")
                        },
                        new
                        {
                            Id = new Guid("229b95f8-89e0-4b64-8e7d-9150374fd016"),
                            Hide = true,
                            Path = "tbd",
                            TrainerId = new Guid("b7b260c8-bdad-4fe0-8fc0-01949318e999")
                        },
                        new
                        {
                            Id = new Guid("bdfcf2e1-2865-4afb-a912-691224eed780"),
                            Hide = true,
                            Path = "tbd",
                            TrainerId = new Guid("b7b260c8-bdad-4fe0-8fc0-01949318e999")
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
                            Id = new Guid("7d211be3-b1d4-4c01-ac1e-b0097208c288"),
                            CourtReservationId = new Guid("ca91c6a8-3c2f-4439-952a-8a676efae005"),
                            IsDeleted = true,
                            TrainerId = new Guid("12947f7a-a38b-4636-b3c7-1e878f09577e")
                        },
                        new
                        {
                            Id = new Guid("1eeb76fe-1a07-49a2-8c26-3d69184468ea"),
                            CourtReservationId = new Guid("4279b61a-9d6f-4091-b042-260f9e138f16"),
                            IsDeleted = false,
                            TrainerId = new Guid("12947f7a-a38b-4636-b3c7-1e878f09577e")
                        },
                        new
                        {
                            Id = new Guid("e03a2ec7-1274-45cf-b05b-572ce60eca7d"),
                            CourtReservationId = new Guid("77bad34a-2689-4745-8464-98e325922256"),
                            IsDeleted = false,
                            TrainerId = new Guid("b7b260c8-bdad-4fe0-8fc0-01949318e999")
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

                    b.Property<Guid>("ReservationId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId");

                    b.ToTable("TrainerReviews");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bc9972fd-67b2-4835-95f2-e2ea1a078b0f"),
                            Hide = false,
                            Rating = 5,
                            ReservationId = new Guid("e03a2ec7-1274-45cf-b05b-572ce60eca7d"),
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

                    b.Property<string>("SecurityStamp")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a71850ce-6719-4ed4-ae31-b20c62a8f931"),
                            DateOfBirth = new DateTime(2001, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "514329@mail.muni.cz",
                            FirstName = "Adam",
                            IsTrainer = false,
                            LastName = "Mydla",
                            PasswordHash = "tbd",
                            PhotoPath = "tbd",
                            Role = 0,
                            SecurityStamp = "1abcdef"
                        },
                        new
                        {
                            Id = new Guid("706dce76-bb9d-4ad2-91a4-0e144f824f88"),
                            DateOfBirth = new DateTime(1995, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "pppeter@nonexistentmail.com",
                            FirstName = "Peter",
                            IsTrainer = false,
                            LastName = "Griffin",
                            PasswordHash = "tbd",
                            PhotoPath = "tbd",
                            Role = 0,
                            SecurityStamp = "2abcdef"
                        },
                        new
                        {
                            Id = new Guid("6c804cbf-85b0-43e0-894b-a70ebf50dbee"),
                            DateOfBirth = new DateTime(1955, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "monic@nonexistentmail.com",
                            FirstName = "Monica",
                            IsTrainer = false,
                            LastName = "Bellucci",
                            PasswordHash = "tbd",
                            PhotoPath = "tbd",
                            Role = 0,
                            SecurityStamp = "4abcdef"
                        },
                        new
                        {
                            Id = new Guid("b69e9a6f-6b23-4d77-b3b6-7390259197f7"),
                            DateOfBirth = new DateTime(1993, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "rntr@nonexistentmail.com",
                            FirstName = "Roman",
                            IsTrainer = false,
                            LastName = "NieTenRoman",
                            PasswordHash = "tbd",
                            PhotoPath = "tbd",
                            Role = 0,
                            SecurityStamp = "3abcdef"
                        },
                        new
                        {
                            Id = new Guid("01b7e1f2-53f3-4708-b30c-e0474cc3a004"),
                            DateOfBirth = new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "rhanculak@mail.muni.cz",
                            FirstName = "Radovan",
                            IsTrainer = true,
                            LastName = "Hančuľák",
                            PasswordHash = "tbd",
                            PhotoPath = "tbd",
                            Role = 0,
                            SecurityStamp = "5abcdef"
                        },
                        new
                        {
                            Id = new Guid("766d4249-db85-4c9c-a275-f43dbd67869e"),
                            DateOfBirth = new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "493352@mail.muni.cz",
                            FirstName = "Jitka",
                            IsTrainer = true,
                            LastName = "Viceníková",
                            PasswordHash = "tbd",
                            PhotoPath = "tbd",
                            Role = 0,
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

                    b.HasOne("Sprint.DAL.EFCore.Models.TrainerReview", "TrainerReview")
                        .WithMany()
                        .HasForeignKey("TrainerReviewId");

                    b.Navigation("CourtReservation");

                    b.Navigation("Trainer");

                    b.Navigation("TrainerReview");
                });

            modelBuilder.Entity("Sprint.DAL.EFCore.Models.TrainerReview", b =>
                {
                    b.HasOne("Sprint.DAL.EFCore.Models.TrainerReservation", "Reservation")
                        .WithMany()
                        .HasForeignKey("ReservationId")
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

            modelBuilder.Entity("Sprint.DAL.EFCore.Models.User", b =>
                {
                    b.Navigation("CourtReservations");

                    b.Navigation("Trainer");
                });
#pragma warning restore 612, 618
        }
    }
}
