using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E.Commerce.Identity.Migrations
{
    public partial class editRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "4f846251-1a67-4fca-9c5c-e4e566b1fb74", "b08d005c-9b4f-4711-927b-e4122730b2ba", "User", "User" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d37fbeb0-fc94-4df8-97d6-6c39a1686ed8", "9b945194-b7c7-4560-804a-b62f9a90d1ea", "Admin", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f846251-1a67-4fca-9c5c-e4e566b1fb74");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d37fbeb0-fc94-4df8-97d6-6c39a1686ed8");

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
    }
}
