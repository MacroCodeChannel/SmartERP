using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartERP.Migrations
{
    /// <inheritdoc />
    public partial class PurchaseOrderUpdatesDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeliveryLocationId",
                table: "PurchaseHeaders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseHeaders_DeliveryLocationId",
                table: "PurchaseHeaders",
                column: "DeliveryLocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseHeaders_Location_DeliveryLocationId",
                table: "PurchaseHeaders",
                column: "DeliveryLocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseHeaders_Location_DeliveryLocationId",
                table: "PurchaseHeaders");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseHeaders_DeliveryLocationId",
                table: "PurchaseHeaders");

            migrationBuilder.DropColumn(
                name: "DeliveryLocationId",
                table: "PurchaseHeaders");
        }
    }
}
