using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartERP.Migrations
{
    /// <inheritdoc />
    public partial class SequenceDetailsUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SequenceNo",
                table: "WorkFlowUserGroups");

            migrationBuilder.AddColumn<int>(
                name: "SequenceNo",
                table: "WorkFlowUserGroupMembers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SequenceNo",
                table: "WorkFlowUserGroupMembers");

            migrationBuilder.AddColumn<int>(
                name: "SequenceNo",
                table: "WorkFlowUserGroups",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
