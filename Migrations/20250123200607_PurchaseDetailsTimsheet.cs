using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartERP.Migrations
{
    /// <inheritdoc />
    public partial class PurchaseDetailsTimsheet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TimesheetLineId",
                table: "PurchaseLines",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseLines_TimesheetLineId",
                table: "PurchaseLines",
                column: "TimesheetLineId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseLines_TimeSheetLines_TimesheetLineId",
                table: "PurchaseLines",
                column: "TimesheetLineId",
                principalTable: "TimeSheetLines",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseLines_TimeSheetLines_TimesheetLineId",
                table: "PurchaseLines");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseLines_TimesheetLineId",
                table: "PurchaseLines");

            migrationBuilder.DropColumn(
                name: "TimesheetLineId",
                table: "PurchaseLines");
        }
    }
}
