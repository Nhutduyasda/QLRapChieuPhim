using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Model
{
    public class HoaDon
    {
        public string MaHoaDon { get; set; }
        public string MaKhachHang { get; set; }
        public DateTime NgayLapHoaDon { get; set; }
        public decimal TongTien { get; set; }
        public string TrangThai { get; set; }
    }
}
