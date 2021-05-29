using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineCourses.Migrations
{
    public partial class ChangeTeacherNameField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Teachers",
                newName: "TeacherName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TeacherName",
                table: "Teachers",
                newName: "Name");
        }
    }
}
