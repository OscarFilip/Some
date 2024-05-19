using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LIAProv.Migrations
{
    /// <inheritdoc />
    public partial class fixedspellingerror : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VehicleID",
                table: "VehicleReports",
                newName: "VehicleReportID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VehicleReportID",
                table: "VehicleReports",
                newName: "VehicleID");
        }
    }
}
