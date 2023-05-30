using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CubeGame.Migrations
{
    /// <inheritdoc />
    public partial class discoverapis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsComingSoon",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsFreeGame",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsGameOnSale",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsMostPlayed",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsMostPopular",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsNewRelease",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsRecentlyUpdated",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsTopRated",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsTopSeller",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

        //    migrationBuilder.CreateTable(
        //        name: "wishlists",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            AccountID = table.Column<string>(type: "nvarchar(450)", nullable: false),
        //            ProductID = table.Column<int>(type: "int", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_wishlists", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_wishlists_AspNetUsers_AccountID",
        //                column: x => x.AccountID,
        //                principalTable: "AspNetUsers",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_wishlists_Products_ProductID",
        //                column: x => x.ProductID,
        //                principalTable: "Products",
        //                principalColumn: "ProductId",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateIndex(
        //        name: "IX_wishlists_AccountID",
        //        table: "wishlists",
        //        column: "AccountID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_wishlists_ProductID",
        //        table: "wishlists",
        //        column: "ProductID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "wishlists");

            migrationBuilder.DropColumn(
                name: "IsComingSoon",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsFreeGame",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsGameOnSale",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsMostPlayed",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsMostPopular",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsNewRelease",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsRecentlyUpdated",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsTopRated",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsTopSeller",
                table: "Products");
        }
    }
}
