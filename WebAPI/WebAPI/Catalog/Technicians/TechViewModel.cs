using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Catalog.Technicians
{
    public class TechViewModel
    {
        public int id_ktv { get; set; }
        
        public string ten_ktv { get; set; }
        public int RFID_id { get; set; }
       
        public string so_dien_thoai { get; set; }
        
        public string dia_chi { get; set; }
        public string avartar { get; set; }
        
        public string email { get; set; }
        public int id_don_vi { get; set; }
        public bool nghi_viec { get; set; }
        
        public string ma_can_bo { get; set; }
        
        public string gioi_tinh { get; set; }
        public string ten_donvi { get; set; }
    }
}
