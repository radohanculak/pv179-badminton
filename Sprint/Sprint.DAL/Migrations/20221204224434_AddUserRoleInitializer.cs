using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sprint.DAL.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class AddUserRoleInitializer : Migration
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

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CourtNumber", "HourlyRate" },
                values: new object[,]
                {
                    { new Guid("3cd70919-8600-4490-a9de-884c267bda39"), "C", 800m },
                    { new Guid("77e58714-93d2-439f-947a-480ca6884394"), "B", 800m },
                    { new Guid("de76f6aa-99a9-436b-a444-757a66574bf3"), "D", 500m },
                    { new Guid("fff03dec-7db9-4e9e-b9f1-cc49ac1f4202"), "A", 1000m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "IsTrainer", "LastName", "PasswordHash", "PhotoPath", "Role" },
                values: new object[,]
                {
                    { new Guid("1dc48374-8e94-433b-b2d1-61ff715d12ec"), new DateTime(2001, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "514329@mail.muni.cz", "Adam", false, "Mydla", "tbd", "tbd", 0 },
                    { new Guid("1fa8325a-344e-4ed7-9ca5-1e9a7f459988"), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "rhanculak@mail.muni.cz", "Radovan", true, "Hančuľák", "tbd", "tbd", 1 },
                    { new Guid("4f681c3c-4a71-4047-871c-e450700d2fab"), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "493352@mail.muni.cz", "Jitka", true, "Viceníková", "tbd", "tbd", 1 },
                    { new Guid("c575ad0c-99f8-4678-ae50-131c07280888"), new DateTime(1955, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "monic@nonexistentmail.com", "Monica", false, "Bellucci", "tbd", "tbd", 0 },
                    { new Guid("ceaf7cd9-f88e-4c6e-ae17-5ed2772ebcc0"), new DateTime(1995, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "pppeter@nonexistentmail.com", "Peter", false, "Griffin", "tbd", "tbd", 0 },
                    { new Guid("fd6d8cda-5e37-4085-97ec-3b725a32132a"), new DateTime(1993, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "rntr@nonexistentmail.com", "Roman", false, "NieTenRoman", "tbd", "tbd", 0 }
                });

            migrationBuilder.InsertData(
                table: "CourtReservations",
                columns: new[] { "Id", "CourtId", "Created", "From", "IsDeleted", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("02f36151-3409-4a92-a558-90f1540b907b"), new Guid("77e58714-93d2-439f-947a-480ca6884394"), new DateTime(2022, 9, 15, 18, 4, 4, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fd6d8cda-5e37-4085-97ec-3b725a32132a") },
                    { new Guid("03504239-28d7-40de-a401-4e51c287461a"), new Guid("3cd70919-8600-4490-a9de-884c267bda39"), new DateTime(2022, 9, 21, 6, 51, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1dc48374-8e94-433b-b2d1-61ff715d12ec") },
                    { new Guid("5a152461-381f-413f-9901-ab29328b9a22"), new Guid("de76f6aa-99a9-436b-a444-757a66574bf3"), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 12, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c575ad0c-99f8-4678-ae50-131c07280888") },
                    { new Guid("90b01ce9-bdc2-4444-af48-919381c89329"), new Guid("77e58714-93d2-439f-947a-480ca6884394"), new DateTime(2022, 9, 16, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 9, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fd6d8cda-5e37-4085-97ec-3b725a32132a") },
                    { new Guid("987ca7e9-f15d-443a-b97e-a482a9c52b42"), new Guid("fff03dec-7db9-4e9e-b9f1-cc49ac1f4202"), new DateTime(2022, 9, 28, 19, 19, 19, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ceaf7cd9-f88e-4c6e-ae17-5ed2772ebcc0") },
                    { new Guid("a12eca9f-0641-47bc-a140-37c7e979cd70"), new Guid("3cd70919-8600-4490-a9de-884c267bda39"), new DateTime(2022, 9, 5, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1dc48374-8e94-433b-b2d1-61ff715d12ec") },
                    { new Guid("bb6fee60-93af-4589-9dee-5607ac8c21d3"), new Guid("fff03dec-7db9-4e9e-b9f1-cc49ac1f4202"), new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1dc48374-8e94-433b-b2d1-61ff715d12ec") },
                    { new Guid("ced7cc9e-980c-442a-b7c4-5c5a2e7e0b4a"), new Guid("fff03dec-7db9-4e9e-b9f1-cc49ac1f4202"), new DateTime(2022, 9, 20, 9, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 9, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ceaf7cd9-f88e-4c6e-ae17-5ed2772ebcc0") }
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Description", "HourlyRate", "UserId" },
                values: new object[,]
                {
                    { new Guid("2e6378df-ca0c-45f1-a38f-93f173d430b8"), "I know how to play, that's all", 2000m, new Guid("1fa8325a-344e-4ed7-9ca5-1e9a7f459988") },
                    { new Guid("b3125ba5-d393-4b90-9d30-4455a3bdd9c5"), "I know how to play even better, that's all", 3485m, new Guid("4f681c3c-4a71-4047-871c-e450700d2fab") }
                });

            migrationBuilder.InsertData(
                table: "TrainerPhotos",
                columns: new[] { "Id", "Hide", "Path", "TrainerId" },
                values: new object[,]
                {
                    { new Guid("1d5764b5-fb93-4c6e-a5f5-3e4afec37676"), true, "tbd", new Guid("b3125ba5-d393-4b90-9d30-4455a3bdd9c5") },
                    { new Guid("b34056fc-20ca-4b37-9854-6d0dcb86b38d"), false, "tbd", new Guid("2e6378df-ca0c-45f1-a38f-93f173d430b8") },
                    { new Guid("be6609b5-3ed6-475f-9a7d-1e1818b6eae4"), false, "tbd", new Guid("2e6378df-ca0c-45f1-a38f-93f173d430b8") },
                    { new Guid("f6bea63b-d3db-476f-bb25-3a0cc55bbfee"), true, "tbd", new Guid("b3125ba5-d393-4b90-9d30-4455a3bdd9c5") }
                });

            migrationBuilder.InsertData(
                table: "TrainerReservations",
                columns: new[] { "Id", "CourtReservationId", "IsDeleted", "TrainerId", "TrainerReviewId" },
                values: new object[,]
                {
                    { new Guid("1bcfec30-e02f-4234-9eb0-27e7912fadc2"), new Guid("90b01ce9-bdc2-4444-af48-919381c89329"), true, new Guid("2e6378df-ca0c-45f1-a38f-93f173d430b8"), null },
                    { new Guid("a698edf3-5778-4449-93bc-dfe77a74b125"), new Guid("02f36151-3409-4a92-a558-90f1540b907b"), false, new Guid("2e6378df-ca0c-45f1-a38f-93f173d430b8"), null },
                    { new Guid("b48ee0b2-6413-4486-8573-af648c7f62c0"), new Guid("5a152461-381f-413f-9901-ab29328b9a22"), false, new Guid("b3125ba5-d393-4b90-9d30-4455a3bdd9c5"), null }
                });

            migrationBuilder.InsertData(
                table: "TrainerReviews",
                columns: new[] { "Id", "Hide", "Rating", "ReservationId", "Text" },
                values: new object[] { new Guid("d8ddc4b6-4a03-4922-8e5a-65abe063b9a8"), false, 5, new Guid("b48ee0b2-6413-4486-8573-af648c7f62c0"), "tbd" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("03504239-28d7-40de-a401-4e51c287461a"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("987ca7e9-f15d-443a-b97e-a482a9c52b42"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("a12eca9f-0641-47bc-a140-37c7e979cd70"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("bb6fee60-93af-4589-9dee-5607ac8c21d3"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("ced7cc9e-980c-442a-b7c4-5c5a2e7e0b4a"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("1d5764b5-fb93-4c6e-a5f5-3e4afec37676"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("b34056fc-20ca-4b37-9854-6d0dcb86b38d"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("be6609b5-3ed6-475f-9a7d-1e1818b6eae4"));

            migrationBuilder.DeleteData(
                table: "TrainerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("f6bea63b-d3db-476f-bb25-3a0cc55bbfee"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("1bcfec30-e02f-4234-9eb0-27e7912fadc2"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("a698edf3-5778-4449-93bc-dfe77a74b125"));

            migrationBuilder.DeleteData(
                table: "TrainerReviews",
                keyColumn: "Id",
                keyValue: new Guid("d8ddc4b6-4a03-4922-8e5a-65abe063b9a8"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("02f36151-3409-4a92-a558-90f1540b907b"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("90b01ce9-bdc2-4444-af48-919381c89329"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("3cd70919-8600-4490-a9de-884c267bda39"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("fff03dec-7db9-4e9e-b9f1-cc49ac1f4202"));

            migrationBuilder.DeleteData(
                table: "TrainerReservations",
                keyColumn: "Id",
                keyValue: new Guid("b48ee0b2-6413-4486-8573-af648c7f62c0"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("2e6378df-ca0c-45f1-a38f-93f173d430b8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1dc48374-8e94-433b-b2d1-61ff715d12ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ceaf7cd9-f88e-4c6e-ae17-5ed2772ebcc0"));

            migrationBuilder.DeleteData(
                table: "CourtReservations",
                keyColumn: "Id",
                keyValue: new Guid("5a152461-381f-413f-9901-ab29328b9a22"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("77e58714-93d2-439f-947a-480ca6884394"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("b3125ba5-d393-4b90-9d30-4455a3bdd9c5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1fa8325a-344e-4ed7-9ca5-1e9a7f459988"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fd6d8cda-5e37-4085-97ec-3b725a32132a"));

            migrationBuilder.DeleteData(
                table: "Courts",
                keyColumn: "Id",
                keyValue: new Guid("de76f6aa-99a9-436b-a444-757a66574bf3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4f681c3c-4a71-4047-871c-e450700d2fab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c575ad0c-99f8-4678-ae50-131c07280888"));

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
