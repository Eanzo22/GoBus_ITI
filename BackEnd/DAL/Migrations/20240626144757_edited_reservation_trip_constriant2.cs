using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class edited_reservation_trip_constriant2 : Migration
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
                values: new object[] { "c7ef89a5-a0c8-429a-ba5e-70ec06e03989", "c24a0389-8f7c-49bc-b4cf-604f9b7399e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10ebb4a2-4078-4d38-9c1d-b71731e51813",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "48bf1d99-58f9-4125-8a21-916e3d29e27f", "ffd71e65-6de7-4f63-b0b9-e683350c5833" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1305c3a4-d78d-4698-9767-fb6f0be09c0b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8c4fa8ed-49a3-490d-8321-88deeb95564c", "316a69e4-e5ee-4eda-b204-42b1cc576027" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1947e428-e7f7-4b72-8333-259683d51737",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "407c7047-dc4f-4225-b534-2d0596dbd9e8", "75342c6d-6dd5-433f-adc5-0b55808b64e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20260240-d81d-4eb5-9efa-6750cd5efd78",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4edfc4f8-3240-4e06-a801-85e4ea687042", "785ba4eb-0165-4ec2-8933-217932e4e5d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ccb170d-598b-4202-86d0-2e30da515914",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0fcf502b-2c4e-4af6-9667-8ed09eb1acb3", "cdb1552f-f26b-4d96-a29e-aa1e90579999" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2fcd9e91-89f7-48a9-8f0f-33c4af7e8d80",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "97e45669-4a7f-4f21-80e6-da0b337f9d9a", "3fcf5b8c-998e-46ad-b0e0-9291030227b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38e2719d-2c73-4451-b386-32673b9798f4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7f56963e-1c72-4a43-86e7-f7d67c1e650f", "73e41593-5f7a-42a4-8d8f-573f6b2e15aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3ac4283c-46f2-412b-848d-abbef6f8f96d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "10f2ed74-1839-4640-9225-39d34bd4e43f", "01a92a0d-4cd7-481b-96b2-e6423ce09102" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43f816d6-81e7-4ec8-9e7e-a90eb27c60c6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "01f5ff49-2de2-4f05-b054-095c3535aa23", "87abf7a0-ac33-4b9f-bad4-1b635c870e46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45289333-f686-4cc5-a2ed-20d3cb48901b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ed1bdf0b-97e8-4448-b2c5-e7f3f4ac1715", "13fa96db-b83d-4ed6-acd1-1a8d729b1b79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b47560f-1a8e-451d-8088-e2d96df2deca",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c923eaae-0b7d-483a-ac5b-7d6963434055", "730d620a-f984-4985-bac5-b47328c8ddbf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58efc192-1af9-4b71-ab9c-165c96593240",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cc75cb05-17ca-4264-86f3-0abb0ae3d320", "c11d2573-f77e-4e16-a0a8-ad78bed327f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5aa2d999-f820-46f7-a9bc-d16da40263f9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6c6d5ef4-0bc4-4e77-8718-523c83aa30eb", "a848c277-b490-49a8-aa45-61933917aeff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "61db600d-6a31-4c49-9e4f-eff9621218d7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e7c2724a-95b6-4e1f-98c9-a01700784e60", "3555535c-301d-4cc7-b52b-e1f3cd2f939e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6304764a-9691-4fc9-8070-4b5f464c16dd",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "644ec21d-2987-4f67-b3fc-373131c1f03c", "2df8a3f6-abe0-4d47-bc65-fa6811da9ff8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69fab494-f64b-4e36-8202-43c8659d6942",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dcae0ef4-0a71-491d-8e7f-a75babe99df6", "a970ce99-b338-4093-a16f-318f53ec4ee9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ab33b1e-42a6-46c0-adf8-dc572a3a4d36",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "47c12195-8eeb-44da-bfc7-1ddbf205a8ba", "51b6dede-30b5-4439-be9f-cba5b900ca0f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7119d1ad-6f54-421c-99ed-bd1ed7ff3a28",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "357f7332-d0f3-423d-9fbe-5fadda1d7044", "321ec0d9-6ae5-48c2-8fef-38c7b87d9cbc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "733ec01e-c84f-4c95-ab8f-d3f73d6b3661",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a1562414-a3f0-49fb-b04c-454c07f667b1", "d07691ec-fba9-4b79-a5cc-3170d1dfe538" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74a47e09-f97c-4e4b-ad51-3eed7fd6ea0d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d0e6e5f0-5c10-4d00-84a6-37347d9455e7", "4f0c3cfa-9e38-42ce-b84a-da39f32eabf4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "829c0f3d-5cc9-470e-a7da-e6f1186a7216",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "db47d8de-919b-4f14-beea-6a05110d0096", "43170d81-c42d-4f14-9326-08d19003f277" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8341a302-6b87-431b-a252-2ffcd90948a1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fb0527b5-ae65-4ee0-857d-18e09688282f", "321d289f-1daf-414d-bbf8-ebdea0e08bac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8361dfdf-f686-45f4-a45c-7d83a347792d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6d27bcc3-537e-48b4-be71-f11da50365df", "bafbeb0a-c391-48de-be2e-a152ed330d16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e449921-33a6-494a-ae62-3de5b2d1f41c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8bb70649-7157-43f2-9890-6efa8faf767c", "139094a3-2669-4047-b9c7-8b55c9fce40d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a0f9ad5-2f92-4955-9275-d136728b51a7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8bde0261-af65-46eb-91f2-05994b3604bc", "b5283940-3bff-4679-9fbd-1960913aad04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b915f3e-8ff0-40e1-af96-ed02561ba2b5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d27a561d-e1b3-48f8-8e2a-cd9a13d4b737", "b3f241ae-3524-4a48-8396-eeef1c499c12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a079a3f1-ddb0-4f6a-a3fb-952fa92c8951",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "067fe75d-52c4-4a52-9869-937079752c89", "6a9771e0-6d5b-4cff-b383-54a5d36a5dd5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0ee769b-5470-44a5-8529-2fa87d254f4a",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "757810e1-adf2-4cf9-8ec7-d81eb32812f3", "5643e86f-ae0f-4d79-a64d-7704a153cd75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a31eabb3-ff8f-4d89-8750-d7d9a2431149",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c9fe233f-da15-44c6-8fa4-973e8031a612", "cc71abf7-8785-46f2-bc30-15062caaa429" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a83eeaef-cacf-4848-81c2-a1d5746dc2c8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5a283cc5-9d7a-419d-9d0d-106fe37b74d9", "da6c1f84-00b3-49ee-8b9b-8e310f0a67ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b96da449-a77f-49b0-bc3e-01ce46dd991c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c7b35f4e-df7f-4a97-8e86-be47fafc2296", "c724755f-5bb2-4438-a388-e7ac107d1650" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcd0a627-1e73-4d60-99bb-5fa4359d1c0d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c498db47-f7ed-484d-bfa8-5b06da3dd0d9", "76f5a626-2eef-452e-ae36-ec53599abd8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c60ffa8f-57cb-4821-b0a0-5178d12bda71",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "93b65c3d-4972-4457-a896-7b4ebbd87467", "3eba7361-cfa5-4189-9b0a-5b44b9a35ac5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6cdde60-f783-4542-8f36-443c00cdf41f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f03359ea-c2ce-4a8d-92e2-6d7371316383", "ceebbfcc-a58d-45af-9bff-e1d72bf4823f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc6c9526-f50c-4769-91b1-2b0b5bf73acf",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "20732660-6200-4a99-9768-1c6d0b8423ae", "cc568942-4f6b-4e48-987a-2fdcb893806d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db413fd2-ed42-4eb3-81cb-af1d0f5d34c1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "71234f1d-5d35-438e-9f3d-aa126a3e9d84", "038b02f2-ca94-45b3-a89b-54ce4dff3b59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6d0209c-c4f2-4e25-891c-a653e14a21dd",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7e1fbaa2-1433-4bc4-9d77-6513089563e7", "16e0d983-7fdf-43c2-807d-2e9bd4f0b089" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed62cea4-f01a-4283-b098-642299b04776",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ae750335-6a5e-41d0-a7a1-3f41c084e180", "dbcdd622-ec30-4d12-b6a3-ed13db942e1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0fd67a7-a8f6-42d1-924b-4ef2cbfbe7dd",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "eaa5aea7-f1d4-4a86-894d-0679c8f34c01", "f14534bf-826b-4531-a3ae-a85899b1d9ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f95361be-330d-4e79-b667-4981fd7503c7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3ad26d4b-0135-43e1-842b-068ab7f95212", "4f9c8419-010f-4334-938d-d73996f88a7a" });

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Trips_TripId",
                table: "Reservations",
                column: "TripId",
                principalTable: "Trips",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
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
    }
}
