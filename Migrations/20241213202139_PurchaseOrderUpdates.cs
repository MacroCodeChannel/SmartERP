using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartERP.Migrations
{
    /// <inheritdoc />
    public partial class PurchaseOrderUpdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseHeaders_SystemCodeDetails_CurrencyId",
                table: "PurchaseHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseHeaders_SystemCodeDetails_PaymentTermId",
                table: "PurchaseHeaders");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseHeaders_CurrencyId",
                table: "PurchaseHeaders");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "PurchaseHeaders");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "PurchaseHeaders");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "PurchaseHeaders");

            migrationBuilder.RenameColumn(
                name: "PaymentTermId",
                table: "PurchaseHeaders",
                newName: "OrderTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseHeaders_PaymentTermId",
                table: "PurchaseHeaders",
                newName: "IX_PurchaseHeaders_OrderTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseHeaders_SystemCodeDetails_OrderTypeId",
                table: "PurchaseHeaders",
                column: "OrderTypeId",
                principalTable: "SystemCodeDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseHeaders_SystemCodeDetails_OrderTypeId",
                table: "PurchaseHeaders");

            migrationBuilder.RenameColumn(
                name: "OrderTypeId",
                table: "PurchaseHeaders",
                newName: "PaymentTermId");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseHeaders_OrderTypeId",
                table: "PurchaseHeaders",
                newName: "IX_PurchaseHeaders_PaymentTermId");

            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                table: "PurchaseHeaders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "PurchaseHeaders",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "PurchaseHeaders",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseHeaders_CurrencyId",
                table: "PurchaseHeaders",
                column: "CurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseHeaders_SystemCodeDetails_CurrencyId",
                table: "PurchaseHeaders",
                column: "CurrencyId",
                principalTable: "SystemCodeDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseHeaders_SystemCodeDetails_PaymentTermId",
                table: "PurchaseHeaders",
                column: "PaymentTermId",
                principalTable: "SystemCodeDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
