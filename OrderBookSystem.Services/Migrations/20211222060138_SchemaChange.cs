using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderBookSystem.Services.Migrations
{
    public partial class SchemaChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Stocks",
                newName: "OrderType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderType",
                table: "Stocks",
                newName: "Type");
        }
    }
}
