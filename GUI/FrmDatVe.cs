using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmDatVe : Form
    {
        public FrmDatVe()
        {
            InitializeComponent();
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

            if (danhSachGheDaChon.Contains(ghe))
            {
                ghe.BackColor = SystemColors.Control;
                danhSachGheDaChon.Remove(ghe);
            }
            else
            {
                ghe.BackColor = Color.LimeGreen;
                danhSachGheDaChon.Add(ghe);
            }

            CapNhatThongTinGheVaTien();
        }
        private void CapNhatThongTinGheVaTien()
        {
            // Hiển thị danh sách số ghế đã chọn
            var danhSachSoGhe = danhSachGheDaChon
                .Select(ghe => ghe.Text)
                .OrderBy(so => int.Parse(so))
                .ToList();

            txtGheDaChon.Text = string.Join(", ", danhSachSoGhe);

            // Tính tổng tiền
            int giaVe = 75000;
            int tongTien = danhSachGheDaChon.Count * giaVe;

            txtTongTienVe.Text = tongTien.ToString("N0") + " VNĐ"; // định dạng 75,000 VNĐ
        }

        private void TaoGheTuDong()
        {
            int soLuongGhe = 50;
            int soCot = 10;
            int soHang = soLuongGhe / soCot;

            int leTrai = 20;
            int leTren = 100;
            int khoangCach = 10;

            int chieuRongPanel = 920;  // phần bên trái
            int chieuCaoPanel = 600;

            int chieuRongGhe = (chieuRongPanel - (soCot - 1) * khoangCach) / soCot;
            int chieuCaoGhe = (chieuCaoPanel - (soHang - 1) * khoangCach) / soHang;

            for (int i = 0; i < soLuongGhe; i++)
            {
                Button ghe = new Button();
                ghe.Name = "btnGhe" + (i + 1);
                ghe.Text = (i + 1).ToString();
                ghe.Width = chieuRongGhe;
                ghe.Height = chieuCaoGhe;

                int cot = i % soCot;
                int hang = i / soCot;

                ghe.Left = leTrai + cot * (chieuRongGhe + khoangCach);
                ghe.Top = leTren + hang * (chieuCaoGhe + khoangCach);

                ghe.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                ghe.BackColor = SystemColors.Control;

                ghe.Click += SuKienChonGhe;

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
            if (danhSachGheDaChon.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ThongTinKhachHang formKH = new ThongTinKhachHang();

            if (formKH.ShowDialog() == DialogResult.OK)
            {
                // Giả sử formKH có các thuộc tính public
                string tenKH = formKH.HoTen;
                
                string sdt = formKH.SoDienThoai;
                string email = formKH.Email;
                string gheDaChon = txtGheDaChon.Text;
                string tongTien = txtTongTienVe.Text;

                XuatHoaDon(tenKH, sdt, email, gheDaChon, tongTien);

                // Ẩn các ghế đã mua
                foreach (Button ghe in danhSachGheDaChon)
                {
                    ghe.Visible = false;
                }
                danhSachGheDaChon.Clear();
                txtGheDaChon.Clear();
                txtTongTienVe.Clear();
            }
        }
        private void XuatHoaDon(string hoTen, string sdt, string email, string ghe, string tongTien)
        {
            string hoaDon = "===== HÓA ĐƠN =====\n";
            hoaDon += $"Họ tên: {hoTen}\n";
            hoaDon += $"SĐT: {sdt}\n";
            hoaDon += $"Email: {email}\n";
            hoaDon += $"Ghế đã chọn: {ghe}\n";
            hoaDon += $"Tổng tiền: {tongTien}\n";
            hoaDon += "----------------------\n";
            hoaDon += "Cảm ơn quý khách!";

            MessageBox.Show(hoaDon, "HÓA ĐƠN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
