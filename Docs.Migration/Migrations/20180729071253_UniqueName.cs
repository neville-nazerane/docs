using Microsoft.EntityFrameworkCore.Migrations;

namespace Docs.Migrations.Migrations
{
    public partial class UniqueName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Packages_Name",
                table: "Packages",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Packages_Name",
                table: "Packages");
        }
    }
}
