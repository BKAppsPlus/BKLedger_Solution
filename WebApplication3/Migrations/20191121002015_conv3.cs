using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations
{
    public partial class conv3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "conv3_OneClass",
                columns: table => new
                {
                    ClassIdee = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClassName = table.Column<string>(nullable: true),
                    Section = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conv3_OneClass", x => x.ClassIdee);
                });

            migrationBuilder.CreateTable(
                name: "conv3_ManyStudent",
                columns: table => new
                {
                    DudeIdee = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentName = table.Column<string>(nullable: true),
                    ClassOfTheStudentClassIdee = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conv3_ManyStudent", x => x.DudeIdee);
                    table.ForeignKey(
                        name: "FK_conv3_ManyStudent_conv3_OneClass_ClassOfTheStudentClassIdee",
                        column: x => x.ClassOfTheStudentClassIdee,
                        principalTable: "conv3_OneClass",
                        principalColumn: "ClassIdee",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_conv3_ManyStudent_ClassOfTheStudentClassIdee",
                table: "conv3_ManyStudent",
                column: "ClassOfTheStudentClassIdee");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "conv3_ManyStudent");

            migrationBuilder.DropTable(
                name: "conv3_OneClass");
        }
    }
}
