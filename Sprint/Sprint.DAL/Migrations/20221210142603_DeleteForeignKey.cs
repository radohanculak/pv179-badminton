using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sprint.DAL.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class DeleteForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainerReservations_TrainerReviews_TrainerReviewId",
                table: "TrainerReservations");

            migrationBuilder.DropIndex(
                name: "IX_TrainerReviews_ReservationId",
                table: "TrainerReviews");

            migrationBuilder.DropIndex(
                name: "IX_TrainerReservations_TrainerReviewId",
                table: "TrainerReservations");

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
                name: "TrainerReviewId",
                table: "TrainerReservations");

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate" },
                values: new object[,]
                {
                    { new Guid("0bbe28da-2d3c-4f9d-9bac-4e71a94f7db0"), "B", 800m },
                    { new Guid("0c20b79a-a739-46ff-96d3-69b8647d8b50"), "C", 800m },
                    { new Guid("4bb06d25-11ec-43ac-a4a9-81661e942241"), "D", 500m },
                    { new Guid("f3df6de4-ddf6-4ccd-9ab8-7979af693cc0"), "A", 1000m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "IsTrainer", "LastName", "PasswordHash", "PhotoPath", "Role", "SecurityStamp" },
                values: new object[,]
                {
                    { new Guid("1a631a4b-bb6c-40e3-a0ef-a80614950876"), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "rhanculak@mail.muni.cz", "Radovan", true, "Hančuľák", "tbd", "tbd", 0, "5abcdef" },
                    { new Guid("228c087a-9708-40a3-b7ba-5c77c7acf1ac"), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "493352@mail.muni.cz", "Jitka", true, "Viceníková", "tbd", "tbd", 0, "6abcdef" },
                    { new Guid("6127ccf7-4ec7-4c56-8339-24653fe303a2"), new DateTime(1993, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "rntr@nonexistentmail.com", "Roman", false, "NieTenRoman", "tbd", "tbd", 0, "3abcdef" },
                    { new Guid("a599f1ab-a631-4119-929f-d09e7a80d758"), new DateTime(1955, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "monic@nonexistentmail.com", "Monica", false, "Bellucci", "tbd", "tbd", 0, "4abcdef" },
                    { new Guid("a71c6be5-e512-459a-b40d-0a870a6cd56f"), new DateTime(2001, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "514329@mail.muni.cz", "Adam", false, "Mydla", "tbd", "tbd", 0, "1abcdef" },
                    { new Guid("e3752cbf-1ca7-4185-84f9-5b0ae6909508"), new DateTime(1995, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "pppeter@nonexistentmail.com", "Peter", false, "Griffin", "tbd", "tbd", 0, "2abcdef" }
                });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("0f73608f-1324-4939-a679-7ccfbe632592"), new Guid("f3df6de4-ddf6-4ccd-9ab8-7979af693cc0"), new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e3752cbf-1ca7-4185-84f9-5b0ae6909508") },
                    { new Guid("25be54a3-6dc4-4af0-a7a3-e32f9d816743"), new Guid("0c20b79a-a739-46ff-96d3-69b8647d8b50"), new DateTime(2022, 9, 5, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a71c6be5-e512-459a-b40d-0a870a6cd56f") },
                    { new Guid("39aca6e9-fb70-42a0-a114-098290409ab7"), new Guid("f3df6de4-ddf6-4ccd-9ab8-7979af693cc0"), new DateTime(2022, 9, 28, 19, 19, 19, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e3752cbf-1ca7-4185-84f9-5b0ae6909508") },
                    { new Guid("651c7a8d-3e5d-4877-ab7d-c64622193543"), new Guid("0c20b79a-a739-46ff-96d3-69b8647d8b50"), new DateTime(2022, 9, 21, 6, 51, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a71c6be5-e512-459a-b40d-0a870a6cd56f") },
                    { new Guid("6e1d769f-e869-47e6-81d2-8ac2af06c6d3"), new Guid("0bbe28da-2d3c-4f9d-9bac-4e71a94f7db0"), new DateTime(2022, 9, 15, 18, 4, 4, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6127ccf7-4ec7-4c56-8339-24653fe303a2") },
                    { new Guid("6f549e4f-d0e7-4643-9a8a-e572ce00d9c6"), new Guid("4bb06d25-11ec-43ac-a4a9-81661e942241"), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 12, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a599f1ab-a631-4119-929f-d09e7a80d758") },
                    { new Guid("9b4e02db-2e22-4771-adc3-548f30dfe93e"), new Guid("f3df6de4-ddf6-4ccd-9ab8-7979af693cc0"), new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a71c6be5-e512-459a-b40d-0a870a6cd56f") },
                    { new Guid("d291f83c-d1ff-4815-9223-3c4728079537"), new Guid("0bbe28da-2d3c-4f9d-9bac-4e71a94f7db0"), new DateTime(2022, 9, 16, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 9, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6127ccf7-4ec7-4c56-8339-24653fe303a2") }
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Description", "HourlyRate", "UserId" },
                values: new object[,]
                {
                    { new Guid("7efd8053-1f79-448c-97af-36504394b4f4"), "I know how to play, that's all", 2000m, new Guid("1a631a4b-bb6c-40e3-a0ef-a80614950876") },
                    { new Guid("ced745b0-d3f3-4641-90bc-dc4bb6260bb4"), "I know how to play even better, that's all", 3485m, new Guid("228c087a-9708-40a3-b7ba-5c77c7acf1ac") }
                });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[,]
                {
                    { new Guid("176d365d-a4ae-4516-bf13-ec8eb8032482"), false, "tbd", new Guid("7efd8053-1f79-448c-97af-36504394b4f4") },
                    { new Guid("806232f6-5b18-4d33-8d6e-807613eea646"), false, "tbd", new Guid("7efd8053-1f79-448c-97af-36504394b4f4") },
                    { new Guid("cfae7435-773e-4991-ae4b-b51884572c24"), true, "tbd", new Guid("ced745b0-d3f3-4641-90bc-dc4bb6260bb4") },
                    { new Guid("eb409b84-4599-4fc1-8419-12fb817062f3"), true, "tbd", new Guid("ced745b0-d3f3-4641-90bc-dc4bb6260bb4") }
                });

            migrationBuilder.InsertData(
                table: "TrainerReservations",
                columns: new[] { "Id", "CourtReservationId", "IsDeleted", "TrainerId" },
                values: new object[,]
                {
                    { new Guid("91b67825-2101-4e51-8b97-860a8687df12"), new Guid("d291f83c-d1ff-4815-9223-3c4728079537"), true, new Guid("7efd8053-1f79-448c-97af-36504394b4f4") },
                    { new Guid("a813c6f2-bd50-4300-a9fe-27a37ea196f7"), new Guid("6f549e4f-d0e7-4643-9a8a-e572ce00d9c6"), false, new Guid("ced745b0-d3f3-4641-90bc-dc4bb6260bb4") },
                    { new Guid("d6616aaf-b3e6-4d82-a9bc-0f2a7759a5e1"), new Guid("6e1d769f-e869-47e6-81d2-8ac2af06c6d3"), false, new Guid("7efd8053-1f79-448c-97af-36504394b4f4") }
                });

            migrationBuilder.InsertData(
                table: "TrainerReviews",
                columns: new[] { "Id", "Hide", "Rating", "ReservationId", "Text" },
                values: new object[] { new Guid("e1895799-db9f-41d7-98d8-e340bf965937"), false, 5, new Guid("a813c6f2-bd50-4300-a9fe-27a37ea196f7"), "tbd" });

            migrationBuilder.CreateIndex(
                name: "IX_TrainerReviews_ReservationId",
                table: "TrainerReviews",
                column: "ReservationId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TrainerReviews_ReservationId",
                table: "TrainerReviews");

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("0f73608f-1324-4939-a679-7ccfbe632592"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("25be54a3-6dc4-4af0-a7a3-e32f9d816743"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("39aca6e9-fb70-42a0-a114-098290409ab7"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("651c7a8d-3e5d-4877-ab7d-c64622193543"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("9b4e02db-2e22-4771-adc3-548f30dfe93e"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("176d365d-a4ae-4516-bf13-ec8eb8032482"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("806232f6-5b18-4d33-8d6e-807613eea646"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("cfae7435-773e-4991-ae4b-b51884572c24"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("eb409b84-4599-4fc1-8419-12fb817062f3"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("91b67825-2101-4e51-8b97-860a8687df12"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("d6616aaf-b3e6-4d82-a9bc-0f2a7759a5e1"));

            migrationBuilder.DeleteData(
                table: "TrainerReviews",
                keyColumn: "Id",
                keyValue: new Guid("e1895799-db9f-41d7-98d8-e340bf965937"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("6e1d769f-e869-47e6-81d2-8ac2af06c6d3"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("d291f83c-d1ff-4815-9223-3c4728079537"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("0c20b79a-a739-46ff-96d3-69b8647d8b50"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("f3df6de4-ddf6-4ccd-9ab8-7979af693cc0"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("a813c6f2-bd50-4300-a9fe-27a37ea196f7"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("7efd8053-1f79-448c-97af-36504394b4f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a71c6be5-e512-459a-b40d-0a870a6cd56f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e3752cbf-1ca7-4185-84f9-5b0ae6909508"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("6f549e4f-d0e7-4643-9a8a-e572ce00d9c6"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("0bbe28da-2d3c-4f9d-9bac-4e71a94f7db0"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("ced745b0-d3f3-4641-90bc-dc4bb6260bb4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a631a4b-bb6c-40e3-a0ef-a80614950876"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6127ccf7-4ec7-4c56-8339-24653fe303a2"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("4bb06d25-11ec-43ac-a4a9-81661e942241"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("228c087a-9708-40a3-b7ba-5c77c7acf1ac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a599f1ab-a631-4119-929f-d09e7a80d758"));

            migrationBuilder.AddColumn<Guid>(
                name: "TrainerReviewId",
                table: "TrainerReservations",
                type: "TEXT",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_TrainerReviews_ReservationId",
                table: "TrainerReviews",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainerReservations_TrainerReviewId",
                table: "TrainerReservations",
                column: "TrainerReviewId");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerReservations_TrainerReviews_TrainerReviewId",
                table: "TrainerReservations",
                column: "TrainerReviewId",
                principalTable: "TrainerReviews",
                principalColumn: "Id");
        }
    }
}
