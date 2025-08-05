using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_Service;
using DTO_Model;

namespace GUI
{
    public partial class Ghe : Form
    {
        GheDAL gheDAL = new GheDAL();
        PhongChieuDAL phongChieuDAL = new PhongChieuDAL();
        public Ghe()
        {
            InitializeComponent();
            gheDAL = new GheDAL();
            LoadComboBoxPhongChieu();
            LoadComboBoxTrangThai();
            SetUpColors();

        }
        private void SetUpColors()
        {
            this.BackColor = ColorTranslator.FromHtml("#ace3de");
            this.btnLoad.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnLoad.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.btnLuu.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnLuu.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.txtMaGhe.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.txtMaGhe.ForeColor = ColorTranslator.FromHtml("#000000");
            this.txtTenGhe.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.txtTenGhe.ForeColor = ColorTranslator.FromHtml("#000000");
            this.cboPhongChieu.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.cboPhongChieu.ForeColor = ColorTranslator.FromHtml("#000000");
            this.cboTrangThai.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.cboTrangThai.ForeColor = ColorTranslator.FromHtml("#000000");

        }
        private void LoadComboBoxPhongChieu()
        {
            List<PhongChieuDTO> dsPhong = phongChieuDAL.selectAll();
            cboPhongChieu.DataSource = dsPhong;
            cboPhongChieu.DisplayMember = "TenPhongChieu";
            cboPhongChieu.ValueMember = "MaPhongChieu";
        }
        private void LoadComboBoxTrangThai()
        {
            List<string> trangThaiList = new List<string> { "Trống", "Đã đặt", "Bảo trì" };
            cboTrangThai.DataSource = trangThaiList;
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            string maPhong = cboPhongChieu.SelectedValue.ToString();
            List<GheDTO> danhSachGhe = gheDAL.selectByMaPhongChieu(maPhong);


            LoadSoDoGhe(danhSachGhe);
        }
        private void LoadSoDoGhe(List<GheDTO> danhSachGhe)
        {
            flowLayoutPanel1.Controls.Clear();

            // Kích thước ghế và khoảng cách
            int buttonWidth = 80;
            int buttonHeight = 100;
            int margin = 5;

            // Cấu hình số ghế mỗi hàng
            int seatsPerRow = 10;

            for (int i = 0; i < danhSachGhe.Count; i++)
            {
                GheDTO ghe = danhSachGhe[i];
                Button btnGhe = new Button();

                btnGhe.Width = buttonWidth;
                btnGhe.Height = buttonHeight;
                btnGhe.Text = ghe.ViTri;
                btnGhe.Tag = ghe;

                // Tính vị trí theo dòng và cột
                int row = i / seatsPerRow;
                int col = i % seatsPerRow;

                btnGhe.Left = col * (buttonWidth + margin);
                btnGhe.Top = row * (buttonHeight + margin);

                // Màu theo trạng thái
                switch (ghe.TrangThai)
                {
                    case "Trống":
                        btnGhe.BackColor = Color.White;
                        break;
                    case "Đã đặt":
                        btnGhe.BackColor = Color.LightGreen;
                        break;
                    case "Bảo trì":
                        btnGhe.BackColor = Color.IndianRed;
                        break;
                }

                btnGhe.Click += BtnGhe_Click;
                flowLayoutPanel1.Controls.Add(btnGhe);
            }


        }
        private void BtnGhe_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GheDTO ghe = btn.Tag as GheDTO;

            txtMaGhe.Text = ghe.MaGhe;
            txtTenGhe.Text = ghe.ViTri;
            cboTrangThai.SelectedItem = ghe.TrangThai;
        }


        private void btnGhe5_Click(object sender, EventArgs e)
        {

        }

        private void btnGhe1_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // không cho phép đổi cbo từ "Đã đặt" sang "Trống" hoặc "Bảo trì"
            // Lấy trạng thái hiện tại của ghế từ database
            var gheHienTai = gheDAL.selectById(txtMaGhe.Text);
            string trangThaiCu = gheHienTai?.TrangThai ?? "";
            string trangThaiMoi = cboTrangThai.SelectedItem.ToString();

            // Kiểm tra điều kiện không cho phép đổi
            if (trangThaiCu == "Đã đặt" && (trangThaiMoi == "Trống" || trangThaiMoi == "Bảo trì"))
            {
                MessageBox.Show("Không thể chuyển ghế từ 'Đã đặt' sang 'Trống' hoặc 'Bảo trì'!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((trangThaiCu == "Trống" || trangThaiCu == "Bảo trì") && trangThaiMoi == "Đã đặt")
            {
                MessageBox.Show("Không thể chuyển ghế từ 'Trống' hoặc 'Bảo trì' sang 'Đã đặt'!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            GheDTO ghe = new GheDTO
            {
                MaGhe = txtMaGhe.Text,
                TenGhe = txtTenGhe.Text,
                TrangThai = cboTrangThai.SelectedItem.ToString()
            };

            // Use the instance of GheDAL to call UpdateTrangThai  
            gheDAL.UpdateTrangThai(ghe);

            MessageBox.Show("Đã lưu trạng thái ghế!");

            // Tải lại giao diện ghế  
            LoadSoDoGhe(gheDAL.selectByMaPhongChieu(cboPhongChieu.SelectedValue.ToString()));
        }

        private void btnGhe1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
