using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiBooksAmadeus.Migrations
{
    public partial class AddingStoreModelandRelationShipwithBookModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "storeId",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Store",
                columns: table => new
                {
                    storeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adress = table.Column<string>(type: "varchar(500)", nullable: true),
                    phone = table.Column<string>(type: "varchar(500)", nullable: true),
                    openTime = table.Column<string>(type: "varchar(500)", nullable: true),
                    parking = table.Column<bool>(type: "bit", nullable: false),
                    delivery = table.Column<bool>(type: "bit", nullable: false),
                    phoneDelivery = table.Column<string>(type: "varchar(500)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.storeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_storeId",
                table: "Book",
                column: "storeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Store_storeId",
                table: "Book",
                column: "storeId",
                principalTable: "Store",
                principalColumn: "storeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Store_storeId",
                table: "Book");

            migrationBuilder.DropTable(
                name: "Store");

            migrationBuilder.DropIndex(
                name: "IX_Book_storeId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "storeId",
                table: "Book");
        }
    }
}
