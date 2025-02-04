using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartERP.Migrations
{
    /// <inheritdoc />
    public partial class PurchaseOrderOrderRequestDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderTypeId",
                table: "PurchaseHeaders",
                newName: "OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseHeaders_OrderTypeId",
                table: "PurchaseHeaders",
                newName: "IX_PurchaseHeaders_OrderId");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
         
            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "PurchaseHeaders",
                newName: "OrderTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseHeaders_OrderId",
                table: "PurchaseHeaders",
                newName: "IX_PurchaseHeaders_OrderTypeId");

        }
    }
}
