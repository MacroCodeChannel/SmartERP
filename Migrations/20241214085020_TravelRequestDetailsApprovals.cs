using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartERP.Migrations
{
    /// <inheritdoc />
    public partial class TravelRequestDetailsApprovals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArrivalInstructions",
                table: "TravelRequestHeaders");

            migrationBuilder.RenameColumn(
                name: "DestinationInstructions",
                table: "TravelRequestHeaders",
                newName: "SpecialInstructions");

            migrationBuilder.AddColumn<string>(
                name: "ApprovedById",
                table: "TravelRequestHeaders",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "ApprovedOn",
                table: "TravelRequestHeaders",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "TravelRequestHeaders",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "TravelRequestHeaders",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedById",
                table: "TravelRequestHeaders",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "TravelRequestHeaders",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TravelRequestHeaders_ApprovedById",
                table: "TravelRequestHeaders",
                column: "ApprovedById");

            migrationBuilder.CreateIndex(
                name: "IX_TravelRequestHeaders_CreatedById",
                table: "TravelRequestHeaders",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TravelRequestHeaders_ModifiedById",
                table: "TravelRequestHeaders",
                column: "ModifiedById");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelRequestHeaders_AspNetUsers_ApprovedById",
                table: "TravelRequestHeaders",
                column: "ApprovedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelRequestHeaders_AspNetUsers_CreatedById",
                table: "TravelRequestHeaders",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TravelRequestHeaders_AspNetUsers_ModifiedById",
                table: "TravelRequestHeaders",
                column: "ModifiedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TravelRequestHeaders_AspNetUsers_ApprovedById",
                table: "TravelRequestHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelRequestHeaders_AspNetUsers_CreatedById",
                table: "TravelRequestHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelRequestHeaders_AspNetUsers_ModifiedById",
                table: "TravelRequestHeaders");

            migrationBuilder.DropIndex(
                name: "IX_TravelRequestHeaders_ApprovedById",
                table: "TravelRequestHeaders");

            migrationBuilder.DropIndex(
                name: "IX_TravelRequestHeaders_CreatedById",
                table: "TravelRequestHeaders");

            migrationBuilder.DropIndex(
                name: "IX_TravelRequestHeaders_ModifiedById",
                table: "TravelRequestHeaders");

            migrationBuilder.DropColumn(
                name: "ApprovedById",
                table: "TravelRequestHeaders");

            migrationBuilder.DropColumn(
                name: "ApprovedOn",
                table: "TravelRequestHeaders");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "TravelRequestHeaders");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "TravelRequestHeaders");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "TravelRequestHeaders");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "TravelRequestHeaders");

            migrationBuilder.RenameColumn(
                name: "SpecialInstructions",
                table: "TravelRequestHeaders",
                newName: "DestinationInstructions");

            migrationBuilder.AddColumn<string>(
                name: "ArrivalInstructions",
                table: "TravelRequestHeaders",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
