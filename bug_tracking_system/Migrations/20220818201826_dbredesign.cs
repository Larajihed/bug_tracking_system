using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bug_tracking_system.Migrations
{
    public partial class dbredesign : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_Priorities_PriorityId",
                table: "Bugs");

            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_Severities_SeverityId",
                table: "Bugs");

            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_Status_StatusId",
                table: "Bugs");

            migrationBuilder.DropTable(
                name: "Priorities");

            migrationBuilder.DropTable(
                name: "Severities");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropIndex(
                name: "IX_Bugs_PriorityId",
                table: "Bugs");

            migrationBuilder.DropIndex(
                name: "IX_Bugs_SeverityId",
                table: "Bugs");

            migrationBuilder.DropIndex(
                name: "IX_Bugs_StatusId",
                table: "Bugs");

            migrationBuilder.RenameColumn(
                name: "StatusId",
                table: "Bugs",
                newName: "Severity");

            migrationBuilder.RenameColumn(
                name: "SeverityId",
                table: "Bugs",
                newName: "Priority");

            migrationBuilder.RenameColumn(
                name: "PriorityId",
                table: "Bugs",
                newName: "BugStatus");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Severity",
                table: "Bugs",
                newName: "StatusId");

            migrationBuilder.RenameColumn(
                name: "Priority",
                table: "Bugs",
                newName: "SeverityId");

            migrationBuilder.RenameColumn(
                name: "BugStatus",
                table: "Bugs",
                newName: "PriorityId");

            migrationBuilder.CreateTable(
                name: "Priorities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Priorities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Severities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Severities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bugs_PriorityId",
                table: "Bugs",
                column: "PriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_Bugs_SeverityId",
                table: "Bugs",
                column: "SeverityId");

            migrationBuilder.CreateIndex(
                name: "IX_Bugs_StatusId",
                table: "Bugs",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_Priorities_PriorityId",
                table: "Bugs",
                column: "PriorityId",
                principalTable: "Priorities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_Severities_SeverityId",
                table: "Bugs",
                column: "SeverityId",
                principalTable: "Severities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_Status_StatusId",
                table: "Bugs",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
