using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartERP.Migrations
{
    /// <inheritdoc />
    public partial class OrderRequestTypeId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderTypeId",
                table: "OrderRequests",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderRequests_OrderTypeId",
                table: "OrderRequests",
                column: "OrderTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderRequests_SystemCodeDetails_OrderTypeId",
                table: "OrderRequests",
                column: "OrderTypeId",
                principalTable: "SystemCodeDetails",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderRequests_SystemCodeDetails_OrderTypeId",
                table: "OrderRequests");

            migrationBuilder.DropIndex(
                name: "IX_OrderRequests_OrderTypeId",
                table: "OrderRequests");

            migrationBuilder.DropColumn(
                name: "OrderTypeId",
                table: "OrderRequests");
        }
    }
}
