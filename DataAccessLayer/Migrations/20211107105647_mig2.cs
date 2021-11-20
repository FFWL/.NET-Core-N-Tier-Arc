using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "categoryID",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_categoryID",
                table: "Blogs",
                column: "categoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Categories_categoryID",
                table: "Blogs",
                column: "categoryID",
                principalTable: "Categories",
                principalColumn: "categoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Categories_categoryID",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_categoryID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "categoryID",
                table: "Blogs");
        }
    }
}
