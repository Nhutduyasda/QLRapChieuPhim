using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Model
{
    public class ViewSuatChieu
    {
        public string MaSuatChieu { get; set; }
        public string TenPhim { get; set; }
        public string TenPhongChieu { get; set; }
        public DateTime NgayChieu { get; set; }
        public TimeSpan ThoiGianBatDau { get; set; }
        public TimeSpan ThoiGianKetThuc { get; set; }
        public decimal GiaVe { get; set; }
    }
}
