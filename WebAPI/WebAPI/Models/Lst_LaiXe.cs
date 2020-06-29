using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Lst_LaiXe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_lg_xe { get; set; }

       // [Column(TypeName = "varchar")]
        [StringLength (100)]
        public string ten_lai_xe { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngay_sinh { get; set; }

        public int gioi_tinh { get; set; }

      //  [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string nhom_mau { get; set; }

       // [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string so_dien_thoai { get; set; }

       // [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string cmnd { get; set; }

       // [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string giay_phep_lx { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngay_cap { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngay_het_han { get; set; }

        public int so_hieu_lai_xe { get; set; }
        public int vi_tri_lam_viec { get; set; }
        public int id_RFID { get; set; }
        public int id_nguoi_dung { get; set; }
        public DateTime thoi_gian { get; set; }
        public bool nghi_viec { get; set; }
        public string avatar { get; set; }
        public int id_don_vi { get; set; }

        [StringLength(50)]
        public string ma_canbo { get; set; }

       // [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string email { get; set; }
        public string ten_donvi { get; set; }
    }
}
