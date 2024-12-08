using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartERP.Migrations
{
    /// <inheritdoc />
    public partial class ProjectMembers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReportsToId",
                table: "ProjectMembers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectMembers_ReportsToId",
                table: "ProjectMembers",
                column: "ReportsToId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectMembers_Employees_ReportsToId",
                table: "ProjectMembers",
                column: "ReportsToId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectMembers_Employees_ReportsToId",
                table: "ProjectMembers");

            migrationBuilder.DropIndex(
                name: "IX_ProjectMembers_ReportsToId",
                table: "ProjectMembers");

            migrationBuilder.DropColumn(
                name: "ReportsToId",
                table: "ProjectMembers");
        }
    }
}
