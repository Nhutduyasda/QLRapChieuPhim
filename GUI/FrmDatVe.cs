using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_Service;
using DTO_Model;
using QuestPDF.Fluent;
using UTIL_Valication;



namespace GUI
{
    public partial class FrmDatVe : Form
    {
        private List<string> gheDaChon = new List<string>();
        private string maSuatChieu;
        private string tenPhim;
        private string tenPhongChieu;
        private string maPhongChieu;
        private TimeSpan gioBatDau;
        private TimeSpan gioKetThuc;
        private KhachHangDAL khachHangDAL;
        public FrmDatVe(string maSuatChieu, string tenPhim, string tenPhongChieu, string maPhongChieu, TimeSpan gioBatDau, TimeSpan gioKetThuc)
        {
            InitializeComponent();
            this.maSuatChieu = maSuatChieu;
            this.tenPhim = tenPhim;
            this.tenPhongChieu = tenPhongChieu;
            this.maPhongChieu = maPhongChieu;
            this.gioBatDau = gioBatDau;
            this.gioKetThuc = gioKetThuc;
            khachHangDAL = new KhachHangDAL();

            lblTieuDe.Text = $"Màn hình chiếu ";
            lblSuatChieu.Text = $"Suất chiếu: {maSuatChieu} ";
            lblTenPhim.Text = $"Tên phim: {tenPhim} ";
            lblPhongChieu.Text = $"Phòng chiếu: {tenPhongChieu}";
            lblTime.Text = $"Thời gian: {gioBatDau.ToString(@"hh\:mm")} - {gioKetThuc.ToString(@"hh\:mm")}";
        }

        private List<Button> danhSachGheDaChon = new List<Button>();
        private void FrmDatVe_Load(object sender, EventArgs e)
        {

            foreach (Control dieuKhien in this.Controls)
            {
                if (dieuKhien is Button && dieuKhien.Name.StartsWith("btnGhe"))
                {
                    dieuKhien.Click += SuKienChonGhe;
                }
            }

        }

        private void SuKienChonGhe(object sender, EventArgs e)
        {
            Button ghe = sender as Button;
            // hiện tổng số ghế đã chọn
            



            if (danhSachGheDaChon.Contains(ghe))
            {
                ghe.BackColor = SystemColors.Control;
                danhSachGheDaChon.Remove(ghe);
            }
            else
            {
                ghe.BackColor = ColorTranslator.FromHtml("#4CAF50");
                danhSachGheDaChon.Add(ghe);
            }

            CapNhatThongTinGheVaTien();
        }
        private void CapNhatThongTinGheVaTien()
        {
            if (danhSachGheDaChon.Count == 0)
            {
                txtTongTienVe.Clear();
                return;
            }
            // Hiển thị tổng số  ghế đã chọn
            lblDanhSachGheDaChon.Text = $"Số ghế đã chọn: {danhSachGheDaChon.Count}";


            int giaVe = 75000;
            int tongTien = danhSachGheDaChon.Count * giaVe;

            txtTongTienVe.Text = tongTien.ToString("N0") + " VNĐ";
        }

        private void TaoGheTuDong()
        {
            GheDAL gheDAL = new GheDAL();
            List<GheDTO> danhSachGhe = gheDAL.selectByMaPhongChieu(maPhongChieu);

            VeDAL veDAL = new VeDAL();
            List<VeDTO> danhSachVeDaDat = veDAL.GetVeByMaSuatChieu(maSuatChieu);


            int soHang = danhSachGhe.Max(g => g.TenGhe[0]) - 'A' + 1;
            int soCot = danhSachGhe.Where(g => g.TenGhe.StartsWith("A")).Count();

            int leTrai = 20;
            int leTren = 50;
            int khoangCach = 10;

            int chieuRongPanel = 836;
            int chieuCaoPanel = 562;

            int chieuRongGhe = (chieuRongPanel - (soCot - 1) * khoangCach) / soCot;
            int chieuCaoGhe = (chieuCaoPanel - (soHang - 1) * khoangCach) / soHang;

            foreach (var gheDTO in danhSachGhe)
            {
                char hangChar = gheDTO.TenGhe[0];
                int hang = hangChar - 'A';


                int cot = int.Parse(gheDTO.TenGhe.Substring(1)) - 1;

                Button ghe = new Button();
                ghe.Name = gheDTO.MaGhe;
                ghe.Text = gheDTO.TenGhe;
                ghe.Width = chieuRongGhe;
                ghe.Height = chieuCaoGhe;
                ghe.Left = leTrai + cot * (chieuRongGhe + khoangCach);
                ghe.Top = leTren + hang * (chieuCaoGhe + khoangCach);
                ghe.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                ghe.Tag = gheDTO;

                
                if (danhSachVeDaDat.Any(ve => ve.MaGhe == gheDTO.MaGhe))
                {
                    ghe.BackColor = Color.Gray;
                    ghe.Enabled = false;
                }
                else
                {
                    ghe.BackColor = SystemColors.Control;
                    ghe.Click += SuKienChonGhe;
                }

                this.Controls.Add(ghe);
            }
        }





        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void FrmDatVe_Load_1(object sender, EventArgs e)
        {
            foreach (Control dieuKhien in this.Controls)
            {
                if (dieuKhien is Button && dieuKhien.Name.StartsWith("btnGhe"))
                {
                    dieuKhien.Click += SuKienChonGhe;
                }
            }
            TaoGheTuDong();
        }

