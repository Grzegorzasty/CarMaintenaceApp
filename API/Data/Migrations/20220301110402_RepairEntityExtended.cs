using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class RepairEntityExtended : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workshop_Repair_RepairId",
                table: "Workshop");

            migrationBuilder.DropIndex(
                name: "IX_Workshop_RepairId",
                table: "Workshop");

            migrationBuilder.RenameColumn(
                name: "Parts",
                table: "Repair",
                newName: "KeyWords");

            migrationBuilder.RenameColumn(
                name: "OilFilterChange",
                table: "Repair",
                newName: "WorkshopId");

            migrationBuilder.RenameColumn(
                name: "OilChange",
                table: "Repair",
                newName: "HydraulicOilFilterChange");

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

            migrationBuilder.CreateIndex(
                name: "IX_Repair_WorkshopId",
                table: "Repair",
                column: "WorkshopId");

            migrationBuilder.AddForeignKey(
                name: "FK_Repair_Workshop_WorkshopId",
                table: "Repair",
                column: "WorkshopId",
                principalTable: "Workshop",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Repair_Workshop_WorkshopId",
                table: "Repair");

            migrationBuilder.DropIndex(
                name: "IX_Repair_WorkshopId",
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
                name: "GearboxOilChange",
                table: "Repair");

            migrationBuilder.DropColumn(
                name: "GearboxOilFilterChange",
                table: "Repair");

            migrationBuilder.DropColumn(
                name: "HydraulicOilChange",
                table: "Repair");

            migrationBuilder.RenameColumn(
                name: "WorkshopId",
                table: "Repair",
                newName: "OilFilterChange");

            migrationBuilder.RenameColumn(
                name: "KeyWords",
                table: "Repair",
                newName: "Parts");

            migrationBuilder.RenameColumn(
                name: "HydraulicOilFilterChange",
                table: "Repair",
                newName: "OilChange");

            migrationBuilder.CreateIndex(
                name: "IX_Workshop_RepairId",
                table: "Workshop",
                column: "RepairId");

            migrationBuilder.AddForeignKey(
                name: "FK_Workshop_Repair_RepairId",
                table: "Workshop",
                column: "RepairId",
                principalTable: "Repair",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
