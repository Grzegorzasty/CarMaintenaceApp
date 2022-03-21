using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class deleted_bool_values : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AirFilterChange",
                table: "Repair");

            migrationBuilder.DropColumn(
                name: "BreakDiscsChange",
                table: "Repair");

            migrationBuilder.DropColumn(
                name: "BreakFluidChange",
                table: "Repair");

            migrationBuilder.DropColumn(
                name: "BreakPadsChange",
                table: "Repair");

            migrationBuilder.DropColumn(
                name: "CabinFilterChange",
                table: "Repair");

            migrationBuilder.DropColumn(
                name: "CoolantChange",
                table: "Repair");

            migrationBuilder.DropColumn(
                name: "EngineCamChange",
                table: "Repair");

            migrationBuilder.DropColumn(
                name: "EngineOilChange",
                table: "Repair");

            migrationBuilder.DropColumn(
                name: "EngineOilFilterChange",
                table: "Repair");

            migrationBuilder.DropColumn(
                name: "FuelFilterChange",
                table: "Repair");

            migrationBuilder.DropColumn(
                name: "GearboxOilChange",
                table: "Repair");

            migrationBuilder.DropColumn(
                name: "GearboxOilFilterChange",
                table: "Repair");

            migrationBuilder.DropColumn(
                name: "HydraulicOilChange",
                table: "Repair");

            migrationBuilder.DropColumn(
                name: "HydraulicOilFilterChange",
                table: "Repair");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AirFilterChange",
                table: "Repair",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "BreakDiscsChange",
                table: "Repair",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "BreakFluidChange",
                table: "Repair",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "BreakPadsChange",
                table: "Repair",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CabinFilterChange",
                table: "Repair",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CoolantChange",
                table: "Repair",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EngineCamChange",
                table: "Repair",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EngineOilChange",
                table: "Repair",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EngineOilFilterChange",
                table: "Repair",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FuelFilterChange",
                table: "Repair",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "GearboxOilChange",
                table: "Repair",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "GearboxOilFilterChange",
                table: "Repair",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HydraulicOilChange",
                table: "Repair",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HydraulicOilFilterChange",
                table: "Repair",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
