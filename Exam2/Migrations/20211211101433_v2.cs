using Microsoft.EntityFrameworkCore.Migrations;

namespace Exam2.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Country_id",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Country_id",
                table: "Employee",
                column: "Country_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Country_Country_id",
                table: "Employee",
                column: "Country_id",
                principalTable: "Country",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Country_Country_id",
                table: "Employee");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropIndex(
                name: "IX_Employee_Country_id",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Country_id",
                table: "Employee");
        }
    }
}
