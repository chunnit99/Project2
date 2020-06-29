using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class LstKithuatvien : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ten_donvi",
                table: "Lst_LaiXe",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Lst_KiThuatVien",
                columns: table => new
                {
                    id_ktv = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ten_ktv = table.Column<string>(maxLength: 128, nullable: true),
                    RFID_id = table.Column<int>(nullable: true),
                    so_dien_thoai = table.Column<string>(maxLength: 20, nullable: true),
                    dia_chi = table.Column<string>(maxLength: 256, nullable: true),
                    avartar = table.Column<string>(nullable: true),
                    email = table.Column<string>(maxLength: 50, nullable: true),
                    id_don_vi = table.Column<int>(nullable: true),
                    nghi_viec = table.Column<bool>(nullable: true),
                    ma_can_bo = table.Column<string>(maxLength: 50, nullable: true),
                    gioi_tinh = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lst_KiThuatVien", x => x.id_ktv);
                });

            migrationBuilder.CreateTable(
                name: "Lst_Xe",
                columns: table => new
                {
                    id_xe = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bien_kiem_soat = table.Column<string>(maxLength: 50, nullable: true),
                    vin_number = table.Column<string>(maxLength: 100, nullable: true),
                    id_thiet_bi = table.Column<int>(nullable: true),
                    id_loai_xe = table.Column<int>(nullable: true),
                    id_lai_xe_chinh = table.Column<int>(nullable: true),
                    loai_nhien_lieu = table.Column<int>(nullable: true),
                    dinh_muc_nhien_lieu = table.Column<float>(nullable: true),
                    id_don_vi_nhien_lieu = table.Column<int>(nullable: true),
                    van_toc_gioi_han = table.Column<int>(nullable: true),
                    rezo_speed_gps = table.Column<int>(nullable: true),
                    nhom_xe_thong_tu = table.Column<bool>(nullable: false),
                    thoi_gian = table.Column<DateTime>(nullable: true),
                    lsat_time_driving = table.Column<DateTime>(nullable: true),
                    dang_ky_tong_cuc = table.Column<bool>(nullable: true),
                    so_luong_camera = table.Column<int>(nullable: true),
                    loai_xe = table.Column<string>(maxLength: 50, nullable: true),
                    chu_ky_bao_duong = table.Column<int>(nullable: true),
                    lan_baoduong_cuoi = table.Column<DateTime>(type: "date", nullable: true),
                    ngay_het_baohiem = table.Column<DateTime>(type: "date", nullable: true),
                    ngay_mua_baohiem = table.Column<DateTime>(type: "date", nullable: true),
                    ngay_thaydau = table.Column<DateTime>(type: "date", nullable: true),
                    noidung_baoduong = table.Column<string>(maxLength: 512, nullable: true),
                    noidung_thaydau = table.Column<string>(maxLength: 512, nullable: true),
                    ghichu = table.Column<string>(maxLength: 512, nullable: true),
                    cam1_rotate = table.Column<int>(nullable: true),
                    cam2_rotate = table.Column<int>(nullable: true),
                    cam_select = table.Column<int>(nullable: true),
                    ngay_het_dangkiem = table.Column<DateTime>(type: "date", nullable: true),
                    ngay_suachua = table.Column<DateTime>(type: "date", nullable: true),
                    RFID_id = table.Column<int>(nullable: true),
                    noidung_suachua = table.Column<string>(maxLength: 512, nullable: true),
                    giatri_suachua = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lst_Xe", x => x.id_xe);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lst_KiThuatVien");

            migrationBuilder.DropTable(
                name: "Lst_Xe");

            migrationBuilder.DropColumn(
                name: "ten_donvi",
                table: "Lst_LaiXe");
        }
    }
}
