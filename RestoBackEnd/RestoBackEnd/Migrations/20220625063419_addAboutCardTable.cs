using Microsoft.EntityFrameworkCore.Migrations;

namespace RestoBackEnd.Migrations
{
    public partial class addAboutCardTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutCard",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutCardImageUrl = table.Column<string>(nullable: true),
                    AboutCardtitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutCard", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutCard");
        }
    }
}
