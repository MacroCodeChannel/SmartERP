using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartERP.Migrations
{
    /// <inheritdoc />
    public partial class AddedSalesheaderUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApprovedById",
                table: "SalesHeaders",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "ApprovedOn",
                table: "SalesHeaders",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "SalesHeaders",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "SalesHeaders",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedById",
                table: "SalesHeaders",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "SalesHeaders",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SalesHeaders_ApprovedById",
                table: "SalesHeaders",
                column: "ApprovedById");

            migrationBuilder.CreateIndex(
                name: "IX_SalesHeaders_CreatedById",
                table: "SalesHeaders",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_SalesHeaders_ModifiedById",
                table: "SalesHeaders",
                column: "ModifiedById");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesHeaders_AspNetUsers_ApprovedById",
                table: "SalesHeaders",
                column: "ApprovedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesHeaders_AspNetUsers_CreatedById",
                table: "SalesHeaders",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesHeaders_AspNetUsers_ModifiedById",
                table: "SalesHeaders",
                column: "ModifiedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesHeaders_AspNetUsers_ApprovedById",
                table: "SalesHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesHeaders_AspNetUsers_CreatedById",
                table: "SalesHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesHeaders_AspNetUsers_ModifiedById",
                table: "SalesHeaders");

            migrationBuilder.DropIndex(
                name: "IX_SalesHeaders_ApprovedById",
                table: "SalesHeaders");

            migrationBuilder.DropIndex(
                name: "IX_SalesHeaders_CreatedById",
                table: "SalesHeaders");

            migrationBuilder.DropIndex(
                name: "IX_SalesHeaders_ModifiedById",
                table: "SalesHeaders");

            migrationBuilder.DropColumn(
                name: "ApprovedById",
                table: "SalesHeaders");

            migrationBuilder.DropColumn(
                name: "ApprovedOn",
                table: "SalesHeaders");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "SalesHeaders");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "SalesHeaders");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "SalesHeaders");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "SalesHeaders");
        }
    }
}
