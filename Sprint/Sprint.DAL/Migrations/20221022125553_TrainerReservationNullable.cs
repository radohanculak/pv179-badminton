using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sprint.DAL.EFCore.Migrations
{
    public partial class TrainerReservationNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("32af9051-c940-4777-b340-a706590f4dc5"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("502530e5-7d30-43ac-a53c-8bb8b15d3ff5"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("a3ace0c7-0dbb-46f7-99c1-8c655b0d3d59"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("a5ec885d-9c2a-4ad3-bbf0-af602fcd6943"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("e290db1a-37a7-428a-9062-ed93b330c7b8"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("270df941-caff-4073-a04f-4c15e33d7b51"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("8518a4ac-00a5-4350-8322-125ce5beaa35"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("e30979b2-0802-4067-a034-60739a5429fc"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("eca699b6-fd97-40e5-a4f5-21ab5ebad248"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("5a97a3e8-1255-4746-a292-8e8110359051"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("6caa3663-590d-4dea-be23-8aa7ca7ba8ca"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("a6ebf392-bb1e-4d36-ac28-d64c40a4f87a"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("3d9a3f7f-851d-42a8-850d-9a467b15babc"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("98c6e6ed-d4f0-4b58-a580-9b4144e55e97"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("abfc6696-9eed-4703-8b4d-9c34eec7795a"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("307d4080-7dba-4567-b359-f0222341e3a7"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("ce384bc6-9139-4ccc-9716-3ddbfce01022"));

            migrationBuilder.DeleteData(
                table: "TrainerReviews",
                keyColumn: "Id",
                keyValue: new Guid("102cbf9f-80e4-4ac5-ba89-6a5da6dce1f1"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("2aa44892-ba41-40fd-b058-2cfad3ea9644"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("45d75ad8-10f0-4e66-8212-783bafe50d16"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("77237c69-7a31-4777-993b-477183f3541e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa480908-5712-4dab-a843-c9150dbe5870"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("a5cc0b56-fc9b-43c2-9278-957b8380451c"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("c7c1a907-8d7e-4ece-a63d-a4ad9f464a9d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81ca6b64-6721-4c1e-ba7d-a2198b7e0e50"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9051a943-c1d9-4e4b-80d4-b169947c3f50"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("307d4080-7dba-4567-b359-f0222341e3a7"), "A", 1000m });

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate" },
                values: new object[] { new Guid("a5cc0b56-fc9b-43c2-9278-957b8380451c"), "D", 500m });

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate" },
                values: new object[] { new Guid("c7c1a907-8d7e-4ece-a63d-a4ad9f464a9d"), "B", 800m });

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate" },
                values: new object[] { new Guid("ce384bc6-9139-4ccc-9716-3ddbfce01022"), "C", 800m });

            migrationBuilder.InsertData(
                table: "TrainerReviews",
                columns: new[] { "Id", "Hide", "Rating", "Text" },
                values: new object[] { new Guid("102cbf9f-80e4-4ac5-ba89-6a5da6dce1f1"), false, 5, "tbd" });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Description", "Email", "FirstName", "HourlyRate", "LastName", "PasswordHash" },
                values: new object[] { new Guid("2aa44892-ba41-40fd-b058-2cfad3ea9644"), "I know how to play even better, that's all", "493352@mail.muni.cz", "Jitka", 3485m, "Viceníková", "tbd" });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Description", "Email", "FirstName", "HourlyRate", "LastName", "PasswordHash" },
                values: new object[] { new Guid("45d75ad8-10f0-4e66-8212-783bafe50d16"), "I know how to play, that's all", "rhanculak@mail.muni.cz", "Radovan", 2000m, "Hančuľák", "tbd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "LastName", "PasswordHash", "PhotoPath" },
                values: new object[] { new Guid("77237c69-7a31-4777-993b-477183f3541e"), new DateTime(2001, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "514329@mail.muni.cz", "Adam", "Mydla", "tbd", "tbd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "LastName", "PasswordHash", "PhotoPath" },
                values: new object[] { new Guid("81ca6b64-6721-4c1e-ba7d-a2198b7e0e50"), new DateTime(1955, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "monic@nonexistentmail.com", "Monica", "Bellucci", "tbd", "tbd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "LastName", "PasswordHash", "PhotoPath" },
                values: new object[] { new Guid("9051a943-c1d9-4e4b-80d4-b169947c3f50"), new DateTime(1993, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "rntr@nonexistentmail.com", "Roman", "NieTenRoman", "tbd", "tbd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "LastName", "PasswordHash", "PhotoPath" },
                values: new object[] { new Guid("aa480908-5712-4dab-a843-c9150dbe5870"), new DateTime(1995, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "pppeter@nonexistentmail.com", "Peter", "Griffin", "tbd", "tbd" });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("32af9051-c940-4777-b340-a706590f4dc5"), new Guid("ce384bc6-9139-4ccc-9716-3ddbfce01022"), new DateTime(2022, 9, 5, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new Guid("77237c69-7a31-4777-993b-477183f3541e") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("3d9a3f7f-851d-42a8-850d-9a467b15babc"), new Guid("c7c1a907-8d7e-4ece-a63d-a4ad9f464a9d"), new DateTime(2022, 9, 16, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 9, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9051a943-c1d9-4e4b-80d4-b169947c3f50") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("502530e5-7d30-43ac-a53c-8bb8b15d3ff5"), new Guid("307d4080-7dba-4567-b359-f0222341e3a7"), new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("77237c69-7a31-4777-993b-477183f3541e") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("98c6e6ed-d4f0-4b58-a580-9b4144e55e97"), new Guid("c7c1a907-8d7e-4ece-a63d-a4ad9f464a9d"), new DateTime(2022, 9, 15, 18, 4, 4, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9051a943-c1d9-4e4b-80d4-b169947c3f50") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("a3ace0c7-0dbb-46f7-99c1-8c655b0d3d59"), new Guid("307d4080-7dba-4567-b359-f0222341e3a7"), new DateTime(2022, 9, 28, 19, 19, 19, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aa480908-5712-4dab-a843-c9150dbe5870") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("a5ec885d-9c2a-4ad3-bbf0-af602fcd6943"), new Guid("ce384bc6-9139-4ccc-9716-3ddbfce01022"), new DateTime(2022, 9, 21, 6, 51, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), new Guid("77237c69-7a31-4777-993b-477183f3541e") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("abfc6696-9eed-4703-8b4d-9c34eec7795a"), new Guid("a5cc0b56-fc9b-43c2-9278-957b8380451c"), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 12, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("81ca6b64-6721-4c1e-ba7d-a2198b7e0e50") });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[] { new Guid("e290db1a-37a7-428a-9062-ed93b330c7b8"), new Guid("307d4080-7dba-4567-b359-f0222341e3a7"), new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aa480908-5712-4dab-a843-c9150dbe5870") });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[] { new Guid("270df941-caff-4073-a04f-4c15e33d7b51"), false, "tbd", new Guid("45d75ad8-10f0-4e66-8212-783bafe50d16") });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[] { new Guid("8518a4ac-00a5-4350-8322-125ce5beaa35"), true, "tbd", new Guid("2aa44892-ba41-40fd-b058-2cfad3ea9644") });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[] { new Guid("e30979b2-0802-4067-a034-60739a5429fc"), true, "tbd", new Guid("2aa44892-ba41-40fd-b058-2cfad3ea9644") });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[] { new Guid("eca699b6-fd97-40e5-a4f5-21ab5ebad248"), false, "tbd", new Guid("45d75ad8-10f0-4e66-8212-783bafe50d16") });

            migrationBuilder.InsertData(
                table: "TrainerReservations",
                columns: new[] { "Id", "CourtReservationId", "IsDeleted", "TrainerId", "TrainerReviewId" },
                values: new object[] { new Guid("5a97a3e8-1255-4746-a292-8e8110359051"), new Guid("abfc6696-9eed-4703-8b4d-9c34eec7795a"), false, new Guid("2aa44892-ba41-40fd-b058-2cfad3ea9644"), new Guid("102cbf9f-80e4-4ac5-ba89-6a5da6dce1f1") });

            migrationBuilder.InsertData(
                table: "TrainerReservations",
                columns: new[] { "Id", "CourtReservationId", "IsDeleted", "TrainerId", "TrainerReviewId" },
                values: new object[] { new Guid("6caa3663-590d-4dea-be23-8aa7ca7ba8ca"), new Guid("98c6e6ed-d4f0-4b58-a580-9b4144e55e97"), false, new Guid("45d75ad8-10f0-4e66-8212-783bafe50d16"), null });

            migrationBuilder.InsertData(
                table: "TrainerReservations",
                columns: new[] { "Id", "CourtReservationId", "IsDeleted", "TrainerId", "TrainerReviewId" },
                values: new object[] { new Guid("a6ebf392-bb1e-4d36-ac28-d64c40a4f87a"), new Guid("3d9a3f7f-851d-42a8-850d-9a467b15babc"), true, new Guid("45d75ad8-10f0-4e66-8212-783bafe50d16"), null });
        }
    }
}
