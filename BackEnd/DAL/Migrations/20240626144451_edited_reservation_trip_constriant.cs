using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class edited_reservation_trip_constriant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Trips_TripId",
                table: "Reservations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06c4fa4f-f281-4375-a5a5-25f4aaa5fa09",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6bc29492-f4ac-4fc0-9116-eea5d239594c", "848609b5-2c2d-44e8-9920-d7befaf5e8ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10ebb4a2-4078-4d38-9c1d-b71731e51813",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "695851d4-4ed6-4819-9cd4-a7380cb0d1e7", "10b7ea80-482e-4065-892b-07509a09cdbc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1305c3a4-d78d-4698-9767-fb6f0be09c0b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "17256c43-d832-473b-893e-01e7dc3f7de6", "f32d02ac-56f5-49a0-969b-cea7eea904f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1947e428-e7f7-4b72-8333-259683d51737",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "36879ebf-2f42-4399-83c9-888f0d1701ab", "f3bde01c-0e53-42fe-83d8-e6a0daff3ce0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20260240-d81d-4eb5-9efa-6750cd5efd78",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c13aa6c9-9b39-4d29-bb48-1be0629b0b70", "8c58b139-9f41-45be-863a-fbe9808ca8d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ccb170d-598b-4202-86d0-2e30da515914",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "eefc596d-0763-4a6d-9885-f86bcc8d9d59", "e92c190d-3154-431e-943b-469760a50ec4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2fcd9e91-89f7-48a9-8f0f-33c4af7e8d80",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8f645408-0d28-4a88-a33c-cc48d25abe31", "e8928c9e-882d-4d0f-b043-529aea7fe80f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38e2719d-2c73-4451-b386-32673b9798f4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bbfe9f6e-ef25-448e-8150-bbb10012c676", "b127d625-8e6f-426f-8747-2ba4c297ca34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3ac4283c-46f2-412b-848d-abbef6f8f96d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0cea73de-2388-472f-810a-e0280137fd29", "cd995739-ede0-4c56-98a8-1b795ca06fcb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43f816d6-81e7-4ec8-9e7e-a90eb27c60c6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d415b966-da6d-4ec4-9105-7d3cc7b022ff", "b1cc1c4d-57f9-4f0c-b154-fce861e98b73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45289333-f686-4cc5-a2ed-20d3cb48901b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "eb3edfea-194c-4637-9a21-8dc4fc2dbbb7", "5dd699ca-5662-4fd4-a143-1c5eeb74253e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b47560f-1a8e-451d-8088-e2d96df2deca",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3dc45307-b8e9-415b-bc02-8a7df68bb600", "70617a6b-daa9-47b4-a75d-59f3072f6dbd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58efc192-1af9-4b71-ab9c-165c96593240",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "85d76fb9-626f-4477-8c86-1321e4756ac0", "2e11f2b7-8c62-4a00-9f9a-2cd7b11b9314" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5aa2d999-f820-46f7-a9bc-d16da40263f9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "581aa014-852d-40d8-aa4f-27d63ead37fd", "d8a48478-7dde-4da8-9055-fd953db5c620" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "61db600d-6a31-4c49-9e4f-eff9621218d7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "03397a1a-0b09-4ca0-9b81-9c0d956e4981", "3ffc3399-130c-438a-b3c4-2a0c5f5342c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6304764a-9691-4fc9-8070-4b5f464c16dd",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cbb232a4-0359-488a-95bb-f4fb26ad79fe", "3f243116-34ae-470e-831b-26cf0b3f7807" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69fab494-f64b-4e36-8202-43c8659d6942",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "42334b64-359d-4b2b-a8bb-4000112b22a0", "7f190d50-558b-466f-a89e-3be60c6c90f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ab33b1e-42a6-46c0-adf8-dc572a3a4d36",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "330bc640-0fba-4018-8b7d-2701285b0c97", "31faca20-dd89-41c9-b922-3779e46aecbd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7119d1ad-6f54-421c-99ed-bd1ed7ff3a28",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3949459b-b9b1-47fb-9eb4-05101ed23c03", "dd875b97-45ba-44ad-8872-5ac99f007aca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "733ec01e-c84f-4c95-ab8f-d3f73d6b3661",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2b664378-62b0-46d1-ad55-5e7d7c4c9fc5", "70b0e40f-b8ed-4cf9-859c-73c1209995ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74a47e09-f97c-4e4b-ad51-3eed7fd6ea0d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d486ef78-b82b-4b5f-885a-083c433eaf10", "b4893c8f-eb42-4080-817e-1e0905f4167f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "829c0f3d-5cc9-470e-a7da-e6f1186a7216",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ca58d072-8536-4f48-95e3-78fe6e5cc8df", "f843f7f5-4be4-4199-8049-de47897c97b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8341a302-6b87-431b-a252-2ffcd90948a1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "64d5424f-cbcd-489c-adbf-1ced0740f065", "101cefc6-8b79-4fda-8a9b-7e40ac9f4569" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8361dfdf-f686-45f4-a45c-7d83a347792d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "74dfc6c4-411b-46e1-87d7-d91ee5cf8e59", "2767bda6-2791-41af-b20d-447efe0d1e7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e449921-33a6-494a-ae62-3de5b2d1f41c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3a89ecc4-9154-4263-96a8-98027df3828b", "e5dee399-fc5e-4afc-a23d-2841f08b2f6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a0f9ad5-2f92-4955-9275-d136728b51a7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fea5d8a6-dbee-48b9-8d43-ff767bf03ad1", "854160b9-983f-41f3-bee4-0cb4f8a1cca9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b915f3e-8ff0-40e1-af96-ed02561ba2b5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d8c9fea0-9950-4fc6-a445-2fb0ea1be277", "14d7fa93-6954-4e5d-aac8-d82ea7a092cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a079a3f1-ddb0-4f6a-a3fb-952fa92c8951",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dd7e5251-79c0-4c1d-8ded-f68e18e108d1", "5b779412-0608-4e0e-a835-123e47de929c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0ee769b-5470-44a5-8529-2fa87d254f4a",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "eab34bab-3836-4cff-8fbe-326563cd4753", "c51e149b-9efa-423a-a03b-88858ca7e494" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a31eabb3-ff8f-4d89-8750-d7d9a2431149",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5ffb68a0-549d-4803-bdb5-1f7431f5ed35", "f473d624-9332-4b81-bfda-fae57d2779d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a83eeaef-cacf-4848-81c2-a1d5746dc2c8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f1817712-4f97-41e3-bf16-fd78658efcae", "4ce98b41-b3e2-4a22-86b2-932ac0abfb72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b96da449-a77f-49b0-bc3e-01ce46dd991c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8f07f7fc-2131-4418-92db-a9c8378a64b1", "62684bde-2f5f-443e-b3fd-1a9f3b16b4a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcd0a627-1e73-4d60-99bb-5fa4359d1c0d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f793721d-cb58-4689-a464-6a40f34f6977", "7cd3f59d-0a7c-4731-b770-065651f3e3ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c60ffa8f-57cb-4821-b0a0-5178d12bda71",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0ce4014e-6f36-497d-b34a-32fcb5735324", "340a5c6b-bd7c-4b31-a32d-7c678eabe6f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6cdde60-f783-4542-8f36-443c00cdf41f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "19ad97d1-eaa6-4e0c-9f82-83073336b589", "7e4ac09e-7e98-4c46-8559-57e2a5a02ae7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc6c9526-f50c-4769-91b1-2b0b5bf73acf",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3523e50e-a54d-4868-98d4-b07f96dea095", "0f5f5b13-4cc4-4144-962e-414cea069445" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db413fd2-ed42-4eb3-81cb-af1d0f5d34c1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2d870e8c-604a-480d-9c83-4709371cad6a", "6d410423-a1f4-4c86-8043-b5e47fb0e779" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6d0209c-c4f2-4e25-891c-a653e14a21dd",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a256436d-f85e-4353-ad52-0285cc6fbd24", "1ff716aa-c754-4951-927c-008e5e0092dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed62cea4-f01a-4283-b098-642299b04776",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dec8839d-5a47-4132-8892-c433f1079ce2", "031633b5-b987-4623-821b-a3ca14ea455c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0fd67a7-a8f6-42d1-924b-4ef2cbfbe7dd",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5de3fe3c-d576-4c0d-9772-fb30c431d6c4", "0a15862d-2041-4f39-9ee2-f17d0d340122" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f95361be-330d-4e79-b667-4981fd7503c7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9b1d01e0-7cb5-4412-baf6-611a76dcf816", "9412335e-7228-4952-92d0-4b594c1f649c" });

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Trips_TripId",
                table: "Reservations",
                column: "TripId",
                principalTable: "Trips",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Trips_TripId",
                table: "Reservations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06c4fa4f-f281-4375-a5a5-25f4aaa5fa09",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9adc2df9-66d3-4331-a8f5-53a734001246", "8a16560f-b8d5-4e3d-b56a-94dd38e9010e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10ebb4a2-4078-4d38-9c1d-b71731e51813",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "61ebad4a-881e-4c64-abaf-f90b542c5591", "c069c33f-b4fd-448a-bc9b-ce55c2a7d3a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1305c3a4-d78d-4698-9767-fb6f0be09c0b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "662c1a5c-b0dc-499e-adcd-1b888bba5356", "09c7705e-4f02-469c-988a-e173fbbb67d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1947e428-e7f7-4b72-8333-259683d51737",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cfa91aa5-7464-4b36-8cbd-b3bcb2f3d961", "9094a5dc-468e-42e8-be50-da53f8256ace" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20260240-d81d-4eb5-9efa-6750cd5efd78",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7ea407c9-77ae-40b6-b94a-fa7a86d3d0ae", "2fd9d4da-d46a-42b6-85d2-9fee94955fce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ccb170d-598b-4202-86d0-2e30da515914",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "74fc9af3-52ac-41af-b275-fd7a4499d8e4", "6cbc7e79-5b4a-425e-b5dd-29bfd8b5bda9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2fcd9e91-89f7-48a9-8f0f-33c4af7e8d80",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "90c500a8-dd0b-419d-9b44-e48c705db4f9", "3e6bb192-d6ef-4415-b170-ab0a28c04048" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38e2719d-2c73-4451-b386-32673b9798f4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9e302bb8-1bda-4884-9fd5-654a82a062e0", "823cd7f8-388c-4f96-acaf-999d6bf3276a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3ac4283c-46f2-412b-848d-abbef6f8f96d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9e611874-62df-4e03-97bb-13beee484521", "567cca94-f04c-4726-b383-c829026d7a86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43f816d6-81e7-4ec8-9e7e-a90eb27c60c6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2b50532e-ed15-4cb5-a1fd-f381f7c64fc6", "dbdc12c9-67e7-4903-ba92-27494f4f97e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45289333-f686-4cc5-a2ed-20d3cb48901b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a338b4b4-b344-4773-bd1d-964aff737ea4", "f1aed34e-a374-4a99-9088-d3ab33fc5886" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b47560f-1a8e-451d-8088-e2d96df2deca",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ac3a0a6b-fd17-4a63-9ecd-dd83ab4145d1", "7a1b1ea8-bbf1-4f6a-be85-d2d6b160f348" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58efc192-1af9-4b71-ab9c-165c96593240",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "89041fb6-883c-4eb5-b37b-090ca2f64c24", "12908d0f-a2b2-47e7-afd3-912565de1cc7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5aa2d999-f820-46f7-a9bc-d16da40263f9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2d0544c6-9cc0-4bc6-8b02-c7f4ffc2afc4", "89de8f9d-d2ae-49b4-b96f-64214bfd93e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "61db600d-6a31-4c49-9e4f-eff9621218d7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "649d57cf-71c0-4b40-9876-5554a6aa880b", "5a918215-c35d-44ea-9d58-0c8052858521" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6304764a-9691-4fc9-8070-4b5f464c16dd",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ee35e2cd-c63e-47d7-b7a0-50f2c6bb8867", "23ef1435-9eff-45b4-a9d9-202dc3b6e489" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69fab494-f64b-4e36-8202-43c8659d6942",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3b15d5c4-a8d1-4168-9ed4-8179a2aae1c2", "a40ad102-513b-4fa1-8e6c-6dc7214d385e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ab33b1e-42a6-46c0-adf8-dc572a3a4d36",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0d16d375-9b2c-459b-b97e-513a4988dddc", "26e69fad-8ce9-44fa-aa1f-93043e5bf41c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7119d1ad-6f54-421c-99ed-bd1ed7ff3a28",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b8c5be40-65ae-4679-bbba-2a5acc1cadab", "18c6c72d-3d2b-4c61-8d33-eb202a73a9a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "733ec01e-c84f-4c95-ab8f-d3f73d6b3661",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f44c59da-b6df-42bd-8b09-f7b999a506a8", "23a67cca-077c-4727-a8e9-715937e96993" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74a47e09-f97c-4e4b-ad51-3eed7fd6ea0d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cc75ec05-180e-4d9d-b538-59eb1239e019", "1f3f5c35-5ab8-4c4f-b308-23fe8c764799" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "829c0f3d-5cc9-470e-a7da-e6f1186a7216",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3f442327-3770-481e-bb8c-299106d57f7e", "c73580fd-0549-4e52-9306-1acb5ccaafc3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8341a302-6b87-431b-a252-2ffcd90948a1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2b354365-4f98-4f0f-972e-f1509d36c716", "a3ebd597-894e-45d9-94d8-cfc1a9a79dbd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8361dfdf-f686-45f4-a45c-7d83a347792d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5e606761-374c-4005-8f92-5da693be948c", "505848fc-b92d-4fc5-9a43-fa0caca51b08" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e449921-33a6-494a-ae62-3de5b2d1f41c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "42275981-f570-489c-80e0-ce480f094ac7", "0c5abd1d-06a1-4e05-a258-80e47024b801" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a0f9ad5-2f92-4955-9275-d136728b51a7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "27615a36-61e0-4d1a-83d6-0f005bf0b05d", "1d8d868d-7e43-4674-9d5e-fa031abf5112" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b915f3e-8ff0-40e1-af96-ed02561ba2b5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ba4f06c3-5f16-45b4-bb17-06d89d9a0cf0", "29816733-55c9-478f-be50-415084540924" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a079a3f1-ddb0-4f6a-a3fb-952fa92c8951",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f069574a-4fa3-457e-98c9-f6462f6c744b", "c8548905-5b3b-4d4e-825a-4a2d9158cfa5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0ee769b-5470-44a5-8529-2fa87d254f4a",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "305a4203-5f46-46dd-88a7-293c3382e797", "06ef5d90-96eb-4cd8-95af-da8bc5f27687" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a31eabb3-ff8f-4d89-8750-d7d9a2431149",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e43e8e55-b2fa-4cf6-bc65-d7fb64e071da", "e17ee829-eeec-4407-bceb-2716b52ed35b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a83eeaef-cacf-4848-81c2-a1d5746dc2c8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e8a85b02-7230-4ed0-80c4-9e7d923d716e", "8d110688-7209-4ae1-8fbf-c31fd8f478e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b96da449-a77f-49b0-bc3e-01ce46dd991c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c7867434-cc0b-46f8-af1f-466d55438f98", "32377858-c4c6-42eb-91a2-10648f3dac16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcd0a627-1e73-4d60-99bb-5fa4359d1c0d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7a712abc-548d-48d7-b329-97481665e263", "92e06abf-56f9-4fb2-9340-fcfb365f5d64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c60ffa8f-57cb-4821-b0a0-5178d12bda71",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4590ac42-cf90-4a9a-bc51-b12406ae17a0", "9f59997d-bc61-4dcc-ab02-911bc1935a11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6cdde60-f783-4542-8f36-443c00cdf41f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d22ff767-ef0b-423a-b860-d4aeee96e574", "28a787ab-38f6-4250-8f90-6c53b4c1278b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc6c9526-f50c-4769-91b1-2b0b5bf73acf",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6f59084b-88cc-498d-8343-7ee24f8e4b20", "71c6194b-0d3d-4c08-86e3-444a03d90909" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db413fd2-ed42-4eb3-81cb-af1d0f5d34c1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7a5a0ae7-2008-4870-81ef-5a38d93d73b0", "cc85f249-7efe-46c5-bada-18db1579d455" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6d0209c-c4f2-4e25-891c-a653e14a21dd",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f0c0eeb8-002a-4218-858a-98edc1e976ac", "029d5944-ba72-4fc4-acc3-a1b834597abf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed62cea4-f01a-4283-b098-642299b04776",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7ee863c5-78c0-4e66-8a3c-12a68734c954", "3c862ece-e808-4999-8542-48516106ccd7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0fd67a7-a8f6-42d1-924b-4ef2cbfbe7dd",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2aecb549-ed1d-4c48-989f-aa9555e8588a", "edc663de-8b1c-44ef-b603-52a48c20be8e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f95361be-330d-4e79-b667-4981fd7503c7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bdd2be42-f20c-4d4c-adf3-357f0d39a8fa", "1a19fd63-4e52-43d8-9378-57d9745ccac7" });

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Trips_TripId",
                table: "Reservations",
                column: "TripId",
                principalTable: "Trips",
                principalColumn: "Id");
        }
    }
}
