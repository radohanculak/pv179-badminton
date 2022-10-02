using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sprint.DAL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HourlyRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CourtNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainerReviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hide = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainerReviews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trainers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HourlyRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainerPhotos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hide = table.Column<bool>(type: "bit", nullable: false),
                    TrainerId = table.Column<int>(type: "int", nullable: false)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    From = table.Column<DateTime>(type: "datetime2", nullable: false),
                    To = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CourtId = table.Column<int>(type: "int", nullable: false)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CourtReservationId = table.Column<int>(type: "int", nullable: false),
                    TrainerId = table.Column<int>(type: "int", nullable: false),
                    TrainerReviewId = table.Column<int>(type: "int", nullable: false)
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainerReservations_Trainers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "Trainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
