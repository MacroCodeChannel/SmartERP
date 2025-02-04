using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartERP.Migrations
{
    /// <inheritdoc />
    public partial class ContractRates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "DailyRate",
                table: "Contracts",
                type: "decimal(18,3)",
                precision: 18,
                scale: 3,
                nullable: true,
                defaultValueSql: "00.000");

            migrationBuilder.AddColumn<decimal>(
                name: "LumpsumAmount",
                table: "Contracts",
                type: "decimal(18,3)",
                precision: 18,
                scale: 3,
                nullable: true,
                defaultValueSql: "00.000");

            migrationBuilder.AddColumn<decimal>(
                name: "MonthlyRate",
                table: "Contracts",
                type: "decimal(18,3)",
                precision: 18,
                scale: 3,
                nullable: true,
                defaultValueSql: "00.000");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DailyRate",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "LumpsumAmount",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "MonthlyRate",
                table: "Contracts");
        }
    }
}
