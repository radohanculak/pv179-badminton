using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sprint.DAL.EFCore.Migrations
{
    public partial class NullablePhotoPath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("049522ad-16e0-4f6f-b485-8f41629a672f"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("52e368cf-700a-412e-b461-ffe67fa2f0c0"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("630c4627-ba8e-4df5-80d6-6806dc84a6d3"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("6a2616f4-b04b-4518-b6ac-2afe83f1ccf4"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("f50cdc59-d9c8-4eb3-b43b-bd67fcf80120"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("27f453ea-3b8e-49ce-96d7-a3c27bb9222e"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("3add0837-1d31-41e8-a1b3-06f3d4db00d2"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("5f65ada2-57d3-4b87-bf59-b54114882c38"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("6cd74a00-be41-4da6-9347-bcb30825571d"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("4efa2767-2e5f-4b4d-a099-ec1744de7a94"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("8d2830a9-6316-4abe-8fdd-10afddc0d4fe"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("af3f766e-6fe5-4be1-864c-db6936f5908e"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("068fac4a-34d5-40a2-a9c0-a43d02a004cc"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("238463f3-38f6-446d-ac72-75e4ece5c33e"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("8817d241-03ee-42ff-b570-43b67320eddb"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("1bd0d071-c2c4-4016-9b69-bbc132a15102"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("f26f4994-d745-46e1-9490-ca92a2b06fef"));

            migrationBuilder.DeleteData(
                table: "TrainerReviews",
                keyColumn: "Id",
                keyValue: new Guid("2f048d4a-9a45-41af-94aa-f68ce994d8b5"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("37e681f2-085b-4fd6-8b4b-f3d4a4575027"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("d62d13ee-250a-4269-ade2-5170a2e00dee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22d00d08-346f-4b2f-bcb1-9e0b8f111473"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55c262c7-b0ad-4ba2-8e1d-0cd55960bbbb"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("5ad00c60-d894-4f3b-b008-3189de1e65a6"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("dd9296d4-44c3-4062-a1da-07c41f01e4ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0e1d88b0-e364-426e-8936-99098e5b5615"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4dd5b0aa-de5d-48f8-9077-08cbe759adc7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6fb59675-4eef-4975-bbbc-542ee80eddd1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("75059c6a-a984-478a-97dc-f4a8284349e8"));

            migrationBuilder.AlterColumn<string>(
                name: "PhotoPath",
                table: "Users",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "PhotoPath",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate" },
                values: new object[] { new Guid("1bd0d071-c2c4-4016-9b69-bbc132a15102"), "C", 800m });

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate" },
                values: new object[] { new Guid("5ad00c60-d894-4f3b-b008-3189de1e65a6"), "D", 500m });

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate" },
                values: new object[] { new Guid("dd9296d4-44c3-4062-a1da-07c41f01e4ba"), "B", 800m });

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate" },
                values: new object[] { new Guid("f26f4994-d745-46e1-9490-ca92a2b06fef"), "A", 1000m });

            migrationBuilder.InsertData(
                table: "TrainerReviews",
                columns: new[] { "Id", "Hide", "Rating", "Text" },
                values: new object[] { new Guid("2f048d4a-9a45-41af-94aa-f68ce994d8b5"), false, 5, "tbd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "IsTrainer", "LastName", "PasswordHash", "PhotoPath", "Role" },
                values: new object[] { new Guid("0e1d88b0-e364-426e-8936-99098e5b5615"), new DateTime(1955, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "monic@nonexistentmail.com", "Monica", false, "Bellucci", "tbd", "tbd", 0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "IsTrainer", "LastName", "PasswordHash", "PhotoPath", "Role" },
                values: new object[] { new Guid("22d00d08-346f-4b2f-bcb1-9e0b8f111473"), new DateTime(2001, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "514329@mail.muni.cz", "Adam", false, "Mydla", "tbd", "tbd", 0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "IsTrainer", "LastName", "PasswordHash", "PhotoPath", "Role" },
                values: new object[] { new Guid("4dd5b0aa-de5d-48f8-9077-08cbe759adc7"), new DateTime(1993, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "rntr@nonexistentmail.com", "Roman", false, "NieTenRoman", "tbd", "tbd", 0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "IsTrainer", "LastName", "PasswordHash", "PhotoPath", "Role" },
                values: new object[] { new Guid("55c262c7-b0ad-4ba2-8e1d-0cd55960bbbb"), new DateTime(1995, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "pppeter@nonexistentmail.com", "Peter", false, "Griffin", "tbd", "tbd", 0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "IsTrainer", "LastName", "PasswordHash", "PhotoPath", "Role" },
                values: new object[] { new Guid("6fb59675-4eef-4975-bbbc-542ee80eddd1"), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "rhanculak@mail.muni.cz", "Radovan", true, "Hančuľák", "tbd", "tbd", 0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "IsTrainer", "LastName", "PasswordHash", "PhotoPath", "Role" },
                values: new object[] { new Guid("75059c6a-a984-478a-97dc-f4a8284349e8"), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "493352@mail.muni.cz", "Jitka", true, "Viceníková", "tbd", "tbd", 0 });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("049522ad-16e0-4f6f-b485-8f41629a672f"), new Guid("f26f4994-d745-46e1-9490-ca92a2b06fef"), new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), new Guid("55c262c7-b0ad-4ba2-8e1d-0cd55960bbbb") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("068fac4a-34d5-40a2-a9c0-a43d02a004cc"), new Guid("5ad00c60-d894-4f3b-b008-3189de1e65a6"), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 12, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0e1d88b0-e364-426e-8936-99098e5b5615") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("238463f3-38f6-446d-ac72-75e4ece5c33e"), new Guid("dd9296d4-44c3-4062-a1da-07c41f01e4ba"), new DateTime(2022, 9, 16, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 9, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4dd5b0aa-de5d-48f8-9077-08cbe759adc7") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("52e368cf-700a-412e-b461-ffe67fa2f0c0"), new Guid("1bd0d071-c2c4-4016-9b69-bbc132a15102"), new DateTime(2022, 9, 21, 6, 51, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), new Guid("22d00d08-346f-4b2f-bcb1-9e0b8f111473") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("630c4627-ba8e-4df5-80d6-6806dc84a6d3"), new Guid("1bd0d071-c2c4-4016-9b69-bbc132a15102"), new DateTime(2022, 9, 5, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new Guid("22d00d08-346f-4b2f-bcb1-9e0b8f111473") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("6a2616f4-b04b-4518-b6ac-2afe83f1ccf4"), new Guid("f26f4994-d745-46e1-9490-ca92a2b06fef"), new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("22d00d08-346f-4b2f-bcb1-9e0b8f111473") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("8817d241-03ee-42ff-b570-43b67320eddb"), new Guid("dd9296d4-44c3-4062-a1da-07c41f01e4ba"), new DateTime(2022, 9, 15, 18, 4, 4, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4dd5b0aa-de5d-48f8-9077-08cbe759adc7") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("f50cdc59-d9c8-4eb3-b43b-bd67fcf80120"), new Guid("f26f4994-d745-46e1-9490-ca92a2b06fef"), new DateTime(2022, 9, 28, 19, 19, 19, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("55c262c7-b0ad-4ba2-8e1d-0cd55960bbbb") });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Description", "HourlyRate", "UserId" },
                values: new object[] { new Guid("37e681f2-085b-4fd6-8b4b-f3d4a4575027"), "I know how to play even better, that's all", 3485m, new Guid("75059c6a-a984-478a-97dc-f4a8284349e8") });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Description", "HourlyRate", "UserId" },
                values: new object[] { new Guid("d62d13ee-250a-4269-ade2-5170a2e00dee"), "I know how to play, that's all", 2000m, new Guid("6fb59675-4eef-4975-bbbc-542ee80eddd1") });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[] { new Guid("27f453ea-3b8e-49ce-96d7-a3c27bb9222e"), true, "tbd", new Guid("37e681f2-085b-4fd6-8b4b-f3d4a4575027") });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[] { new Guid("3add0837-1d31-41e8-a1b3-06f3d4db00d2"), false, "tbd", new Guid("d62d13ee-250a-4269-ade2-5170a2e00dee") });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[] { new Guid("5f65ada2-57d3-4b87-bf59-b54114882c38"), true, "tbd", new Guid("37e681f2-085b-4fd6-8b4b-f3d4a4575027") });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[] { new Guid("6cd74a00-be41-4da6-9347-bcb30825571d"), false, "tbd", new Guid("d62d13ee-250a-4269-ade2-5170a2e00dee") });

            migrationBuilder.InsertData(
                table: "TrainerReservations",
                columns: new[] { "Id", "CourtReservationId", "IsDeleted", "TrainerId", "TrainerReviewId" },
                values: new object[] { new Guid("4efa2767-2e5f-4b4d-a099-ec1744de7a94"), new Guid("8817d241-03ee-42ff-b570-43b67320eddb"), false, new Guid("d62d13ee-250a-4269-ade2-5170a2e00dee"), null });

            migrationBuilder.InsertData(
                table: "TrainerReservations",
                columns: new[] { "Id", "CourtReservationId", "IsDeleted", "TrainerId", "TrainerReviewId" },
                values: new object[] { new Guid("8d2830a9-6316-4abe-8fdd-10afddc0d4fe"), new Guid("068fac4a-34d5-40a2-a9c0-a43d02a004cc"), false, new Guid("37e681f2-085b-4fd6-8b4b-f3d4a4575027"), new Guid("2f048d4a-9a45-41af-94aa-f68ce994d8b5") });

            migrationBuilder.InsertData(
                table: "TrainerReservations",
                columns: new[] { "Id", "CourtReservationId", "IsDeleted", "TrainerId", "TrainerReviewId" },
                values: new object[] { new Guid("af3f766e-6fe5-4be1-864c-db6936f5908e"), new Guid("238463f3-38f6-446d-ac72-75e4ece5c33e"), true, new Guid("d62d13ee-250a-4269-ade2-5170a2e00dee"), null });
        }
    }
}
