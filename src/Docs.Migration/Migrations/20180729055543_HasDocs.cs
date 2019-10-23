using Microsoft.EntityFrameworkCore.Migrations;

namespace Docs.Migrations.Migrations
{
    public partial class HasDocs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasDocumentation",
                table: "Packages",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasDocumentation",
                table: "Packages");
        }
    }
}
