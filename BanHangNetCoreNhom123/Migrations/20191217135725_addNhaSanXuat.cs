using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BanHangNetCoreNhom123.Migrations
{
    public partial class addNhaSanXuat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietHoaDon");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.AddColumn<int>(
                name: "LuotMua",
                table: "ThucDon",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LuotXem",
                table: "ThucDon",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaNSX",
                table: "ThucDon",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "NhaSanXuat",
                columns: table => new
                {
                    MaNSX = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenNSX = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaSanXuat", x => x.MaNSX);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ThucDon_MaNSX",
                table: "ThucDon",
                column: "MaNSX");

            migrationBuilder.AddForeignKey(
                name: "FK_ThucDon_NhaSanXuat_MaNSX",
                table: "ThucDon",
                column: "MaNSX",
                principalTable: "NhaSanXuat",
                principalColumn: "MaNSX",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ThucDon_NhaSanXuat_MaNSX",
                table: "ThucDon");

            migrationBuilder.DropTable(
                name: "NhaSanXuat");

            migrationBuilder.DropIndex(
                name: "IX_ThucDon_MaNSX",
                table: "ThucDon");

            migrationBuilder.DropColumn(
                name: "LuotMua",
                table: "ThucDon");

            migrationBuilder.DropColumn(
                name: "LuotXem",
                table: "ThucDon");

            migrationBuilder.DropColumn(
                name: "MaNSX",
                table: "ThucDon");

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    MaHoaDon = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaKhachHang = table.Column<int>(nullable: true),
                    ThoiGianLap = table.Column<DateTime>(nullable: true),
                    TongTien = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.MaHoaDon);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_MaKhachHang",
                        column: x => x.MaKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "MaKhachHang",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDon",
                columns: table => new
                {
                    MaChiTiet = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DonGia = table.Column<double>(nullable: true),
                    MaHoaDon = table.Column<int>(nullable: true),
                    MaThucDon = table.Column<int>(nullable: true),
                    SoLuong = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDon", x => x.MaChiTiet);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDon_HoaDon_MaHoaDon",
                        column: x => x.MaHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "MaHoaDon",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDon_ThucDon_MaThucDon",
                        column: x => x.MaThucDon,
                        principalTable: "ThucDon",
                        principalColumn: "MaThucDon",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDon_MaHoaDon",
                table: "ChiTietHoaDon",
                column: "MaHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDon_MaThucDon",
                table: "ChiTietHoaDon",
                column: "MaThucDon");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaKhachHang",
                table: "HoaDon",
                column: "MaKhachHang");
        }
    }
}
