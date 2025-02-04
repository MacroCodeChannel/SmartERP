using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartERP.Migrations
{
    /// <inheritdoc />
    public partial class ClientsDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropIndex(
                name: "IX_SalesHeaders_ConsultantId",
                table: "SalesHeaders");

            migrationBuilder.DropColumn(
                name: "ConsultantId",
                table: "SalesHeaders");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "SalesHeaders",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_SalesHeaders_EmployeeId",
                table: "SalesHeaders",
                newName: "IX_SalesHeaders_ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesHeaders_Clients_ClientId",
                table: "SalesHeaders",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "SalesHeaders",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_SalesHeaders_ClientId",
                table: "SalesHeaders",
                newName: "IX_SalesHeaders_EmployeeId");

            migrationBuilder.AddColumn<int>(
                name: "ConsultantId",
                table: "SalesHeaders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SalesHeaders_ConsultantId",
                table: "SalesHeaders",
                column: "ConsultantId");

        }
    }
}
