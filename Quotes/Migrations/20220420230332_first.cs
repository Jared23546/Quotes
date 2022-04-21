using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Quotes.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "quotes",
                columns: table => new
                {
                    QuoteId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TheQuote = table.Column<string>(nullable: false),
                    Author = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    Citation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quotes", x => x.QuoteId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "quotes");
        }
    }
}
