using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StreamCasa.Repository.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class ChangeRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Courses_CoursesId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CoursesId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CoursesId",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CoursesId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_CoursesId",
                table: "Users",
                column: "CoursesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Courses_CoursesId",
                table: "Users",
                column: "CoursesId",
                principalTable: "Courses",
                principalColumn: "Id");
        }
    }
}
