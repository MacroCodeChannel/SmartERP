using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartERP.Migrations
{
    /// <inheritdoc />
    public partial class TimesheetDetailsUpdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "TimeSheetLines",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "TimeSheetLines",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TimeSheetLines_LocationId",
                table: "TimeSheetLines",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeSheetLines_Location_LocationId",
                table: "TimeSheetLines",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimeSheetLines_Location_LocationId",
                table: "TimeSheetLines");

            migrationBuilder.DropIndex(
                name: "IX_TimeSheetLines_LocationId",
                table: "TimeSheetLines");

            migrationBuilder.DropColumn(
                name: "Comments",
                table: "TimeSheetLines");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "TimeSheetLines");
        }
    }
}
