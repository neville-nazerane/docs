using Microsoft.EntityFrameworkCore.Migrations;

namespace Docs.Migrations.Migrations
{
    public partial class Displayable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDisplayed",
                table: "Packages",
                nullable: false,
                defaultValue: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDisplayed",
                table: "Packages");
        }
    }
}
