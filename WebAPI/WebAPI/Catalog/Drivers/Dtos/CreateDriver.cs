using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Catalog.Drivers.Dtos
{
    public class CreateDriver
    {
        public int id_lg_xe { get; set; }
        public string ten_lai_xe { get; set; }
        public int gioi_tinh { get; set; }
        public string so_dien_thoai { get; set; }
        public int id_RFID { get; set; }
        public bool nghi_viec { get; set; }
        public string avatar { get; set; }
        public string ten_donvi { get; set; }
        public string email { get; set; }
    }
}
