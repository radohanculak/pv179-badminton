using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sprint.DAL.EFCore.Migrations
{
    public partial class GuidChange : Migration
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
                name: "Trainers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: false),
                    HourlyRate = table.Column<decimal>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainers", x => x.Id);
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
                    PhotoPath = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
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
                name: "CourtReservations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    From = table.Column<DateTime>(type: "TEXT", nullable: false),
                    To = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CourtId = table.Column<Guid>(type: "TEXT", nullable: false)
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
                name: "TrainerReservations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CourtReservationId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TrainerId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TrainerReviewId = table.Column<Guid>(type: "TEXT", nullable: true)
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
                values: new object[] { new Guid("307d4080-7dba-4567-b359-f0222341e3a7"), "A", 1000m });

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate" },
                values: new object[] { new Guid("a5cc0b56-fc9b-43c2-9278-957b8380451c"), "D", 500m });

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate" },
                values: new object[] { new Guid("c7c1a907-8d7e-4ece-a63d-a4ad9f464a9d"), "B", 800m });

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate" },
                values: new object[] { new Guid("ce384bc6-9139-4ccc-9716-3ddbfce01022"), "C", 800m });

            migrationBuilder.InsertData(
                table: "TrainerReviews",
                columns: new[] { "Id", "Hide", "Rating", "Text" },
                values: new object[] { new Guid("102cbf9f-80e4-4ac5-ba89-6a5da6dce1f1"), false, 5, "tbd" });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Description", "Email", "FirstName", "HourlyRate", "LastName", "PasswordHash" },
                values: new object[] { new Guid("2aa44892-ba41-40fd-b058-2cfad3ea9644"), "I know how to play even better, that's all", "493352@mail.muni.cz", "Jitka", 3485m, "Viceníková", "tbd" });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Description", "Email", "FirstName", "HourlyRate", "LastName", "PasswordHash" },
                values: new object[] { new Guid("45d75ad8-10f0-4e66-8212-783bafe50d16"), "I know how to play, that's all", "rhanculak@mail.muni.cz", "Radovan", 2000m, "Hančuľák", "tbd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "LastName", "PasswordHash", "PhotoPath" },
                values: new object[] { new Guid("77237c69-7a31-4777-993b-477183f3541e"), new DateTime(2001, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "514329@mail.muni.cz", "Adam", "Mydla", "tbd", "tbd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "LastName", "PasswordHash", "PhotoPath" },
                values: new object[] { new Guid("81ca6b64-6721-4c1e-ba7d-a2198b7e0e50"), new DateTime(1955, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "monic@nonexistentmail.com", "Monica", "Bellucci", "tbd", "tbd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "LastName", "PasswordHash", "PhotoPath" },
                values: new object[] { new Guid("9051a943-c1d9-4e4b-80d4-b169947c3f50"), new DateTime(1993, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "rntr@nonexistentmail.com", "Roman", "NieTenRoman", "tbd", "tbd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "LastName", "PasswordHash", "PhotoPath" },
                values: new object[] { new Guid("aa480908-5712-4dab-a843-c9150dbe5870"), new DateTime(1995, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "pppeter@nonexistentmail.com", "Peter", "Griffin", "tbd", "tbd" });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("32af9051-c940-4777-b340-a706590f4dc5"), new Guid("ce384bc6-9139-4ccc-9716-3ddbfce01022"), new DateTime(2022, 9, 5, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new Guid("77237c69-7a31-4777-993b-477183f3541e") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("3d9a3f7f-851d-42a8-850d-9a467b15babc"), new Guid("c7c1a907-8d7e-4ece-a63d-a4ad9f464a9d"), new DateTime(2022, 9, 16, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 9, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9051a943-c1d9-4e4b-80d4-b169947c3f50") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("502530e5-7d30-43ac-a53c-8bb8b15d3ff5"), new Guid("307d4080-7dba-4567-b359-f0222341e3a7"), new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("77237c69-7a31-4777-993b-477183f3541e") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("98c6e6ed-d4f0-4b58-a580-9b4144e55e97"), new Guid("c7c1a907-8d7e-4ece-a63d-a4ad9f464a9d"), new DateTime(2022, 9, 15, 18, 4, 4, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9051a943-c1d9-4e4b-80d4-b169947c3f50") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("a3ace0c7-0dbb-46f7-99c1-8c655b0d3d59"), new Guid("307d4080-7dba-4567-b359-f0222341e3a7"), new DateTime(2022, 9, 28, 19, 19, 19, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aa480908-5712-4dab-a843-c9150dbe5870") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("a5ec885d-9c2a-4ad3-bbf0-af602fcd6943"), new Guid("ce384bc6-9139-4ccc-9716-3ddbfce01022"), new DateTime(2022, 9, 21, 6, 51, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), new Guid("77237c69-7a31-4777-993b-477183f3541e") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("abfc6696-9eed-4703-8b4d-9c34eec7795a"), new Guid("a5cc0b56-fc9b-43c2-9278-957b8380451c"), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 12, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("81ca6b64-6721-4c1e-ba7d-a2198b7e0e50") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("e290db1a-37a7-428a-9062-ed93b330c7b8"), new Guid("307d4080-7dba-4567-b359-f0222341e3a7"), new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aa480908-5712-4dab-a843-c9150dbe5870") });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[] { new Guid("270df941-caff-4073-a04f-4c15e33d7b51"), false, "tbd", new Guid("45d75ad8-10f0-4e66-8212-783bafe50d16") });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[] { new Guid("8518a4ac-00a5-4350-8322-125ce5beaa35"), true, "tbd", new Guid("2aa44892-ba41-40fd-b058-2cfad3ea9644") });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[] { new Guid("e30979b2-0802-4067-a034-60739a5429fc"), true, "tbd", new Guid("2aa44892-ba41-40fd-b058-2cfad3ea9644") });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[] { new Guid("eca699b6-fd97-40e5-a4f5-21ab5ebad248"), false, "tbd", new Guid("45d75ad8-10f0-4e66-8212-783bafe50d16") });

            migrationBuilder.InsertData(
                table: "TrainerReservations",
                columns: new[] { "Id", "CourtReservationId", "IsDeleted", "TrainerId", "TrainerReviewId" },
                values: new object[] { new Guid("5a97a3e8-1255-4746-a292-8e8110359051"), new Guid("abfc6696-9eed-4703-8b4d-9c34eec7795a"), false, new Guid("2aa44892-ba41-40fd-b058-2cfad3ea9644"), new Guid("102cbf9f-80e4-4ac5-ba89-6a5da6dce1f1") });

            migrationBuilder.InsertData(
                table: "TrainerReservations",
                columns: new[] { "Id", "CourtReservationId", "IsDeleted", "TrainerId", "TrainerReviewId" },
                values: new object[] { new Guid("6caa3663-590d-4dea-be23-8aa7ca7ba8ca"), new Guid("98c6e6ed-d4f0-4b58-a580-9b4144e55e97"), false, new Guid("45d75ad8-10f0-4e66-8212-783bafe50d16"), null });

            migrationBuilder.InsertData(
                table: "TrainerReservations",
                columns: new[] { "Id", "CourtReservationId", "IsDeleted", "TrainerId", "TrainerReviewId" },
                values: new object[] { new Guid("a6ebf392-bb1e-4d36-ac28-d64c40a4f87a"), new Guid("3d9a3f7f-851d-42a8-850d-9a467b15babc"), true, new Guid("45d75ad8-10f0-4e66-8212-783bafe50d16"), null });

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
