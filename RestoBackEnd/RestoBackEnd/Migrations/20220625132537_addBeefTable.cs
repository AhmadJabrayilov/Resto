using Microsoft.EntityFrameworkCore.Migrations;

namespace RestoBackEnd.Migrations
{
    public partial class addBeefTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BeefMeal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryMealName = table.Column<string>(nullable: true),
                    MealName = table.Column<string>(nullable: true),
                    MealDesc = table.Column<string>(nullable: true),
                    MealPrice = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeefMeal", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BeefMeal");
        }
    }
}
