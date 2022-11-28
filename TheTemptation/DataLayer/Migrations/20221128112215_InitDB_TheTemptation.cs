using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class InitDBTheTemptation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Draws",
                columns: table => new
                {
                    IdDraw = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameWin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Jackpot = table.Column<int>(type: "int", nullable: false),
                    DateHourDraw = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Draws", x => x.IdDraw);
                });

            migrationBuilder.CreateTable(
                name: "GameUsers",
                columns: table => new
                {
                    CodeShortGui = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GamePlaying = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdDraw = table.Column<int>(type: "int", nullable: false),
                    DrawIdDraw = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameUsers", x => x.CodeShortGui);
                    table.ForeignKey(
                        name: "FK_GameUsers_Draws_DrawIdDraw",
                        column: x => x.DrawIdDraw,
                        principalTable: "Draws",
                        principalColumn: "IdDraw",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameUsers_DrawIdDraw",
                table: "GameUsers",
                column: "DrawIdDraw");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameUsers");

            migrationBuilder.DropTable(
                name: "Draws");
        }
    }
}
