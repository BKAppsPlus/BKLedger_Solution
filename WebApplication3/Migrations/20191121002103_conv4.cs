using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations
{
    public partial class conv4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "conv4_OneClass",
                columns: table => new
                {
                    ClassIdee = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClassName = table.Column<string>(nullable: true),
                    Section = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conv4_OneClass", x => x.ClassIdee);
                });

            migrationBuilder.CreateTable(
                name: "conv4_ManyStudent",
                columns: table => new
                {
                    DudeIdee = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentName = table.Column<string>(nullable: true),
                    ClassIdee = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conv4_ManyStudent", x => x.DudeIdee);
                    table.ForeignKey(
                        name: "FK_conv4_ManyStudent_conv4_OneClass_ClassIdee",
                        column: x => x.ClassIdee,
                        principalTable: "conv4_OneClass",
                        principalColumn: "ClassIdee",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_conv4_ManyStudent_ClassIdee",
                table: "conv4_ManyStudent",
                column: "ClassIdee");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "conv4_ManyStudent");

            migrationBuilder.DropTable(
                name: "conv4_OneClass");
        }
    }
}
