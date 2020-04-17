using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectAthena.Migrations
{
    public partial class ManagerIDToCampaignsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ManagerId",
                table: "Campaign",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "Campaign");
        }
    }
}
