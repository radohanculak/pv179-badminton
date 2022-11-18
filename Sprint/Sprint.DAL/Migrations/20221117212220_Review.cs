using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sprint.DAL.EFCore.Migrations
{
    public partial class Review : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("32d15c84-726d-4233-95ef-5c09ff05f7e4"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("77b86c47-5b62-4a0a-9838-1dd52e46d105"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("7b208b55-2104-484e-9d3b-dd171e731d9f"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("a75f3832-36df-48c1-9f9d-d9eacde5881c"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("ecbeb3f9-372b-42f3-afcf-c388b354bf02"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("0b3d1a31-02c3-411a-9a64-ef91374756e0"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("0f2ec1ee-0ad2-488a-8955-a37f56f65beb"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("24b3f86e-562d-4244-80c4-16185982eddb"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("4d14fadf-2f16-4400-9ead-dcaec82e68ae"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("480d615b-a7e4-441c-804c-e75d995c812e"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("7d5360d0-9c41-4f02-9a5d-1780d3b60c42"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("bc5d2725-45fa-45b8-adeb-641929929488"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("0c5b1d2e-b005-439a-88ab-35cf54560a25"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("47a0db10-972b-4466-bca2-f9025522d3d4"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("c58cface-a29f-45d3-974c-0f0191cbf5c4"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("c1af8f98-d28a-4606-bf7d-d58ce5175e79"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("d1bb58ce-9fcb-468d-8be3-1d931dcf7086"));

            migrationBuilder.DeleteData(
                table: "TrainerReviews",
                keyColumn: "Id",
                keyValue: new Guid("a26c86fa-5f35-40d3-9751-8b7ddd3a101b"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("36093406-e64b-4b5d-92ff-7cae8c26a418"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("6208ded4-3aa9-47ab-b5b5-72c82239fe20"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4f077246-8c57-4856-8c70-bc8c030554ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9cc77071-18f4-4c37-8fb4-f8510a1e8c9d"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("9e1c3d6b-b08b-41a6-b0ff-483f74291f09"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("c6238797-61ec-4dfc-a31e-26db0e5db49d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ca99934-a42b-430a-bf9b-51c5ae9b88d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b725f74a-21b4-4887-a22e-93796013f020"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa95c41f-e449-46aa-b4f4-61af47c6d6f5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ff690b73-633b-4f41-8413-60afabb15c08"));

            migrationBuilder.AddColumn<Guid>(
                name: "ReservationId",
                table: "TrainerReviews",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_TrainerReviews_ReservationId",
                table: "TrainerReviews",
                column: "ReservationId");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerReviews_TrainerReservations_ReservationId",
                table: "TrainerReviews",
                column: "ReservationId",
                principalTable: "TrainerReservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainerReviews_TrainerReservations_ReservationId",
                table: "TrainerReviews");

            migrationBuilder.DropIndex(
                name: "IX_TrainerReviews_ReservationId",
                table: "TrainerReviews");

            migrationBuilder.DropColumn(
                name: "ReservationId",
                table: "TrainerReviews");

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate" },
                values: new object[] { new Guid("9e1c3d6b-b08b-41a6-b0ff-483f74291f09"), "B", 800m });

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate" },
                values: new object[] { new Guid("c1af8f98-d28a-4606-bf7d-d58ce5175e79"), "A", 1000m });

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate" },
                values: new object[] { new Guid("c6238797-61ec-4dfc-a31e-26db0e5db49d"), "D", 500m });

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate" },
                values: new object[] { new Guid("d1bb58ce-9fcb-468d-8be3-1d931dcf7086"), "C", 800m });

            migrationBuilder.InsertData(
                table: "TrainerReviews",
                columns: new[] { "Id", "Hide", "Rating", "Text" },
                values: new object[] { new Guid("a26c86fa-5f35-40d3-9751-8b7ddd3a101b"), false, 5, "tbd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "IsTrainer", "LastName", "PasswordHash", "PhotoPath", "Role" },
                values: new object[] { new Guid("3ca99934-a42b-430a-bf9b-51c5ae9b88d1"), new DateTime(1993, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "rntr@nonexistentmail.com", "Roman", false, "NieTenRoman", "tbd", "tbd", 0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "IsTrainer", "LastName", "PasswordHash", "PhotoPath", "Role" },
                values: new object[] { new Guid("4f077246-8c57-4856-8c70-bc8c030554ca"), new DateTime(1995, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "pppeter@nonexistentmail.com", "Peter", false, "Griffin", "tbd", "tbd", 0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "IsTrainer", "LastName", "PasswordHash", "PhotoPath", "Role" },
                values: new object[] { new Guid("9cc77071-18f4-4c37-8fb4-f8510a1e8c9d"), new DateTime(2001, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "514329@mail.muni.cz", "Adam", false, "Mydla", "tbd", "tbd", 0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "IsTrainer", "LastName", "PasswordHash", "PhotoPath", "Role" },
                values: new object[] { new Guid("b725f74a-21b4-4887-a22e-93796013f020"), new DateTime(1955, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "monic@nonexistentmail.com", "Monica", false, "Bellucci", "tbd", "tbd", 0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "IsTrainer", "LastName", "PasswordHash", "PhotoPath", "Role" },
                values: new object[] { new Guid("fa95c41f-e449-46aa-b4f4-61af47c6d6f5"), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "rhanculak@mail.muni.cz", "Radovan", true, "Hančuľák", "tbd", "tbd", 0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "IsTrainer", "LastName", "PasswordHash", "PhotoPath", "Role" },
                values: new object[] { new Guid("ff690b73-633b-4f41-8413-60afabb15c08"), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "493352@mail.muni.cz", "Jitka", true, "Viceníková", "tbd", "tbd", 0 });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("0c5b1d2e-b005-439a-88ab-35cf54560a25"), new Guid("9e1c3d6b-b08b-41a6-b0ff-483f74291f09"), new DateTime(2022, 9, 16, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 9, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3ca99934-a42b-430a-bf9b-51c5ae9b88d1") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("32d15c84-726d-4233-95ef-5c09ff05f7e4"), new Guid("c1af8f98-d28a-4606-bf7d-d58ce5175e79"), new DateTime(2022, 9, 28, 19, 19, 19, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4f077246-8c57-4856-8c70-bc8c030554ca") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("47a0db10-972b-4466-bca2-f9025522d3d4"), new Guid("9e1c3d6b-b08b-41a6-b0ff-483f74291f09"), new DateTime(2022, 9, 15, 18, 4, 4, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3ca99934-a42b-430a-bf9b-51c5ae9b88d1") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("77b86c47-5b62-4a0a-9838-1dd52e46d105"), new Guid("d1bb58ce-9fcb-468d-8be3-1d931dcf7086"), new DateTime(2022, 9, 5, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9cc77071-18f4-4c37-8fb4-f8510a1e8c9d") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("7b208b55-2104-484e-9d3b-dd171e731d9f"), new Guid("c1af8f98-d28a-4606-bf7d-d58ce5175e79"), new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4f077246-8c57-4856-8c70-bc8c030554ca") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("a75f3832-36df-48c1-9f9d-d9eacde5881c"), new Guid("c1af8f98-d28a-4606-bf7d-d58ce5175e79"), new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9cc77071-18f4-4c37-8fb4-f8510a1e8c9d") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("c58cface-a29f-45d3-974c-0f0191cbf5c4"), new Guid("c6238797-61ec-4dfc-a31e-26db0e5db49d"), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 12, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b725f74a-21b4-4887-a22e-93796013f020") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("ecbeb3f9-372b-42f3-afcf-c388b354bf02"), new Guid("d1bb58ce-9fcb-468d-8be3-1d931dcf7086"), new DateTime(2022, 9, 21, 6, 51, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9cc77071-18f4-4c37-8fb4-f8510a1e8c9d") });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Description", "HourlyRate", "UserId" },
                values: new object[] { new Guid("36093406-e64b-4b5d-92ff-7cae8c26a418"), "I know how to play even better, that's all", 3485m, new Guid("ff690b73-633b-4f41-8413-60afabb15c08") });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Description", "HourlyRate", "UserId" },
                values: new object[] { new Guid("6208ded4-3aa9-47ab-b5b5-72c82239fe20"), "I know how to play, that's all", 2000m, new Guid("fa95c41f-e449-46aa-b4f4-61af47c6d6f5") });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[] { new Guid("0b3d1a31-02c3-411a-9a64-ef91374756e0"), false, "tbd", new Guid("6208ded4-3aa9-47ab-b5b5-72c82239fe20") });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[] { new Guid("0f2ec1ee-0ad2-488a-8955-a37f56f65beb"), true, "tbd", new Guid("36093406-e64b-4b5d-92ff-7cae8c26a418") });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[] { new Guid("24b3f86e-562d-4244-80c4-16185982eddb"), false, "tbd", new Guid("6208ded4-3aa9-47ab-b5b5-72c82239fe20") });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[] { new Guid("4d14fadf-2f16-4400-9ead-dcaec82e68ae"), true, "tbd", new Guid("36093406-e64b-4b5d-92ff-7cae8c26a418") });

            migrationBuilder.InsertData(
                table: "TrainerReservations",
                columns: new[] { "Id", "CourtReservationId", "IsDeleted", "TrainerId", "TrainerReviewId" },
                values: new object[] { new Guid("480d615b-a7e4-441c-804c-e75d995c812e"), new Guid("47a0db10-972b-4466-bca2-f9025522d3d4"), false, new Guid("6208ded4-3aa9-47ab-b5b5-72c82239fe20"), null });

            migrationBuilder.InsertData(
                table: "TrainerReservations",
                columns: new[] { "Id", "CourtReservationId", "IsDeleted", "TrainerId", "TrainerReviewId" },
                values: new object[] { new Guid("7d5360d0-9c41-4f02-9a5d-1780d3b60c42"), new Guid("0c5b1d2e-b005-439a-88ab-35cf54560a25"), true, new Guid("6208ded4-3aa9-47ab-b5b5-72c82239fe20"), null });

            migrationBuilder.InsertData(
                table: "TrainerReservations",
                columns: new[] { "Id", "CourtReservationId", "IsDeleted", "TrainerId", "TrainerReviewId" },
                values: new object[] { new Guid("bc5d2725-45fa-45b8-adeb-641929929488"), new Guid("c58cface-a29f-45d3-974c-0f0191cbf5c4"), false, new Guid("36093406-e64b-4b5d-92ff-7cae8c26a418"), new Guid("a26c86fa-5f35-40d3-9751-8b7ddd3a101b") });
        }
    }
}
