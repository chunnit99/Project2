using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebAPI.Models
{
    public class Lst_KiThuatVien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_ktv { get; set; }
        [StringLength(128)]
        public string ten_ktv { get; set; } 
        public int RFID_id { get; set; }
        [StringLength(20)]
        public string so_dien_thoai { get; set; }
        [StringLength(256)]
        public string dia_chi { get; set; }
        public string avartar { get; set; }
        [StringLength(50)]
        public string email { get; set; }
        public int id_don_vi { get; set; }
        public bool nghi_viec { get; set; }
        [StringLength(50)]
        public string ma_can_bo { get; set; }
        [StringLength(50)]
        public string gioi_tinh { get; set; }
        public string ten_donvi { get; set; }
    }
}
