using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PustokProject.Migrations
{
    public partial class CreateHomeSliderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HomeSlider_Button_ButtonId",
                table: "HomeSlider");

            migrationBuilder.DropTable(
                name: "Button");

            migrationBuilder.DropIndex(
                name: "IX_HomeSlider_ButtonId",
                table: "HomeSlider");

            migrationBuilder.DropColumn(
                name: "ButtonId",
                table: "HomeSlider");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ButtonId",
                table: "HomeSlider",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Button",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Button", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HomeSlider_ButtonId",
                table: "HomeSlider",
                column: "ButtonId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeSlider_Button_ButtonId",
                table: "HomeSlider",
                column: "ButtonId",
                principalTable: "Button",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
