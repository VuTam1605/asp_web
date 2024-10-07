using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaiKiemTra03_02.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateNamSinhToInt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NamSinh",
                table: "TacGia",
                type: "int",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "NamSinh",
                table: "TacGia",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
