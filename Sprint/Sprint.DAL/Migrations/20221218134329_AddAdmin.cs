using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sprint.DAL.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class AddAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("355a1a58-e4eb-4ae7-8288-a4ddc36a0134"), "C", 800m, false },
                    { new Guid("794d2012-dc07-42c9-a2d8-a685b15f3786"), "D", 500m, false },
                    { new Guid("9f3191c6-1e26-4b7b-8e72-ab567cfffd6a"), "A", 1000m, false },
                    { new Guid("ddbc951b-4266-45fb-a251-2f95a790a70d"), "B", 800m, false }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "IsDeleted", "IsTrainer", "LastName", "PasswordHash", "PhotoPath", "Role", "SecurityStamp" },
                values: new object[,]
                {
                    { new Guid("01e782c1-5410-4679-a6a0-9b4aa8f29b21"), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "rhanculak@mail.muni.cz", "Radovan", false, true, "Hančuľák", "AQAAAAEAACcQAAAAEDYvse/qqhU35jl44zZBhM9bCpnX2o80uv2Q7NpynUUcTSL+TO6dSU258h/1muym4g==", "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg", 1, "5abcdef" },
                    { new Guid("1b0fadba-d4c0-4dda-be29-070698133b26"), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "493352@mail.muni.cz", "Jitka", false, true, "Viceníková", "AQAAAAEAACcQAAAAEDYvse/qqhU35jl44zZBhM9bCpnX2o80uv2Q7NpynUUcTSL+TO6dSU258h/1muym4g==", "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg", 1, "6abcdef" },
                    { new Guid("1b2d9929-0ded-41c5-ab02-2ea77b034b14"), new DateTime(1995, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "pppeter@nonexistentmail.com", "Peter", false, false, "Griffin", "AQAAAAEAACcQAAAAEDYvse/qqhU35jl44zZBhM9bCpnX2o80uv2Q7NpynUUcTSL+TO6dSU258h/1muym4g==", "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg", 0, "2abcdef" },
                    { new Guid("38a0f66e-4357-4d08-90bc-6c001fab8248"), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@sprint.cz", "Admin", false, true, "Admin", "AQAAAAEAACcQAAAAEDYvse/qqhU35jl44zZBhM9bCpnX2o80uv2Q7NpynUUcTSL+TO6dSU258h/1muym4g==", "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg", 2, "6abcdef" },
                    { new Guid("885b4e04-a384-4e97-b7bb-8ba2c5a498c6"), new DateTime(2001, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "514329@mail.muni.cz", "Adam", false, false, "Mydla", "AQAAAAEAACcQAAAAEDYvse/qqhU35jl44zZBhM9bCpnX2o80uv2Q7NpynUUcTSL+TO6dSU258h/1muym4g==", "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg", 0, "1abcdef" },
                    { new Guid("8a2d90eb-2022-48d9-8382-14cde71351a5"), new DateTime(1993, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "rntr@nonexistentmail.com", "Roman", false, false, "NieTenRoman", "AQAAAAEAACcQAAAAEDYvse/qqhU35jl44zZBhM9bCpnX2o80uv2Q7NpynUUcTSL+TO6dSU258h/1muym4g==", "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg", 0, "3abcdef" },
                    { new Guid("aa411737-fd41-4870-83a6-e8dc4044e3b7"), new DateTime(1955, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "monic@nonexistentmail.com", "Monica", false, false, "Bellucci", "AQAAAAEAACcQAAAAEDYvse/qqhU35jl44zZBhM9bCpnX2o80uv2Q7NpynUUcTSL+TO6dSU258h/1muym4g==", "https://img3.stockfresh.com/files/w/wavebreak_media/m/12/8944331_stock-photo-badminton-player-holding-racket-and-shuttlecock.jpg", 0, "4abcdef" }
                });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("198b0f1e-11ab-474a-aa44-ae9d3661fd5e"), new Guid("794d2012-dc07-42c9-a2d8-a685b15f3786"), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 12, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aa411737-fd41-4870-83a6-e8dc4044e3b7") },
                    { new Guid("7de69e84-3663-450e-8d93-d3b27ca680f5"), new Guid("355a1a58-e4eb-4ae7-8288-a4ddc36a0134"), new DateTime(2022, 9, 21, 6, 51, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), new Guid("885b4e04-a384-4e97-b7bb-8ba2c5a498c6") },
                    { new Guid("a25e935c-b835-4595-9578-eea7ecb4ffe2"), new Guid("9f3191c6-1e26-4b7b-8e72-ab567cfffd6a"), new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1b2d9929-0ded-41c5-ab02-2ea77b034b14") },
                    { new Guid("bc67b007-02d9-4c84-8cad-13d0f058908d"), new Guid("355a1a58-e4eb-4ae7-8288-a4ddc36a0134"), new DateTime(2022, 9, 5, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new Guid("885b4e04-a384-4e97-b7bb-8ba2c5a498c6") },
                    { new Guid("c83ae353-1c6d-4010-9195-0d9fae4bc521"), new Guid("ddbc951b-4266-45fb-a251-2f95a790a70d"), new DateTime(2022, 9, 16, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 9, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8a2d90eb-2022-48d9-8382-14cde71351a5") },
                    { new Guid("d42de53a-7788-49ea-a7ba-c07dd5eda7ff"), new Guid("9f3191c6-1e26-4b7b-8e72-ab567cfffd6a"), new DateTime(2022, 9, 28, 19, 19, 19, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1b2d9929-0ded-41c5-ab02-2ea77b034b14") },
                    { new Guid("dae9a42b-fd8a-47d2-9d38-bd88d0ca1120"), new Guid("9f3191c6-1e26-4b7b-8e72-ab567cfffd6a"), new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("885b4e04-a384-4e97-b7bb-8ba2c5a498c6") },
                    { new Guid("daf53428-11a8-45db-8ed0-36b15551e519"), new Guid("ddbc951b-4266-45fb-a251-2f95a790a70d"), new DateTime(2022, 9, 15, 18, 4, 4, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8a2d90eb-2022-48d9-8382-14cde71351a5") }
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Description", "HourlyRate", "IsDeleted", "UserId" },
                values: new object[,]
                {
                    { new Guid("d4fbc9d5-1145-4ed9-a73e-c24b0f6374a0"), "I know how to play, that's all", 2000m, false, new Guid("01e782c1-5410-4679-a6a0-9b4aa8f29b21") },
                    { new Guid("d5d48bf1-dd40-4bf1-a359-49d1294d1b3f"), "I know how to play even better, that's all", 3485m, false, new Guid("1b0fadba-d4c0-4dda-be29-070698133b26") }
                });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "IsDeleted", "Path", "TrainerId" },
                values: new object[,]
                {
                    { new Guid("2cfb41fa-f5d7-4804-be96-7c1aea18885d"), true, false, "https://static8.depositphotos.com/1460388/938/i/600/depositphotos_9388060-stock-photo-next-rally.jpg", new Guid("d5d48bf1-dd40-4bf1-a359-49d1294d1b3f") },
                    { new Guid("b36fc384-f8d0-42aa-a352-7b6d9d32ee14"), false, false, "https://static8.depositphotos.com/1460388/938/i/600/depositphotos_9388060-stock-photo-next-rally.jpg", new Guid("d4fbc9d5-1145-4ed9-a73e-c24b0f6374a0") },
                    { new Guid("b772b3a7-238f-487a-bf58-b391cd67ad00"), false, false, "https://static8.depositphotos.com/1460388/938/i/600/depositphotos_9388060-stock-photo-next-rally.jpg", new Guid("d4fbc9d5-1145-4ed9-a73e-c24b0f6374a0") },
                    { new Guid("f3a7c39c-c819-4ab4-8000-978e8d4f5704"), true, false, "https://static8.depositphotos.com/1460388/938/i/600/depositphotos_9388060-stock-photo-next-rally.jpg", new Guid("d5d48bf1-dd40-4bf1-a359-49d1294d1b3f") }
                });

            migrationBuilder.InsertData(
                table: "TrainerReservations",
                columns: new[] { "Id", "CourtReservationId", "IsDeleted", "TrainerId" },
                values: new object[,]
                {
                    { new Guid("187d320f-e01c-44d5-ab32-9fc344c15888"), new Guid("198b0f1e-11ab-474a-aa44-ae9d3661fd5e"), false, new Guid("d5d48bf1-dd40-4bf1-a359-49d1294d1b3f") },
                    { new Guid("4e66c4d2-f30b-4ff3-8178-e42a0f03fa18"), new Guid("daf53428-11a8-45db-8ed0-36b15551e519"), false, new Guid("d4fbc9d5-1145-4ed9-a73e-c24b0f6374a0") },
                    { new Guid("59320dac-3a78-41d2-a962-0252ee865176"), new Guid("c83ae353-1c6d-4010-9195-0d9fae4bc521"), true, new Guid("d4fbc9d5-1145-4ed9-a73e-c24b0f6374a0") }
                });

            migrationBuilder.InsertData(
                table: "TrainerReviews",
                columns: new[] { "Id", "Hide", "IsDeleted", "Rating", "ReservationId", "Text" },
                values: new object[] { new Guid("05c529ba-e3e1-46ad-9d86-67e00c3db32c"), false, false, 5, new Guid("187d320f-e01c-44d5-ab32-9fc344c15888"), "Awesome!" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("7de69e84-3663-450e-8d93-d3b27ca680f5"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("a25e935c-b835-4595-9578-eea7ecb4ffe2"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("bc67b007-02d9-4c84-8cad-13d0f058908d"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("d42de53a-7788-49ea-a7ba-c07dd5eda7ff"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("dae9a42b-fd8a-47d2-9d38-bd88d0ca1120"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("2cfb41fa-f5d7-4804-be96-7c1aea18885d"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("b36fc384-f8d0-42aa-a352-7b6d9d32ee14"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("b772b3a7-238f-487a-bf58-b391cd67ad00"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("f3a7c39c-c819-4ab4-8000-978e8d4f5704"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("4e66c4d2-f30b-4ff3-8178-e42a0f03fa18"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("59320dac-3a78-41d2-a962-0252ee865176"));

            migrationBuilder.DeleteData(
                table: "TrainerReviews",
                keyColumn: "Id",
                keyValue: new Guid("05c529ba-e3e1-46ad-9d86-67e00c3db32c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("38a0f66e-4357-4d08-90bc-6c001fab8248"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("c83ae353-1c6d-4010-9195-0d9fae4bc521"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("daf53428-11a8-45db-8ed0-36b15551e519"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("355a1a58-e4eb-4ae7-8288-a4ddc36a0134"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("9f3191c6-1e26-4b7b-8e72-ab567cfffd6a"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("187d320f-e01c-44d5-ab32-9fc344c15888"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("d4fbc9d5-1145-4ed9-a73e-c24b0f6374a0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1b2d9929-0ded-41c5-ab02-2ea77b034b14"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("885b4e04-a384-4e97-b7bb-8ba2c5a498c6"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("198b0f1e-11ab-474a-aa44-ae9d3661fd5e"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("ddbc951b-4266-45fb-a251-2f95a790a70d"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("d5d48bf1-dd40-4bf1-a359-49d1294d1b3f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("01e782c1-5410-4679-a6a0-9b4aa8f29b21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8a2d90eb-2022-48d9-8382-14cde71351a5"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("794d2012-dc07-42c9-a2d8-a685b15f3786"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1b0fadba-d4c0-4dda-be29-070698133b26"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa411737-fd41-4870-83a6-e8dc4044e3b7"));

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
    }
}
