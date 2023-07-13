using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingListApp.Migrations
{
    /// <inheritdoc />
    public partial class subCategoriesNameUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SubCategorys",
                table: "SubCategorys");

            migrationBuilder.RenameTable(
                name: "SubCategorys",
                newName: "SubCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubCategories",
                table: "SubCategories",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SubCategories",
                table: "SubCategories");

            migrationBuilder.RenameTable(
                name: "SubCategories",
                newName: "SubCategorys");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubCategorys",
                table: "SubCategorys",
                column: "Id");
        }
    }
}
