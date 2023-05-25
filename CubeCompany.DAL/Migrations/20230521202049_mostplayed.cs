using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CubeGame.Migrations
{
    /// <inheritdoc />
    public partial class mostplayed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mostplayeds",
                columns: table => new
                {
                    MostplayedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mostplayeds", x => x.MostplayedId);
                    table.ForeignKey(
                        name: "FK_Mostplayeds_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            //migrationBuilder.CreateTable(
            //    name: "wishlists",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        AccountID = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        ProductID = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_wishlists", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_wishlists_AspNetUsers_AccountID",
            //            column: x => x.AccountID,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_wishlists_Products_ProductID",
            //            column: x => x.ProductID,
            //            principalTable: "Products",
            //            principalColumn: "ProductId",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            migrationBuilder.CreateIndex(
                name: "IX_Mostplayeds_CategoryId",
                table: "Mostplayeds",
                column: "CategoryId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_wishlists_AccountID",
            //    table: "wishlists",
            //    column: "AccountID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_wishlists_ProductID",
            //    table: "wishlists",
            //    column: "ProductID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mostplayeds");

            //migrationBuilder.DropTable(
            //    name: "wishlists");
        }
    }
}
