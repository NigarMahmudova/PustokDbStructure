using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PustokProject.Migrations
{
    public partial class AddedRelationsBetweenSliderAndButton : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ButtonId",
                table: "HomeSlider",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_HomeSlider_ButtonId",
                table: "HomeSlider",
                column: "ButtonId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeSlider_Buttons_ButtonId",
                table: "HomeSlider",
                column: "ButtonId",
                principalTable: "Buttons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HomeSlider_Buttons_ButtonId",
                table: "HomeSlider");

            migrationBuilder.DropIndex(
                name: "IX_HomeSlider_ButtonId",
                table: "HomeSlider");

            migrationBuilder.DropColumn(
                name: "ButtonId",
                table: "HomeSlider");
        }
    }
}
