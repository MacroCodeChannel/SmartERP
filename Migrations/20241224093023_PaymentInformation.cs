using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartERP.Migrations
{
    /// <inheritdoc />
    public partial class PaymentInformation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentLines_Payments_ItemId",
                table: "PaymentLines");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentLines_Payments_ItemTypeId",
                table: "PaymentLines");

            migrationBuilder.DropIndex(
                name: "IX_PaymentLines_ItemId",
                table: "PaymentLines");

            migrationBuilder.DropIndex(
                name: "IX_PaymentLines_ItemTypeId",
                table: "PaymentLines");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "PaymentLines");

            migrationBuilder.DropColumn(
                name: "ItemTypeId",
                table: "PaymentLines");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalAmount",
                table: "Payments",
                type: "decimal(18,3)",
                precision: 18,
                scale: 3,
                nullable: false,
                defaultValueSql: "00.000",
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AddColumn<string>(
                name: "ItemName",
                table: "PaymentLines",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalAmount",
                table: "PaymentLines",
                type: "decimal(18,3)",
                precision: 18,
                scale: 3,
                nullable: false,
                defaultValueSql: "00.000");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemName",
                table: "PaymentLines");

            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "PaymentLines");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalAmount",
                table: "Payments",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,3)",
                oldPrecision: 18,
                oldScale: 3,
                oldDefaultValueSql: "00.000");

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "PaymentLines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItemTypeId",
                table: "PaymentLines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PaymentLines_ItemId",
                table: "PaymentLines",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentLines_ItemTypeId",
                table: "PaymentLines",
                column: "ItemTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentLines_Payments_ItemId",
                table: "PaymentLines",
                column: "ItemId",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentLines_Payments_ItemTypeId",
                table: "PaymentLines",
                column: "ItemTypeId",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
