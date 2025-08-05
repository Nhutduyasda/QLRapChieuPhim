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
    public partial class ThemPhim : Form
    {
        PhimDAL phim;
        public ThemPhim()
        {
            InitializeComponent();
            phim = new PhimDAL();
            LoadCombox();
            LoadDSPhim();
            SetUpDataGirdView();
            SetUpColors();
            SetUpNumbericUpDown();

        }
        private void SetUpNumbericUpDown()
        {
            nudThoiLuong.Minimum = 30;    // Phim ngắn nhất 30 phút
            nudThoiLuong.Maximum = 300;   // Phim dài nhất 5 tiếng
            nudThoiLuong.Increment = 5;   // Mỗi lần tăng/giảm 5 phút
            nudThoiLuong.Value = 90;      // Mặc định 90 phút
        }
        public void SetUpColors()
        {
            this.BackColor = ColorTranslator.FromHtml("#ace3de");
            this.dgvDanhSachPhim.BackgroundColor = ColorTranslator.FromHtml("#FFFFFF");
            this.dgvDanhSachPhim.DefaultCellStyle.SelectionForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.dgvDanhSachPhim.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#000000");
            this.dgvDanhSachPhim.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            //Button colors
            this.btnThemPhim.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnThemPhim.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.btnCapNhat.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnCapNhat.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.btnXoa.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnXoa.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.btnLamMoi.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnLamMoi.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.txtTenPhim.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.txtTenPhim.ForeColor = ColorTranslator.FromHtml("#000000");
            this.cboTheLoai.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.cboTheLoai.ForeColor = ColorTranslator.FromHtml("#000000");
            this.cboDoTuoi.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.cboDoTuoi.ForeColor = ColorTranslator.FromHtml("#000000");
            this.cbo_TinhTrang.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.cbo_TinhTrang.ForeColor = ColorTranslator.FromHtml("#000000");
            this.txtTenPhim.BorderStyle = BorderStyle.FixedSingle;
            this.pictureBox_anhPhim.BorderStyle = BorderStyle.FixedSingle;

        }
        public void SetUpDataGirdView()
        {
            dgvDanhSachPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachPhim.AutoGenerateColumns = true;
            dgvDanhSachPhim.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachPhim.AllowUserToAddRows = false;
            
        }
        public void LoadCombox()
        {
            cboDoTuoi.Items.Clear();
            cboDoTuoi.Items.Add("13+");
            cboDoTuoi.Items.Add("16");
            cboDoTuoi.Items.Add("18+");


            cbo_TinhTrang.Items.Clear();
            cbo_TinhTrang.Items.Add("Đang Chiếu");
            cbo_TinhTrang.Items.Add("Ngừng Chiếu");

            cbo_TinhTrang.SelectedIndex = 0; 
            cboDoTuoi.SelectedIndex = 0; 
            cboDoTuoi.DropDownStyle = ComboBoxStyle.DropDownList; 
            cbo_TinhTrang.DropDownStyle = ComboBoxStyle.DropDownList; 

            cboTheLoai.Items.Clear();
            cboTheLoai.Items.Add("Hành Động");
            cboTheLoai.Items.Add("Hài Hước");
            cboTheLoai.Items.Add("Kinh Dị");
            cboTheLoai.Items.Add("Tình Cảm");
            cboTheLoai.Items.Add("Hoạt Hình");
            cboTheLoai.SelectedIndex = 0;
            cboTheLoai.DropDownStyle = ComboBoxStyle.DropDownList;


        }
        public void LoadDSPhim()
        {

            phim = new PhimDAL();
            List<DTO_Model.PhimDTO> list = phim.selectAll();
            list.Reverse();

            
            dgvDanhSachPhim.Columns.Clear();
            dgvDanhSachPhim.Rows.Clear();

            
            dgvDanhSachPhim.Columns.Add("MaPhim", "Mã phim");
            dgvDanhSachPhim.Columns.Add("TenPhim", "Tên phim");
            dgvDanhSachPhim.Columns.Add("TheLoai", "Thể loại");
            dgvDanhSachPhim.Columns.Add("TinhTrang", "Tình trạng");
            dgvDanhSachPhim.Columns.Add("ThoiLuong", "Thời lượng");
            dgvDanhSachPhim.Columns.Add("DoTuoi", "Độ tuổi");

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.Name = "AnhPhim";
            imgCol.HeaderText = "Hình ảnh";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom; // Hình ảnh vừa cell
            dgvDanhSachPhim.Columns.Add(imgCol);
            dgvDanhSachPhim.Columns["MaPhim"].Width = 110;
            dgvDanhSachPhim.Columns["TenPhim"].Width = 180;
            dgvDanhSachPhim.Columns["TheLoai"].Width = 110;
            dgvDanhSachPhim.Columns["TinhTrang"].Width = 110;
            dgvDanhSachPhim.Columns["ThoiLuong"].Width = 100;
            dgvDanhSachPhim.Columns["DoTuoi"].Width = 100;
            dgvDanhSachPhim.Columns["AnhPhim"].Width = 150; // Để ảnh to hơn
            dgvDanhSachPhim.RowTemplate.Height = 120;

            // Thêm dữ liệu
            foreach (var item in list)
            {
                Image img = null;
                if (!string.IsNullOrEmpty(item.HinhAnh) && System.IO.File.Exists(item.HinhAnh))
                {
                    img = Image.FromFile(item.HinhAnh);
                }
                // Thêm dòng mới
                dgvDanhSachPhim.Rows.Add(
                    item.MaPhim,
                    item.TenPhim,
                    item.TheLoai,
                    item.TinhTrang,
                    item.ThoiLuong,
                    item.DoTuoi,
                    img // Cell hình ảnh
                );
            }

        }

        private void ThemPhim_Load(object sender, EventArgs e)
        {


        }

        private void btnThemPhim_Click(object sender, EventArgs e)
        {
            try
            {
                // bắt lỗi chi tiết từng input
                if (string.IsNullOrWhiteSpace(txtTenPhim.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên phim.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cboTheLoai.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng nhập thể loại phim.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cbo_TinhTrang.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn tình trạng phim.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cboDoTuoi.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn độ tuổi phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(pictureBox_anhPhim.ImageLocation))
                {
                    MessageBox.Show("Vui lòng chọn hình ảnh cho phim.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                PhimDTO phimDTO = new PhimDTO
                {
                    MaPhim = phim.generateAutoMaPhim("PHIM", "MaPhim", "PHIM"),
                    TenPhim = txtTenPhim.Text,
                    TheLoai = cboTheLoai.Text,
                    TinhTrang = cbo_TinhTrang.Text,
                    ThoiLuong = nudThoiLuong.Value > 0 ? (int)nudThoiLuong.Value : 90,
                    HinhAnh = pictureBox_anhPhim.ImageLocation,
                    DoTuoi = cboDoTuoi.Text

                };
                phim.Insert(phimDTO);
                LoadDSPhim();
                ClearInputFields();
                MessageBox.Show("Thêm phim thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phim: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox_anhPhim.ImageLocation = openFileDialog.FileName;
            }


        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                // bắt lỗi chi tiết từng input
                if (string.IsNullOrWhiteSpace(txtTenPhim.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên phim.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cboTheLoai.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng nhập thể loại phim.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cbo_TinhTrang.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn tình trạng phim.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cboDoTuoi.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn độ tuổi phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dgvDanhSachPhim.SelectedRows.Count > 0)
                {
                    PhimDTO phimDTO = new PhimDTO
                    {
                        MaPhim = dgvDanhSachPhim.SelectedRows[0].Cells["MaPhim"].Value.ToString(),
                        TenPhim = txtTenPhim.Text,
                        TheLoai = cboTheLoai.Text,
                        TinhTrang = cbo_TinhTrang.Text,
                        ThoiLuong = nudThoiLuong.Value > 0 ? (int)nudThoiLuong.Value : 90,
                        HinhAnh = pictureBox_anhPhim.ImageLocation,
                        DoTuoi = cboDoTuoi.Text
                    };
                    phim.Update(phimDTO);
                    LoadDSPhim();
                    ClearInputFields();
                    MessageBox.Show("Cập nhật phim thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một phim để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật phim: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDanhSachPhim.SelectedRows.Count > 0)
                {
                    string maPhim = dgvDanhSachPhim.SelectedRows[0].Cells["MaPhim"].Value.ToString();
                    phim.Delete(maPhim);
                    LoadDSPhim();
                    ClearInputFields();
                    MessageBox.Show("Xóa phim thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một phim để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa phim: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void ClearInputFields()
        {
            txtTenPhim.Clear();
            cboTheLoai.SelectedIndex = -1;
            cbo_TinhTrang.SelectedIndex = -1;
            nudThoiLuong.Value = 90;
            pictureBox_anhPhim.ImageLocation = null;
            cboDoTuoi.SelectedIndex = -1;
        }
        private void dgvDanhSachPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSachPhim.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvDanhSachPhim.Rows[e.RowIndex];
                // Hiển thị thông tin phim vào các ô nhập liệu
                txtTenPhim.Text = selectedRow.Cells["TenPhim"].Value.ToString();
                cboTheLoai.Text = selectedRow.Cells["TheLoai"].Value.ToString();
                cbo_TinhTrang.Text = selectedRow.Cells["TinhTrang"].Value.ToString();
                if (selectedRow.Cells["ThoiLuong"].Value != null && int.TryParse(selectedRow.Cells["ThoiLuong"].Value.ToString(), out int thoiLuong))
                {
                    nudThoiLuong.Value = thoiLuong;
                }
                else
                {
                    nudThoiLuong.Value = 90;
                }
                // Nếu bạn có cột hình ảnh kiểu Image thì lấy trực tiếp
                if (selectedRow.Cells["AnhPhim"].Value != null && selectedRow.Cells["AnhPhim"].Value is Image)
                {
                    pictureBox_anhPhim.Image = (Image)selectedRow.Cells["AnhPhim"].Value;
                }
                else
                {
                    // Nếu chỉ có đường dẫn thì xử lý như sau
                    string imgPath = selectedRow.Cells["HinhAnh"].Value?.ToString();
                    if (!string.IsNullOrEmpty(imgPath) && System.IO.File.Exists(imgPath))
                    {
                        pictureBox_anhPhim.Image = Image.FromFile(imgPath);
                        pictureBox_anhPhim.ImageLocation = imgPath;
                    }
                    else
                    {
                        pictureBox_anhPhim.Image = null;
                        pictureBox_anhPhim.ImageLocation = null;
                    }
                }
                cboDoTuoi.Text = selectedRow.Cells["DoTuoi"].Value.ToString();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            LoadDSPhim();

        }

        private void dgvDanhSachPhim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
