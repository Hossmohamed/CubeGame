using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CubeGame.Migrations
{
    /// <inheritdoc />
    public partial class MostPlayedImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MostplayedId",
                table: "Images",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Images_MostplayedId",
                table: "Images",
                column: "MostplayedId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Mostplayeds_MostplayedId",
                table: "Images",
                column: "MostplayedId",
                principalTable: "Mostplayeds",
                principalColumn: "MostplayedId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Mostplayeds_MostplayedId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_MostplayedId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "MostplayedId",
                table: "Images");
        }
    }
}
