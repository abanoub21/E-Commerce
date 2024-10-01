using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E.Commerce.Infrastracture.Migrations
{
    public partial class EditQuantity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carts_products_ProductId",
                table: "carts");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderProducts_ordered_OrderId",
                table: "OrderProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderProducts_products_ProductID",
                table: "OrderProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_products_Categories_CategoryId",
                table: "products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_products",
                table: "products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ordered",
                table: "ordered");

            migrationBuilder.DropPrimaryKey(
                name: "PK_carts",
                table: "carts");

            migrationBuilder.RenameTable(
                name: "products",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "ordered",
                newName: "Ordered");

            migrationBuilder.RenameTable(
                name: "carts",
                newName: "Carts");

            migrationBuilder.RenameIndex(
                name: "IX_products_CategoryId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.RenameColumn(
                name: "Qantity",
                table: "OrderProducts",
                newName: "Quantity");

            migrationBuilder.RenameIndex(
                name: "IX_carts_ProductId",
                table: "Carts",
                newName: "IX_Carts_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ordered",
                table: "Ordered",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Products_ProductId",
                table: "Carts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProducts_Ordered_OrderId",
                table: "OrderProducts",
                column: "OrderId",
                principalTable: "Ordered",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProducts_Products_ProductID",
                table: "OrderProducts",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Products_ProductId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderProducts_Ordered_OrderId",
                table: "OrderProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderProducts_Products_ProductID",
                table: "OrderProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ordered",
                table: "Ordered");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "products");

            migrationBuilder.RenameTable(
                name: "Ordered",
                newName: "ordered");

            migrationBuilder.RenameTable(
                name: "Carts",
                newName: "carts");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "products",
                newName: "IX_products_CategoryId");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "OrderProducts",
                newName: "Qantity");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_ProductId",
                table: "carts",
                newName: "IX_carts_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_products",
                table: "products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ordered",
                table: "ordered",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_carts",
                table: "carts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_carts_products_ProductId",
                table: "carts",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProducts_ordered_OrderId",
                table: "OrderProducts",
                column: "OrderId",
                principalTable: "ordered",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProducts_products_ProductID",
                table: "OrderProducts",
                column: "ProductID",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_Categories_CategoryId",
                table: "products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
