using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartERP.Migrations
{
    /// <inheritdoc />
    public partial class TimesheetGeneralDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "TimeSheets");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "TimeSheets");

            migrationBuilder.DropColumn(
                name: "TotalHours",
                table: "TimeSheets");

            migrationBuilder.DropColumn(
                name: "DayTypeId",
                table: "TimeSheetLines");

            migrationBuilder.DropColumn(
                name: "ProjectRoleId",
                table: "TimeSheetLines");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "TimeSheets",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "TimeSheets",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "TotalHours",
                table: "TimeSheets",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "DayTypeId",
                table: "TimeSheetLines",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectRoleId",
                table: "TimeSheetLines",
                type: "int",
                nullable: true);

        }
    }
}
