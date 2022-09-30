using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sprint.DAL.Migrations
{
    public partial class SeedDbReviewErrorFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainerReservations_TrainerReviews_TrainerReviewId",
                table: "TrainerReservations");

            migrationBuilder.AlterColumn<int>(
                name: "TrainerReviewId",
                table: "TrainerReservations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "TrainerReservations",
                columns: new[] { "Id", "CourtReservationId", "IsDeleted", "TrainerId", "TrainerReviewId" },
                values: new object[] { 1, 7, true, 1, null });

            migrationBuilder.InsertData(
                table: "TrainerReservations",
                columns: new[] { "Id", "CourtReservationId", "IsDeleted", "TrainerId", "TrainerReviewId" },
                values: new object[] { 2, 6, false, 1, null });

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerReservations_TrainerReviews_TrainerReviewId",
                table: "TrainerReservations",
                column: "TrainerReviewId",
                principalTable: "TrainerReviews",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainerReservations_TrainerReviews_TrainerReviewId",
                table: "TrainerReservations");

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "TrainerReviewId",
                table: "TrainerReservations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerReservations_TrainerReviews_TrainerReviewId",
                table: "TrainerReservations",
                column: "TrainerReviewId",
                principalTable: "TrainerReviews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
