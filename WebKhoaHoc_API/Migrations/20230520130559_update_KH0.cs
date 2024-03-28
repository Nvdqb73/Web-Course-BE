using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebKhoaHoc_API.Migrations
{
    public partial class update_KH0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SoLuong",
                table: "KhoaHoc",
                newName: "SoLuongHocVien");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SoLuongHocVien",
                table: "KhoaHoc",
                newName: "SoLuong");
        }
    }
}
