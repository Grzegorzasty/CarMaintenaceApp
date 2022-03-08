using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class Deleted_workshop_entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Repair_Workshop_WorkshopId",
                table: "Repair");

            migrationBuilder.DropTable(
                name: "Workshop");

            migrationBuilder.DropIndex(
                name: "IX_Repair_WorkshopId",
                table: "Repair");

            migrationBuilder.DropColumn(
                name: "WorkshopId",
                table: "Repair");

            migrationBuilder.AddColumn<string>(
                name: "WorkshopName",
                table: "Repair",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WorkshopName",
                table: "Repair");

            migrationBuilder.AddColumn<int>(
                name: "WorkshopId",
                table: "Repair",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Workshop",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Adress = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    RepairId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workshop", x => x.Id);
                });

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
    }
}
