using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartERP.Migrations
{
    /// <inheritdoc />
    public partial class projectMembersdetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ConsultantId",
                table: "ProjectMembers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContractId",
                table: "ProjectMembers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectMembers_ConsultantId",
                table: "ProjectMembers",
                column: "ConsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectMembers_ContractId",
                table: "ProjectMembers",
                column: "ContractId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectMembers_Consultants_ConsultantId",
                table: "ProjectMembers",
                column: "ConsultantId",
                principalTable: "Consultants",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectMembers_Consultants_ContractId",
                table: "ProjectMembers",
                column: "ContractId",
                principalTable: "Consultants",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectMembers_Consultants_ConsultantId",
                table: "ProjectMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectMembers_Consultants_ContractId",
                table: "ProjectMembers");

            migrationBuilder.DropIndex(
                name: "IX_ProjectMembers_ConsultantId",
                table: "ProjectMembers");

            migrationBuilder.DropIndex(
                name: "IX_ProjectMembers_ContractId",
                table: "ProjectMembers");

            migrationBuilder.DropColumn(
                name: "ConsultantId",
                table: "ProjectMembers");

            migrationBuilder.DropColumn(
                name: "ContractId",
                table: "ProjectMembers");
        }
    }
}
