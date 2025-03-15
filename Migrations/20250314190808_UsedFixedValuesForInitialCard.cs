using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlashCardLearning.Migrations
{
    /// <inheritdoc />
    public partial class UsedFixedValuesForInitialCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("2bf7da17-ef05-4357-8999-75329f695acb"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("adda961e-ff99-4d86-920f-43ee64c8d657"));

            migrationBuilder.InsertData(
                table: "FlashCard",
                columns: new[] { "Id", "Description", "Name", "type" },
                values: new object[,]
                {
                    { new Guid("a8e5d29a-6d67-4c76-8cc7-c444f3e6f5b8"), "a card", "card 1", "Text" },
                    { new Guid("e363572b-b54b-433d-a001-2e1252c81852"), "a card", "card 2", "Text" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a8e5d29a-6d67-4c76-8cc7-c444f3e6f5b8"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e363572b-b54b-433d-a001-2e1252c81852"));

            migrationBuilder.InsertData(
                table: "FlashCard",
                columns: new[] { "Id", "Description", "Name", "type" },
                values: new object[,]
                {
                    { new Guid("2bf7da17-ef05-4357-8999-75329f695acb"), "a card", "card 2", "Text" },
                    { new Guid("adda961e-ff99-4d86-920f-43ee64c8d657"), "a card", "card 1", "Text" }
                });
        }
    }
}
