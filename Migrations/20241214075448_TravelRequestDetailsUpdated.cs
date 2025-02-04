using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartERP.Migrations
{
    /// <inheritdoc />
    public partial class TravelRequestDetailsUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TravelRequestMembers_Countries_NationalityId",
                table: "TravelRequestMembers");

            migrationBuilder.DropIndex(
                name: "IX_TravelRequestMembers_NationalityId",
                table: "TravelRequestMembers");

            migrationBuilder.DropColumn(
                name: "NationalityId",
                table: "TravelRequestMembers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NationalityId",
                table: "TravelRequestMembers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TravelRequestMembers_NationalityId",
                table: "TravelRequestMembers",
                column: "NationalityId");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelRequestMembers_Countries_NationalityId",
                table: "TravelRequestMembers",
                column: "NationalityId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
