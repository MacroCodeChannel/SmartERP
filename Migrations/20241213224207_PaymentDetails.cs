using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartERP.Migrations
{
    /// <inheritdoc />
    public partial class PaymentDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_SystemCodeDetails_CurrencyTypeId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_SystemCodeDetails_PaymentStatusId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_CurrencyTypeId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "CurrencyTypeId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Payee",
                table: "Payments");

            migrationBuilder.RenameColumn(
                name: "PaymentStatusId",
                table: "Payments",
                newName: "StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_PaymentStatusId",
                table: "Payments",
                newName: "IX_Payments_StatusId");

            migrationBuilder.AddColumn<int>(
                name: "ConsultantId",
                table: "Payments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Payments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ConsultantId",
                table: "Payments",
                column: "ConsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_EmployeeId",
                table: "Payments",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Consultants_ConsultantId",
                table: "Payments",
                column: "ConsultantId",
                principalTable: "Consultants",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Employees_EmployeeId",
                table: "Payments",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_SystemCodeDetails_StatusId",
                table: "Payments",
                column: "StatusId",
                principalTable: "SystemCodeDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Consultants_ConsultantId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Employees_EmployeeId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_SystemCodeDetails_StatusId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_ConsultantId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_EmployeeId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "ConsultantId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Payments");

            migrationBuilder.RenameColumn(
                name: "StatusId",
                table: "Payments",
                newName: "PaymentStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_StatusId",
                table: "Payments",
                newName: "IX_Payments_PaymentStatusId");

            migrationBuilder.AddColumn<int>(
                name: "CurrencyTypeId",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Payee",
                table: "Payments",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_CurrencyTypeId",
                table: "Payments",
                column: "CurrencyTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_SystemCodeDetails_CurrencyTypeId",
                table: "Payments",
                column: "CurrencyTypeId",
                principalTable: "SystemCodeDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_SystemCodeDetails_PaymentStatusId",
                table: "Payments",
                column: "PaymentStatusId",
                principalTable: "SystemCodeDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
