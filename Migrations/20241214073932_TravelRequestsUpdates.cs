using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartERP.Migrations
{
    /// <inheritdoc />
    public partial class TravelRequestsUpdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DocumentNo",
                table: "Payments",
                newName: "Code");

            migrationBuilder.CreateTable(
                name: "TravelRequestHeaders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Position = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModeofTransportId = table.Column<int>(type: "int", nullable: false),
                    TravelDocumentTypeId = table.Column<int>(type: "int", nullable: false),
                    TravelDocNo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AdvanceAmount = table.Column<decimal>(type: "decimal(18,3)", precision: 18, scale: 3, nullable: false, defaultValueSql: "00.000"),
                    TravelReason = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DestinationFrom = table.Column<int>(type: "int", nullable: false),
                    DestinationId = table.Column<int>(type: "int", nullable: false),
                    ArrivalTo = table.Column<int>(type: "int", nullable: false),
                    ArrivalId = table.Column<int>(type: "int", nullable: false),
                    DepartureDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DestinationInstructions = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ArrivalInstructions = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TravelDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    OtherTravelArrangements = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelRequestHeaders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TravelRequestHeaders_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TravelRequestHeaders_Location_ArrivalId",
                        column: x => x.ArrivalId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TravelRequestHeaders_Location_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TravelRequestHeaders_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TravelRequestHeaders_SystemCodeDetails_ModeofTransportId",
                        column: x => x.ModeofTransportId,
                        principalTable: "SystemCodeDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TravelRequestHeaders_SystemCodeDetails_TravelDocumentTypeId",
                        column: x => x.TravelDocumentTypeId,
                        principalTable: "SystemCodeDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TravelRequesLines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TravelRequestHeaderId = table.Column<int>(type: "int", nullable: false),
                    UnitofMeasureId = table.Column<int>(type: "int", nullable: false),
                    ItemName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ItemDescription = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Days = table.Column<int>(type: "int", nullable: false),
                    UnitCost = table.Column<decimal>(type: "decimal(18,3)", precision: 18, scale: 3, nullable: false, defaultValueSql: "00.000"),
                    TotalCost = table.Column<decimal>(type: "decimal(18,3)", precision: 18, scale: 3, nullable: false, defaultValueSql: "00.000")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelRequesLines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TravelRequesLines_SystemCodeDetails_UnitofMeasureId",
                        column: x => x.UnitofMeasureId,
                        principalTable: "SystemCodeDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TravelRequesLines_TravelRequestHeaders_TravelRequestHeaderId",
                        column: x => x.TravelRequestHeaderId,
                        principalTable: "TravelRequestHeaders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TravelRequestMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TravelRequestHeaderId = table.Column<int>(type: "int", nullable: false),
                    ProjectMemberId = table.Column<int>(type: "int", nullable: false),
                    NationalityId = table.Column<int>(type: "int", nullable: false),
                    PassportNo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SpecialInstruction = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelRequestMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TravelRequestMembers_Countries_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TravelRequestMembers_ProjectMembers_ProjectMemberId",
                        column: x => x.ProjectMemberId,
                        principalTable: "ProjectMembers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TravelRequestMembers_TravelRequestHeaders_TravelRequestHeade~",
                        column: x => x.TravelRequestHeaderId,
                        principalTable: "TravelRequestHeaders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_TravelRequesLines_TravelRequestHeaderId",
                table: "TravelRequesLines",
                column: "TravelRequestHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelRequesLines_UnitofMeasureId",
                table: "TravelRequesLines",
                column: "UnitofMeasureId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelRequestHeaders_ArrivalId",
                table: "TravelRequestHeaders",
                column: "ArrivalId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelRequestHeaders_DestinationId",
                table: "TravelRequestHeaders",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelRequestHeaders_EmployeeId",
                table: "TravelRequestHeaders",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelRequestHeaders_ModeofTransportId",
                table: "TravelRequestHeaders",
                column: "ModeofTransportId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelRequestHeaders_ProjectId",
                table: "TravelRequestHeaders",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelRequestHeaders_TravelDocumentTypeId",
                table: "TravelRequestHeaders",
                column: "TravelDocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelRequestMembers_NationalityId",
                table: "TravelRequestMembers",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelRequestMembers_ProjectMemberId",
                table: "TravelRequestMembers",
                column: "ProjectMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelRequestMembers_TravelRequestHeaderId",
                table: "TravelRequestMembers",
                column: "TravelRequestHeaderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TravelRequesLines");

            migrationBuilder.DropTable(
                name: "TravelRequestMembers");

            migrationBuilder.DropTable(
                name: "TravelRequestHeaders");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "Payments",
                newName: "DocumentNo");
        }
    }
}
