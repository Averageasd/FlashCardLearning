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
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

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
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Basic"),
                    UserModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlashCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FlashCards_Users_UserModelId",
                        column: x => x.UserModelId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "UserName" },
                values: new object[,]
                {
                    { new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d"), "password", "user2" },
                    { new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0"), "password", "user1" }
                });

            migrationBuilder.InsertData(
                table: "FlashCards",
                columns: new[] { "Id", "Answer", "CreatedDate", "Description", "Name", "Type", "UserModelId" },
                values: new object[,]
                {
                    { 1, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 1", "Basic", new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0") },
                    { 2, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 2", "Basic", new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0") },
                    { 3, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 3", "Basic", new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0") },
                    { 4, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 4", "Basic", new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0") },
                    { 5, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 5", "Basic", new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0") },
                    { 6, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 6", "Basic", new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0") },
                    { 7, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 7", "Basic", new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0") },
                    { 8, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 8", "Basic", new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0") },
                    { 9, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 9", "Basic", new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0") },
                    { 10, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 10", "Basic", new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0") },
                    { 11, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 11", "Basic", new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0") },
                    { 12, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 12", "Basic", new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0") },
                    { 13, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 13", "Basic", new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0") },
                    { 14, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 14", "Basic", new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0") },
                    { 15, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 15", "Basic", new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0") },
                    { 16, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 16", "Basic", new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0") },
                    { 17, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 17", "Basic", new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0") },
                    { 18, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 18", "Basic", new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0") },
                    { 19, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 19", "Basic", new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0") },
                    { 20, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 20", "Basic", new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0") },
                    { 21, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 21", "Basic", new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d") },
                    { 22, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 22", "Basic", new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d") },
                    { 23, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 23", "Basic", new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d") },
                    { 24, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 24", "Basic", new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d") },
                    { 25, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 25", "Basic", new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d") },
                    { 26, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 26", "Basic", new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d") },
                    { 27, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 27", "Basic", new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d") },
                    { 28, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 28", "Basic", new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d") },
                    { 29, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 29", "Basic", new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d") },
                    { 30, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 30", "Basic", new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d") },
                    { 31, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 31", "Basic", new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d") },
                    { 32, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 32", "Basic", new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d") },
                    { 33, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 33", "Basic", new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d") },
                    { 34, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 34", "Basic", new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d") },
                    { 35, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 35", "Basic", new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d") },
                    { 36, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 36", "Basic", new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d") },
                    { 37, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 37", "Basic", new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d") },
                    { 38, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 38", "Basic", new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d") },
                    { 39, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 39", "Basic", new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d") },
                    { 40, "answer", new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified), "a card", "card 40", "Basic", new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlashCards_UserModelId",
                table: "FlashCards",
                column: "UserModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlashCards");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
