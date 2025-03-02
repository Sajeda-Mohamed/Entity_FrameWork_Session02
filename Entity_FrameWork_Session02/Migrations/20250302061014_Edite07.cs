using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_FrameWork_Session02.Migrations
{
    /// <inheritdoc />
    public partial class Edite07 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Dept_Id",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_Dept_Id",
                table: "Students",
                column: "Dept_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_Dept_Id",
                table: "Students",
                column: "Dept_Id",
                principalTable: "Departments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_Dept_Id",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_Dept_Id",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Dept_Id",
                table: "Students");

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
    }
}
