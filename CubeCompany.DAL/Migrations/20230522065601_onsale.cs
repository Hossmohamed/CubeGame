using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CubeGame.Migrations
{
    /// <inheritdoc />
    public partial class onsale : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OnsaleId",
                table: "Images",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Onsales",
                columns: table => new
                {
                    OnsaleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Onsales", x => x.OnsaleId);
                    table.ForeignKey(
                        name: "FK_Onsales_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_OnsaleId",
                table: "Images",
                column: "OnsaleId");

            migrationBuilder.CreateIndex(
                name: "IX_Onsales_CategoryId",
                table: "Onsales",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Onsales_OnsaleId",
                table: "Images",
                column: "OnsaleId",
                principalTable: "Onsales",
                principalColumn: "OnsaleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Onsales_OnsaleId",
                table: "Images");

            migrationBuilder.DropTable(
                name: "Onsales");

            migrationBuilder.DropIndex(
                name: "IX_Images_OnsaleId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "OnsaleId",
                table: "Images");
        }
    }
}
