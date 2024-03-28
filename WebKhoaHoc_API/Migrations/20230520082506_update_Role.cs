using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebKhoaHoc_API.Migrations
{
    public partial class update_Role : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GiangVien_Role_MaRole",
                table: "GiangVien");

            migrationBuilder.DropForeignKey(
                name: "FK_NguoiDung_Role_MaRole",
                table: "NguoiDung");

            migrationBuilder.DropForeignKey(
                name: "FK_QuanTriVien_Role_MaRole",
                table: "QuanTriVien");

            migrationBuilder.RenameColumn(
                name: "MaRole",
                table: "QuanTriVien",
                newName: "RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_QuanTriVien_MaRole",
                table: "QuanTriVien",
                newName: "IX_QuanTriVien_RoleId");

            migrationBuilder.RenameColumn(
                name: "MaRole",
                table: "NguoiDung",
                newName: "RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_NguoiDung_MaRole",
                table: "NguoiDung",
                newName: "IX_NguoiDung_RoleId");

            migrationBuilder.RenameColumn(
                name: "MaRole",
                table: "GiangVien",
                newName: "RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_GiangVien_MaRole",
                table: "GiangVien",
                newName: "IX_GiangVien_RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_GiangVien_Role_RoleId",
                table: "GiangVien",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NguoiDung_Role_RoleId",
                table: "NguoiDung",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuanTriVien_Role_RoleId",
                table: "QuanTriVien",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GiangVien_Role_RoleId",
                table: "GiangVien");

            migrationBuilder.DropForeignKey(
                name: "FK_NguoiDung_Role_RoleId",
                table: "NguoiDung");

            migrationBuilder.DropForeignKey(
                name: "FK_QuanTriVien_Role_RoleId",
                table: "QuanTriVien");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "QuanTriVien",
                newName: "MaRole");

            migrationBuilder.RenameIndex(
                name: "IX_QuanTriVien_RoleId",
                table: "QuanTriVien",
                newName: "IX_QuanTriVien_MaRole");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "NguoiDung",
                newName: "MaRole");

            migrationBuilder.RenameIndex(
                name: "IX_NguoiDung_RoleId",
                table: "NguoiDung",
                newName: "IX_NguoiDung_MaRole");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "GiangVien",
                newName: "MaRole");

            migrationBuilder.RenameIndex(
                name: "IX_GiangVien_RoleId",
                table: "GiangVien",
                newName: "IX_GiangVien_MaRole");

            migrationBuilder.AddForeignKey(
                name: "FK_GiangVien_Role_MaRole",
                table: "GiangVien",
                column: "MaRole",
                principalTable: "Role",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NguoiDung_Role_MaRole",
                table: "NguoiDung",
                column: "MaRole",
                principalTable: "Role",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuanTriVien_Role_MaRole",
                table: "QuanTriVien",
                column: "MaRole",
                principalTable: "Role",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
