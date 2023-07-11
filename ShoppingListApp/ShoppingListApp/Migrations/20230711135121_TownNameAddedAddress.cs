using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingListApp.Migrations
{
    /// <inheritdoc />
    public partial class TownNameAddedAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TownName",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TownName",
                table: "Addresses");
        }
    }
}
