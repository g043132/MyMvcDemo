using Microsoft.EntityFrameworkCore.Migrations;

namespace MyStudy.MVCDemo.Migrations
{
    public partial class InitialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "Movie",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Movie",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Singer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Singer", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Singer");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Movie");
        }
    }
}
