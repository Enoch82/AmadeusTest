using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiBooksAmadeus.Migrations
{
    public partial class AddingBookModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    bookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "varchar(200)", nullable: false),
                    subtitle = table.Column<string>(type: "varchar(200)", nullable: true),
                    authors = table.Column<string>(type: "varchar(200)", nullable: false),
                    publisher = table.Column<string>(type: "varchar(200)", nullable: false),
                    isbn10 = table.Column<string>(type: "varchar(200)", nullable: true),
                    isbn13 = table.Column<int>(type: "int", nullable: false),
                    pages = table.Column<int>(type: "int", nullable: false),
                    year = table.Column<int>(type: "int", nullable: false),
                    rating = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    description = table.Column<string>(type: "varchar(200)", nullable: false),
                    price = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    urlImage = table.Column<string>(type: "varchar(500)", nullable: true),
                    url = table.Column<string>(type: "varchar(500)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.bookId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");
        }
    }
}
