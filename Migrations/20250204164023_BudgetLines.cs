using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartERP.Migrations
{
    /// <inheritdoc />
    public partial class BudgetLines : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BudgetItemId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_BudgetItemId",
                table: "Items",
                column: "BudgetItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ProjectBudgetItems_BudgetItemId",
                table: "Items",
                column: "BudgetItemId",
                principalTable: "ProjectBudgetItems",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ProjectBudgetItems_BudgetItemId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_BudgetItemId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "BudgetItemId",
                table: "Items");
        }
    }
}
