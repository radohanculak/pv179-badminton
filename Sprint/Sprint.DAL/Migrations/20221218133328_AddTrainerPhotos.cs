using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sprint.DAL.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class AddTrainerPhotos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("0d6f904c-09e3-46bb-96a3-71225fc687dd"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("1c4199b5-dffa-4d91-a5d8-b9b7a45ad9f8"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("46ca34a1-d8b2-45bd-98dd-c75dc3593e58"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("60f7e6bc-ceac-4a89-9ed6-e4822ece7d96"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("df96fece-4bd0-46d9-ada9-d1ea7b39bec1"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("81ed96c7-f207-4952-a889-53ccc5ca0783"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("8bd0b742-4183-4cfa-9704-889d45f9197c"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("b26b93fc-f4c5-4dbf-b35b-1fa94db26273"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("ff161d88-213e-4958-8059-d97798c69d19"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("0d3198ef-53c1-45aa-8ae8-670d4e08bf36"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("cd658e1a-9056-4966-9af8-9a2b66b293af"));

            migrationBuilder.DeleteData(
                table: "TrainerReviews",
                keyColumn: "Id",
                keyValue: new Guid("c86327ad-29f0-4fa4-82f9-fc7b234cabfa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2b4f490b-78c6-4d78-8052-14095a47a7dd"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("4869f2a5-5283-4aac-9286-07ffdf64e4b1"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("4970864a-7db3-4d37-bf25-9136d2ac9852"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("21582987-8c62-4c0e-8baa-c9b17bef04a9"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("4c74390d-31bd-431e-bec5-7478d8bc067a"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("e6c1928a-e4ca-43df-be38-7beb3596f9dd"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("dfdb5acc-aeb2-4465-a859-8ba250311e38"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("02414384-5f04-4c71-817e-84c9401489af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f48f6bc9-42f1-4eeb-b234-e58711a87103"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("dafc2fa5-40a9-48fc-8864-b99b3bbbcdfa"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("0cdbbff1-2588-4d06-acdb-c9c765763ecd"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("e97aaae7-f306-418a-bbb0-8172600ca28b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9a14dd6e-6198-4b43-ba4e-f15319cb66a7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bcbcb6f0-6f36-4bf4-b44b-81f539030b8d"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("08270c26-6799-4270-a319-533bee854927"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4386b2d9-89ff-453d-8d1e-f8d5ba2eb87b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b2d6a26e-8cb5-4301-9d6f-6acbd4cdba52"));

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("875fd8d9-3ae2-4222-bd4a-d0189c2a71d1"), "C", 800m, false },
                    { new Guid("aa6390dc-ed52-42c6-9236-99036b9f040f"), "A", 1000m, false },
                    { new Guid("ec858b0b-f861-45d4-8371-edd21d5fc799"), "D", 500m, false },
                    { new Guid("ee427533-5658-4ccf-86e5-c82943ee84db"), "B", 800m, false }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "IsDeleted", "IsTrainer", "LastName", "PasswordHash", "PhotoPath", "Role", "SecurityStamp" },
                values: new object[,]
                {
                    { new Guid("10bbd36f-8a70-406b-8fcf-df8e177603f6"), new DateTime(1993, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "rntr@nonexistentmail.com", "Roman", false, false, "NieTenRoman", "AQAAAAEAACcQAAAAEHJNzc74MClYcrnmRa5hjbMdWsPhr1E4FMkrPTJvDaYId7MDVwvXrPlsnOv6dZS7xg==", "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg", 0, "3abcdef" },
                    { new Guid("1274d0bc-b6d7-46b0-9f56-9d391735f941"), new DateTime(2001, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "514329@mail.muni.cz", "Adam", false, false, "Mydla", "AQAAAAEAACcQAAAAEHJNzc74MClYcrnmRa5hjbMdWsPhr1E4FMkrPTJvDaYId7MDVwvXrPlsnOv6dZS7xg==", "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg", 0, "1abcdef" },
                    { new Guid("1e0182e3-ae8a-485c-9b90-32e1379baa3d"), new DateTime(1995, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "pppeter@nonexistentmail.com", "Peter", false, false, "Griffin", "AQAAAAEAACcQAAAAEHJNzc74MClYcrnmRa5hjbMdWsPhr1E4FMkrPTJvDaYId7MDVwvXrPlsnOv6dZS7xg==", "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg", 0, "2abcdef" },
                    { new Guid("6c8d8a53-f5ac-4fea-b0da-d19d05d4784d"), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@sprint.cz", "Admin", false, true, "Admin", "AQAAAAEAACcQAAAAEHJNzc74MClYcrnmRa5hjbMdWsPhr1E4FMkrPTJvDaYId7MDVwvXrPlsnOv6dZS7xg==", "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg", 1, "6abcdef" },
                    { new Guid("b3c7c975-7dc0-4486-a3c4-524201624fca"), new DateTime(1955, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "monic@nonexistentmail.com", "Monica", false, false, "Bellucci", "AQAAAAEAACcQAAAAEHJNzc74MClYcrnmRa5hjbMdWsPhr1E4FMkrPTJvDaYId7MDVwvXrPlsnOv6dZS7xg==", "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg", 0, "4abcdef" },
                    { new Guid("d40b6b29-f87c-4384-87da-34151d9ab66b"), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "493352@mail.muni.cz", "Jitka", false, true, "Viceníková", "AQAAAAEAACcQAAAAEHJNzc74MClYcrnmRa5hjbMdWsPhr1E4FMkrPTJvDaYId7MDVwvXrPlsnOv6dZS7xg==", "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg", 1, "6abcdef" },
                    { new Guid("f4d2804f-6008-42f2-b243-8d0ead61d6f1"), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "rhanculak@mail.muni.cz", "Radovan", false, true, "Hančuľák", "AQAAAAEAACcQAAAAEHJNzc74MClYcrnmRa5hjbMdWsPhr1E4FMkrPTJvDaYId7MDVwvXrPlsnOv6dZS7xg==", "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg", 1, "5abcdef" }
                });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("070f1d3f-7487-4ec3-b22c-7d66eade90f1"), new Guid("ec858b0b-f861-45d4-8371-edd21d5fc799"), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 12, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b3c7c975-7dc0-4486-a3c4-524201624fca") },
                    { new Guid("3cee9034-dfa2-41a2-a116-59333f220322"), new Guid("ee427533-5658-4ccf-86e5-c82943ee84db"), new DateTime(2022, 9, 15, 18, 4, 4, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), new Guid("10bbd36f-8a70-406b-8fcf-df8e177603f6") },
                    { new Guid("4e838456-4c35-4b7d-8fb2-cfe3f6634f61"), new Guid("875fd8d9-3ae2-4222-bd4a-d0189c2a71d1"), new DateTime(2022, 9, 5, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1274d0bc-b6d7-46b0-9f56-9d391735f941") },
                    { new Guid("515d5846-4665-488f-a006-516721b6634a"), new Guid("aa6390dc-ed52-42c6-9236-99036b9f040f"), new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1274d0bc-b6d7-46b0-9f56-9d391735f941") },
                    { new Guid("9859b4f8-5904-4b9a-b203-1fb7f1f36b99"), new Guid("ee427533-5658-4ccf-86e5-c82943ee84db"), new DateTime(2022, 9, 16, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 9, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("10bbd36f-8a70-406b-8fcf-df8e177603f6") },
                    { new Guid("bb58669b-d6bb-45d5-9c9d-966ef6b9e44d"), new Guid("aa6390dc-ed52-42c6-9236-99036b9f040f"), new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1e0182e3-ae8a-485c-9b90-32e1379baa3d") },
                    { new Guid("dbbcf2b0-3e08-42ad-8317-fbb6f6c25983"), new Guid("875fd8d9-3ae2-4222-bd4a-d0189c2a71d1"), new DateTime(2022, 9, 21, 6, 51, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1274d0bc-b6d7-46b0-9f56-9d391735f941") },
                    { new Guid("f8b5b07a-1a89-430a-9f67-55ac17d723e6"), new Guid("aa6390dc-ed52-42c6-9236-99036b9f040f"), new DateTime(2022, 9, 28, 19, 19, 19, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1e0182e3-ae8a-485c-9b90-32e1379baa3d") }
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Description", "HourlyRate", "IsDeleted", "UserId" },
                values: new object[,]
                {
                    { new Guid("257b8445-2cfa-4772-9fc8-1c74036cca7b"), "I know how to play even better, that's all", 3485m, false, new Guid("d40b6b29-f87c-4384-87da-34151d9ab66b") },
                    { new Guid("d7c4b238-88d2-4456-a6f9-1fc5cd29509a"), "I know how to play, that's all", 2000m, false, new Guid("f4d2804f-6008-42f2-b243-8d0ead61d6f1") }
                });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "IsDeleted", "Path", "TrainerId" },
                values: new object[,]
                {
                    { new Guid("1637b7ee-e801-4631-92c6-8efb0439f489"), true, false, "https://static8.depositphotos.com/1460388/938/i/600/depositphotos_9388060-stock-photo-next-rally.jpg", new Guid("257b8445-2cfa-4772-9fc8-1c74036cca7b") },
                    { new Guid("1964a3db-35a1-490d-a25e-556eed5911a4"), false, false, "https://static8.depositphotos.com/1460388/938/i/600/depositphotos_9388060-stock-photo-next-rally.jpg", new Guid("d7c4b238-88d2-4456-a6f9-1fc5cd29509a") },
                    { new Guid("667a3650-62da-497d-a165-d7b627eddf3c"), false, false, "https://static8.depositphotos.com/1460388/938/i/600/depositphotos_9388060-stock-photo-next-rally.jpg", new Guid("d7c4b238-88d2-4456-a6f9-1fc5cd29509a") },
                    { new Guid("b19a07ab-30c8-4a88-86fe-b49616d0ed13"), true, false, "https://static8.depositphotos.com/1460388/938/i/600/depositphotos_9388060-stock-photo-next-rally.jpg", new Guid("257b8445-2cfa-4772-9fc8-1c74036cca7b") }
                });

            migrationBuilder.InsertData(
                table: "TrainerReservations",
                columns: new[] { "Id", "CourtReservationId", "IsDeleted", "TrainerId" },
                values: new object[,]
                {
                    { new Guid("162b630a-644b-428c-a4df-865de13277e4"), new Guid("070f1d3f-7487-4ec3-b22c-7d66eade90f1"), false, new Guid("257b8445-2cfa-4772-9fc8-1c74036cca7b") },
                    { new Guid("47eed06c-351b-4bf0-b026-a3b0add3c871"), new Guid("3cee9034-dfa2-41a2-a116-59333f220322"), false, new Guid("d7c4b238-88d2-4456-a6f9-1fc5cd29509a") },
                    { new Guid("bb86baaa-e685-498d-916d-695b0fc84f92"), new Guid("9859b4f8-5904-4b9a-b203-1fb7f1f36b99"), true, new Guid("d7c4b238-88d2-4456-a6f9-1fc5cd29509a") }
                });

            migrationBuilder.InsertData(
                table: "TrainerReviews",
                columns: new[] { "Id", "Hide", "IsDeleted", "Rating", "ReservationId", "Text" },
                values: new object[] { new Guid("068db159-977b-4d28-8067-1c40840299d4"), false, false, 5, new Guid("162b630a-644b-428c-a4df-865de13277e4"), "Awesome!" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("4e838456-4c35-4b7d-8fb2-cfe3f6634f61"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("515d5846-4665-488f-a006-516721b6634a"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("bb58669b-d6bb-45d5-9c9d-966ef6b9e44d"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("dbbcf2b0-3e08-42ad-8317-fbb6f6c25983"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("f8b5b07a-1a89-430a-9f67-55ac17d723e6"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("1637b7ee-e801-4631-92c6-8efb0439f489"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("1964a3db-35a1-490d-a25e-556eed5911a4"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("667a3650-62da-497d-a165-d7b627eddf3c"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("b19a07ab-30c8-4a88-86fe-b49616d0ed13"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("47eed06c-351b-4bf0-b026-a3b0add3c871"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("bb86baaa-e685-498d-916d-695b0fc84f92"));

            migrationBuilder.DeleteData(
                table: "TrainerReviews",
                keyColumn: "Id",
                keyValue: new Guid("068db159-977b-4d28-8067-1c40840299d4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6c8d8a53-f5ac-4fea-b0da-d19d05d4784d"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("3cee9034-dfa2-41a2-a116-59333f220322"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("9859b4f8-5904-4b9a-b203-1fb7f1f36b99"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("875fd8d9-3ae2-4222-bd4a-d0189c2a71d1"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("aa6390dc-ed52-42c6-9236-99036b9f040f"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("162b630a-644b-428c-a4df-865de13277e4"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("d7c4b238-88d2-4456-a6f9-1fc5cd29509a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1274d0bc-b6d7-46b0-9f56-9d391735f941"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e0182e3-ae8a-485c-9b90-32e1379baa3d"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("070f1d3f-7487-4ec3-b22c-7d66eade90f1"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("ee427533-5658-4ccf-86e5-c82943ee84db"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("257b8445-2cfa-4772-9fc8-1c74036cca7b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10bbd36f-8a70-406b-8fcf-df8e177603f6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f4d2804f-6008-42f2-b243-8d0ead61d6f1"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("ec858b0b-f861-45d4-8371-edd21d5fc799"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b3c7c975-7dc0-4486-a3c4-524201624fca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d40b6b29-f87c-4384-87da-34151d9ab66b"));

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("08270c26-6799-4270-a319-533bee854927"), "D", 500m, false },
                    { new Guid("0cdbbff1-2588-4d06-acdb-c9c765763ecd"), "B", 800m, false },
                    { new Guid("21582987-8c62-4c0e-8baa-c9b17bef04a9"), "C", 800m, false },
                    { new Guid("4c74390d-31bd-431e-bec5-7478d8bc067a"), "A", 1000m, false }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "IsDeleted", "IsTrainer", "LastName", "PasswordHash", "PhotoPath", "Role", "SecurityStamp" },
                values: new object[,]
                {
                    { new Guid("02414384-5f04-4c71-817e-84c9401489af"), new DateTime(1995, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "pppeter@nonexistentmail.com", "Peter", false, false, "Griffin", "AQAAAAEAACcQAAAAEHXEV2HCDjz7mVo6WFzIKS1rWts0VQwNFiYGj8JnBHlmD3xeqwMBBYvH4RhQITs5qQ==", "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg", 0, "2abcdef" },
                    { new Guid("2b4f490b-78c6-4d78-8052-14095a47a7dd"), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@sprint.cz", "Admin", false, true, "Admin", "AQAAAAEAACcQAAAAEHXEV2HCDjz7mVo6WFzIKS1rWts0VQwNFiYGj8JnBHlmD3xeqwMBBYvH4RhQITs5qQ==", "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg", 1, "6abcdef" },
                    { new Guid("4386b2d9-89ff-453d-8d1e-f8d5ba2eb87b"), new DateTime(1955, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "monic@nonexistentmail.com", "Monica", false, false, "Bellucci", "AQAAAAEAACcQAAAAEHXEV2HCDjz7mVo6WFzIKS1rWts0VQwNFiYGj8JnBHlmD3xeqwMBBYvH4RhQITs5qQ==", "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg", 0, "4abcdef" },
                    { new Guid("9a14dd6e-6198-4b43-ba4e-f15319cb66a7"), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "rhanculak@mail.muni.cz", "Radovan", false, true, "Hančuľák", "AQAAAAEAACcQAAAAEHXEV2HCDjz7mVo6WFzIKS1rWts0VQwNFiYGj8JnBHlmD3xeqwMBBYvH4RhQITs5qQ==", "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg", 1, "5abcdef" },
                    { new Guid("b2d6a26e-8cb5-4301-9d6f-6acbd4cdba52"), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "493352@mail.muni.cz", "Jitka", false, true, "Viceníková", "AQAAAAEAACcQAAAAEHXEV2HCDjz7mVo6WFzIKS1rWts0VQwNFiYGj8JnBHlmD3xeqwMBBYvH4RhQITs5qQ==", "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg", 1, "6abcdef" },
                    { new Guid("bcbcb6f0-6f36-4bf4-b44b-81f539030b8d"), new DateTime(1993, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "rntr@nonexistentmail.com", "Roman", false, false, "NieTenRoman", "AQAAAAEAACcQAAAAEHXEV2HCDjz7mVo6WFzIKS1rWts0VQwNFiYGj8JnBHlmD3xeqwMBBYvH4RhQITs5qQ==", "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg", 0, "3abcdef" },
                    { new Guid("f48f6bc9-42f1-4eeb-b234-e58711a87103"), new DateTime(2001, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "514329@mail.muni.cz", "Adam", false, false, "Mydla", "AQAAAAEAACcQAAAAEHXEV2HCDjz7mVo6WFzIKS1rWts0VQwNFiYGj8JnBHlmD3xeqwMBBYvH4RhQITs5qQ==", "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg", 0, "1abcdef" }
                });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("0d6f904c-09e3-46bb-96a3-71225fc687dd"), new Guid("4c74390d-31bd-431e-bec5-7478d8bc067a"), new DateTime(2022, 9, 28, 19, 19, 19, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("02414384-5f04-4c71-817e-84c9401489af") },
                    { new Guid("1c4199b5-dffa-4d91-a5d8-b9b7a45ad9f8"), new Guid("4c74390d-31bd-431e-bec5-7478d8bc067a"), new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f48f6bc9-42f1-4eeb-b234-e58711a87103") },
                    { new Guid("46ca34a1-d8b2-45bd-98dd-c75dc3593e58"), new Guid("21582987-8c62-4c0e-8baa-c9b17bef04a9"), new DateTime(2022, 9, 5, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f48f6bc9-42f1-4eeb-b234-e58711a87103") },
                    { new Guid("4869f2a5-5283-4aac-9286-07ffdf64e4b1"), new Guid("0cdbbff1-2588-4d06-acdb-c9c765763ecd"), new DateTime(2022, 9, 16, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 9, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bcbcb6f0-6f36-4bf4-b44b-81f539030b8d") },
                    { new Guid("4970864a-7db3-4d37-bf25-9136d2ac9852"), new Guid("0cdbbff1-2588-4d06-acdb-c9c765763ecd"), new DateTime(2022, 9, 15, 18, 4, 4, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bcbcb6f0-6f36-4bf4-b44b-81f539030b8d") },
                    { new Guid("60f7e6bc-ceac-4a89-9ed6-e4822ece7d96"), new Guid("21582987-8c62-4c0e-8baa-c9b17bef04a9"), new DateTime(2022, 9, 21, 6, 51, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f48f6bc9-42f1-4eeb-b234-e58711a87103") },
                    { new Guid("dafc2fa5-40a9-48fc-8864-b99b3bbbcdfa"), new Guid("08270c26-6799-4270-a319-533bee854927"), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 12, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4386b2d9-89ff-453d-8d1e-f8d5ba2eb87b") },
                    { new Guid("df96fece-4bd0-46d9-ada9-d1ea7b39bec1"), new Guid("4c74390d-31bd-431e-bec5-7478d8bc067a"), new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), new Guid("02414384-5f04-4c71-817e-84c9401489af") }
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Description", "HourlyRate", "IsDeleted", "UserId" },
                values: new object[,]
                {
                    { new Guid("dfdb5acc-aeb2-4465-a859-8ba250311e38"), "I know how to play, that's all", 2000m, false, new Guid("9a14dd6e-6198-4b43-ba4e-f15319cb66a7") },
                    { new Guid("e97aaae7-f306-418a-bbb0-8172600ca28b"), "I know how to play even better, that's all", 3485m, false, new Guid("b2d6a26e-8cb5-4301-9d6f-6acbd4cdba52") }
                });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "IsDeleted", "Path", "TrainerId" },
                values: new object[,]
                {
                    { new Guid("81ed96c7-f207-4952-a889-53ccc5ca0783"), true, false, "tbd", new Guid("e97aaae7-f306-418a-bbb0-8172600ca28b") },
                    { new Guid("8bd0b742-4183-4cfa-9704-889d45f9197c"), false, false, "tbd", new Guid("dfdb5acc-aeb2-4465-a859-8ba250311e38") },
                    { new Guid("b26b93fc-f4c5-4dbf-b35b-1fa94db26273"), true, false, "tbd", new Guid("e97aaae7-f306-418a-bbb0-8172600ca28b") },
                    { new Guid("ff161d88-213e-4958-8059-d97798c69d19"), false, false, "tbd", new Guid("dfdb5acc-aeb2-4465-a859-8ba250311e38") }
                });

            migrationBuilder.InsertData(
                table: "TrainerReservations",
                columns: new[] { "Id", "CourtReservationId", "IsDeleted", "TrainerId" },
                values: new object[,]
                {
                    { new Guid("0d3198ef-53c1-45aa-8ae8-670d4e08bf36"), new Guid("4869f2a5-5283-4aac-9286-07ffdf64e4b1"), true, new Guid("dfdb5acc-aeb2-4465-a859-8ba250311e38") },
                    { new Guid("cd658e1a-9056-4966-9af8-9a2b66b293af"), new Guid("4970864a-7db3-4d37-bf25-9136d2ac9852"), false, new Guid("dfdb5acc-aeb2-4465-a859-8ba250311e38") },
                    { new Guid("e6c1928a-e4ca-43df-be38-7beb3596f9dd"), new Guid("dafc2fa5-40a9-48fc-8864-b99b3bbbcdfa"), false, new Guid("e97aaae7-f306-418a-bbb0-8172600ca28b") }
                });

            migrationBuilder.InsertData(
                table: "TrainerReviews",
                columns: new[] { "Id", "Hide", "IsDeleted", "Rating", "ReservationId", "Text" },
                values: new object[] { new Guid("c86327ad-29f0-4fa4-82f9-fc7b234cabfa"), false, false, 5, new Guid("e6c1928a-e4ca-43df-be38-7beb3596f9dd"), "tbd" });
        }
    }
}
