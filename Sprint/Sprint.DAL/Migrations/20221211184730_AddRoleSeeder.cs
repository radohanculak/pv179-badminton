using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sprint.DAL.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class AddRoleSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate" },
                values: new object[,]
                {
                    { new Guid("06a275ee-60f3-4c06-b775-3db318f21f3a"), "B", 800m },
                    { new Guid("87ff9b82-a2e8-40a0-befb-3c268ab6aff8"), "C", 800m },
                    { new Guid("c661e22c-02e9-40f6-855e-bf44d53eaaee"), "D", 500m },
                    { new Guid("de24a7a6-5389-4210-a925-0dcca933756a"), "A", 1000m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "IsTrainer", "LastName", "PasswordHash", "PhotoPath", "Role", "SecurityStamp" },
                values: new object[,]
                {
                    { new Guid("173e3f53-e794-4a16-9eff-1f094673d678"), new DateTime(1995, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "pppeter@nonexistentmail.com", "Peter", false, "Griffin", "tbd", "tbd", 0, "2abcdef" },
                    { new Guid("3429f6c0-4869-4c26-96db-ed4df0dbdba7"), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "rhanculak@mail.muni.cz", "Radovan", true, "Hančuľák", "tbd", "tbd", 1, "5abcdef" },
                    { new Guid("3bd9fe55-4331-4fc9-bee3-f1cc25d967fb"), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "493352@mail.muni.cz", "Jitka", true, "Viceníková", "tbd", "tbd", 1, "6abcdef" },
                    { new Guid("5bb3c883-96fd-4d83-beb1-38a144a393db"), new DateTime(1955, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "monic@nonexistentmail.com", "Monica", false, "Bellucci", "tbd", "tbd", 0, "4abcdef" },
                    { new Guid("7ba23d6d-f927-4593-bdbb-cfb1c3bf102a"), new DateTime(1993, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "rntr@nonexistentmail.com", "Roman", false, "NieTenRoman", "tbd", "tbd", 0, "3abcdef" },
                    { new Guid("9994383b-d683-4920-9c52-fa1b70f6311c"), new DateTime(2001, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "514329@mail.muni.cz", "Adam", false, "Mydla", "tbd", "tbd", 0, "1abcdef" }
                });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("12b7afac-4bfd-49d2-8255-2c7c33fcbee3"), new Guid("87ff9b82-a2e8-40a0-befb-3c268ab6aff8"), new DateTime(2022, 9, 21, 6, 51, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9994383b-d683-4920-9c52-fa1b70f6311c") },
                    { new Guid("16c031b1-0153-4c47-bc29-06aea4e56d34"), new Guid("de24a7a6-5389-4210-a925-0dcca933756a"), new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9994383b-d683-4920-9c52-fa1b70f6311c") },
                    { new Guid("1b6fff70-f742-4074-972f-54ff1c5ecd01"), new Guid("de24a7a6-5389-4210-a925-0dcca933756a"), new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), new Guid("173e3f53-e794-4a16-9eff-1f094673d678") },
                    { new Guid("5834c425-10f9-4747-baf5-d8534c21ce29"), new Guid("87ff9b82-a2e8-40a0-befb-3c268ab6aff8"), new DateTime(2022, 9, 5, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9994383b-d683-4920-9c52-fa1b70f6311c") },
                    { new Guid("7fdf7d3b-f6a2-4f1f-81d1-f80b45dc4817"), new Guid("06a275ee-60f3-4c06-b775-3db318f21f3a"), new DateTime(2022, 9, 15, 18, 4, 4, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7ba23d6d-f927-4593-bdbb-cfb1c3bf102a") },
                    { new Guid("abfdde5e-4b60-4b5a-91b8-f4a8762d46c7"), new Guid("de24a7a6-5389-4210-a925-0dcca933756a"), new DateTime(2022, 9, 28, 19, 19, 19, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("173e3f53-e794-4a16-9eff-1f094673d678") },
                    { new Guid("e1db7d30-2cf9-4964-9b06-e938aba9deb2"), new Guid("c661e22c-02e9-40f6-855e-bf44d53eaaee"), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 12, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5bb3c883-96fd-4d83-beb1-38a144a393db") },
                    { new Guid("ed460060-0a53-4fc1-8c6b-9ec52dd24094"), new Guid("06a275ee-60f3-4c06-b775-3db318f21f3a"), new DateTime(2022, 9, 16, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 9, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7ba23d6d-f927-4593-bdbb-cfb1c3bf102a") }
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Description", "HourlyRate", "UserId" },
                values: new object[,]
                {
                    { new Guid("e482d281-8825-4100-ac53-f1faccc221e3"), "I know how to play even better, that's all", 3485m, new Guid("3bd9fe55-4331-4fc9-bee3-f1cc25d967fb") },
                    { new Guid("ef5c2365-065e-4d31-9eea-494efe2b06e6"), "I know how to play, that's all", 2000m, new Guid("3429f6c0-4869-4c26-96db-ed4df0dbdba7") }
                });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[,]
                {
                    { new Guid("06459349-bc31-43ab-ae30-5b94a8a27696"), true, "tbd", new Guid("e482d281-8825-4100-ac53-f1faccc221e3") },
                    { new Guid("a3c5a370-55c0-4ad2-8c04-7878841aa8cb"), false, "tbd", new Guid("ef5c2365-065e-4d31-9eea-494efe2b06e6") },
                    { new Guid("b7a68066-bf4d-4ced-86db-329310005ae3"), true, "tbd", new Guid("e482d281-8825-4100-ac53-f1faccc221e3") },
                    { new Guid("bb6c3bfb-a866-4fdd-a738-f4d8477f0950"), false, "tbd", new Guid("ef5c2365-065e-4d31-9eea-494efe2b06e6") }
                });

            migrationBuilder.InsertData(
                table: "TrainerReservations",
                columns: new[] { "Id", "CourtReservationId", "IsDeleted", "TrainerId" },
                values: new object[,]
                {
                    { new Guid("06b80881-d672-4fdf-ad49-d0ed1b108be1"), new Guid("e1db7d30-2cf9-4964-9b06-e938aba9deb2"), false, new Guid("e482d281-8825-4100-ac53-f1faccc221e3") },
                    { new Guid("36e66d98-1148-4e72-ae3f-ce1141d86b6b"), new Guid("7fdf7d3b-f6a2-4f1f-81d1-f80b45dc4817"), false, new Guid("ef5c2365-065e-4d31-9eea-494efe2b06e6") },
                    { new Guid("fef507e2-4975-466b-88b4-9a4fb3ec5d4d"), new Guid("ed460060-0a53-4fc1-8c6b-9ec52dd24094"), true, new Guid("ef5c2365-065e-4d31-9eea-494efe2b06e6") }
                });

            migrationBuilder.InsertData(
                table: "TrainerReviews",
                columns: new[] { "Id", "Hide", "Rating", "ReservationId", "Text" },
                values: new object[] { new Guid("bbf6693a-0b5a-4f70-bee4-8b691b1f077f"), false, 5, new Guid("06b80881-d672-4fdf-ad49-d0ed1b108be1"), "tbd" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("12b7afac-4bfd-49d2-8255-2c7c33fcbee3"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("16c031b1-0153-4c47-bc29-06aea4e56d34"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("1b6fff70-f742-4074-972f-54ff1c5ecd01"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("5834c425-10f9-4747-baf5-d8534c21ce29"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("abfdde5e-4b60-4b5a-91b8-f4a8762d46c7"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("06459349-bc31-43ab-ae30-5b94a8a27696"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("a3c5a370-55c0-4ad2-8c04-7878841aa8cb"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("b7a68066-bf4d-4ced-86db-329310005ae3"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("bb6c3bfb-a866-4fdd-a738-f4d8477f0950"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("36e66d98-1148-4e72-ae3f-ce1141d86b6b"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("fef507e2-4975-466b-88b4-9a4fb3ec5d4d"));

            migrationBuilder.DeleteData(
                table: "TrainerReviews",
                keyColumn: "Id",
                keyValue: new Guid("bbf6693a-0b5a-4f70-bee4-8b691b1f077f"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("7fdf7d3b-f6a2-4f1f-81d1-f80b45dc4817"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("ed460060-0a53-4fc1-8c6b-9ec52dd24094"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("87ff9b82-a2e8-40a0-befb-3c268ab6aff8"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("de24a7a6-5389-4210-a925-0dcca933756a"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("06b80881-d672-4fdf-ad49-d0ed1b108be1"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("ef5c2365-065e-4d31-9eea-494efe2b06e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("173e3f53-e794-4a16-9eff-1f094673d678"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9994383b-d683-4920-9c52-fa1b70f6311c"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("e1db7d30-2cf9-4964-9b06-e938aba9deb2"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("06a275ee-60f3-4c06-b775-3db318f21f3a"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("e482d281-8825-4100-ac53-f1faccc221e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3429f6c0-4869-4c26-96db-ed4df0dbdba7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ba23d6d-f927-4593-bdbb-cfb1c3bf102a"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("c661e22c-02e9-40f6-855e-bf44d53eaaee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3bd9fe55-4331-4fc9-bee3-f1cc25d967fb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5bb3c883-96fd-4d83-beb1-38a144a393db"));

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
        }
    }
}
