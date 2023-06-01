using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CubeGame.Migrations
{
    /// <inheritdoc />
    public partial class ImagesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ComingsoonId",
                table: "Images",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FreegameId",
                table: "Images",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NewreleaseId",
                table: "Images",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecentlyupdatedId",
                table: "Images",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TopratedId",
                table: "Images",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TopsellerId",
                table: "Images",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Images_ComingsoonId",
                table: "Images",
                column: "ComingsoonId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_FreegameId",
                table: "Images",
                column: "FreegameId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_NewreleaseId",
                table: "Images",
                column: "NewreleaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_RecentlyupdatedId",
                table: "Images",
                column: "RecentlyupdatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_TopratedId",
                table: "Images",
                column: "TopratedId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_TopsellerId",
                table: "Images",
                column: "TopsellerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Comingsoons_ComingsoonId",
                table: "Images",
                column: "ComingsoonId",
                principalTable: "Comingsoons",
                principalColumn: "ComingsoonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Freegames_FreegameId",
                table: "Images",
                column: "FreegameId",
                principalTable: "Freegames",
                principalColumn: "FreegameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Newreleases_NewreleaseId",
                table: "Images",
                column: "NewreleaseId",
                principalTable: "Newreleases",
                principalColumn: "NewreleaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Recentlyupdateds_RecentlyupdatedId",
                table: "Images",
                column: "RecentlyupdatedId",
                principalTable: "Recentlyupdateds",
                principalColumn: "RecentlyupdatedId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Toprateds_TopratedId",
                table: "Images",
                column: "TopratedId",
                principalTable: "Toprateds",
                principalColumn: "TopratedId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Topsellers_TopsellerId",
                table: "Images",
                column: "TopsellerId",
                principalTable: "Topsellers",
                principalColumn: "TopsellerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Comingsoons_ComingsoonId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Freegames_FreegameId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Newreleases_NewreleaseId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Recentlyupdateds_RecentlyupdatedId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Toprateds_TopratedId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Topsellers_TopsellerId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_ComingsoonId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_FreegameId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_NewreleaseId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_RecentlyupdatedId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_TopratedId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_TopsellerId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "ComingsoonId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "FreegameId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "NewreleaseId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "RecentlyupdatedId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "TopratedId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "TopsellerId",
                table: "Images");
        }
    }
}
