using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class LstLaixe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lst_LaiXe",
                columns: table => new
                {
                    id_lg_xe = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ten_lai_xe = table.Column<string>(maxLength: 100, nullable: true),
                    ngay_sinh = table.Column<DateTime>(type: "date", nullable: true),
                    gioi_tinh = table.Column<int>(nullable: true),
                    nhom_mau = table.Column<string>(maxLength: 10, nullable: true),
                    so_dien_thoai = table.Column<string>(maxLength: 20, nullable: true),
                    cmnd = table.Column<string>(maxLength: 50, nullable: true),
                    giay_phep_lx = table.Column<string>(maxLength: 50, nullable: true),
                    ngay_cap = table.Column<DateTime>(type: "date", nullable: true),
                    ngay_het_han = table.Column<DateTime>(type: "date", nullable: true),
                    so_hieu_lai_xe = table.Column<int>(nullable: true),
                    vi_tri_lam_viec = table.Column<int>(nullable: true),
                    id_RFID = table.Column<int>(nullable: true),
                    id_nguoi_dung = table.Column<int>(nullable: false),
                    thoi_gian = table.Column<DateTime>(nullable: true),
                    nghi_viec = table.Column<bool>(nullable: false),
                    avatar = table.Column<string>(nullable: true),
                    id_don_vi = table.Column<int>(nullable: true),
                    ma_canbo = table.Column<string>(maxLength: 50, nullable: true),
                    email = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lst_LaiXe", x => x.id_lg_xe);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lst_LaiXe");
        }
    }
}
