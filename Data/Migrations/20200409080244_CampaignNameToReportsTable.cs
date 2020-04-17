using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectAthena.Migrations
{
    public partial class CampaignNameToReportsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CampaignName",
                table: "Report",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CampaignName",
                table: "Report");
        }
    }
}
