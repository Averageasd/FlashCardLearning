using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlashCardLearning.Migrations
{
    /// <inheritdoc />
    public partial class UpdateInitialDataValue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "FlashCards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Basic",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "FlashCards",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "FlashCards",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 1,
                column: "Type",
                value: "Basic");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 2,
                column: "Type",
                value: "Basic");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 3,
                column: "Type",
                value: "Basic");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 4,
                column: "Type",
                value: "Basic");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 5,
                column: "Type",
                value: "Basic");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 6,
                column: "Type",
                value: "Basic");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 7,
                column: "Type",
                value: "Basic");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 8,
                column: "Type",
                value: "Basic");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 9,
                column: "Type",
                value: "Basic");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 10,
                column: "Type",
                value: "Basic");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 11,
                column: "Type",
                value: "Basic");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 12,
                column: "Type",
                value: "Basic");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 13,
                column: "Type",
                value: "Basic");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 14,
                column: "Type",
                value: "Basic");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 15,
                column: "Type",
                value: "Basic");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 16,
                column: "Type",
                value: "Basic");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 17,
                column: "Type",
                value: "Basic");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 18,
                column: "Type",
                value: "Basic");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 19,
                column: "Type",
                value: "Basic");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 20,
                column: "Type",
                value: "Basic");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "FlashCards",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Basic");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "FlashCards",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "FlashCards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 1,
                column: "Type",
                value: "Text");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 2,
                column: "Type",
                value: "Text");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 3,
                column: "Type",
                value: "Text");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 4,
                column: "Type",
                value: "Text");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 5,
                column: "Type",
                value: "Text");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 6,
                column: "Type",
                value: "Text");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 7,
                column: "Type",
                value: "Text");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 8,
                column: "Type",
                value: "Text");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 9,
                column: "Type",
                value: "Text");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 10,
                column: "Type",
                value: "Text");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 11,
                column: "Type",
                value: "Text");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 12,
                column: "Type",
                value: "Text");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 13,
                column: "Type",
                value: "Text");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 14,
                column: "Type",
                value: "Text");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 15,
                column: "Type",
                value: "Text");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 16,
                column: "Type",
                value: "Text");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 17,
                column: "Type",
                value: "Text");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 18,
                column: "Type",
                value: "Text");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 19,
                column: "Type",
                value: "Text");

            migrationBuilder.UpdateData(
                table: "FlashCards",
                keyColumn: "Id",
                keyValue: 20,
                column: "Type",
                value: "Text");
        }
    }
}
