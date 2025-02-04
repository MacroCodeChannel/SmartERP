using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartERP.Migrations
{
    /// <inheritdoc />
    public partial class ReceivedNotesUserActivity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "GoodsReceivedNoteHeaders",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "GoodsReceivedNoteHeaders",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedById",
                table: "GoodsReceivedNoteHeaders",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "GoodsReceivedNoteHeaders",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GoodsReceivedNoteHeaders_CreatedById",
                table: "GoodsReceivedNoteHeaders",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_GoodsReceivedNoteHeaders_ModifiedById",
                table: "GoodsReceivedNoteHeaders",
                column: "ModifiedById");

            migrationBuilder.AddForeignKey(
                name: "FK_GoodsReceivedNoteHeaders_AspNetUsers_CreatedById",
                table: "GoodsReceivedNoteHeaders",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GoodsReceivedNoteHeaders_AspNetUsers_ModifiedById",
                table: "GoodsReceivedNoteHeaders",
                column: "ModifiedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GoodsReceivedNoteHeaders_AspNetUsers_CreatedById",
                table: "GoodsReceivedNoteHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_GoodsReceivedNoteHeaders_AspNetUsers_ModifiedById",
                table: "GoodsReceivedNoteHeaders");

            migrationBuilder.DropIndex(
                name: "IX_GoodsReceivedNoteHeaders_CreatedById",
                table: "GoodsReceivedNoteHeaders");

            migrationBuilder.DropIndex(
                name: "IX_GoodsReceivedNoteHeaders_ModifiedById",
                table: "GoodsReceivedNoteHeaders");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "GoodsReceivedNoteHeaders");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "GoodsReceivedNoteHeaders");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "GoodsReceivedNoteHeaders");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "GoodsReceivedNoteHeaders");
        }
    }
}
