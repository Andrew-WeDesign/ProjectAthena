using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectAthena.Migrations
{
    public partial class ChangeCampaignColumnNamesForLINQ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataColumn10Title",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumn1Title",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumn2Title",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumn3Title",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumn4Title",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumn5Title",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumn6Title",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumn7Title",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumn8Title",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumn9Title",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumnATitle",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumnBTitle",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumnCTitle",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumnDTitle",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumnETitle",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumnFTitle",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumnGTitle",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumnHTitle",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumnITitle",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumnJTitle",
                table: "Campaign");

            migrationBuilder.AddColumn<string>(
                name: "DataColumnNumber10Title",
                table: "Campaign",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnNumber1Title",
                table: "Campaign",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnNumber2Title",
                table: "Campaign",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnNumber3Title",
                table: "Campaign",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnNumber4Title",
                table: "Campaign",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnNumber5Title",
                table: "Campaign",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnNumber6Title",
                table: "Campaign",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnNumber7Title",
                table: "Campaign",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnNumber8Title",
                table: "Campaign",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnNumber9Title",
                table: "Campaign",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnTextATitle",
                table: "Campaign",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnTextBTitle",
                table: "Campaign",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnTextCTitle",
                table: "Campaign",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnTextDTitle",
                table: "Campaign",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnTextETitle",
                table: "Campaign",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnTextFTitle",
                table: "Campaign",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnTextGTitle",
                table: "Campaign",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnTextHTitle",
                table: "Campaign",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnTextITitle",
                table: "Campaign",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnTextJTitle",
                table: "Campaign",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataColumnNumber10Title",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumnNumber1Title",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumnNumber2Title",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumnNumber3Title",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumnNumber4Title",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumnNumber5Title",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumnNumber6Title",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumnNumber7Title",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumnNumber8Title",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumnNumber9Title",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumnTextATitle",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumnTextBTitle",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumnTextCTitle",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumnTextDTitle",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumnTextETitle",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumnTextFTitle",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumnTextGTitle",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumnTextHTitle",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumnTextITitle",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "DataColumnTextJTitle",
                table: "Campaign");

            migrationBuilder.AddColumn<string>(
                name: "DataColumn10Title",
                table: "Campaign",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumn1Title",
                table: "Campaign",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumn2Title",
                table: "Campaign",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumn3Title",
                table: "Campaign",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumn4Title",
                table: "Campaign",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumn5Title",
                table: "Campaign",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumn6Title",
                table: "Campaign",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumn7Title",
                table: "Campaign",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumn8Title",
                table: "Campaign",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumn9Title",
                table: "Campaign",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnATitle",
                table: "Campaign",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnBTitle",
                table: "Campaign",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnCTitle",
                table: "Campaign",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnDTitle",
                table: "Campaign",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnETitle",
                table: "Campaign",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnFTitle",
                table: "Campaign",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnGTitle",
                table: "Campaign",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnHTitle",
                table: "Campaign",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnITitle",
                table: "Campaign",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnJTitle",
                table: "Campaign",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
