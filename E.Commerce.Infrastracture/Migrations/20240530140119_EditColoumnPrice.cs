using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E.Commerce.Infrastracture.Migrations
{
    public partial class EditColoumnPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalPraice",
                table: "carts",
                newName: "TotalPrice");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalPrice",
                table: "carts",
                newName: "TotalPraice");
        }
    }
}
