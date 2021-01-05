using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineCourses.Migrations
{
    public partial class ChangeTeacherModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Link",
                table: "Teachers",
                newName: "Specialization");

            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "Teachers",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Teachers");

            migrationBuilder.RenameColumn(
                name: "Specialization",
                table: "Teachers",
                newName: "Link");
        }
    }
}
