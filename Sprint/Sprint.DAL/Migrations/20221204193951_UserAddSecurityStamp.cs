using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sprint.DAL.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class UserAddSecurityStamp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("3d98094c-a6b7-4c57-9b92-8b653254d807"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("769500e9-55f1-466c-91c1-629e069f5a47"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("95ecf625-4f2a-4a63-89e0-f8875e375764"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("d2427e6f-dff9-4dfd-a642-f152aefd2f00"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("ee59459e-90dd-4856-9e60-9377d7d629c2"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("6e604110-b762-482c-8f19-3c596fa9c4b7"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("70150cd1-3d4d-4a1f-a998-89ddfa065e89"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("8287b03e-8b23-422f-acd2-c8eacf67c940"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("e8d7fc6a-f00c-431a-83fa-7aa75c76afa2"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("01948a50-74a9-4905-b13d-a3355f2b310a"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("02f356b6-84d4-493c-9516-e873d9259393"));

            migrationBuilder.DeleteData(
                table: "TrainerReviews",
                keyColumn: "Id",
                keyValue: new Guid("494674da-f0ec-4a06-adb0-04b1d412cba6"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("67928fb6-3274-4dac-9148-0b3404f72905"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("77537ad0-bd42-47c8-a423-01cca83fc116"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("01ae6160-5b3d-49d0-b310-513dc2f016c7"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("e3a1aa08-1294-4521-8296-83f55c609903"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("f3bfc2c6-421d-43d9-b904-ceb8159cae1c"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("c1f063e5-0905-4a64-a55d-2e172f0f82a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("50eec809-60af-4861-a251-8d625415c86d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("67ef4e77-a0db-42a9-8cdc-5bfd4253a319"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("3ffab3b1-6cc0-41ca-9f36-41b790eb3d67"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("b33eae87-7342-4b3d-8516-641dc74b78c2"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("e57920ce-c0ef-4799-9c87-b47faae9aa37"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8d8f7ae6-fc10-4636-a9ff-af8e62dc4608"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a1458b88-d332-4d57-9660-0852a2fc756d"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("47651432-6037-4b95-8f71-d66f8ec111ce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("70da335e-1ed3-4580-bb64-1d6af3fb90ae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("85ea12ba-25d3-4b63-84c4-c20277748252"));

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate" },
                values: new object[,]
                {
                    { new Guid("4ecb7510-a1e8-4ac4-b033-1d98b1457693"), "A", 1000m },
                    { new Guid("5cad9183-60bb-44b5-99f9-96260f71cc7c"), "B", 800m },
                    { new Guid("948a513c-dcc9-4d31-bfcd-73555429810b"), "C", 800m },
                    { new Guid("c9652d89-d860-45ea-b6c5-feb63f6a94e2"), "D", 500m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "IsTrainer", "LastName", "PasswordHash", "PhotoPath", "Role", "SecurityStamp" },
                values: new object[,]
                {
                    { new Guid("01b7e1f2-53f3-4708-b30c-e0474cc3a004"), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "rhanculak@mail.muni.cz", "Radovan", true, "Hančuľák", "tbd", "tbd", 0, "5abcdef" },
                    { new Guid("6c804cbf-85b0-43e0-894b-a70ebf50dbee"), new DateTime(1955, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "monic@nonexistentmail.com", "Monica", false, "Bellucci", "tbd", "tbd", 0, "4abcdef" },
                    { new Guid("706dce76-bb9d-4ad2-91a4-0e144f824f88"), new DateTime(1995, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "pppeter@nonexistentmail.com", "Peter", false, "Griffin", "tbd", "tbd", 0, "2abcdef" },
                    { new Guid("766d4249-db85-4c9c-a275-f43dbd67869e"), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "493352@mail.muni.cz", "Jitka", true, "Viceníková", "tbd", "tbd", 0, "6abcdef" },
                    { new Guid("a71850ce-6719-4ed4-ae31-b20c62a8f931"), new DateTime(2001, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "514329@mail.muni.cz", "Adam", false, "Mydla", "tbd", "tbd", 0, "1abcdef" },
                    { new Guid("b69e9a6f-6b23-4d77-b3b6-7390259197f7"), new DateTime(1993, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "rntr@nonexistentmail.com", "Roman", false, "NieTenRoman", "tbd", "tbd", 0, "3abcdef" }
                });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("1312c777-ab11-46d3-bc8f-deabd7b88ac0"), new Guid("948a513c-dcc9-4d31-bfcd-73555429810b"), new DateTime(2022, 9, 5, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a71850ce-6719-4ed4-ae31-b20c62a8f931") },
                    { new Guid("3994328e-292b-4505-bee2-e7ee5df55fc5"), new Guid("4ecb7510-a1e8-4ac4-b033-1d98b1457693"), new DateTime(2022, 9, 28, 19, 19, 19, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("706dce76-bb9d-4ad2-91a4-0e144f824f88") },
                    { new Guid("4279b61a-9d6f-4091-b042-260f9e138f16"), new Guid("5cad9183-60bb-44b5-99f9-96260f71cc7c"), new DateTime(2022, 9, 15, 18, 4, 4, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b69e9a6f-6b23-4d77-b3b6-7390259197f7") },
                    { new Guid("77bad34a-2689-4745-8464-98e325922256"), new Guid("c9652d89-d860-45ea-b6c5-feb63f6a94e2"), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 12, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6c804cbf-85b0-43e0-894b-a70ebf50dbee") },
                    { new Guid("ca91c6a8-3c2f-4439-952a-8a676efae005"), new Guid("5cad9183-60bb-44b5-99f9-96260f71cc7c"), new DateTime(2022, 9, 16, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 9, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b69e9a6f-6b23-4d77-b3b6-7390259197f7") },
                    { new Guid("eeaee8cf-7579-4d3c-a81d-60e65a25cb3d"), new Guid("4ecb7510-a1e8-4ac4-b033-1d98b1457693"), new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a71850ce-6719-4ed4-ae31-b20c62a8f931") },
                    { new Guid("f0ff7ead-2fa7-4b59-aa24-0d6371b8ca70"), new Guid("948a513c-dcc9-4d31-bfcd-73555429810b"), new DateTime(2022, 9, 21, 6, 51, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a71850ce-6719-4ed4-ae31-b20c62a8f931") },
                    { new Guid("f9a96b21-978c-41f6-b859-e6451be08ffb"), new Guid("4ecb7510-a1e8-4ac4-b033-1d98b1457693"), new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), new Guid("706dce76-bb9d-4ad2-91a4-0e144f824f88") }
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Description", "HourlyRate", "UserId" },
                values: new object[,]
                {
                    { new Guid("12947f7a-a38b-4636-b3c7-1e878f09577e"), "I know how to play, that's all", 2000m, new Guid("01b7e1f2-53f3-4708-b30c-e0474cc3a004") },
                    { new Guid("b7b260c8-bdad-4fe0-8fc0-01949318e999"), "I know how to play even better, that's all", 3485m, new Guid("766d4249-db85-4c9c-a275-f43dbd67869e") }
                });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[,]
                {
                    { new Guid("229b95f8-89e0-4b64-8e7d-9150374fd016"), true, "tbd", new Guid("b7b260c8-bdad-4fe0-8fc0-01949318e999") },
                    { new Guid("452b0f52-9c3d-4af4-9e12-3eb3e7406973"), false, "tbd", new Guid("12947f7a-a38b-4636-b3c7-1e878f09577e") },
                    { new Guid("b88c5cd2-c268-406d-a864-daad8025d6a3"), false, "tbd", new Guid("12947f7a-a38b-4636-b3c7-1e878f09577e") },
                    { new Guid("bdfcf2e1-2865-4afb-a912-691224eed780"), true, "tbd", new Guid("b7b260c8-bdad-4fe0-8fc0-01949318e999") }
                });

            migrationBuilder.InsertData(
                table: "TrainerReservations",
                columns: new[] { "Id", "CourtReservationId", "IsDeleted", "TrainerId", "TrainerReviewId" },
                values: new object[,]
                {
                    { new Guid("1eeb76fe-1a07-49a2-8c26-3d69184468ea"), new Guid("4279b61a-9d6f-4091-b042-260f9e138f16"), false, new Guid("12947f7a-a38b-4636-b3c7-1e878f09577e"), null },
                    { new Guid("7d211be3-b1d4-4c01-ac1e-b0097208c288"), new Guid("ca91c6a8-3c2f-4439-952a-8a676efae005"), true, new Guid("12947f7a-a38b-4636-b3c7-1e878f09577e"), null },
                    { new Guid("e03a2ec7-1274-45cf-b05b-572ce60eca7d"), new Guid("77bad34a-2689-4745-8464-98e325922256"), false, new Guid("b7b260c8-bdad-4fe0-8fc0-01949318e999"), null }
                });

            migrationBuilder.InsertData(
                table: "TrainerReviews",
                columns: new[] { "Id", "Hide", "Rating", "ReservationId", "Text" },
                values: new object[] { new Guid("bc9972fd-67b2-4835-95f2-e2ea1a078b0f"), false, 5, new Guid("e03a2ec7-1274-45cf-b05b-572ce60eca7d"), "tbd" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("1312c777-ab11-46d3-bc8f-deabd7b88ac0"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("3994328e-292b-4505-bee2-e7ee5df55fc5"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("eeaee8cf-7579-4d3c-a81d-60e65a25cb3d"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("f0ff7ead-2fa7-4b59-aa24-0d6371b8ca70"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("f9a96b21-978c-41f6-b859-e6451be08ffb"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("229b95f8-89e0-4b64-8e7d-9150374fd016"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("452b0f52-9c3d-4af4-9e12-3eb3e7406973"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("b88c5cd2-c268-406d-a864-daad8025d6a3"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("bdfcf2e1-2865-4afb-a912-691224eed780"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("1eeb76fe-1a07-49a2-8c26-3d69184468ea"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("7d211be3-b1d4-4c01-ac1e-b0097208c288"));

            migrationBuilder.DeleteData(
                table: "TrainerReviews",
                keyColumn: "Id",
                keyValue: new Guid("bc9972fd-67b2-4835-95f2-e2ea1a078b0f"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("4279b61a-9d6f-4091-b042-260f9e138f16"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("ca91c6a8-3c2f-4439-952a-8a676efae005"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("4ecb7510-a1e8-4ac4-b033-1d98b1457693"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("948a513c-dcc9-4d31-bfcd-73555429810b"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("e03a2ec7-1274-45cf-b05b-572ce60eca7d"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("12947f7a-a38b-4636-b3c7-1e878f09577e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("706dce76-bb9d-4ad2-91a4-0e144f824f88"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a71850ce-6719-4ed4-ae31-b20c62a8f931"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("77bad34a-2689-4745-8464-98e325922256"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("5cad9183-60bb-44b5-99f9-96260f71cc7c"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("b7b260c8-bdad-4fe0-8fc0-01949318e999"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("01b7e1f2-53f3-4708-b30c-e0474cc3a004"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b69e9a6f-6b23-4d77-b3b6-7390259197f7"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("c9652d89-d860-45ea-b6c5-feb63f6a94e2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6c804cbf-85b0-43e0-894b-a70ebf50dbee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("766d4249-db85-4c9c-a275-f43dbd67869e"));

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate" },
                values: new object[,]
                {
                    { new Guid("01ae6160-5b3d-49d0-b310-513dc2f016c7"), "C", 800m },
                    { new Guid("47651432-6037-4b95-8f71-d66f8ec111ce"), "D", 500m },
                    { new Guid("b33eae87-7342-4b3d-8516-641dc74b78c2"), "B", 800m },
                    { new Guid("e3a1aa08-1294-4521-8296-83f55c609903"), "A", 1000m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "IsTrainer", "LastName", "PasswordHash", "PhotoPath", "Role" },
                values: new object[,]
                {
                    { new Guid("50eec809-60af-4861-a251-8d625415c86d"), new DateTime(2001, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "514329@mail.muni.cz", "Adam", false, "Mydla", "tbd", "tbd", 0 },
                    { new Guid("67ef4e77-a0db-42a9-8cdc-5bfd4253a319"), new DateTime(1995, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "pppeter@nonexistentmail.com", "Peter", false, "Griffin", "tbd", "tbd", 0 },
                    { new Guid("70da335e-1ed3-4580-bb64-1d6af3fb90ae"), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "493352@mail.muni.cz", "Jitka", true, "Viceníková", "tbd", "tbd", 0 },
                    { new Guid("85ea12ba-25d3-4b63-84c4-c20277748252"), new DateTime(1955, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "monic@nonexistentmail.com", "Monica", false, "Bellucci", "tbd", "tbd", 0 },
                    { new Guid("8d8f7ae6-fc10-4636-a9ff-af8e62dc4608"), new DateTime(1993, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "rntr@nonexistentmail.com", "Roman", false, "NieTenRoman", "tbd", "tbd", 0 },
                    { new Guid("a1458b88-d332-4d57-9660-0852a2fc756d"), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "rhanculak@mail.muni.cz", "Radovan", true, "Hančuľák", "tbd", "tbd", 0 }
                });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("3d98094c-a6b7-4c57-9b92-8b653254d807"), new Guid("01ae6160-5b3d-49d0-b310-513dc2f016c7"), new DateTime(2022, 9, 21, 6, 51, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), new Guid("50eec809-60af-4861-a251-8d625415c86d") },
                    { new Guid("3ffab3b1-6cc0-41ca-9f36-41b790eb3d67"), new Guid("47651432-6037-4b95-8f71-d66f8ec111ce"), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 12, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("85ea12ba-25d3-4b63-84c4-c20277748252") },
                    { new Guid("67928fb6-3274-4dac-9148-0b3404f72905"), new Guid("b33eae87-7342-4b3d-8516-641dc74b78c2"), new DateTime(2022, 9, 16, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 9, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8d8f7ae6-fc10-4636-a9ff-af8e62dc4608") },
                    { new Guid("769500e9-55f1-466c-91c1-629e069f5a47"), new Guid("e3a1aa08-1294-4521-8296-83f55c609903"), new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("50eec809-60af-4861-a251-8d625415c86d") },
                    { new Guid("77537ad0-bd42-47c8-a423-01cca83fc116"), new Guid("b33eae87-7342-4b3d-8516-641dc74b78c2"), new DateTime(2022, 9, 15, 18, 4, 4, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8d8f7ae6-fc10-4636-a9ff-af8e62dc4608") },
                    { new Guid("95ecf625-4f2a-4a63-89e0-f8875e375764"), new Guid("e3a1aa08-1294-4521-8296-83f55c609903"), new DateTime(2022, 9, 28, 19, 19, 19, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("67ef4e77-a0db-42a9-8cdc-5bfd4253a319") },
                    { new Guid("d2427e6f-dff9-4dfd-a642-f152aefd2f00"), new Guid("01ae6160-5b3d-49d0-b310-513dc2f016c7"), new DateTime(2022, 9, 5, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new Guid("50eec809-60af-4861-a251-8d625415c86d") },
                    { new Guid("ee59459e-90dd-4856-9e60-9377d7d629c2"), new Guid("e3a1aa08-1294-4521-8296-83f55c609903"), new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), new Guid("67ef4e77-a0db-42a9-8cdc-5bfd4253a319") }
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Description", "HourlyRate", "UserId" },
                values: new object[,]
                {
                    { new Guid("c1f063e5-0905-4a64-a55d-2e172f0f82a5"), "I know how to play, that's all", 2000m, new Guid("a1458b88-d332-4d57-9660-0852a2fc756d") },
                    { new Guid("e57920ce-c0ef-4799-9c87-b47faae9aa37"), "I know how to play even better, that's all", 3485m, new Guid("70da335e-1ed3-4580-bb64-1d6af3fb90ae") }
                });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[,]
                {
                    { new Guid("6e604110-b762-482c-8f19-3c596fa9c4b7"), true, "tbd", new Guid("e57920ce-c0ef-4799-9c87-b47faae9aa37") },
                    { new Guid("70150cd1-3d4d-4a1f-a998-89ddfa065e89"), true, "tbd", new Guid("e57920ce-c0ef-4799-9c87-b47faae9aa37") },
                    { new Guid("8287b03e-8b23-422f-acd2-c8eacf67c940"), false, "tbd", new Guid("c1f063e5-0905-4a64-a55d-2e172f0f82a5") },
                    { new Guid("e8d7fc6a-f00c-431a-83fa-7aa75c76afa2"), false, "tbd", new Guid("c1f063e5-0905-4a64-a55d-2e172f0f82a5") }
                });

            migrationBuilder.InsertData(
                table: "TrainerReservations",
                columns: new[] { "Id", "CourtReservationId", "IsDeleted", "TrainerId", "TrainerReviewId" },
                values: new object[,]
                {
                    { new Guid("01948a50-74a9-4905-b13d-a3355f2b310a"), new Guid("67928fb6-3274-4dac-9148-0b3404f72905"), true, new Guid("c1f063e5-0905-4a64-a55d-2e172f0f82a5"), null },
                    { new Guid("02f356b6-84d4-493c-9516-e873d9259393"), new Guid("77537ad0-bd42-47c8-a423-01cca83fc116"), false, new Guid("c1f063e5-0905-4a64-a55d-2e172f0f82a5"), null },
                    { new Guid("f3bfc2c6-421d-43d9-b904-ceb8159cae1c"), new Guid("3ffab3b1-6cc0-41ca-9f36-41b790eb3d67"), false, new Guid("e57920ce-c0ef-4799-9c87-b47faae9aa37"), null }
                });

            migrationBuilder.InsertData(
                table: "TrainerReviews",
                columns: new[] { "Id", "Hide", "Rating", "ReservationId", "Text" },
                values: new object[] { new Guid("494674da-f0ec-4a06-adb0-04b1d412cba6"), false, 5, new Guid("f3bfc2c6-421d-43d9-b904-ceb8159cae1c"), "tbd" });
        }
    }
}
