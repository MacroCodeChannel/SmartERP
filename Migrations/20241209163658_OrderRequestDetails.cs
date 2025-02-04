using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartERP.Migrations
{
    /// <inheritdoc />
    public partial class OrderRequestDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropIndex(
                name: "IX_OrderRequestLines_ItemId",
                table: "OrderRequestLines");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "OrderRequestLines");

            migrationBuilder.AlterColumn<string>(
                name: "ItemDescription",
                table: "OrderRequestLines",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ItemName",
                table: "OrderRequestLines",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemName",
                table: "OrderRequestLines");

            migrationBuilder.UpdateData(
                table: "OrderRequestLines",
                keyColumn: "ItemDescription",
                keyValue: null,
                column: "ItemDescription",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "ItemDescription",
                table: "OrderRequestLines",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "OrderRequestLines",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderRequestLines_ItemId",
                table: "OrderRequestLines",
                column: "ItemId");
        }
    }
}
