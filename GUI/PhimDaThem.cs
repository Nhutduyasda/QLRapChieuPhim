using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_Service;
using DTO_Model;

namespace GUI
{
    public partial class PhimDaThem : Form
    {

        PhimDAL phimDAL;

        public PhimDaThem()
        {
            InitializeComponent();
            SetUpComponent();
            phimDAL = new PhimDAL();
            SetUpColors();
            LoadDanhSachPhim();
            SetUpDataGirdView();

        }
        private void SetUpDataGirdView()
        {
            dgvDSPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSPhim.AutoGenerateColumns = true;
            dgvDSPhim.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSPhim.AllowUserToAddRows = false;
        }
        private void LoadDanhSachPhim()
        {


            phimDAL = new PhimDAL();
            List<DTO_Model.PhimDTO> list = phimDAL.selectAll();
            list.Reverse();

            // Xóa dữ liệu và cột cũ
            dgvDSPhim.Columns.Clear();
            dgvDSPhim.Rows.Clear();

            // Tạo các cột (trừ HinhAnh)
            dgvDSPhim.Columns.Add("MaPhim", "Mã phim");
            dgvDSPhim.Columns.Add("TenPhim", "Tên phim");
            dgvDSPhim.Columns.Add("TheLoai", "Thể loại");
            dgvDSPhim.Columns.Add("TinhTrang", "Tình trạng");
            dgvDSPhim.Columns.Add("ThoiLuong", "Thời lượng ( Phút )");
            dgvDSPhim.Columns.Add("DoTuoi", "Độ tuổi");

            // Thêm cột hình ảnh kiểu hình ảnh
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.Name = "AnhPhim";
            imgCol.HeaderText = "Hình ảnh";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom; 
            dgvDSPhim.Columns.Add(imgCol);
            dgvDSPhim.Columns["MaPhim"].Width = 110;
            dgvDSPhim.Columns["TenPhim"].Width = 180;
            dgvDSPhim.Columns["TheLoai"].Width = 110;
            dgvDSPhim.Columns["TinhTrang"].Width = 110;
            dgvDSPhim.Columns["ThoiLuong"].Width = 100;
            dgvDSPhim.Columns["DoTuoi"].Width = 100;
            dgvDSPhim.Columns["AnhPhim"].Width = 150; // Để ảnh to hơn
            dgvDSPhim.RowTemplate.Height = 120;

            // Thêm dữ liệu
            foreach (var item in list)
            {
                Image img = null;
                if (!string.IsNullOrEmpty(item.HinhAnh) && System.IO.File.Exists(item.HinhAnh))
                {
                    img = Image.FromFile(item.HinhAnh);
                }
                // Thêm dòng mới
                dgvDSPhim.Rows.Add(
                    item.MaPhim,
                    item.TenPhim,
                    item.TheLoai,
                    item.TinhTrang,
                    item.ThoiLuong,
                    item.DoTuoi,
                    img // Cell hình ảnh
                );
            }
            // Cập nhật số lượng phim đang chiếu
            DemSoPhimDangChieu();
            // Cập nhật số lượng nhân viên
            DemSoNhanVien();
            // Hiển thị ngày giờ hiện tại
            ShowDateTime();

        }
        private void LoadImageToPictureBox(PictureBox pictureBox, string url)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    byte[] imageData = client.DownloadData(url);
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox.Image = Image.FromStream(ms);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải ảnh cho control: " + ex.Message);
            }
        }
        private void DemSoNhanVien()
        {

            NhanVienDAL nhanVienDAL = new NhanVienDAL();
            int count = nhanVienDAL.selectAll().Count;
            lblEmp.Text = count.ToString();
            // Đặt định dạng cho nhãn
            lblEmp.Font = new Font("Arial", 12, FontStyle.Bold);
            lblEmp.ForeColor = Color.Black;
            lblNV.Font = new Font("Arial", 12, FontStyle.Bold);
            lblNV.ForeColor = Color.Black;

        }
        private void ShowDateTime()
        {

            lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            // Đặt định dạng cho nhãn
            lblDateTime.Font = new Font("Arial", 12, FontStyle.Bold);
            lblDateTime.ForeColor = Color.Black;
            lblNgay.Font = new Font("Arial", 12, FontStyle.Bold);
            lblNgay.ForeColor = Color.Black;
;

        }

        private void DemSoPhimDangChieu()
        {

            int count = dgvDSPhim.Rows
                .Cast<DataGridViewRow>()
                .Count(row => row.Cells["TinhTrang"].Value?.ToString() == "Đang Chiếu");

            lblNumber.Text = count.ToString();
            // Đặt định dạng cho nhãn
            lblNumber.Font = new Font("Arial", 12, FontStyle.Bold);
            lblNumber.ForeColor = Color.Black;
            lblName.Font = new Font("Arial", 12, FontStyle.Bold);
            lblName.ForeColor = Color.Black;

        }

        private void SetUpColors()
        {
            this.BackColor = ColorTranslator.FromHtml("#ace3de");
            this.dgvDSPhim.BackgroundColor = ColorTranslator.FromHtml("#FFFFFF");
            this.dgvDSPhim.DefaultCellStyle.SelectionForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.dgvDSPhim.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#000000");
            this.dgvDSPhim.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.panel1.BackColor = ColorTranslator.FromHtml("#81C784");
            this.panel2.BackColor = ColorTranslator.FromHtml("#81C784");
            this.panel3.BackColor = ColorTranslator.FromHtml("#81C784");
        }
        private void SetUpComponent()
        {
            StartPosition = FormStartPosition.CenterScreen;
            dgvDSPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSPhim.AutoGenerateColumns = true;
            dgvDSPhim.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void PhimDaThem_Load(object sender, EventArgs e)
        {
            LoadDanhSachPhim();
        }


        private void PhimDaThem_Load_1(object sender, EventArgs e)
        {
            LoadDanhSachPhim();
            Dictionary<PictureBox, string> imageMap = new Dictionary<PictureBox, string>()
            {
                { pictureBox1, "https://cdn-icons-png.flaticon.com/128/686/686458.png" },
                { pictureBox2, "https://cdn-icons-png.flaticon.com/128/2352/2352167.png" },
                
            };

            foreach (var pair in imageMap)
            {
                LoadImageToPictureBox(pair.Key, pair.Value);
            }
        }
    }
}
