using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_FrameWork_Session02.Migrations
{
    /// <inheritdoc />
    public partial class M2MRelationShip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Stud_Courses_Course_Id",
                table: "Stud_Courses",
                column: "Course_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Course_Insts_Course_Id",
                table: "Course_Insts",
                column: "Course_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Insts_Courses_Course_Id",
                table: "Course_Insts",
                column: "Course_Id",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Insts_Instructors_Inst_Id",
                table: "Course_Insts",
                column: "Inst_Id",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Courses_Courses_Course_Id",
                table: "Stud_Courses",
                column: "Course_Id",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Courses_Students_Stud_Id",
                table: "Stud_Courses",
                column: "Stud_Id",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Insts_Courses_Course_Id",
                table: "Course_Insts");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Insts_Instructors_Inst_Id",
                table: "Course_Insts");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Courses_Courses_Course_Id",
                table: "Stud_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Courses_Students_Stud_Id",
                table: "Stud_Courses");

            migrationBuilder.DropIndex(
                name: "IX_Stud_Courses_Course_Id",
                table: "Stud_Courses");

            migrationBuilder.DropIndex(
                name: "IX_Course_Insts_Course_Id",
                table: "Course_Insts");
        }
    }
}
