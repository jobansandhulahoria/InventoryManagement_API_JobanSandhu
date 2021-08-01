using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryManagement_API_JobanSandhu.Data.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockMaintains_Categories_CategoryID",
                table: "StockMaintains");

            migrationBuilder.DropForeignKey(
                name: "FK_StockMaintains_Products_ProductID",
                table: "StockMaintains");

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "StockMaintains",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryID",
                table: "StockMaintains",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_StockMaintains_Categories_CategoryID",
                table: "StockMaintains",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StockMaintains_Products_ProductID",
                table: "StockMaintains",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockMaintains_Categories_CategoryID",
                table: "StockMaintains");

            migrationBuilder.DropForeignKey(
                name: "FK_StockMaintains_Products_ProductID",
                table: "StockMaintains");

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "StockMaintains",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryID",
                table: "StockMaintains",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_StockMaintains_Categories_CategoryID",
                table: "StockMaintains",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StockMaintains_Products_ProductID",
                table: "StockMaintains",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