        private void button51_Click(object sender, EventArgs e)
        {

            if (danhSachGheDaChon == null || danhSachGheDaChon.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mở form nhập thông tin khách hàng
            ThongTinKhachHang formKH = new ThongTinKhachHang();

            if (formKH.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrWhiteSpace(formKH.MaKhachHang) ||
                    string.IsNullOrWhiteSpace(formKH.HoTen) ||
                    string.IsNullOrWhiteSpace(formKH.SoDienThoai) ||
                    string.IsNullOrWhiteSpace(formKH.Email))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtTongTienVe.Text.Replace(" VNĐ", "").Replace(",", ""), out decimal tongTienDecimal))
                {
                    MessageBox.Show("Tổng tiền không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string maDatVe = "DV" + Guid.NewGuid().ToString("N").Substring(0, 8);

                DatVeDTO datVe = new DatVeDTO
                {
                    MaDatVe = maDatVe,
                    MaKhachHang = formKH.MaKhachHang,
                    MaNhanVien = Session.MaNhanVien, // Cần sửa thành thông tin đăng nhập nếu có
                    ThoiGianDatVe = DateTime.Now,
                    TongTien = tongTienDecimal,
                    TrangThaiThanhToan = "Chờ xử lý"
                };

                DatVeDAL datVeDAL = new DatVeDAL();
                datVeDAL.Insert(datVe);

                VeDAL veDAL = new VeDAL();
                GheDAL gheDAL = new GheDAL();

                List<string> tenGheList = new List<string>();

                foreach (Button btn in danhSachGheDaChon )
                {
                    
                    string maGhe = btn.Name?.ToString();
                    if (string.IsNullOrWhiteSpace(maGhe)) continue;

                    VeDTO ve = new VeDTO
                    {
                        MaVe = "VE" + Guid.NewGuid().ToString("N").Substring(0, 6),
                        MaDatVe = maDatVe,
                        MaSuatChieu = this.maSuatChieu,
                        MaGhe = maGhe,
                        GiaVe = 75000,
                        LoaiVe = "Người lớn"
                    };
                    veDAL.Insert(ve);

                    GheDTO ghe = new GheDTO
                    {
                        MaGhe = maGhe,
                        TrangThai = "Đã đặt"
                    };
                    gheDAL.UpdateTrangThai(ghe);

                    tenGheList.Add(btn.Text);
                }

                XuatHoaDonPDF(maDatVe, formKH.HoTen, formKH.SoDienThoai, formKH.Email, string.Join(", ", tenGheList), txtTongTienVe.Text);

                foreach (Button ghe in danhSachGheDaChon)
                {
                    ghe.BackColor = Color.Gray;
                    ghe.Enabled = false;
                }


                danhSachGheDaChon.Clear();
                txtTongTienVe.Clear();

                MessageBox.Show("Đặt vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void XuatHoaDonPDF(string maDatVe, string hoTen, string sdt, string email, string ghe, string tongTien)
        {
            // Ensure QuestPDF license is set correctly  
            QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;

            // Use the static `Document.Create` method to create a new document  
            var document = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(50);
                    page.Content().Column(column =>
                    {
                        column.Item().Text("===== HÓA ĐƠN =====").FontSize(20).Bold();
                        column.Item().Text($"Mã đặt vé: {maDatVe}");
                        column.Item().Text($"Họ tên: {hoTen}");
                        column.Item().Text($"SĐT: {sdt}");
                        column.Item().Text($"Email: {email}");
                        column.Item().Text($"Suất chiếu: {maSuatChieu}");
                        column.Item().Text($"Phòng chiếu: {tenPhongChieu}");
                        column.Item().Text($"Tên phim: {tenPhim}");
                        column.Item().Text($"Ghế đã chọn: {ghe}");
                        column.Item().Text($"Thời gian đặt vé: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}");
                        column.Item().Text($"Tổng tiền: {tongTien}");
                        column.Item().Text("----------------------");
                        column.Item().Text("Cảm ơn quý khách!");
                    });
                });
            });

            // lưu hoá đơn vào file PDF vào đường dẫn E:\FPT POLYTECHNIC\PRO131 - Dự án 1 (UDPM.NET)-20250701T003301Z-1-001\QL Rạp Chiếu Phim\HoaDon
            string filePath = @"E:\FPT POLYTECHNIC\PRO131 - Dự án 1 (UDPM.NET)-20250701T003301Z-1-001\QL Rạp Chiếu Phim\HoaDon\" + maDatVe + ".pdf";
            document.GeneratePdf(filePath);






            MessageBox.Show("Hóa đơn đã được xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi người dùng muốn hủy đặt vé
            if (danhSachGheDaChon.Count == 0)
            {
                MessageBox.Show("Không có ghế nào được chọn để hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Hiển thị thông báo xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy đặt vé đã chọn?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Xóa các ghế đã chọn
                foreach (Button ghe in danhSachGheDaChon)
                {
                    ghe.BackColor = SystemColors.Control; // Đặt lại màu nền của ghế
                    ghe.Visible = true; // Hiển thị lại ghế
                }
                danhSachGheDaChon.Clear();
                txtTongTienVe.Clear();
                MessageBox.Show("Đặt vé đã được hủy thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
