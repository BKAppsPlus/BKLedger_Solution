using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations
{
    public partial class conv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "conv2_OneClass",
                columns: table => new
                {
                    Class0Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClassName = table.Column<string>(nullable: true),
                    Section = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conv2_OneClass", x => x.Class0Id);
                });

            migrationBuilder.CreateTable(
                name: "conv2_ManyStudent",
                columns: table => new
                {
                    Student0Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentName = table.Column<string>(nullable: true),
                    conv2_OneClassClass0Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conv2_ManyStudent", x => x.Student0Id);
                    table.ForeignKey(
                        name: "FK_conv2_ManyStudent_conv2_OneClass_conv2_OneClassClass0Id",
                        column: x => x.conv2_OneClassClass0Id,
                        principalTable: "conv2_OneClass",
                        principalColumn: "Class0Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_conv2_ManyStudent_conv2_OneClassClass0Id",
                table: "conv2_ManyStudent",
                column: "conv2_OneClassClass0Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "conv2_ManyStudent");

            migrationBuilder.DropTable(
                name: "conv2_OneClass");
        }
    }
}
