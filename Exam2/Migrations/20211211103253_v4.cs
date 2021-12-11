using Microsoft.EntityFrameworkCore.Migrations;

namespace Exam2.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Country_Country_id",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Country",
                table: "Country");

            migrationBuilder.RenameTable(
                name: "Country",
                newName: "country");

            migrationBuilder.AddPrimaryKey(
                name: "PK_country",
                table: "country",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_country_Country_id",
                table: "Employee",
                column: "Country_id",
                principalTable: "country",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_country_Country_id",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_country",
                table: "country");

            migrationBuilder.RenameTable(
                name: "country",
                newName: "Country");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Country",
                table: "Country",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Country_Country_id",
                table: "Employee",
                column: "Country_id",
                principalTable: "Country",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
