using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartERP.Migrations
{
    /// <inheritdoc />
    public partial class Workflowusergroupsdetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserGroupMemberId",
                table: "ApprovalEntries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ApprovalEntries_UserGroupMemberId",
                table: "ApprovalEntries",
                column: "UserGroupMemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApprovalEntries_WorkFlowUserGroupMembers_UserGroupMemberId",
                table: "ApprovalEntries",
                column: "UserGroupMemberId",
                principalTable: "WorkFlowUserGroupMembers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApprovalEntries_WorkFlowUserGroupMembers_UserGroupMemberId",
                table: "ApprovalEntries");

            migrationBuilder.DropIndex(
                name: "IX_ApprovalEntries_UserGroupMemberId",
                table: "ApprovalEntries");

            migrationBuilder.DropColumn(
                name: "UserGroupMemberId",
                table: "ApprovalEntries");
        }
    }
}
