using Microsoft.EntityFrameworkCore.Migrations;

namespace EscaleraMillonaria_API.Migrations
{
    public partial class AddEscaleraMillonariaDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    IdCategory = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.IdCategory);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    IdPlayer = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamePlayer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayerAwards = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlayerCategory = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.IdPlayer);
                });

            migrationBuilder.CreateTable(
                name: "Awards",
                columns: table => new
                {
                    IdAward = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AwardValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryIdCategory = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Awards", x => x.IdAward);
                    table.ForeignKey(
                        name: "FK_Awards_Categories_CategoryIdCategory",
                        column: x => x.CategoryIdCategory,
                        principalTable: "Categories",
                        principalColumn: "IdCategory",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    IdQuestion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionStatement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OptionOne = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OptionTwo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OptionThree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OptionFour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryIdCategory = table.Column<int>(type: "int", nullable: true),
                    PlayerIdPlayer = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.IdQuestion);
                    table.ForeignKey(
                        name: "FK_Questions_Categories_CategoryIdCategory",
                        column: x => x.CategoryIdCategory,
                        principalTable: "Categories",
                        principalColumn: "IdCategory",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Questions_Players_PlayerIdPlayer",
                        column: x => x.PlayerIdPlayer,
                        principalTable: "Players",
                        principalColumn: "IdPlayer",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Awards_CategoryIdCategory",
                table: "Awards",
                column: "CategoryIdCategory");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_CategoryIdCategory",
                table: "Questions",
                column: "CategoryIdCategory");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_PlayerIdPlayer",
                table: "Questions",
                column: "PlayerIdPlayer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Awards");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
