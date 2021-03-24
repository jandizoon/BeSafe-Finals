using Microsoft.EntityFrameworkCore.Migrations;

namespace MyInventory.Migrations
{
    public partial class Act3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Items",
                newName: "CompanyName");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Items",
                newName: "Representative");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "Items",
                newName: "SupplierId");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "Representative",
                table: "Items",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "Items",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "SupplierId",
                table: "Items",
                newName: "ItemId");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Items",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
