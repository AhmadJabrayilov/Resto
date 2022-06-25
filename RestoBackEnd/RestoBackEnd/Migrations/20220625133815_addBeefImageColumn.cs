using Microsoft.EntityFrameworkCore.Migrations;

namespace RestoBackEnd.Migrations
{
    public partial class addBeefImageColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MealImageUrl",
                table: "BeefMeal",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MealImageUrl",
                table: "BeefMeal");
        }
    }
}
