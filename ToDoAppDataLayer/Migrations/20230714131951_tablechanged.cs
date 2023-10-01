using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoAppDataLayer.Migrations
{
    /// <inheritdoc />
    public partial class tablechanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ToDoTable",
                table: "ToDoTable");

            migrationBuilder.RenameTable(
                name: "ToDoTable",
                newName: "todo");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "todo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "todo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_todo",
                table: "todo",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_todo",
                table: "todo");

            migrationBuilder.RenameTable(
                name: "todo",
                newName: "ToDoTable");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "ToDoTable",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ToDoTable",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToDoTable",
                table: "ToDoTable",
                column: "Id");
        }
    }
}
