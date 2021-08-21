using Microsoft.EntityFrameworkCore.Migrations;

namespace BanHangNetCoreNhom123.Migrations
{
    public partial class updatedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ThucDon",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NoiDung",
                table: "Banner",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TieuDe",
                table: "Banner",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "ThucDon");

            migrationBuilder.DropColumn(
                name: "NoiDung",
                table: "Banner");

            migrationBuilder.DropColumn(
                name: "TieuDe",
                table: "Banner");
        }
    }
}
