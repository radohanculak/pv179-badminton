using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sprint.DAL.EFCore.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    HourlyRate = table.Column<decimal>(type: "TEXT", nullable: false),
                    CourtNumber = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainerReviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Rating = table.Column<int>(type: "INTEGER", nullable: false),
                    Text = table.Column<string>(type: "TEXT", nullable: false),
                    Hide = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainerReviews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PhotoPath = table.Column<string>(type: "TEXT", nullable: false),
                    IsTrainer = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourtReservations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    From = table.Column<DateTime>(type: "TEXT", nullable: false),
                    To = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CourtId = table.Column<Guid>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourtReservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourtReservations_Courts_CourtId",
                        column: x => x.CourtId,
                        principalTable: "Courts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourtReservations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trainers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    HourlyRate = table.Column<decimal>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trainers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainerPhotos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Path = table.Column<string>(type: "TEXT", nullable: false),
                    Hide = table.Column<bool>(type: "INTEGER", nullable: false),
                    TrainerId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainerPhotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainerPhotos_Trainers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "Trainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainerReservations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CourtReservationId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TrainerId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TrainerReviewId = table.Column<Guid>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainerReservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainerReservations_CourtReservations_CourtReservationId",
                        column: x => x.CourtReservationId,
                        principalTable: "CourtReservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainerReservations_TrainerReviews_TrainerReviewId",
                        column: x => x.TrainerReviewId,
                        principalTable: "TrainerReviews",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TrainerReservations_Trainers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "Trainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate" },
                values: new object[] { new Guid("9a51e515-9bed-41b0-a02d-f53170a2cd62"), "D", 500m });

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate" },
                values: new object[] { new Guid("b7a69cd7-c564-410f-94fa-39cc9e9d00af"), "A", 1000m });

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate" },
                values: new object[] { new Guid("bae019c3-ef45-4abd-a111-6d8449fd8dfa"), "C", 800m });

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate" },
                values: new object[] { new Guid("e7c08187-122e-4a22-802e-13401fac8ff8"), "B", 800m });

            migrationBuilder.InsertData(
                table: "TrainerReviews",
                columns: new[] { "Id", "Hide", "Rating", "Text" },
                values: new object[] { new Guid("60ab8e97-4a30-431f-ba74-eecc137dc341"), false, 5, "tbd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "IsTrainer", "LastName", "PasswordHash", "PhotoPath" },
                values: new object[] { new Guid("51dbded9-758f-46d6-b3a9-560a97d3674c"), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "rhanculak@mail.muni.cz", "Radovan", true, "Hančuľák", "tbd", "tbd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "IsTrainer", "LastName", "PasswordHash", "PhotoPath" },
                values: new object[] { new Guid("b428940e-c009-4ca9-8408-675c22e23a87"), new DateTime(2001, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "514329@mail.muni.cz", "Adam", false, "Mydla", "tbd", "tbd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "IsTrainer", "LastName", "PasswordHash", "PhotoPath" },
                values: new object[] { new Guid("b4d94aa2-7aa5-48eb-b5da-67c1f771cc3f"), new DateTime(1993, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "rntr@nonexistentmail.com", "Roman", false, "NieTenRoman", "tbd", "tbd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "IsTrainer", "LastName", "PasswordHash", "PhotoPath" },
                values: new object[] { new Guid("c4864536-bf24-4102-8dd8-ab0ef0930bd3"), new DateTime(1955, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "monic@nonexistentmail.com", "Monica", false, "Bellucci", "tbd", "tbd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "IsTrainer", "LastName", "PasswordHash", "PhotoPath" },
                values: new object[] { new Guid("d278f3c0-7c21-4f22-a964-54d085730861"), new DateTime(1995, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "pppeter@nonexistentmail.com", "Peter", false, "Griffin", "tbd", "tbd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "IsTrainer", "LastName", "PasswordHash", "PhotoPath" },
                values: new object[] { new Guid("e3647ea9-54ef-4097-94f7-32aa103b81f9"), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "493352@mail.muni.cz", "Jitka", true, "Viceníková", "tbd", "tbd" });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("0ccf4f68-d3e5-4c64-b0c4-67e3dfe6bcdb"), new Guid("b7a69cd7-c564-410f-94fa-39cc9e9d00af"), new DateTime(2022, 9, 28, 19, 19, 19, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d278f3c0-7c21-4f22-a964-54d085730861") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("1cc5f600-ad4e-40cc-91d4-280c4ef181c1"), new Guid("b7a69cd7-c564-410f-94fa-39cc9e9d00af"), new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d278f3c0-7c21-4f22-a964-54d085730861") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("1cc89e12-e401-40e5-baa3-00e82eda6e74"), new Guid("e7c08187-122e-4a22-802e-13401fac8ff8"), new DateTime(2022, 9, 15, 18, 4, 4, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b4d94aa2-7aa5-48eb-b5da-67c1f771cc3f") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("50829779-143f-4345-be89-98f6512f3b70"), new Guid("e7c08187-122e-4a22-802e-13401fac8ff8"), new DateTime(2022, 9, 16, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 9, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b4d94aa2-7aa5-48eb-b5da-67c1f771cc3f") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("5975adb7-d979-4d85-bbee-f586887c581c"), new Guid("bae019c3-ef45-4abd-a111-6d8449fd8dfa"), new DateTime(2022, 9, 5, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b428940e-c009-4ca9-8408-675c22e23a87") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("c49b9798-5ea0-41c0-9858-4870f8df193c"), new Guid("b7a69cd7-c564-410f-94fa-39cc9e9d00af"), new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b428940e-c009-4ca9-8408-675c22e23a87") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("d392a4b4-c1cd-4f8a-ba56-f8012e015d82"), new Guid("bae019c3-ef45-4abd-a111-6d8449fd8dfa"), new DateTime(2022, 9, 21, 6, 51, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b428940e-c009-4ca9-8408-675c22e23a87") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("e180d699-31e4-47fa-860f-1ce54bee5103"), new Guid("9a51e515-9bed-41b0-a02d-f53170a2cd62"), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 12, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c4864536-bf24-4102-8dd8-ab0ef0930bd3") });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Description", "HourlyRate", "UserId" },
                values: new object[] { new Guid("47d7ace3-2d3a-4e92-8bfb-abc034ebaffc"), "I know how to play even better, that's all", 3485m, new Guid("e3647ea9-54ef-4097-94f7-32aa103b81f9") });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Description", "HourlyRate", "UserId" },
                values: new object[] { new Guid("c227d056-ef37-4d5f-a7e2-cf7caeb772de"), "I know how to play, that's all", 2000m, new Guid("51dbded9-758f-46d6-b3a9-560a97d3674c") });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[] { new Guid("005eac6c-0982-4c04-9d66-f097af243ed3"), false, "tbd", new Guid("c227d056-ef37-4d5f-a7e2-cf7caeb772de") });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[] { new Guid("17e0dbde-d14e-4637-9939-c2712dc5f6b4"), true, "tbd", new Guid("47d7ace3-2d3a-4e92-8bfb-abc034ebaffc") });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[] { new Guid("aad6876c-1812-4ecb-b3f5-f9a0798d2158"), true, "tbd", new Guid("47d7ace3-2d3a-4e92-8bfb-abc034ebaffc") });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[] { new Guid("f7b12257-4c83-4cdb-97c0-3ddc5d3b3acd"), false, "tbd", new Guid("c227d056-ef37-4d5f-a7e2-cf7caeb772de") });

            migrationBuilder.InsertData(
                table: "TrainerReservations",
                columns: new[] { "Id", "CourtReservationId", "IsDeleted", "TrainerId", "TrainerReviewId" },
                values: new object[] { new Guid("58061a53-b2ac-49f2-9c6f-698da6707709"), new Guid("1cc89e12-e401-40e5-baa3-00e82eda6e74"), false, new Guid("c227d056-ef37-4d5f-a7e2-cf7caeb772de"), null });

            migrationBuilder.InsertData(
                table: "TrainerReservations",
                columns: new[] { "Id", "CourtReservationId", "IsDeleted", "TrainerId", "TrainerReviewId" },
                values: new object[] { new Guid("6ac9ebdc-d9cc-494f-8d4a-1a673d888eb1"), new Guid("e180d699-31e4-47fa-860f-1ce54bee5103"), false, new Guid("47d7ace3-2d3a-4e92-8bfb-abc034ebaffc"), new Guid("60ab8e97-4a30-431f-ba74-eecc137dc341") });

            migrationBuilder.InsertData(
                table: "TrainerReservations",
                columns: new[] { "Id", "CourtReservationId", "IsDeleted", "TrainerId", "TrainerReviewId" },
                values: new object[] { new Guid("a4085a59-22ba-4329-baa7-083c580cac30"), new Guid("50829779-143f-4345-be89-98f6512f3b70"), true, new Guid("c227d056-ef37-4d5f-a7e2-cf7caeb772de"), null });

            migrationBuilder.CreateIndex(
                name: "IX_CourtReservations_CourtId",
                table: "CourtReservations",
                column: "CourtId");

            migrationBuilder.CreateIndex(
                name: "IX_CourtReservations_UserId",
                table: "CourtReservations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainerPhotos_TrainerId",
                table: "TrainerPhotos",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainerReservations_CourtReservationId",
                table: "TrainerReservations",
                column: "CourtReservationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TrainerReservations_TrainerId",
                table: "TrainerReservations",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainerReservations_TrainerReviewId",
                table: "TrainerReservations",
                column: "TrainerReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainers_UserId",
                table: "Trainers",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrainerPhotos");

            migrationBuilder.DropTable(
                name: "TrainerReservations");

            migrationBuilder.DropTable(
                name: "CourtReservations");

            migrationBuilder.DropTable(
                name: "TrainerReviews");

            migrationBuilder.DropTable(
                name: "Trainers");

            migrationBuilder.DropTable(
                name: "Courts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
