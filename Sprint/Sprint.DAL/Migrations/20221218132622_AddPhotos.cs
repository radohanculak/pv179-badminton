using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sprint.DAL.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class AddPhotos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
