using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_FrameWork_Session02.Migrations
{
    /// <inheritdoc />
    public partial class One2ManyRelationShip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "department_IdId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_department_IdId",
                table: "Students",
                column: "department_IdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_department_IdId",
                table: "Students",
                column: "department_IdId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_department_IdId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_department_IdId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "department_IdId",
                table: "Students");
        }
    }
}
