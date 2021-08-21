﻿// <auto-generated />
using System;
using BanHangNetCoreNhom123.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BanHangNetCoreNhom123.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20191217140052_addBanner")]
    partial class addBanner
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BanHangNetCoreNhom123.Models.Banner", b =>
                {
                    b.Property<int>("MaBanner")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UrlBanner");

                    b.HasKey("MaBanner");

                    b.ToTable("Banner");
                });

            modelBuilder.Entity("BanHangNetCoreNhom123.Models.ChiTietGioHang", b =>
                {
                    b.Property<int>("MaCtgioHang")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MaGioHang");

                    b.Property<int?>("MaThucDon");

                    b.Property<int?>("SoLuong");

                    b.HasKey("MaCtgioHang");

                    b.HasIndex("MaGioHang");

                    b.HasIndex("MaThucDon");

                    b.ToTable("ChiTietGioHang");
                });

            modelBuilder.Entity("BanHangNetCoreNhom123.Models.DanhGia", b =>
                {
                    b.Property<int>("MaDanhGia")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LoiNhanXet");

                    b.Property<int?>("MaTaiKhoan");

                    b.Property<int?>("MaThucDon");

                    b.Property<DateTime?>("NgayDanhGia");

                    b.HasKey("MaDanhGia");

                    b.ToTable("DanhGia");
                });

            modelBuilder.Entity("BanHangNetCoreNhom123.Models.GioHang", b =>
                {
                    b.Property<int>("MaGioHang")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MaKhachHang");

                    b.Property<int?>("MaTaiKhoan");

                    b.Property<DateTime?>("NgayDat");

                    b.Property<double?>("TongCong");

                    b.Property<int?>("TrangThai");

                    b.HasKey("MaGioHang");

                    b.HasIndex("MaKhachHang");

                    b.ToTable("GioHang");
                });

            modelBuilder.Entity("BanHangNetCoreNhom123.Models.KhachHang", b =>
                {
                    b.Property<int>("MaKhachHang")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaChi");

                    b.Property<string>("Email");

                    b.Property<int?>("MaTaiKhoan");

                    b.Property<int?>("MaTinhThanh");

                    b.Property<string>("SoDt");

                    b.Property<string>("TenKhachHang");

                    b.HasKey("MaKhachHang");

                    b.HasIndex("MaTaiKhoan");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("BanHangNetCoreNhom123.Models.LoaiThucDon", b =>
                {
                    b.Property<int>("MaLoai")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenLoai");

                    b.HasKey("MaLoai");

                    b.ToTable("LoaiThucDon");
                });

            modelBuilder.Entity("BanHangNetCoreNhom123.Models.NhaSanXuat", b =>
                {
                    b.Property<int>("MaNSX")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenNSX");

                    b.HasKey("MaNSX");

                    b.ToTable("NhaSanXuat");
                });

            modelBuilder.Entity("BanHangNetCoreNhom123.Models.PhanQuyen", b =>
                {
                    b.Property<string>("MaPhanQuyen")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("QuyenHan");

                    b.HasKey("MaPhanQuyen");

                    b.ToTable("PhanQuyen");
                });

            modelBuilder.Entity("BanHangNetCoreNhom123.Models.TaiKhoan", b =>
                {
                    b.Property<int>("MaTaiKhoan")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnhDaiDien");

                    b.Property<int>("DangHoatDong");

                    b.Property<string>("Email");

                    b.Property<string>("MaPhanQuyen");

                    b.Property<string>("MatKhau");

                    b.Property<string>("TenTaiKhoan");

                    b.HasKey("MaTaiKhoan");

                    b.HasIndex("MaPhanQuyen");

                    b.ToTable("TaiKhoan");
                });

            modelBuilder.Entity("BanHangNetCoreNhom123.Models.ThucDon", b =>
                {
                    b.Property<int>("MaThucDon")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double?>("Gia");

                    b.Property<string>("HinhAnh");

                    b.Property<int?>("KhuyenMai");

                    b.Property<int?>("LuotMua");

                    b.Property<int?>("LuotXem");

                    b.Property<int?>("MaLoai");

                    b.Property<int?>("MaNSX");

                    b.Property<string>("MoTa");

                    b.Property<string>("TenThucDon");

                    b.HasKey("MaThucDon");

                    b.HasIndex("MaLoai");

                    b.HasIndex("MaNSX");

                    b.ToTable("ThucDon");
                });

            modelBuilder.Entity("BanHangNetCoreNhom123.Models.TinhThanh", b =>
                {
                    b.Property<int>("MaTinhThanh")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenTinhThanh");

                    b.HasKey("MaTinhThanh");

                    b.ToTable("TinhThanh");
                });

            modelBuilder.Entity("BanHangNetCoreNhom123.Models.ChiTietGioHang", b =>
                {
                    b.HasOne("BanHangNetCoreNhom123.Models.GioHang", "MaGioHangNavigation")
                        .WithMany("ChiTietGioHang")
                        .HasForeignKey("MaGioHang");

                    b.HasOne("BanHangNetCoreNhom123.Models.ThucDon", "MaThucDonNavigation")
                        .WithMany("ChiTietGioHang")
                        .HasForeignKey("MaThucDon");
                });

            modelBuilder.Entity("BanHangNetCoreNhom123.Models.GioHang", b =>
                {
                    b.HasOne("BanHangNetCoreNhom123.Models.KhachHang", "MaKhachHangNavigation")
                        .WithMany("GioHang")
                        .HasForeignKey("MaKhachHang");
                });

            modelBuilder.Entity("BanHangNetCoreNhom123.Models.KhachHang", b =>
                {
                    b.HasOne("BanHangNetCoreNhom123.Models.TaiKhoan", "MaTaiKhoanNavigation")
                        .WithMany("KhachHang")
                        .HasForeignKey("MaTaiKhoan");
                });

            modelBuilder.Entity("BanHangNetCoreNhom123.Models.TaiKhoan", b =>
                {
                    b.HasOne("BanHangNetCoreNhom123.Models.PhanQuyen", "MaPhanQuyenNavigation")
                        .WithMany("TaiKhoan")
                        .HasForeignKey("MaPhanQuyen");
                });

            modelBuilder.Entity("BanHangNetCoreNhom123.Models.ThucDon", b =>
                {
                    b.HasOne("BanHangNetCoreNhom123.Models.LoaiThucDon", "MaLoaiNavigation")
                        .WithMany("ThucDon")
                        .HasForeignKey("MaLoai");

                    b.HasOne("BanHangNetCoreNhom123.Models.NhaSanXuat", "MaNSXNavigation")
                        .WithMany("ThucDon")
                        .HasForeignKey("MaNSX");
                });
#pragma warning restore 612, 618
        }
    }
}
