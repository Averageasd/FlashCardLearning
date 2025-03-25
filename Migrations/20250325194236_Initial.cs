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
                    Answer = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Basic")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlashCards", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FlashCards",
                columns: new[] { "Id", "Answer", "CreatedDate", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 1", "Basic" },
                    { 2, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 2", "Basic" },
                    { 3, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 3", "Basic" },
                    { 4, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 4", "Basic" },
                    { 5, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 5", "Basic" },
                    { 6, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 6", "Basic" },
                    { 7, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 7", "Basic" },
                    { 8, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 8", "Basic" },
                    { 9, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 9", "Basic" },
                    { 10, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 10", "Basic" },
                    { 11, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 11", "Basic" },
                    { 12, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 12", "Basic" },
                    { 13, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 13", "Basic" },
                    { 14, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 14", "Basic" },
                    { 15, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 15", "Basic" },
                    { 16, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 16", "Basic" },
                    { 17, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 17", "Basic" },
                    { 18, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 18", "Basic" },
                    { 19, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 19", "Basic" },
                    { 20, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 20", "Basic" }
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
