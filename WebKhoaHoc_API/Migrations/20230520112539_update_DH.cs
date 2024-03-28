using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebKhoaHoc_API.Migrations
{
    public partial class update_DH : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chat_KhoaHoc_KhoaHocMaKH",
                table: "Chat");

            migrationBuilder.DropForeignKey(
                name: "FK_DonHang_NguoiDung_NguoiDungMaND",
                table: "DonHang");

            migrationBuilder.RenameColumn(
                name: "NguoiDungMaND",
                table: "DonHang",
                newName: "MaND");

            migrationBuilder.RenameIndex(
                name: "IX_DonHang_NguoiDungMaND",
                table: "DonHang",
                newName: "IX_DonHang_MaND");

            migrationBuilder.RenameColumn(
                name: "KhoaHocMaKH",
                table: "Chat",
                newName: "MaKH");

            migrationBuilder.RenameIndex(
                name: "IX_Chat_KhoaHocMaKH",
                table: "Chat",
                newName: "IX_Chat_MaKH");

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
                name: "FK_Chat_KhoaHoc_MaKH",
                table: "Chat",
                column: "MaKH",
                principalTable: "KhoaHoc",
                principalColumn: "MaKH",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DonHang_NguoiDung_MaND",
                table: "DonHang",
                column: "MaND",
                principalTable: "NguoiDung",
                principalColumn: "MaND",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_Chat_KhoaHoc_MaKH",
                table: "Chat");

            migrationBuilder.DropForeignKey(
                name: "FK_DonHang_NguoiDung_MaND",
                table: "DonHang");

            migrationBuilder.DropForeignKey(
                name: "FK_KhoaHoc_QuanTriVien_MaQTV",
                table: "KhoaHoc");

            migrationBuilder.DropIndex(
                name: "IX_KhoaHoc_MaQTV",
                table: "KhoaHoc");

            migrationBuilder.DropColumn(
                name: "MaQTV",
                table: "KhoaHoc");

            migrationBuilder.RenameColumn(
                name: "MaND",
                table: "DonHang",
                newName: "NguoiDungMaND");

            migrationBuilder.RenameIndex(
                name: "IX_DonHang_MaND",
                table: "DonHang",
                newName: "IX_DonHang_NguoiDungMaND");

            migrationBuilder.RenameColumn(
                name: "MaKH",
                table: "Chat",
                newName: "KhoaHocMaKH");

            migrationBuilder.RenameIndex(
                name: "IX_Chat_MaKH",
                table: "Chat",
                newName: "IX_Chat_KhoaHocMaKH");

            migrationBuilder.AddForeignKey(
                name: "FK_Chat_KhoaHoc_KhoaHocMaKH",
                table: "Chat",
                column: "KhoaHocMaKH",
                principalTable: "KhoaHoc",
                principalColumn: "MaKH",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DonHang_NguoiDung_NguoiDungMaND",
                table: "DonHang",
                column: "NguoiDungMaND",
                principalTable: "NguoiDung",
                principalColumn: "MaND",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
