using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sprint.DAL.EFCore.Migrations
{
    public partial class DeletableEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("29ba6e9c-d92e-4f62-8d43-06f5d9d5c657"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("5e2cb3f5-1225-45e6-aa71-99998f1b8841"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("8220d240-e4aa-4a0b-b3b7-5229be81cc87"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("baf0afaa-617a-43c5-853b-32188b7fd063"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("d1431fb7-2ae3-4846-9c20-89390fa1139e"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("a21bde57-916b-407c-a621-54fdefc83040"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("c3adc5d4-7917-4d99-868d-a92af88744f8"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("cccc8c38-0009-4b8c-b9fc-6b0005186448"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("dfb1b6eb-631e-4fbc-86af-9cad756d8e8c"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("51dd425b-3185-4746-bc83-5f5905dd61b2"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("c626b9d5-0d52-40af-a876-afdf9b60beee"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("d97ea249-5864-4e1d-9ec3-930646f08278"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("0fdba66e-ff82-47b3-b9e2-b197e1089aa6"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("7ab3bdc6-0531-452d-92dc-cac9bde1795a"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("88874f66-239d-427e-a2b6-824ae8286480"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("6792ae3c-0596-4c98-afa8-62a10328699c"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("76446349-19ef-493a-8c2f-558c108141c7"));

            migrationBuilder.DeleteData(
                table: "TrainerReviews",
                keyColumn: "Id",
                keyValue: new Guid("29438a1f-056c-4186-bbc6-70c35d9e0f46"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("2a5dae96-92b3-47b1-8022-fcfe46c47077"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("833ec7e0-3ea7-412f-836d-2da8eb4723f8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("075079f9-6862-4add-ba49-50d5153041c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a8d8811-ae70-4eae-ba41-00afbe732027"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("d32f674b-b085-4a1a-8dbb-697aa84e6f02"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("ef270c54-2e51-4f69-98c1-a4d9cf545b5d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("193c98e9-c95c-4753-89fe-058cdb68bfc6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("98696623-e7cd-4dd5-81ad-c22d2a474430"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate" },
                values: new object[] { new Guid("6792ae3c-0596-4c98-afa8-62a10328699c"), "A", 1000m });

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate" },
                values: new object[] { new Guid("76446349-19ef-493a-8c2f-558c108141c7"), "C", 800m });

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate" },
                values: new object[] { new Guid("d32f674b-b085-4a1a-8dbb-697aa84e6f02"), "B", 800m });

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate" },
                values: new object[] { new Guid("ef270c54-2e51-4f69-98c1-a4d9cf545b5d"), "D", 500m });

            migrationBuilder.InsertData(
                table: "TrainerReviews",
                columns: new[] { "Id", "Hide", "Rating", "Text" },
                values: new object[] { new Guid("29438a1f-056c-4186-bbc6-70c35d9e0f46"), false, 5, "tbd" });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Description", "Email", "FirstName", "HourlyRate", "LastName", "PasswordHash" },
                values: new object[] { new Guid("2a5dae96-92b3-47b1-8022-fcfe46c47077"), "I know how to play even better, that's all", "493352@mail.muni.cz", "Jitka", 3485m, "Viceníková", "tbd" });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Description", "Email", "FirstName", "HourlyRate", "LastName", "PasswordHash" },
                values: new object[] { new Guid("833ec7e0-3ea7-412f-836d-2da8eb4723f8"), "I know how to play, that's all", "rhanculak@mail.muni.cz", "Radovan", 2000m, "Hančuľák", "tbd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "LastName", "PasswordHash", "PhotoPath" },
                values: new object[] { new Guid("075079f9-6862-4add-ba49-50d5153041c1"), new DateTime(1995, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "pppeter@nonexistentmail.com", "Peter", "Griffin", "tbd", "tbd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "LastName", "PasswordHash", "PhotoPath" },
                values: new object[] { new Guid("193c98e9-c95c-4753-89fe-058cdb68bfc6"), new DateTime(1955, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "monic@nonexistentmail.com", "Monica", "Bellucci", "tbd", "tbd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "LastName", "PasswordHash", "PhotoPath" },
                values: new object[] { new Guid("6a8d8811-ae70-4eae-ba41-00afbe732027"), new DateTime(2001, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "514329@mail.muni.cz", "Adam", "Mydla", "tbd", "tbd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "LastName", "PasswordHash", "PhotoPath" },
                values: new object[] { new Guid("98696623-e7cd-4dd5-81ad-c22d2a474430"), new DateTime(1993, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "rntr@nonexistentmail.com", "Roman", "NieTenRoman", "tbd", "tbd" });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("0fdba66e-ff82-47b3-b9e2-b197e1089aa6"), new Guid("d32f674b-b085-4a1a-8dbb-697aa84e6f02"), new DateTime(2022, 9, 16, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 9, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98696623-e7cd-4dd5-81ad-c22d2a474430") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("29ba6e9c-d92e-4f62-8d43-06f5d9d5c657"), new Guid("6792ae3c-0596-4c98-afa8-62a10328699c"), new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), new Guid("075079f9-6862-4add-ba49-50d5153041c1") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("5e2cb3f5-1225-45e6-aa71-99998f1b8841"), new Guid("6792ae3c-0596-4c98-afa8-62a10328699c"), new DateTime(2022, 9, 28, 19, 19, 19, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("075079f9-6862-4add-ba49-50d5153041c1") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("7ab3bdc6-0531-452d-92dc-cac9bde1795a"), new Guid("d32f674b-b085-4a1a-8dbb-697aa84e6f02"), new DateTime(2022, 9, 15, 18, 4, 4, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98696623-e7cd-4dd5-81ad-c22d2a474430") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("8220d240-e4aa-4a0b-b3b7-5229be81cc87"), new Guid("76446349-19ef-493a-8c2f-558c108141c7"), new DateTime(2022, 9, 21, 6, 51, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6a8d8811-ae70-4eae-ba41-00afbe732027") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("88874f66-239d-427e-a2b6-824ae8286480"), new Guid("ef270c54-2e51-4f69-98c1-a4d9cf545b5d"), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 12, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("193c98e9-c95c-4753-89fe-058cdb68bfc6") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("baf0afaa-617a-43c5-853b-32188b7fd063"), new Guid("76446349-19ef-493a-8c2f-558c108141c7"), new DateTime(2022, 9, 5, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6a8d8811-ae70-4eae-ba41-00afbe732027") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("d1431fb7-2ae3-4846-9c20-89390fa1139e"), new Guid("6792ae3c-0596-4c98-afa8-62a10328699c"), new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6a8d8811-ae70-4eae-ba41-00afbe732027") });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[] { new Guid("a21bde57-916b-407c-a621-54fdefc83040"), false, "tbd", new Guid("833ec7e0-3ea7-412f-836d-2da8eb4723f8") });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[] { new Guid("c3adc5d4-7917-4d99-868d-a92af88744f8"), true, "tbd", new Guid("2a5dae96-92b3-47b1-8022-fcfe46c47077") });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[] { new Guid("cccc8c38-0009-4b8c-b9fc-6b0005186448"), false, "tbd", new Guid("833ec7e0-3ea7-412f-836d-2da8eb4723f8") });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[] { new Guid("dfb1b6eb-631e-4fbc-86af-9cad756d8e8c"), true, "tbd", new Guid("2a5dae96-92b3-47b1-8022-fcfe46c47077") });

            migrationBuilder.InsertData(
                table: "TrainerReservations",
                columns: new[] { "Id", "CourtReservationId", "IsDeleted", "TrainerId", "TrainerReviewId" },
                values: new object[] { new Guid("51dd425b-3185-4746-bc83-5f5905dd61b2"), new Guid("88874f66-239d-427e-a2b6-824ae8286480"), false, new Guid("2a5dae96-92b3-47b1-8022-fcfe46c47077"), new Guid("29438a1f-056c-4186-bbc6-70c35d9e0f46") });

            migrationBuilder.InsertData(
                table: "TrainerReservations",
                columns: new[] { "Id", "CourtReservationId", "IsDeleted", "TrainerId", "TrainerReviewId" },
                values: new object[] { new Guid("c626b9d5-0d52-40af-a876-afdf9b60beee"), new Guid("7ab3bdc6-0531-452d-92dc-cac9bde1795a"), false, new Guid("833ec7e0-3ea7-412f-836d-2da8eb4723f8"), null });

            migrationBuilder.InsertData(
                table: "TrainerReservations",
                columns: new[] { "Id", "CourtReservationId", "IsDeleted", "TrainerId", "TrainerReviewId" },
                values: new object[] { new Guid("d97ea249-5864-4e1d-9ec3-930646f08278"), new Guid("0fdba66e-ff82-47b3-b9e2-b197e1089aa6"), true, new Guid("833ec7e0-3ea7-412f-836d-2da8eb4723f8"), null });
        }
    }
}
