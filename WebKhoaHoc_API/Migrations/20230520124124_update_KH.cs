using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebKhoaHoc_API.Migrations
{
    public partial class update_KH : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaQTV",
                table: "KhoaHoc",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_KhoaHoc_MaQTV",
                table: "KhoaHoc",
                column: "MaQTV");

            migrationBuilder.AddForeignKey(
                name: "FK_KhoaHoc_QuanTriVien_MaQTV",
                table: "KhoaHoc",
                column: "MaQTV",
                principalTable: "QuanTriVien",
                principalColumn: "MaQTV",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KhoaHoc_QuanTriVien_MaQTV",
                table: "KhoaHoc");

            migrationBuilder.DropIndex(
                name: "IX_KhoaHoc_MaQTV",
                table: "KhoaHoc");

            migrationBuilder.DropColumn(
                name: "MaQTV",
                table: "KhoaHoc");
        }
    }
}
