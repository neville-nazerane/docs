using Microsoft.EntityFrameworkCore.Migrations;

namespace Docs.Migrations.Migrations
{
    public partial class UniqueTag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PackageTags_TagId",
                table: "PackageTags");

            migrationBuilder.CreateIndex(
                name: "IX_PackageTags_TagId_PackageId",
                table: "PackageTags",
                columns: new[] { "TagId", "PackageId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PackageTags_TagId_PackageId",
                table: "PackageTags");

            migrationBuilder.CreateIndex(
                name: "IX_PackageTags_TagId",
                table: "PackageTags",
                column: "TagId");
        }
    }
}
