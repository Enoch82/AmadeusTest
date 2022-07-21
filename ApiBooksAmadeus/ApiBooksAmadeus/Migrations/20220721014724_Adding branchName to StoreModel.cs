using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiBooksAmadeus.Migrations
{
    public partial class AddingbranchNametoStoreModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "branchName",
                table: "Store",
                type: "varchar(500)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "branchName",
                table: "Store");
        }
    }
}
