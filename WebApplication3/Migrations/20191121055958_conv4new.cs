using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations
{
    public partial class conv4new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_conv4_ManyStudent_conv4_OneClass_ClassIdee",
                table: "conv4_ManyStudent");

            migrationBuilder.DropIndex(
                name: "IX_conv4_ManyStudent_ClassIdee",
                table: "conv4_ManyStudent");

            migrationBuilder.RenameColumn(
                name: "ClassIdee",
                table: "conv4_ManyStudent",
                newName: "KelaslassIdee");

            migrationBuilder.AddColumn<int>(
                name: "ClassOfTheStudentClassIdee",
                table: "conv4_ManyStudent",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_conv4_ManyStudent_ClassOfTheStudentClassIdee",
                table: "conv4_ManyStudent",
                column: "ClassOfTheStudentClassIdee");

            migrationBuilder.AddForeignKey(
                name: "FK_conv4_ManyStudent_conv4_OneClass_ClassOfTheStudentClassIdee",
                table: "conv4_ManyStudent",
                column: "ClassOfTheStudentClassIdee",
                principalTable: "conv4_OneClass",
                principalColumn: "ClassIdee",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_conv4_ManyStudent_conv4_OneClass_ClassOfTheStudentClassIdee",
                table: "conv4_ManyStudent");

            migrationBuilder.DropIndex(
                name: "IX_conv4_ManyStudent_ClassOfTheStudentClassIdee",
                table: "conv4_ManyStudent");

            migrationBuilder.DropColumn(
                name: "ClassOfTheStudentClassIdee",
                table: "conv4_ManyStudent");

            migrationBuilder.RenameColumn(
                name: "KelaslassIdee",
                table: "conv4_ManyStudent",
                newName: "ClassIdee");

            migrationBuilder.CreateIndex(
                name: "IX_conv4_ManyStudent_ClassIdee",
                table: "conv4_ManyStudent",
                column: "ClassIdee");

            migrationBuilder.AddForeignKey(
                name: "FK_conv4_ManyStudent_conv4_OneClass_ClassIdee",
                table: "conv4_ManyStudent",
                column: "ClassIdee",
                principalTable: "conv4_OneClass",
                principalColumn: "ClassIdee",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
