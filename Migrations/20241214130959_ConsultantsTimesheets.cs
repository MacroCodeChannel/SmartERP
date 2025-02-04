using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartERP.Migrations
{
    /// <inheritdoc />
    public partial class ConsultantsTimesheets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ConsultantId",
                table: "TimeSheets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TimeSheets_ConsultantId",
                table: "TimeSheets",
                column: "ConsultantId");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeSheets_Consultants_ConsultantId",
                table: "TimeSheets",
                column: "ConsultantId",
                principalTable: "Consultants",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimeSheets_Consultants_ConsultantId",
                table: "TimeSheets");

            migrationBuilder.DropIndex(
                name: "IX_TimeSheets_ConsultantId",
                table: "TimeSheets");

            migrationBuilder.DropColumn(
                name: "ConsultantId",
                table: "TimeSheets");
        }
    }
}
