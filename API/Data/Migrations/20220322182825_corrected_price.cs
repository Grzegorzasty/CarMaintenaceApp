using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class corrected_price : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PartsPrize",
                table: "Repair",
                newName: "PartsPrice");

            migrationBuilder.RenameColumn(
                name: "LaborPrize",
                table: "Repair",
                newName: "LaborPrice");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PartsPrice",
                table: "Repair",
                newName: "PartsPrize");

            migrationBuilder.RenameColumn(
                name: "LaborPrice",
                table: "Repair",
                newName: "LaborPrize");
        }
    }
}
