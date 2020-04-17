using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectAthena.Migrations
{
    public partial class ChangeReportColumnNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataColumn1",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumn10",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumn2",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumn3",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumn4",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumn5",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumn6",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumn7",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumn8",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumn9",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumnA",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumnB",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumnC",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumnD",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumnE",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumnF",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumnG",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumnH",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumnI",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumnJ",
                table: "Report");

            migrationBuilder.AddColumn<int>(
                name: "DataColumnNumber1",
                table: "Report",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DataColumnNumber10",
                table: "Report",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DataColumnNumber2",
                table: "Report",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DataColumnNumber3",
                table: "Report",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DataColumnNumber4",
                table: "Report",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DataColumnNumber5",
                table: "Report",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DataColumnNumber6",
                table: "Report",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DataColumnNumber7",
                table: "Report",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DataColumnNumber8",
                table: "Report",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DataColumnNumber9",
                table: "Report",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnTextA",
                table: "Report",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnTextB",
                table: "Report",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnTextC",
                table: "Report",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnTextD",
                table: "Report",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnTextE",
                table: "Report",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnTextF",
                table: "Report",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnTextG",
                table: "Report",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnTextH",
                table: "Report",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnTextI",
                table: "Report",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnTextJ",
                table: "Report",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataColumnNumber1",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumnNumber10",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumnNumber2",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumnNumber3",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumnNumber4",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumnNumber5",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumnNumber6",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumnNumber7",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumnNumber8",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumnNumber9",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumnTextA",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumnTextB",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumnTextC",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumnTextD",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumnTextE",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumnTextF",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumnTextG",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumnTextH",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumnTextI",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "DataColumnTextJ",
                table: "Report");

            migrationBuilder.AddColumn<int>(
                name: "DataColumn1",
                table: "Report",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DataColumn10",
                table: "Report",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DataColumn2",
                table: "Report",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DataColumn3",
                table: "Report",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DataColumn4",
                table: "Report",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DataColumn5",
                table: "Report",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DataColumn6",
                table: "Report",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DataColumn7",
                table: "Report",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DataColumn8",
                table: "Report",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DataColumn9",
                table: "Report",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnA",
                table: "Report",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnB",
                table: "Report",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnC",
                table: "Report",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnD",
                table: "Report",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnE",
                table: "Report",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnF",
                table: "Report",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnG",
                table: "Report",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnH",
                table: "Report",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnI",
                table: "Report",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataColumnJ",
                table: "Report",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
