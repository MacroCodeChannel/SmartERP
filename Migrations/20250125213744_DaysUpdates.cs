using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartERP.Migrations
{
    /// <inheritdoc />
    public partial class DaysUpdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalHours",
                table: "Contracts",
                newName: "Months");

            migrationBuilder.AddColumn<decimal>(
                name: "Days",
                table: "Contracts",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Days",
                table: "Contracts");

            migrationBuilder.RenameColumn(
                name: "Months",
                table: "Contracts",
                newName: "TotalHours");
        }
    }
}
