using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E.Commerce.Identity.Migrations
{
    public partial class AddIdentitytables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "d91eb758-4d55-464b-a195-ba364babaf0d", "9eb95394-18e0-418f-8f63-4a9181a48cc8", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f84b9b1c-16b1-4ef4-aeff-170743b764d2", "aa3ec49c-55c6-4b62-b0ae-866eb198e7d5", "User", "User" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d91eb758-4d55-464b-a195-ba364babaf0d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f84b9b1c-16b1-4ef4-aeff-170743b764d2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4f846251-1a67-4fca-9c5c-e4e566b1fb74", "b08d005c-9b4f-4711-927b-e4122730b2ba", "User", "User" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d37fbeb0-fc94-4df8-97d6-6c39a1686ed8", "9b945194-b7c7-4560-804a-b62f9a90d1ea", "Admin", "Admin" });
        }
    }
}
