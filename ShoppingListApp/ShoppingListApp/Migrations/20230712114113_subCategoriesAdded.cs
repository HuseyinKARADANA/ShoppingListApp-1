using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingListApp.Migrations
{
    /// <inheritdoc />
    public partial class subCategoriesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryDetail_Categories_CategoryId",
                table: "CategoryDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryDetail",
                table: "CategoryDetail");

            migrationBuilder.RenameTable(
                name: "CategoryDetail",
                newName: "CategoryDetails");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryDetail_CategoryId",
                table: "CategoryDetails",
                newName: "IX_CategoryDetails_CategoryId");

            migrationBuilder.AddColumn<int>(
                name: "SubCategoryId",
                table: "CategoryDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryDetails",
                table: "CategoryDetails",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ItemDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CategoryDetailId = table.Column<int>(type: "int", nullable: false),
                    FeatureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SmartPhones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FrontCameraResolution = table.Column<int>(type: "int", nullable: false),
                    RearCameraResolution = table.Column<int>(type: "int", nullable: false),
                    Memory = table.Column<int>(type: "int", nullable: false),
                    BatteryPower = table.Column<int>(type: "int", nullable: false),
                    RAMCapacity = table.Column<int>(type: "int", nullable: false),
                    ScreenSize = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmartPhones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategorys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategorys", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryDetails_Categories_CategoryId",
                table: "CategoryDetails",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryDetails_Categories_CategoryId",
                table: "CategoryDetails");

            migrationBuilder.DropTable(
                name: "ItemDetails");

            migrationBuilder.DropTable(
                name: "SmartPhones");

            migrationBuilder.DropTable(
                name: "SubCategorys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryDetails",
                table: "CategoryDetails");

            migrationBuilder.DropColumn(
                name: "SubCategoryId",
                table: "CategoryDetails");

            migrationBuilder.RenameTable(
                name: "CategoryDetails",
                newName: "CategoryDetail");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryDetails_CategoryId",
                table: "CategoryDetail",
                newName: "IX_CategoryDetail_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryDetail",
                table: "CategoryDetail",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryDetail_Categories_CategoryId",
                table: "CategoryDetail",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
