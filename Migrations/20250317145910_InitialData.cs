using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlashCardLearning.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FlashCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlashCards", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FlashCards",
                columns: new[] { "Id", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "a card", "card 1", "Text" },
                    { 2, "a card", "card 2", "Text" },
                    { 3, "a card", "card 3", "Text" },
                    { 4, "a card", "card 4", "Text" },
                    { 5, "a card", "card 5", "Text" },
                    { 6, "a card", "card 6", "Text" },
                    { 7, "a card", "card 7", "Text" },
                    { 8, "a card", "card 8", "Text" },
                    { 9, "a card", "card 9", "Text" },
                    { 10, "a card", "card 10", "Text" },
                    { 11, "a card", "card 11", "Text" },
                    { 12, "a card", "card 12", "Text" },
                    { 13, "a card", "card 13", "Text" },
                    { 14, "a card", "card 14", "Text" },
                    { 15, "a card", "card 15", "Text" },
                    { 16, "a card", "card 16", "Text" },
                    { 17, "a card", "card 17", "Text" },
                    { 18, "a card", "card 18", "Text" },
                    { 19, "a card", "card 19", "Text" },
                    { 20, "a card", "card 20", "Text" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlashCards");
        }
    }
}
