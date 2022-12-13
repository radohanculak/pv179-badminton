using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sprint.DAL.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class RemoveDeletableEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Trainers",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TrainerReviews",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TrainerPhotos",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Courts",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("019b7176-22b4-428b-92cb-eec114505788"), "B", 800m, false },
                    { new Guid("053746b5-1614-4fcf-aedc-c5da932b743e"), "A", 1000m, false },
                    { new Guid("e1608d5e-365c-4e22-b19e-25bc0d65072d"), "C", 800m, false },
                    { new Guid("eb949bae-b32c-4d68-a05d-ae4c90e2a745"), "D", 500m, false }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "IsDeleted", "IsTrainer", "LastName", "PasswordHash", "PhotoPath", "Role", "SecurityStamp" },
                values: new object[,]
                {
                    { new Guid("1f83a261-04ca-41ac-88c4-736e2cd2905d"), new DateTime(1955, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "monic@nonexistentmail.com", "Monica", false, false, "Bellucci", "tbd", "tbd", 0, "4abcdef" },
                    { new Guid("4ab6f34d-8f82-4921-8616-1f9d752406cb"), new DateTime(2001, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "514329@mail.muni.cz", "Adam", false, false, "Mydla", "tbd", "tbd", 0, "1abcdef" },
                    { new Guid("663a1513-dd61-454f-8f73-151a18659136"), new DateTime(1993, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "rntr@nonexistentmail.com", "Roman", false, false, "NieTenRoman", "tbd", "tbd", 0, "3abcdef" },
                    { new Guid("78445a82-272a-43c6-a094-91ff2062fc2e"), new DateTime(1995, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "pppeter@nonexistentmail.com", "Peter", false, false, "Griffin", "tbd", "tbd", 0, "2abcdef" },
                    { new Guid("803b7f74-4c34-4024-ba0c-1d23902bf815"), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "rhanculak@mail.muni.cz", "Radovan", false, true, "Hančuľák", "tbd", "tbd", 1, "5abcdef" },
                    { new Guid("b8e71e32-8144-4a9d-b6a1-e30ff73ea570"), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "493352@mail.muni.cz", "Jitka", false, true, "Viceníková", "tbd", "tbd", 1, "6abcdef" }
                });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("133a93d8-b322-4327-9561-5c0791947454"), new Guid("053746b5-1614-4fcf-aedc-c5da932b743e"), new DateTime(2022, 9, 28, 19, 19, 19, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("78445a82-272a-43c6-a094-91ff2062fc2e") },
                    { new Guid("678b4158-2691-49e2-9b65-e215a588ffd4"), new Guid("e1608d5e-365c-4e22-b19e-25bc0d65072d"), new DateTime(2022, 9, 21, 6, 51, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4ab6f34d-8f82-4921-8616-1f9d752406cb") },
                    { new Guid("9bc07151-0c8d-4644-a40a-a641f4abf4f1"), new Guid("eb949bae-b32c-4d68-a05d-ae4c90e2a745"), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 12, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1f83a261-04ca-41ac-88c4-736e2cd2905d") },
                    { new Guid("9c0faca5-3bdf-4d9b-8bb6-115ba4e023d7"), new Guid("019b7176-22b4-428b-92cb-eec114505788"), new DateTime(2022, 9, 15, 18, 4, 4, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), new Guid("663a1513-dd61-454f-8f73-151a18659136") },
                    { new Guid("ab3b26a3-bc38-4a9e-849f-afe30f62c159"), new Guid("053746b5-1614-4fcf-aedc-c5da932b743e"), new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), new Guid("78445a82-272a-43c6-a094-91ff2062fc2e") },
                    { new Guid("b2f0a633-209a-4380-8eee-f44df3a411ff"), new Guid("019b7176-22b4-428b-92cb-eec114505788"), new DateTime(2022, 9, 16, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 9, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("663a1513-dd61-454f-8f73-151a18659136") },
                    { new Guid("be8d181c-a1b6-47e2-bac4-8d7a7a05b433"), new Guid("053746b5-1614-4fcf-aedc-c5da932b743e"), new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4ab6f34d-8f82-4921-8616-1f9d752406cb") },
                    { new Guid("c4f3b80d-8a42-487c-96fa-fbf8e9af5771"), new Guid("e1608d5e-365c-4e22-b19e-25bc0d65072d"), new DateTime(2022, 9, 5, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4ab6f34d-8f82-4921-8616-1f9d752406cb") }
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Description", "HourlyRate", "IsDeleted", "UserId" },
                values: new object[,]
                {
                    { new Guid("7e6e363b-bb24-45e3-bf6f-1362148a2cfd"), "I know how to play even better, that's all", 3485m, false, new Guid("b8e71e32-8144-4a9d-b6a1-e30ff73ea570") },
                    { new Guid("e845ff5f-c15f-4b7b-80d0-0e1007509182"), "I know how to play, that's all", 2000m, false, new Guid("803b7f74-4c34-4024-ba0c-1d23902bf815") }
                });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "IsDeleted", "Path", "TrainerId" },
                values: new object[,]
                {
                    { new Guid("1df958f8-0f56-4e4f-95e8-2bc0e7ed47f5"), true, false, "tbd", new Guid("7e6e363b-bb24-45e3-bf6f-1362148a2cfd") },
                    { new Guid("3db35716-5ad4-4b5f-81ba-5b6d126a2c42"), false, false, "tbd", new Guid("e845ff5f-c15f-4b7b-80d0-0e1007509182") },
                    { new Guid("7ee87a44-cd5c-47ac-8f3a-77c44bffbc18"), false, false, "tbd", new Guid("e845ff5f-c15f-4b7b-80d0-0e1007509182") },
                    { new Guid("cc3eea02-bf82-49cc-95ac-17189f9bba90"), true, false, "tbd", new Guid("7e6e363b-bb24-45e3-bf6f-1362148a2cfd") }
                });

            migrationBuilder.InsertData(
                table: "TrainerReservations",
                columns: new[] { "Id", "CourtReservationId", "IsDeleted", "TrainerId" },
                values: new object[,]
                {
                    { new Guid("32533c67-87f3-4a52-b720-063a663cbe56"), new Guid("9c0faca5-3bdf-4d9b-8bb6-115ba4e023d7"), false, new Guid("e845ff5f-c15f-4b7b-80d0-0e1007509182") },
                    { new Guid("8359f2ab-82c2-460f-8c03-fc0354bcc244"), new Guid("b2f0a633-209a-4380-8eee-f44df3a411ff"), true, new Guid("e845ff5f-c15f-4b7b-80d0-0e1007509182") },
                    { new Guid("f90e7507-5e95-4d20-b090-879b3a95ddee"), new Guid("9bc07151-0c8d-4644-a40a-a641f4abf4f1"), false, new Guid("7e6e363b-bb24-45e3-bf6f-1362148a2cfd") }
                });

            migrationBuilder.InsertData(
                table: "TrainerReviews",
                columns: new[] { "Id", "Hide", "IsDeleted", "Rating", "ReservationId", "Text" },
                values: new object[] { new Guid("db10c392-4c38-49bb-baaa-bee266959084"), false, false, 5, new Guid("f90e7507-5e95-4d20-b090-879b3a95ddee"), "tbd" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("133a93d8-b322-4327-9561-5c0791947454"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("678b4158-2691-49e2-9b65-e215a588ffd4"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("ab3b26a3-bc38-4a9e-849f-afe30f62c159"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("be8d181c-a1b6-47e2-bac4-8d7a7a05b433"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("c4f3b80d-8a42-487c-96fa-fbf8e9af5771"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("1df958f8-0f56-4e4f-95e8-2bc0e7ed47f5"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("3db35716-5ad4-4b5f-81ba-5b6d126a2c42"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("7ee87a44-cd5c-47ac-8f3a-77c44bffbc18"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("cc3eea02-bf82-49cc-95ac-17189f9bba90"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("32533c67-87f3-4a52-b720-063a663cbe56"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("8359f2ab-82c2-460f-8c03-fc0354bcc244"));

            migrationBuilder.DeleteData(
                table: "TrainerReviews",
                keyColumn: "Id",
                keyValue: new Guid("db10c392-4c38-49bb-baaa-bee266959084"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("9c0faca5-3bdf-4d9b-8bb6-115ba4e023d7"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("b2f0a633-209a-4380-8eee-f44df3a411ff"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("053746b5-1614-4fcf-aedc-c5da932b743e"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("e1608d5e-365c-4e22-b19e-25bc0d65072d"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("f90e7507-5e95-4d20-b090-879b3a95ddee"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("e845ff5f-c15f-4b7b-80d0-0e1007509182"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ab6f34d-8f82-4921-8616-1f9d752406cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("78445a82-272a-43c6-a094-91ff2062fc2e"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("9bc07151-0c8d-4644-a40a-a641f4abf4f1"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("019b7176-22b4-428b-92cb-eec114505788"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("7e6e363b-bb24-45e3-bf6f-1362148a2cfd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("663a1513-dd61-454f-8f73-151a18659136"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("803b7f74-4c34-4024-ba0c-1d23902bf815"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("eb949bae-b32c-4d68-a05d-ae4c90e2a745"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1f83a261-04ca-41ac-88c4-736e2cd2905d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8e71e32-8144-4a9d-b6a1-e30ff73ea570"));

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Trainers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TrainerReviews");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TrainerPhotos");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Courts");

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
    }
}
