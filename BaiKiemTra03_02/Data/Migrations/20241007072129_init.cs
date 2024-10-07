using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaiKiemTra03_02.Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TacGia",
                columns: table => new
                {
                    MaTacGia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTacGia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuocTich = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NamSinh = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TacGia", x => x.MaTacGia);
                });

            migrationBuilder.CreateTable(
                name: "Sach",
                columns: table => new
                {
                    MaSach = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TieuDeSach = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NamXuatBan = table.Column<int>(type: "int", nullable: false),
                    MaTacGia = table.Column<int>(type: "int", nullable: false),
                    TheLoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TacGiaObjMaTacGia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sach", x => x.MaSach);
                    table.ForeignKey(
                        name: "FK_Sach_TacGia_TacGiaObjMaTacGia",
                        column: x => x.TacGiaObjMaTacGia,
                        principalTable: "TacGia",
                        principalColumn: "MaTacGia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sach_TacGiaObjMaTacGia",
                table: "Sach",
                column: "TacGiaObjMaTacGia");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sach");

            migrationBuilder.DropTable(
                name: "TacGia");
        }
    }
}
