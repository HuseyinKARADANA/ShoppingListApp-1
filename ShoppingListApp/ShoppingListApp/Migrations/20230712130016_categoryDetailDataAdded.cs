using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShoppingListApp.Migrations
{
    /// <inheritdoc />
    public partial class categoryDetailDataAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CategoryDetails",
                columns: new[] { "Id", "CategoryId", "Name", "SubCategoryId" },
                values: new object[,]
                {
                    { 1, 1, "SmartPhone", 1 },
                    { 2, 1, "Laptop", 2 },
                    { 3, 1, "Monitor", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryDetails",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CategoryDetails",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CategoryDetails",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
