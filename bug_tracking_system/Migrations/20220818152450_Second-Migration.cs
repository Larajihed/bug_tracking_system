using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bug_tracking_system.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectName",
                table: "Bugs");
        }

       
    }
}
