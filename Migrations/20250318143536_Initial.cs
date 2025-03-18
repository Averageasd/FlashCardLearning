using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlashCardLearning.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
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
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Basic")
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
                    { 1, "a card", "card 1", "Basic" },
                    { 2, "a card", "card 2", "Basic" },
                    { 3, "a card", "card 3", "Basic" },
                    { 4, "a card", "card 4", "Basic" },
                    { 5, "a card", "card 5", "Basic" },
                    { 6, "a card", "card 6", "Basic" },
                    { 7, "a card", "card 7", "Basic" },
                    { 8, "a card", "card 8", "Basic" },
                    { 9, "a card", "card 9", "Basic" },
                    { 10, "a card", "card 10", "Basic" },
                    { 11, "a card", "card 11", "Basic" },
                    { 12, "a card", "card 12", "Basic" },
                    { 13, "a card", "card 13", "Basic" },
                    { 14, "a card", "card 14", "Basic" },
                    { 15, "a card", "card 15", "Basic" },
                    { 16, "a card", "card 16", "Basic" },
                    { 17, "a card", "card 17", "Basic" },
                    { 18, "a card", "card 18", "Basic" },
                    { 19, "a card", "card 19", "Basic" },
                    { 20, "a card", "card 20", "Basic" }
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
