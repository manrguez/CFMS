using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CFMS.Data.Migrations
{
    public partial class Responses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Feedback",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Response",
                columns: table => new
                {
                    ResponseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FeedbackId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Response", x => x.ResponseId);
                    table.ForeignKey(
                        name: "FK_Response_Feedback_FeedbackId",
                        column: x => x.FeedbackId,
                        principalTable: "Feedback",
                        principalColumn: "FeedbackId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Response_FeedbackId",
                table: "Response",
                column: "FeedbackId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Response");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Feedback",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);
        }
    }
}
