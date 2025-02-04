using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartERP.Migrations
{
    /// <inheritdoc />
    public partial class ContractUpdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            


            migrationBuilder.DropColumn(
                name: "Delivarables",
                table: "Contracts");

            migrationBuilder.CreateTable(
                name: "ContractDeliverables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ContractId = table.Column<int>(type: "int", nullable: false),
                    TaskName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Days = table.Column<decimal>(type: "decimal(18,3)", precision: 18, scale: 3, nullable: false, defaultValueSql: "00.000")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractDeliverables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractDeliverables_Contracts_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contracts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ContractDeliverables_ContractId",
                table: "ContractDeliverables",
                column: "ContractId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Consultants_ConsultantId",
                table: "Contracts",
                column: "ConsultantId",
                principalTable: "Consultants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeSheets_ProjectMembers_ConsultantId",
                table: "TimeSheets",
                column: "ConsultantId",
                principalTable: "ProjectMembers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContractDeliverables");

            migrationBuilder.AddColumn<string>(
                name: "Delivarables",
                table: "Contracts",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Employees_ConsultantId",
                table: "Contracts",
                column: "ConsultantId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeSheets_Consultants_ConsultantId",
                table: "TimeSheets",
                column: "ConsultantId",
                principalTable: "Consultants",
                principalColumn: "Id");
        }
    }
}
