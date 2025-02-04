using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartERP.Migrations
{
    /// <inheritdoc />
    public partial class GoodsReceiptNotes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GoodsReceivedNoteHeaderId",
                table: "PurchaseLines",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GoodsReceivedNoteHeaders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VendorId = table.Column<int>(type: "int", nullable: false),
                    PurchaseHeaderId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    ReceivedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    DeliveryLocationId = table.Column<int>(type: "int", nullable: false),
                    ReceiptLocationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsReceivedNoteHeaders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GoodsReceivedNoteHeaders_Location_ReceiptLocationId",
                        column: x => x.ReceiptLocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GoodsReceivedNoteHeaders_PurchaseHeaders_PurchaseHeaderId",
                        column: x => x.PurchaseHeaderId,
                        principalTable: "PurchaseHeaders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GoodsReceivedNoteHeaders_SystemCodeDetails_StatusId",
                        column: x => x.StatusId,
                        principalTable: "SystemCodeDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GoodsReceivedNoteHeaders_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GoodsReceivedNoteLines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GRNHeaderId = table.Column<int>(type: "int", nullable: false),
                    UnitofMeasureId = table.Column<int>(type: "int", nullable: false),
                    ItemName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ItemDescription = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsReceivedNoteLines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GoodsReceivedNoteLines_GoodsReceivedNoteHeaders_GRNHeaderId",
                        column: x => x.GRNHeaderId,
                        principalTable: "GoodsReceivedNoteHeaders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GoodsReceivedNoteLines_SystemCodeDetails_UnitofMeasureId",
                        column: x => x.UnitofMeasureId,
                        principalTable: "SystemCodeDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseLines_GoodsReceivedNoteHeaderId",
                table: "PurchaseLines",
                column: "GoodsReceivedNoteHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_GoodsReceivedNoteHeaders_PurchaseHeaderId",
                table: "GoodsReceivedNoteHeaders",
                column: "PurchaseHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_GoodsReceivedNoteHeaders_ReceiptLocationId",
                table: "GoodsReceivedNoteHeaders",
                column: "ReceiptLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_GoodsReceivedNoteHeaders_StatusId",
                table: "GoodsReceivedNoteHeaders",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_GoodsReceivedNoteHeaders_VendorId",
                table: "GoodsReceivedNoteHeaders",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_GoodsReceivedNoteLines_GRNHeaderId",
                table: "GoodsReceivedNoteLines",
                column: "GRNHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_GoodsReceivedNoteLines_UnitofMeasureId",
                table: "GoodsReceivedNoteLines",
                column: "UnitofMeasureId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseLines_GoodsReceivedNoteHeaders_GoodsReceivedNoteHead~",
                table: "PurchaseLines",
                column: "GoodsReceivedNoteHeaderId",
                principalTable: "GoodsReceivedNoteHeaders",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseLines_GoodsReceivedNoteHeaders_GoodsReceivedNoteHead~",
                table: "PurchaseLines");

            migrationBuilder.DropTable(
                name: "GoodsReceivedNoteLines");

            migrationBuilder.DropTable(
                name: "GoodsReceivedNoteHeaders");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseLines_GoodsReceivedNoteHeaderId",
                table: "PurchaseLines");

            migrationBuilder.DropColumn(
                name: "GoodsReceivedNoteHeaderId",
                table: "PurchaseLines");
        }
    }
}
