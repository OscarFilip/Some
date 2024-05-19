using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LIAProv.Migrations
{
    /// <inheritdoc />
    public partial class AddedDescriptiontoVehicleReportClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RegistrationNumber",
                table: "VehicleReports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReportDescripton",
                table: "VehicleReports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReportDescripton",
                table: "VehicleReports");

            migrationBuilder.AlterColumn<string>(
                name: "RegistrationNumber",
                table: "VehicleReports",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
