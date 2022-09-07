using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagement.Migrations
{
    public partial class addedstudenttableindatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Std = table.Column<int>(nullable: false),
                    Div = table.Column<string>(nullable: false),
                    Rollno = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => new { x.Std, x.Div, x.Rollno });
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Std", "Div", "Rollno", "Address", "Name" },
                values: new object[] { 8, "A", 47, "CA", "John" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Std", "Div", "Rollno", "Address", "Name" },
                values: new object[] { 7, "B", 12, "FL", "Amber Heard" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Std", "Div", "Rollno", "Address", "Name" },
                values: new object[] { 4, "C", 1, "NY", "Camile" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
