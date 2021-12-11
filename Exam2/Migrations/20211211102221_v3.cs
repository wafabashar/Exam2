using Microsoft.EntityFrameworkCore.Migrations;

namespace Exam2.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BD",
                table: "Employee",
                newName: "Birth Date");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Birth Date",
                table: "Employee",
                newName: "BD");
        }
    }
}
