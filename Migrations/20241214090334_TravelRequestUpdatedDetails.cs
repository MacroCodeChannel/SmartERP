using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartERP.Migrations
{
    /// <inheritdoc />
    public partial class TravelRequestUpdatedDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TravelRequestHeaders_Location_ArrivalId",
                table: "TravelRequestHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelRequestHeaders_Location_DestinationId",
                table: "TravelRequestHeaders");

            migrationBuilder.DropIndex(
                name: "IX_TravelRequestHeaders_ArrivalId",
                table: "TravelRequestHeaders");

            migrationBuilder.DropColumn(
                name: "ArrivalId",
                table: "TravelRequestHeaders");

            migrationBuilder.DropColumn(
                name: "ArrivalTo",
                table: "TravelRequestHeaders");

            migrationBuilder.RenameColumn(
                name: "DestinationId",
                table: "TravelRequestHeaders",
                newName: "ArrivalToId");

            migrationBuilder.RenameIndex(
                name: "IX_TravelRequestHeaders_DestinationId",
                table: "TravelRequestHeaders",
                newName: "IX_TravelRequestHeaders_ArrivalToId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelRequestHeaders_DestinationFromId",
                table: "TravelRequestHeaders",
                column: "DestinationFromId");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelRequestHeaders_Location_ArrivalToId",
                table: "TravelRequestHeaders",
                column: "ArrivalToId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TravelRequestHeaders_Location_DestinationFromId",
                table: "TravelRequestHeaders",
                column: "DestinationFromId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TravelRequestHeaders_Location_ArrivalToId",
                table: "TravelRequestHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelRequestHeaders_Location_DestinationFromId",
                table: "TravelRequestHeaders");

            migrationBuilder.DropIndex(
                name: "IX_TravelRequestHeaders_DestinationFromId",
                table: "TravelRequestHeaders");

            migrationBuilder.RenameColumn(
                name: "ArrivalToId",
                table: "TravelRequestHeaders",
                newName: "DestinationId");

            migrationBuilder.RenameIndex(
                name: "IX_TravelRequestHeaders_ArrivalToId",
                table: "TravelRequestHeaders",
                newName: "IX_TravelRequestHeaders_DestinationId");

            migrationBuilder.AddColumn<int>(
                name: "ArrivalId",
                table: "TravelRequestHeaders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ArrivalTo",
                table: "TravelRequestHeaders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TravelRequestHeaders_ArrivalId",
                table: "TravelRequestHeaders",
                column: "ArrivalId");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelRequestHeaders_Location_ArrivalId",
                table: "TravelRequestHeaders",
                column: "ArrivalId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TravelRequestHeaders_Location_DestinationId",
                table: "TravelRequestHeaders",
                column: "DestinationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
