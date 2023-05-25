using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CubeGame.Migrations
{
    /// <inheritdoc />
    public partial class MostPopularImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MostpopularId",
                table: "Images",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Images_MostpopularId",
                table: "Images",
                column: "MostpopularId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Mostpopulars_MostpopularId",
                table: "Images",
                column: "MostpopularId",
                principalTable: "Mostpopulars",
                principalColumn: "MostpopularId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Mostpopulars_MostpopularId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_MostpopularId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "MostpopularId",
                table: "Images");
        }
    }
}
