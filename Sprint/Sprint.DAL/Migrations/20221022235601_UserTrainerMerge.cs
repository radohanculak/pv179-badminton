using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sprint.DAL.EFCore.Migrations
{
    public partial class UserTrainerMerge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("336c17f7-7999-49a6-8389-5a3fafe649d6"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("4d56efee-3023-4e82-a51f-b6aa9112e1af"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("c045547d-c2ec-4ebc-8f51-98c54551d895"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("cea88070-3209-4cc0-b596-aade864d4071"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("f2f06407-6ca0-4787-8f94-bb9b0b3e7f97"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("398a8e9f-4ffc-427a-ba49-32409630eb44"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("4cc7ab7f-824e-42ab-acdf-1db826ff1759"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("52fe6e23-ac70-4711-900a-4ab67d4e63f2"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("847399ba-6024-4edd-b881-d32f1b65e97c"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("bd8e2504-4d24-42ab-af40-6040b4abc429"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("da2cd7b2-b080-411d-a45b-d06d25ad2de2"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("f757ac96-f4d0-4fd5-818d-aa522eb7469e"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("5c9bf209-aed6-4266-b317-be08d4cabff1"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("8a595a2c-bc52-47b1-a9a8-2874cab77d76"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("b68ac054-2944-4d20-bf85-44219c4ebea4"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("9dc5c2c5-daa8-4616-a3ae-af61554b4917"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("d27fdc4f-1f49-41d8-8942-e6fbd11032cf"));

            migrationBuilder.DeleteData(
                table: "TrainerReviews",
                keyColumn: "Id",
                keyValue: new Guid("84d6f5bb-1644-475e-b742-7f055bbab03f"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("4528e09b-2020-4502-8d8e-6188a882ac25"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("6845f3a4-cbde-47ee-8206-4c863a433e70"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("94a94c5f-070f-4c36-a3e1-8f25d13bd91c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dd446465-7b9f-44ff-9aa6-0c6c5d850a01"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("3e279425-1791-4982-9a97-42a910ed5832"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("8381019c-5e8a-48f5-a2fa-8a27e8a65fc7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6e414cc8-38d2-4245-9a02-210dce414220"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ef715b0f-15e9-420a-981c-e8c13ea73751"));

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Trainers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Trainers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Trainers");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "Trainers",
                newName: "UserId");

            migrationBuilder.AddColumn<bool>(
                name: "IsTrainer",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate" },
                values: new object[] { new Guid("111648fe-220c-4b17-adcb-7dcb87c3fe7e"), "D", 500m });

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate" },
                values: new object[] { new Guid("4f8065dd-605a-44b6-a73b-f8a6705971fa"), "C", 800m });

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate" },
                values: new object[] { new Guid("6ff6781b-7f81-4a37-9574-0b55659a43ce"), "B", 800m });

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate" },
                values: new object[] { new Guid("84283670-ffcd-472a-b254-305edfa52604"), "A", 1000m });

            migrationBuilder.InsertData(
                table: "TrainerReviews",
                columns: new[] { "Id", "Hide", "Rating", "Text" },
                values: new object[] { new Guid("67fb4edf-3948-44c2-b597-f4a16f58550b"), false, 5, "tbd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "IsTrainer", "LastName", "PasswordHash", "PhotoPath" },
                values: new object[] { new Guid("11e74a02-30e7-4b05-8139-454692334aa7"), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "rhanculak@mail.muni.cz", "Radovan", true, "Hančuľák", "tbd", "tbd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "IsTrainer", "LastName", "PasswordHash", "PhotoPath" },
                values: new object[] { new Guid("14c2ddf0-3a64-4f33-9a04-6f6ae84e58e5"), new DateTime(1955, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "monic@nonexistentmail.com", "Monica", false, "Bellucci", "tbd", "tbd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "IsTrainer", "LastName", "PasswordHash", "PhotoPath" },
                values: new object[] { new Guid("77edbebb-5998-46f6-ad1d-d3eca33eac77"), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "493352@mail.muni.cz", "Jitka", true, "Viceníková", "tbd", "tbd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "IsTrainer", "LastName", "PasswordHash", "PhotoPath" },
                values: new object[] { new Guid("829e6c11-919b-4683-93b1-944acf1299fc"), new DateTime(1995, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "pppeter@nonexistentmail.com", "Peter", false, "Griffin", "tbd", "tbd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "IsTrainer", "LastName", "PasswordHash", "PhotoPath" },
                values: new object[] { new Guid("b67bc389-8418-4d19-912e-51bd50398cd3"), new DateTime(1993, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "rntr@nonexistentmail.com", "Roman", false, "NieTenRoman", "tbd", "tbd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "IsTrainer", "LastName", "PasswordHash", "PhotoPath" },
                values: new object[] { new Guid("bd07a4d4-0cc0-4e75-bef6-5551dcafce5e"), new DateTime(2001, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "514329@mail.muni.cz", "Adam", false, "Mydla", "tbd", "tbd" });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("3edb0eba-fac6-4e4e-9ca8-a48c1ce8a36c"), new Guid("84283670-ffcd-472a-b254-305edfa52604"), new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), new Guid("829e6c11-919b-4683-93b1-944acf1299fc") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("6e73f0fc-8e65-411a-9206-4bf15a826937"), new Guid("4f8065dd-605a-44b6-a73b-f8a6705971fa"), new DateTime(2022, 9, 5, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bd07a4d4-0cc0-4e75-bef6-5551dcafce5e") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("7484c1d7-77e1-4105-9028-02ee47ea955c"), new Guid("4f8065dd-605a-44b6-a73b-f8a6705971fa"), new DateTime(2022, 9, 21, 6, 51, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bd07a4d4-0cc0-4e75-bef6-5551dcafce5e") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("7f14d02c-1079-4b1e-8bfc-20cd44960cb0"), new Guid("6ff6781b-7f81-4a37-9574-0b55659a43ce"), new DateTime(2022, 9, 15, 18, 4, 4, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b67bc389-8418-4d19-912e-51bd50398cd3") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("8a40fbd7-c969-4565-89e3-e6f77c626931"), new Guid("84283670-ffcd-472a-b254-305edfa52604"), new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bd07a4d4-0cc0-4e75-bef6-5551dcafce5e") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("b1f51109-b38a-4d4c-adaa-935d07ec0d3f"), new Guid("84283670-ffcd-472a-b254-305edfa52604"), new DateTime(2022, 9, 28, 19, 19, 19, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("829e6c11-919b-4683-93b1-944acf1299fc") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("d535b13e-3859-4b77-bf0d-fdc824515254"), new Guid("6ff6781b-7f81-4a37-9574-0b55659a43ce"), new DateTime(2022, 9, 16, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 9, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b67bc389-8418-4d19-912e-51bd50398cd3") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("f083f373-aae0-4c42-badb-d17544caf95c"), new Guid("111648fe-220c-4b17-adcb-7dcb87c3fe7e"), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 12, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("14c2ddf0-3a64-4f33-9a04-6f6ae84e58e5") });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Description", "HourlyRate", "UserId" },
                values: new object[] { new Guid("137c9f9b-6168-490f-bfd9-5796bb2767a5"), "I know how to play, that's all", 2000m, new Guid("11e74a02-30e7-4b05-8139-454692334aa7") });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Description", "HourlyRate", "UserId" },
                values: new object[] { new Guid("e581f7a3-3387-4a3e-a39d-799c1f00cea1"), "I know how to play even better, that's all", 3485m, new Guid("77edbebb-5998-46f6-ad1d-d3eca33eac77") });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[] { new Guid("317d0c32-d19f-4338-a6b6-b79b5280fef8"), false, "tbd", new Guid("137c9f9b-6168-490f-bfd9-5796bb2767a5") });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[] { new Guid("37d8a753-f4ab-4194-b8cf-833b92de6fe1"), true, "tbd", new Guid("e581f7a3-3387-4a3e-a39d-799c1f00cea1") });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[] { new Guid("906a87d3-25f0-47e3-bd05-c7fdc0d2b53b"), true, "tbd", new Guid("e581f7a3-3387-4a3e-a39d-799c1f00cea1") });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[] { new Guid("c8c8a7a2-7e15-4d71-8a24-8f2e57473828"), false, "tbd", new Guid("137c9f9b-6168-490f-bfd9-5796bb2767a5") });

            migrationBuilder.InsertData(
                table: "TrainerReservations",
                columns: new[] { "Id", "CourtReservationId", "IsDeleted", "TrainerId", "TrainerReviewId" },
                values: new object[] { new Guid("2ebf2762-081c-4a68-a000-a894afd0bb8b"), new Guid("d535b13e-3859-4b77-bf0d-fdc824515254"), true, new Guid("137c9f9b-6168-490f-bfd9-5796bb2767a5"), null });

            migrationBuilder.InsertData(
                table: "TrainerReservations",
                columns: new[] { "Id", "CourtReservationId", "IsDeleted", "TrainerId", "TrainerReviewId" },
                values: new object[] { new Guid("5be4887e-52ca-4cdb-ba5a-697ae5918f14"), new Guid("7f14d02c-1079-4b1e-8bfc-20cd44960cb0"), false, new Guid("137c9f9b-6168-490f-bfd9-5796bb2767a5"), null });

            migrationBuilder.InsertData(
                table: "TrainerReservations",
                columns: new[] { "Id", "CourtReservationId", "IsDeleted", "TrainerId", "TrainerReviewId" },
                values: new object[] { new Guid("80b40442-7e1a-4f47-b5d1-ce5fe413eff3"), new Guid("f083f373-aae0-4c42-badb-d17544caf95c"), false, new Guid("e581f7a3-3387-4a3e-a39d-799c1f00cea1"), new Guid("67fb4edf-3948-44c2-b597-f4a16f58550b") });

            migrationBuilder.CreateIndex(
                name: "IX_Trainers_UserId",
                table: "Trainers",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Trainers_Users_UserId",
                table: "Trainers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trainers_Users_UserId",
                table: "Trainers");

            migrationBuilder.DropIndex(
                name: "IX_Trainers_UserId",
                table: "Trainers");

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("3edb0eba-fac6-4e4e-9ca8-a48c1ce8a36c"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("6e73f0fc-8e65-411a-9206-4bf15a826937"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("7484c1d7-77e1-4105-9028-02ee47ea955c"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("8a40fbd7-c969-4565-89e3-e6f77c626931"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("b1f51109-b38a-4d4c-adaa-935d07ec0d3f"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("317d0c32-d19f-4338-a6b6-b79b5280fef8"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("37d8a753-f4ab-4194-b8cf-833b92de6fe1"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("906a87d3-25f0-47e3-bd05-c7fdc0d2b53b"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("c8c8a7a2-7e15-4d71-8a24-8f2e57473828"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("2ebf2762-081c-4a68-a000-a894afd0bb8b"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("5be4887e-52ca-4cdb-ba5a-697ae5918f14"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("80b40442-7e1a-4f47-b5d1-ce5fe413eff3"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("7f14d02c-1079-4b1e-8bfc-20cd44960cb0"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("d535b13e-3859-4b77-bf0d-fdc824515254"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("f083f373-aae0-4c42-badb-d17544caf95c"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("4f8065dd-605a-44b6-a73b-f8a6705971fa"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("84283670-ffcd-472a-b254-305edfa52604"));

            migrationBuilder.DeleteData(
                table: "TrainerReviews",
                keyColumn: "Id",
                keyValue: new Guid("67fb4edf-3948-44c2-b597-f4a16f58550b"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("137c9f9b-6168-490f-bfd9-5796bb2767a5"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("e581f7a3-3387-4a3e-a39d-799c1f00cea1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("829e6c11-919b-4683-93b1-944acf1299fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bd07a4d4-0cc0-4e75-bef6-5551dcafce5e"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("111648fe-220c-4b17-adcb-7dcb87c3fe7e"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("6ff6781b-7f81-4a37-9574-0b55659a43ce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11e74a02-30e7-4b05-8139-454692334aa7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("14c2ddf0-3a64-4f33-9a04-6f6ae84e58e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("77edbebb-5998-46f6-ad1d-d3eca33eac77"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b67bc389-8418-4d19-912e-51bd50398cd3"));

            migrationBuilder.DropColumn(
                name: "IsTrainer",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Trainers",
                newName: "PasswordHash");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Trainers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Trainers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Trainers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate" },
                values: new object[] { new Guid("3e279425-1791-4982-9a97-42a910ed5832"), "B", 800m });

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate" },
                values: new object[] { new Guid("8381019c-5e8a-48f5-a2fa-8a27e8a65fc7"), "D", 500m });

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate" },
                values: new object[] { new Guid("9dc5c2c5-daa8-4616-a3ae-af61554b4917"), "C", 800m });

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate" },
                values: new object[] { new Guid("d27fdc4f-1f49-41d8-8942-e6fbd11032cf"), "A", 1000m });

            migrationBuilder.InsertData(
                table: "TrainerReviews",
                columns: new[] { "Id", "Hide", "Rating", "Text" },
                values: new object[] { new Guid("84d6f5bb-1644-475e-b742-7f055bbab03f"), false, 5, "tbd" });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Description", "Email", "FirstName", "HourlyRate", "LastName", "PasswordHash" },
                values: new object[] { new Guid("4528e09b-2020-4502-8d8e-6188a882ac25"), "I know how to play even better, that's all", "493352@mail.muni.cz", "Jitka", 3485m, "Viceníková", "tbd" });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Description", "Email", "FirstName", "HourlyRate", "LastName", "PasswordHash" },
                values: new object[] { new Guid("6845f3a4-cbde-47ee-8206-4c863a433e70"), "I know how to play, that's all", "rhanculak@mail.muni.cz", "Radovan", 2000m, "Hančuľák", "tbd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "LastName", "PasswordHash", "PhotoPath" },
                values: new object[] { new Guid("6e414cc8-38d2-4245-9a02-210dce414220"), new DateTime(1993, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "rntr@nonexistentmail.com", "Roman", "NieTenRoman", "tbd", "tbd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "LastName", "PasswordHash", "PhotoPath" },
                values: new object[] { new Guid("94a94c5f-070f-4c36-a3e1-8f25d13bd91c"), new DateTime(2001, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "514329@mail.muni.cz", "Adam", "Mydla", "tbd", "tbd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "LastName", "PasswordHash", "PhotoPath" },
                values: new object[] { new Guid("dd446465-7b9f-44ff-9aa6-0c6c5d850a01"), new DateTime(1995, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "pppeter@nonexistentmail.com", "Peter", "Griffin", "tbd", "tbd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "LastName", "PasswordHash", "PhotoPath" },
                values: new object[] { new Guid("ef715b0f-15e9-420a-981c-e8c13ea73751"), new DateTime(1955, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "monic@nonexistentmail.com", "Monica", "Bellucci", "tbd", "tbd" });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("336c17f7-7999-49a6-8389-5a3fafe649d6"), new Guid("d27fdc4f-1f49-41d8-8942-e6fbd11032cf"), new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dd446465-7b9f-44ff-9aa6-0c6c5d850a01") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("4d56efee-3023-4e82-a51f-b6aa9112e1af"), new Guid("d27fdc4f-1f49-41d8-8942-e6fbd11032cf"), new DateTime(2022, 9, 28, 19, 19, 19, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dd446465-7b9f-44ff-9aa6-0c6c5d850a01") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("5c9bf209-aed6-4266-b317-be08d4cabff1"), new Guid("3e279425-1791-4982-9a97-42a910ed5832"), new DateTime(2022, 9, 16, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 9, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6e414cc8-38d2-4245-9a02-210dce414220") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("8a595a2c-bc52-47b1-a9a8-2874cab77d76"), new Guid("8381019c-5e8a-48f5-a2fa-8a27e8a65fc7"), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 12, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ef715b0f-15e9-420a-981c-e8c13ea73751") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("b68ac054-2944-4d20-bf85-44219c4ebea4"), new Guid("3e279425-1791-4982-9a97-42a910ed5832"), new DateTime(2022, 9, 15, 18, 4, 4, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6e414cc8-38d2-4245-9a02-210dce414220") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("c045547d-c2ec-4ebc-8f51-98c54551d895"), new Guid("9dc5c2c5-daa8-4616-a3ae-af61554b4917"), new DateTime(2022, 9, 5, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new Guid("94a94c5f-070f-4c36-a3e1-8f25d13bd91c") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("cea88070-3209-4cc0-b596-aade864d4071"), new Guid("d27fdc4f-1f49-41d8-8942-e6fbd11032cf"), new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("94a94c5f-070f-4c36-a3e1-8f25d13bd91c") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("f2f06407-6ca0-4787-8f94-bb9b0b3e7f97"), new Guid("9dc5c2c5-daa8-4616-a3ae-af61554b4917"), new DateTime(2022, 9, 21, 6, 51, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), new Guid("94a94c5f-070f-4c36-a3e1-8f25d13bd91c") });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[] { new Guid("398a8e9f-4ffc-427a-ba49-32409630eb44"), false, "tbd", new Guid("6845f3a4-cbde-47ee-8206-4c863a433e70") });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[] { new Guid("4cc7ab7f-824e-42ab-acdf-1db826ff1759"), false, "tbd", new Guid("6845f3a4-cbde-47ee-8206-4c863a433e70") });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[] { new Guid("52fe6e23-ac70-4711-900a-4ab67d4e63f2"), true, "tbd", new Guid("4528e09b-2020-4502-8d8e-6188a882ac25") });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[] { new Guid("847399ba-6024-4edd-b881-d32f1b65e97c"), true, "tbd", new Guid("4528e09b-2020-4502-8d8e-6188a882ac25") });

            migrationBuilder.InsertData(
                table: "TrainerReservations",
                columns: new[] { "Id", "CourtReservationId", "IsDeleted", "TrainerId", "TrainerReviewId" },
                values: new object[] { new Guid("bd8e2504-4d24-42ab-af40-6040b4abc429"), new Guid("5c9bf209-aed6-4266-b317-be08d4cabff1"), true, new Guid("6845f3a4-cbde-47ee-8206-4c863a433e70"), null });

            migrationBuilder.InsertData(
                table: "TrainerReservations",
                columns: new[] { "Id", "CourtReservationId", "IsDeleted", "TrainerId", "TrainerReviewId" },
                values: new object[] { new Guid("da2cd7b2-b080-411d-a45b-d06d25ad2de2"), new Guid("8a595a2c-bc52-47b1-a9a8-2874cab77d76"), false, new Guid("4528e09b-2020-4502-8d8e-6188a882ac25"), new Guid("84d6f5bb-1644-475e-b742-7f055bbab03f") });

            migrationBuilder.InsertData(
                table: "TrainerReservations",
                columns: new[] { "Id", "CourtReservationId", "IsDeleted", "TrainerId", "TrainerReviewId" },
                values: new object[] { new Guid("f757ac96-f4d0-4fd5-818d-aa522eb7469e"), new Guid("b68ac054-2944-4d20-bf85-44219c4ebea4"), false, new Guid("6845f3a4-cbde-47ee-8206-4c863a433e70"), null });
        }
    }
}
