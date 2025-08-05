using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Model
{
    public class GiaoDichViewDTO
    {
        public string MaDatVe { get; set; } 
        public string TenKhachHang { get; set; }
        public string Email { get; set; }
        public string TenNhanVien { get; set; }
        public string MaSuatChieu { get; set; }
        public string TenPhongChieu { get; set; }
        public string TenPhim { get; set; }
        public string MaGhe { get; set; }
        public DateTime ThoiGianDatVe { get; set; }
        public decimal TongTien { get; set; }
    }
}
