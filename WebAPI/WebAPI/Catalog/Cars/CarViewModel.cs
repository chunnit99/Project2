using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Catalog.Cars
{
    public class CarViewModel
    {
        public int id_xe { get; set; }
        public string bien_kiem_soat { get; set; }
        public int id_lai_xe_chinh { get; set; }
        public string loai_xe { get; set; }
        public int RFID_id { get; set; }
        public int loai_nhien_lieu { get; set; }
        public int van_toc_gioi_han { get; set; }
        public int so_luong_camera { get; set; }
    }
}
