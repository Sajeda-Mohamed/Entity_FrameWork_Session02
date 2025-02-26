using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_FrameWork_Session02.Migrations
{
    /// <inheritdoc />
    public partial class Edite04 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Studentss");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Studentss",
                table: "Studentss",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Studentss",
                table: "Studentss");

            migrationBuilder.RenameTable(
                name: "Studentss",
                newName: "Students");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");
        }
    }
}
