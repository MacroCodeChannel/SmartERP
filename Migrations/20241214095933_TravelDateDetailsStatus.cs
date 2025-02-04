using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartERP.Migrations
{
    /// <inheritdoc />
    public partial class TravelDateDetailsStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "TravelRequestHeaders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TravelRequestHeaders_StatusId",
                table: "TravelRequestHeaders",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelRequestHeaders_SystemCodeDetails_StatusId",
                table: "TravelRequestHeaders",
                column: "StatusId",
                principalTable: "SystemCodeDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TravelRequestHeaders_SystemCodeDetails_StatusId",
                table: "TravelRequestHeaders");

            migrationBuilder.DropIndex(
                name: "IX_TravelRequestHeaders_StatusId",
                table: "TravelRequestHeaders");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "TravelRequestHeaders");
        }
    }
}
