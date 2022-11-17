using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sprint.DAL.EFCore.Migrations
{
    public partial class AddUserRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("0ccf4f68-d3e5-4c64-b0c4-67e3dfe6bcdb"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("1cc5f600-ad4e-40cc-91d4-280c4ef181c1"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("5975adb7-d979-4d85-bbee-f586887c581c"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("c49b9798-5ea0-41c0-9858-4870f8df193c"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("d392a4b4-c1cd-4f8a-ba56-f8012e015d82"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("005eac6c-0982-4c04-9d66-f097af243ed3"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("17e0dbde-d14e-4637-9939-c2712dc5f6b4"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("aad6876c-1812-4ecb-b3f5-f9a0798d2158"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("f7b12257-4c83-4cdb-97c0-3ddc5d3b3acd"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("58061a53-b2ac-49f2-9c6f-698da6707709"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("6ac9ebdc-d9cc-494f-8d4a-1a673d888eb1"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("a4085a59-22ba-4329-baa7-083c580cac30"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("1cc89e12-e401-40e5-baa3-00e82eda6e74"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("50829779-143f-4345-be89-98f6512f3b70"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("e180d699-31e4-47fa-860f-1ce54bee5103"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("b7a69cd7-c564-410f-94fa-39cc9e9d00af"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("bae019c3-ef45-4abd-a111-6d8449fd8dfa"));

            migrationBuilder.DeleteData(
                table: "TrainerReviews",
                keyColumn: "Id",
                keyValue: new Guid("60ab8e97-4a30-431f-ba74-eecc137dc341"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("47d7ace3-2d3a-4e92-8bfb-abc034ebaffc"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("c227d056-ef37-4d5f-a7e2-cf7caeb772de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b428940e-c009-4ca9-8408-675c22e23a87"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d278f3c0-7c21-4f22-a964-54d085730861"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("9a51e515-9bed-41b0-a02d-f53170a2cd62"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("e7c08187-122e-4a22-802e-13401fac8ff8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("51dbded9-758f-46d6-b3a9-560a97d3674c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b4d94aa2-7aa5-48eb-b5da-67c1f771cc3f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4864536-bf24-4102-8dd8-ab0ef0930bd3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e3647ea9-54ef-4097-94f7-32aa103b81f9"));

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

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
        }
    }
}
