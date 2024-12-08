using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartERP.Migrations
{
    /// <inheritdoc />
    public partial class ReportsProjectMembers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectMembers_ProjectMembers_ReportsToId",
                table: "ProjectMembers");

            migrationBuilder.AlterColumn<int>(
                name: "ReportsToId",
                table: "ProjectMembers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectMembers_ProjectMembers_ReportsToId",
                table: "ProjectMembers",
                column: "ReportsToId",
                principalTable: "ProjectMembers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectMembers_ProjectMembers_ReportsToId",
                table: "ProjectMembers");

            migrationBuilder.AlterColumn<int>(
                name: "ReportsToId",
                table: "ProjectMembers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectMembers_ProjectMembers_ReportsToId",
                table: "ProjectMembers",
                column: "ReportsToId",
                principalTable: "ProjectMembers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
