using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations
{
    public partial class conv0mm2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MobserDudeIdee",
                table: "conv0mm_ManyClass",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TopDogDudeIdee",
                table: "conv0mm_ManyClass",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_conv0mm_ManyClass_MobserDudeIdee",
                table: "conv0mm_ManyClass",
                column: "MobserDudeIdee");

            migrationBuilder.CreateIndex(
                name: "IX_conv0mm_ManyClass_TopDogDudeIdee",
                table: "conv0mm_ManyClass",
                column: "TopDogDudeIdee");

            migrationBuilder.AddForeignKey(
                name: "FK_conv0mm_ManyClass_conv0mm_ManyStudent_MobserDudeIdee",
                table: "conv0mm_ManyClass",
                column: "MobserDudeIdee",
                principalTable: "conv0mm_ManyStudent",
                principalColumn: "DudeIdee",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_conv0mm_ManyClass_conv0mm_ManyStudent_TopDogDudeIdee",
                table: "conv0mm_ManyClass",
                column: "TopDogDudeIdee",
                principalTable: "conv0mm_ManyStudent",
                principalColumn: "DudeIdee",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_conv0mm_ManyClass_conv0mm_ManyStudent_MobserDudeIdee",
                table: "conv0mm_ManyClass");

            migrationBuilder.DropForeignKey(
                name: "FK_conv0mm_ManyClass_conv0mm_ManyStudent_TopDogDudeIdee",
                table: "conv0mm_ManyClass");

            migrationBuilder.DropIndex(
                name: "IX_conv0mm_ManyClass_MobserDudeIdee",
                table: "conv0mm_ManyClass");

            migrationBuilder.DropIndex(
                name: "IX_conv0mm_ManyClass_TopDogDudeIdee",
                table: "conv0mm_ManyClass");

            migrationBuilder.DropColumn(
                name: "MobserDudeIdee",
                table: "conv0mm_ManyClass");

            migrationBuilder.DropColumn(
                name: "TopDogDudeIdee",
                table: "conv0mm_ManyClass");
        }
    }
}
