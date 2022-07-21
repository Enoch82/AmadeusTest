using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiBooksAmadeus.Migrations
{
    public partial class ChangingDescriptionsize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "Book",
                type: "varchar(2000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(200)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "Book",
                type: "varchar(200)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(2000)");
        }
    }
}
