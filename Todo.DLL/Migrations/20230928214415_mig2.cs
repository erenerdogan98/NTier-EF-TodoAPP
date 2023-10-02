using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Todo.DLL.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Users",
                newName: "UserID");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Todos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Todos_UserID",
                table: "Todos",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Users_UserID",
                table: "Todos",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Users_UserID",
                table: "Todos");

            migrationBuilder.DropIndex(
                name: "IX_Todos_UserID",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Todos");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Users",
                newName: "ID");
        }
    }
}
