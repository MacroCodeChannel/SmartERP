using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartERP.Migrations
{
    /// <inheritdoc />
    public partial class CreatedONActivity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "SystemSettings");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "WorkFlowUserGroups",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "WorkFlowUserGroupMembers",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "TimeSheets",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "SystemSettings",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "SystemCodes",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "SystemCodeDetails",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Skills",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "PurchaseHeaders",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "ProjectUpdates",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Projects",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "ProjectMembers",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "ProjectLocations",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Payments",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "OrderRequests",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Offices",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "NumberSeriesSetups",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Location",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "LeaveApplications",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "FixedAssets",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Experiences",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Evaluations",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Employees",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Designations",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Contracts",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Consultants",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Clients",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Banks",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "AuditTrails",
                type: "datetime(6)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "WorkFlowUserGroups");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "WorkFlowUserGroupMembers");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Vendors");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "TimeSheets");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "SystemSettings");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "SystemCodes");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "SystemCodeDetails");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "PurchaseHeaders");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "ProjectUpdates");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "ProjectMembers");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "ProjectLocations");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "OrderRequests");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Offices");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "NumberSeriesSetups");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "LeaveApplications");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "FixedAssets");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Experiences");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Evaluations");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Designations");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Consultants");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Banks");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "AuditTrails");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "SystemSettings",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
