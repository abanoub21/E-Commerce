using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E.Commerce.Identity.Migrations
{
    public partial class InsertDataToRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
