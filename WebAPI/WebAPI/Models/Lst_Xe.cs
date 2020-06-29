using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebAPI.Models
{
    public class Lst_Xe
    {
        [Key]
        
        public int id_xe { get; set; }
        [StringLength(50)]
        public string bien_kiem_soat { get; set; }
        [StringLength(100)]
        public string vin_number { get; set; }
        public int id_thiet_bi { get; set; }
        public int id_loai_xe { get; set; }
        public int id_lai_xe_chinh { get; set; }
        public int loai_nhien_lieu { get; set; }
        public float dinh_muc_nhien_lieu { get; set; }
        public int id_don_vi_nhien_lieu { get; set; }
        public int van_toc_gioi_han { get; set; }
        public int rezo_speed_gps { get; set; }
        public bool nhom_xe_thong_tu { get; set; }
        public DateTime thoi_gian { get; set; }
        public DateTime lsat_time_driving { get; set; }
        public bool dang_ky_tong_cuc { get; set; }
        public int so_luong_camera { get; set; }
        [StringLength(50)]
        public string loai_xe { get; set; }
        public int chu_ky_bao_duong { get; set; }
        [Column(TypeName = "date")]
        public DateTime lan_baoduong_cuoi { get; set; }
        [Column(TypeName = "date")]
        public DateTime ngay_het_baohiem { get; set; }
        [Column(TypeName = "date")]
        public DateTime ngay_mua_baohiem { get; set; }
        [Column(TypeName = "date")]
        public DateTime ngay_thaydau { get; set; }
        [StringLength(512)]
        public string noidung_baoduong { get; set; }
        [StringLength(512)]
        public string noidung_thaydau { get; set; }
        [StringLength(512)]
        public string ghichu { get; set; }
        public int cam1_rotate { get; set; }
        public int cam2_rotate { get; set; }
        public int cam_select { get; set; }
        [Column(TypeName = "date")]
        public DateTime ngay_het_dangkiem { get; set; }
        [Column(TypeName = "date")]
        public DateTime ngay_suachua { get; set; }
        public int RFID_id { get; set; }
        [StringLength(512)]
        public string noidung_suachua { get; set; }
        public float giatri_suachua { get; set; }
    }
}
