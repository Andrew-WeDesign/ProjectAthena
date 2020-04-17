using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectAthena.Migrations
{
    public partial class NamesToCampaignUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserFullName",
                table: "CampaignUser",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CampaignName",
                table: "CampaignUser",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplicationUserFullName",
                table: "CampaignUser");

            migrationBuilder.DropColumn(
                name: "CampaignName",
                table: "CampaignUser");
        }
    }
}
