using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagement.Migrations
{
    public partial class initialdatabasecreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CopiesAvailable = table.Column<int>(nullable: false),
                    Author = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Horror" },
                    { 2, "Action and Adventure" },
                    { 3, "Classics" },
                    { 4, "Comic Book" },
                    { 5, "Detective and Mystery" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "CategoryId", "CopiesAvailable", "Name" },
                values: new object[,]
                {
                    { 1, "Shirley Jackson", 1, 10, "The Haunting Of Hill House" },
                    { 2, "Anne Rivers Siddons", 1, 7, "The House Next Door" },
                    { 3, "Shirley Jackson", 1, 10, "Lunar Park" },
                    { 4, "Miguel de Cervantes", 1, 9, "Don Quixote" },
                    { 5, "Walter Scott", 2, 12, "Ivanhoe " },
                    { 6, "Harry", 2, 18, "King Solomon's Mines" },
                    { 7, "Jules Verne", 2, 14, "Journey to the Center of the Earth" },
                    { 8, "Gillian Flynn", 2, 23, "Gone Girl" },
                    { 9, "Robert Traver", 2, 23, "Anatomy of a Murder" },
                    { 10, "Truman Capote", 3, 3, "In Cold Blood" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
