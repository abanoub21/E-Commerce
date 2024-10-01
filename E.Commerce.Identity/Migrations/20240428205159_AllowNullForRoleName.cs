using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E.Commerce.Identity.Migrations
{
    public partial class AllowNullForRoleName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15a6eadb-292c-4936-bd8f-593e72ab9371");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a76bdef-d3a9-4cf2-a16a-d25d1bbaabbc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de4b60a1-9306-46a8-b41a-36f7399bff2c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3fc56c00-548b-43b8-a3cb-8019651f410c", "b48b7262-d3d8-4089-ae37-596153507702", "HR", "Hr" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a25741ca-db73-4759-9213-cb3b92f55329", "314d898f-90e8-4431-99a2-fa6d9e7f400a", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "accc1411-3cb4-45ed-a0d7-a21d011f7661", "c2ce0662-9afe-4c39-9706-fdfda050ff38", "Devlopment", "Devlopment" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3fc56c00-548b-43b8-a3cb-8019651f410c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a25741ca-db73-4759-9213-cb3b92f55329");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "accc1411-3cb4-45ed-a0d7-a21d011f7661");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "15a6eadb-292c-4936-bd8f-593e72ab9371", "cc11b4fe-fe70-4a97-b4dc-1ca17dcb4be4", "HR", "Hr" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6a76bdef-d3a9-4cf2-a16a-d25d1bbaabbc", "4c1caba8-d351-4713-b3b6-0cde955ff837", "Devlopment", "Devlopment" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "de4b60a1-9306-46a8-b41a-36f7399bff2c", "5d9c3b68-832c-46ec-b8d8-50967d1b5086", "Admin", "Admin" });
        }
    }
}
