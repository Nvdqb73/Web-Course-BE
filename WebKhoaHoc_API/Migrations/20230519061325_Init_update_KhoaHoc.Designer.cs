﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebKhoaHoc_API.Models;

#nullable disable

namespace WebKhoaHoc_API.Migrations
{
    [DbContext(typeof(WebKhoaHocDbContext))]
    [Migration("20230519061325_Init_update_KhoaHoc")]
    partial class Init_update_KhoaHoc
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebKhoaHoc_API.Models.BaiHoc", b =>
                {
                    b.Property<int>("MaBH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaBH"), 1L, 1);

                    b.Property<int>("MaKH")
                        .HasColumnType("int");

                    b.Property<string>("NoiDungBH")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenBH")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Video")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaBH");

                    b.HasIndex("MaKH");

                    b.ToTable("BaiHoc");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.BaiTap", b =>
                {
                    b.Property<int>("MaBT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaBT"), 1L, 1);

                    b.Property<string>("DapAn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Diem")
                        .HasColumnType("real");

                    b.Property<int>("MaBH")
                        .HasColumnType("int");

                    b.Property<string>("NoiDungBT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaBT");

                    b.HasIndex("MaBH");

                    b.ToTable("BaiTap");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.BinhLuan", b =>
                {
                    b.Property<int>("MaBL")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaBL"), 1L, 1);

                    b.Property<int>("MaND")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayBL")
                        .HasColumnType("datetime2");

                    b.Property<string>("NoiDung")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaBL");

                    b.HasIndex("MaND");

                    b.ToTable("BinhLuan");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.Chat", b =>
                {
                    b.Property<int>("MaChat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaChat"), 1L, 1);

                    b.Property<int>("KhoaHocMaKH")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayGui")
                        .HasColumnType("datetime2");

                    b.Property<string>("NoiDung")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaChat");

                    b.HasIndex("KhoaHocMaKH");

                    b.ToTable("Chat");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.ChiTietBinhLuan", b =>
                {
                    b.Property<int>("MaCTBL")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaCTBL"), 1L, 1);

                    b.Property<int>("MaBL")
                        .HasColumnType("int");

                    b.Property<int>("MaKH")
                        .HasColumnType("int");

                    b.HasKey("MaCTBL");

                    b.HasIndex("MaBL");

                    b.HasIndex("MaKH");

                    b.ToTable("ChiTietBinhLuan");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.ChiTietChat", b =>
                {
                    b.Property<int>("MaCTC")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaCTC"), 1L, 1);

                    b.Property<int>("MaChat")
                        .HasColumnType("int");

                    b.Property<int>("MaND")
                        .HasColumnType("int");

                    b.HasKey("MaCTC");

                    b.HasIndex("MaChat");

                    b.HasIndex("MaND");

                    b.ToTable("ChiTietChat");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.ChiTietDonHang", b =>
                {
                    b.Property<int>("MaCTDH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaCTDH"), 1L, 1);

                    b.Property<int>("MaDH")
                        .HasColumnType("int");

                    b.Property<int>("MaKH")
                        .HasColumnType("int");

                    b.Property<int>("SoLuongKH")
                        .HasColumnType("int");

                    b.HasKey("MaCTDH");

                    b.HasIndex("MaDH");

                    b.HasIndex("MaKH");

                    b.ToTable("ChiTietDonHang");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.ChungChi", b =>
                {
                    b.Property<int>("MaCC")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaCC"), 1L, 1);

                    b.Property<int>("MaKH")
                        .HasColumnType("int");

                    b.Property<int>("MaND")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayCap")
                        .HasColumnType("datetime2");

                    b.Property<string>("TenCC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaCC");

                    b.HasIndex("MaKH")
                        .IsUnique();

                    b.HasIndex("MaND");

                    b.ToTable("ChungChi");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.DonHang", b =>
                {
                    b.Property<int>("MaDH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaDH"), 1L, 1);

                    b.Property<DateTime>("NgayLap")
                        .HasColumnType("datetime2");

                    b.Property<int>("NguoiDungMaND")
                        .HasColumnType("int");

                    b.Property<string>("TenDH")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TongGiaTri")
                        .HasColumnType("float");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaDH");

                    b.HasIndex("NguoiDungMaND");

                    b.ToTable("DonHang");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.GiangVien", b =>
                {
                    b.Property<int>("MaGV")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaGV"), 1L, 1);

                    b.Property<string>("ChuyenMon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaRole")
                        .HasColumnType("int");

                    b.Property<string>("NamHD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("TenGV")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("MaGV");

                    b.HasIndex("MaRole");

                    b.ToTable("GiangVien");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.KhoaHoc", b =>
                {
                    b.Property<int>("MaKH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaKH"), 1L, 1);

                    b.Property<double?>("Gia")
                        .HasColumnType("float");

                    b.Property<int>("MaGV")
                        .HasColumnType("int");

                    b.Property<int>("MaLoai")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SoLuong")
                        .HasColumnType("int");

                    b.Property<int?>("SoLuongBH")
                        .HasColumnType("int");

                    b.Property<string>("TenKH")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaKH");

                    b.HasIndex("MaGV");

                    b.HasIndex("MaLoai");

                    b.ToTable("KhoaHoc");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.LoaiKH", b =>
                {
                    b.Property<int>("MaLoai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaLoai"), 1L, 1);

                    b.Property<string>("TenLoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaLoai");

                    b.ToTable("LoaiKH");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.LoaiTT", b =>
                {
                    b.Property<int>("MaLTT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaLTT"), 1L, 1);

                    b.Property<string>("TenLTT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaLTT");

                    b.ToTable("LoaiTT");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.NguoiDung", b =>
                {
                    b.Property<int>("MaND")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaND"), 1L, 1);

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaRole")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TenDangNhap")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TenND")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaND");

                    b.HasIndex("MaRole");

                    b.ToTable("NguoiDung");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.PhanHoi", b =>
                {
                    b.Property<int>("MaPH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaPH"), 1L, 1);

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaND")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayPH")
                        .HasColumnType("datetime2");

                    b.Property<string>("NoiDungPH")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaPH");

                    b.HasIndex("MaND");

                    b.ToTable("PhanHoi");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.QuanTriVien", b =>
                {
                    b.Property<int>("MaQTV")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaQTV"), 1L, 1);

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaRole")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("TenQTV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaQTV");

                    b.HasIndex("MaRole");

                    b.ToTable("QuanTriVien");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"), 1L, 1);

                    b.Property<string>("RoleName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("RoleId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.ThanhToan", b =>
                {
                    b.Property<int>("MaTT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaTT"), 1L, 1);

                    b.Property<int>("MaLTT")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayTT")
                        .HasColumnType("datetime2");

                    b.HasKey("MaTT");

                    b.HasIndex("MaLTT");

                    b.ToTable("ThanhToan");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.BaiHoc", b =>
                {
                    b.HasOne("WebKhoaHoc_API.Models.KhoaHoc", "KhoaHoc")
                        .WithMany("BaiHocs")
                        .HasForeignKey("MaKH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhoaHoc");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.BaiTap", b =>
                {
                    b.HasOne("WebKhoaHoc_API.Models.BaiHoc", "BaiHoc")
                        .WithMany("BaiTaps")
                        .HasForeignKey("MaBH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BaiHoc");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.BinhLuan", b =>
                {
                    b.HasOne("WebKhoaHoc_API.Models.NguoiDung", "NguoiDung")
                        .WithMany("BinhLuans")
                        .HasForeignKey("MaND")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NguoiDung");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.Chat", b =>
                {
                    b.HasOne("WebKhoaHoc_API.Models.KhoaHoc", "KhoaHoc")
                        .WithMany("Chats")
                        .HasForeignKey("KhoaHocMaKH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhoaHoc");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.ChiTietBinhLuan", b =>
                {
                    b.HasOne("WebKhoaHoc_API.Models.BinhLuan", "BinhLuan")
                        .WithMany("ChiTietBinhLuans")
                        .HasForeignKey("MaBL")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebKhoaHoc_API.Models.KhoaHoc", "KhoaHoc")
                        .WithMany("ChiTietBinhLuans")
                        .HasForeignKey("MaKH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BinhLuan");

                    b.Navigation("KhoaHoc");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.ChiTietChat", b =>
                {
                    b.HasOne("WebKhoaHoc_API.Models.Chat", "Chat")
                        .WithMany("ChiTietChats")
                        .HasForeignKey("MaChat")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebKhoaHoc_API.Models.NguoiDung", "NguoiDung")
                        .WithMany("ChiTietChats")
                        .HasForeignKey("MaND")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chat");

                    b.Navigation("NguoiDung");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.ChiTietDonHang", b =>
                {
                    b.HasOne("WebKhoaHoc_API.Models.DonHang", "DonHang")
                        .WithMany("ChiTietDonHangs")
                        .HasForeignKey("MaDH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebKhoaHoc_API.Models.KhoaHoc", "KhoaHoc")
                        .WithMany("ChiTietDonHangs")
                        .HasForeignKey("MaKH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DonHang");

                    b.Navigation("KhoaHoc");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.ChungChi", b =>
                {
                    b.HasOne("WebKhoaHoc_API.Models.KhoaHoc", "KhoaHoc")
                        .WithOne("ChungChi")
                        .HasForeignKey("WebKhoaHoc_API.Models.ChungChi", "MaKH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebKhoaHoc_API.Models.NguoiDung", "NguoiDung")
                        .WithMany("ChungChis")
                        .HasForeignKey("MaND")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhoaHoc");

                    b.Navigation("NguoiDung");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.DonHang", b =>
                {
                    b.HasOne("WebKhoaHoc_API.Models.NguoiDung", "NguoiDung")
                        .WithMany("DonHangs")
                        .HasForeignKey("NguoiDungMaND")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NguoiDung");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.GiangVien", b =>
                {
                    b.HasOne("WebKhoaHoc_API.Models.Role", "Role")
                        .WithMany("GiangViens")
                        .HasForeignKey("MaRole")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.KhoaHoc", b =>
                {
                    b.HasOne("WebKhoaHoc_API.Models.GiangVien", "GiangVien")
                        .WithMany("KhoaHocs")
                        .HasForeignKey("MaGV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebKhoaHoc_API.Models.LoaiKH", "LoaiKH")
                        .WithMany("KhoaHoc")
                        .HasForeignKey("MaLoai")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GiangVien");

                    b.Navigation("LoaiKH");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.NguoiDung", b =>
                {
                    b.HasOne("WebKhoaHoc_API.Models.Role", "Role")
                        .WithMany("NguoiDung")
                        .HasForeignKey("MaRole")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.PhanHoi", b =>
                {
                    b.HasOne("WebKhoaHoc_API.Models.NguoiDung", "NguoiDung")
                        .WithMany("PhanHois")
                        .HasForeignKey("MaND")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NguoiDung");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.QuanTriVien", b =>
                {
                    b.HasOne("WebKhoaHoc_API.Models.Role", "Role")
                        .WithMany("QuanTriViens")
                        .HasForeignKey("MaRole")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.ThanhToan", b =>
                {
                    b.HasOne("WebKhoaHoc_API.Models.LoaiTT", "LoaiTT")
                        .WithMany("ThanhToans")
                        .HasForeignKey("MaLTT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoaiTT");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.BaiHoc", b =>
                {
                    b.Navigation("BaiTaps");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.BinhLuan", b =>
                {
                    b.Navigation("ChiTietBinhLuans");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.Chat", b =>
                {
                    b.Navigation("ChiTietChats");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.DonHang", b =>
                {
                    b.Navigation("ChiTietDonHangs");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.GiangVien", b =>
                {
                    b.Navigation("KhoaHocs");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.KhoaHoc", b =>
                {
                    b.Navigation("BaiHocs");

                    b.Navigation("Chats");

                    b.Navigation("ChiTietBinhLuans");

                    b.Navigation("ChiTietDonHangs");

                    b.Navigation("ChungChi")
                        .IsRequired();
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.LoaiKH", b =>
                {
                    b.Navigation("KhoaHoc");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.LoaiTT", b =>
                {
                    b.Navigation("ThanhToans");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.NguoiDung", b =>
                {
                    b.Navigation("BinhLuans");

                    b.Navigation("ChiTietChats");

                    b.Navigation("ChungChis");

                    b.Navigation("DonHangs");

                    b.Navigation("PhanHois");
                });

            modelBuilder.Entity("WebKhoaHoc_API.Models.Role", b =>
                {
                    b.Navigation("GiangViens");

                    b.Navigation("NguoiDung");

                    b.Navigation("QuanTriViens");
                });
#pragma warning restore 612, 618
        }
    }
}
