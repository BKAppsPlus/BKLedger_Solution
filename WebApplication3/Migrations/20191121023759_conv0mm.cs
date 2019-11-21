using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations
{
    public partial class conv0mm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "conv0mm_ManyClass",
                columns: table => new
                {
                    ClassIdee = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClassName = table.Column<string>(nullable: true),
                    Section = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conv0mm_ManyClass", x => x.ClassIdee);
                });

            migrationBuilder.CreateTable(
                name: "conv0mm_ManyStudent",
                columns: table => new
                {
                    DudeIdee = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conv0mm_ManyStudent", x => x.DudeIdee);
                });

            migrationBuilder.CreateTable(
                name: "conv0mm_Class_X_Student",
                columns: table => new
                {
                    PesonId = table.Column<int>(nullable: false),
                    KelasIdee = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conv0mm_Class_X_Student", x => new { x.PesonId, x.KelasIdee });
                    table.ForeignKey(
                        name: "FK_conv0mm_Class_X_Student_conv0mm_ManyClass_KelasIdee",
                        column: x => x.KelasIdee,
                        principalTable: "conv0mm_ManyClass",
                        principalColumn: "ClassIdee",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_conv0mm_Class_X_Student_conv0mm_ManyStudent_PesonId",
                        column: x => x.PesonId,
                        principalTable: "conv0mm_ManyStudent",
                        principalColumn: "DudeIdee",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_conv0mm_Class_X_Student_KelasIdee",
                table: "conv0mm_Class_X_Student",
                column: "KelasIdee");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "conv0mm_Class_X_Student");

            migrationBuilder.DropTable(
                name: "conv0mm_ManyClass");

            migrationBuilder.DropTable(
                name: "conv0mm_ManyStudent");
        }
    }
}
