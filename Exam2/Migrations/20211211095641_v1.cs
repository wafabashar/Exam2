using Microsoft.EntityFrameworkCore.Migrations;

namespace Exam2.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Department_id",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Department_id",
                table: "Employee",
                column: "Department_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Department_Department_id",
                table: "Employee",
                column: "Department_id",
                principalTable: "Department",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Department_Department_id",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_Department_id",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Department_id",
                table: "Employee");
        }
    }
}
