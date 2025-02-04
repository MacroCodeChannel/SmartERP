using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartERP.Migrations
{
    /// <inheritdoc />
    public partial class ProjectBudgetsDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectBudgets_ProjectBudgetCategories_BudgetCategoryId",
                table: "ProjectBudgets");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectBudgets_ProjectBudgetLines_BudgetLineId",
                table: "ProjectBudgets");

            migrationBuilder.DropIndex(
                name: "IX_ProjectBudgets_BudgetCategoryId",
                table: "ProjectBudgets");

            migrationBuilder.DropIndex(
                name: "IX_ProjectBudgets_BudgetLineId",
                table: "ProjectBudgets");

            migrationBuilder.DropColumn(
                name: "BudgetCategoryId",
                table: "ProjectBudgets");

            migrationBuilder.DropColumn(
                name: "BudgetLineId",
                table: "ProjectBudgets");

            migrationBuilder.DropColumn(
                name: "Cost",
                table: "ProjectBudgets");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "ProjectBudgets");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalCost",
                table: "ProjectBudgets",
                type: "decimal(18,3)",
                precision: 18,
                scale: 3,
                nullable: false,
                defaultValueSql: "00.000");

            migrationBuilder.AddColumn<decimal>(
                name: "UnitCost",
                table: "ProjectBudgets",
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
                name: "TotalCost",
                table: "ProjectBudgets");

            migrationBuilder.DropColumn(
                name: "UnitCost",
                table: "ProjectBudgets");

            migrationBuilder.AddColumn<int>(
                name: "BudgetCategoryId",
                table: "ProjectBudgets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BudgetLineId",
                table: "ProjectBudgets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Cost",
                table: "ProjectBudgets",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "ProjectBudgets",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectBudgets_BudgetCategoryId",
                table: "ProjectBudgets",
                column: "BudgetCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectBudgets_BudgetLineId",
                table: "ProjectBudgets",
                column: "BudgetLineId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectBudgets_ProjectBudgetCategories_BudgetCategoryId",
                table: "ProjectBudgets",
                column: "BudgetCategoryId",
                principalTable: "ProjectBudgetCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectBudgets_ProjectBudgetLines_BudgetLineId",
                table: "ProjectBudgets",
                column: "BudgetLineId",
                principalTable: "ProjectBudgetLines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
