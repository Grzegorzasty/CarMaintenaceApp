using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class FullRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Repair_RepairId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Repair_Vehicle_VehicleId",
                table: "Repair");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Users_AppUserId",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Workshop_Repair_RepairId",
                table: "Workshop");

            migrationBuilder.AlterColumn<int>(
                name: "RepairId",
                table: "Workshop",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "Vehicle",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VehicleId",
                table: "Repair",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RepairId",
                table: "Photos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Repair_RepairId",
                table: "Photos",
                column: "RepairId",
                principalTable: "Repair",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Repair_Vehicle_VehicleId",
                table: "Repair",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Users_AppUserId",
                table: "Vehicle",
                column: "AppUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Workshop_Repair_RepairId",
                table: "Workshop",
                column: "RepairId",
                principalTable: "Repair",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Repair_RepairId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Repair_Vehicle_VehicleId",
                table: "Repair");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Users_AppUserId",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Workshop_Repair_RepairId",
                table: "Workshop");

            migrationBuilder.AlterColumn<int>(
                name: "RepairId",
                table: "Workshop",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "Vehicle",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleId",
                table: "Repair",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "RepairId",
                table: "Photos",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Repair_RepairId",
                table: "Photos",
                column: "RepairId",
                principalTable: "Repair",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Repair_Vehicle_VehicleId",
                table: "Repair",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Users_AppUserId",
                table: "Vehicle",
                column: "AppUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Workshop_Repair_RepairId",
                table: "Workshop",
                column: "RepairId",
                principalTable: "Repair",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
