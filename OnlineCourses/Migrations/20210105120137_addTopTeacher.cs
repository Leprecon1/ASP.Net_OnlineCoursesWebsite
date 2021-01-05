using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineCourses.Migrations
{
    public partial class addTopTeacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "TopTeacher",
                table: "Teachers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TopTeacher",
                table: "Teachers");
        }
    }
}
