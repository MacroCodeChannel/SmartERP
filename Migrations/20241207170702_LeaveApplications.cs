using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartERP.Migrations
{
    /// <inheritdoc />
    public partial class LeaveApplications : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveApplications_SystemCodeDetails_DurationId",
                table: "LeaveApplications");

            migrationBuilder.DropIndex(
                name: "IX_LeaveApplications_DurationId",
                table: "LeaveApplications");

            migrationBuilder.DropColumn(
                name: "DurationId",
                table: "LeaveApplications");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DurationId",
                table: "LeaveApplications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_LeaveApplications_DurationId",
                table: "LeaveApplications",
                column: "DurationId");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveApplications_SystemCodeDetails_DurationId",
                table: "LeaveApplications",
                column: "DurationId",
                principalTable: "SystemCodeDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
