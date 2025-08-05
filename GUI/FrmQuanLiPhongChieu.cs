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
using UTIL_Valication;

namespace GUI
{
    public partial class FrmQuanLiPhongChieu : Form
    {
        PhongChieuDAL dal = new PhongChieuDAL();
        public FrmQuanLiPhongChieu()
        {
            InitializeComponent();
            SetUpColors();
            SetUpDataGirdView();
            LoadData();
            LoadComboBox();

        }
        private void SetUpColors()
        {

            this.BackColor = ColorTranslator.FromHtml("#ace3de");
            this.dgvDanhSachPhongChieu.BackgroundColor = ColorTranslator.FromHtml("#FFFFFF");
            this.dgvDanhSachPhongChieu.DefaultCellStyle.SelectionForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.dgvDanhSachPhongChieu.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#000000");
            this.dgvDanhSachPhongChieu.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.btnThemVoiGhe.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnThemVoiGhe.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.btnSua.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnSua.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.btnXoa.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnXoa.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.btnLamMoi.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnLamMoi.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.txtTenPhong.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.txtTenPhong.ForeColor = ColorTranslator.FromHtml("#000000");
            this.nudSoHang.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.nudSoHang.ForeColor = ColorTranslator.FromHtml("#000000");
            this.nudSoGhe.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.nudSoGhe.ForeColor = ColorTranslator.FromHtml("#000000");
            this.cboMaRap.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.cboMaRap.ForeColor = ColorTranslator.FromHtml("#000000");





        }
        private void SetUpDataGirdView()
        {
            dgvDanhSachPhongChieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachPhongChieu.AutoGenerateColumns = true;
            dgvDanhSachPhongChieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        private void LoadComboBox()
        {
            cboMaRap.Items.Add("RAP001");


        }
        private void LoadData()
        {
            List<PhongChieuDTO> list = dal.selectAll();
            dgvDanhSachPhongChieu.DataSource = list;
            dgvDanhSachPhongChieu.Columns["MaPhongChieu"].HeaderText = "Mã Phòng";
            dgvDanhSachPhongChieu.Columns["MaRapChieu"].HeaderText = "Mã Rạp";
            dgvDanhSachPhongChieu.Columns["TenPhongChieu"].HeaderText = "Tên Phòng";
            dgvDanhSachPhongChieu.Columns["SucChua"].HeaderText = "Sức Chứa";
            list.Reverse();
        }

        private void FrmQuanLiPhongChieu_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maPhong = DBUTIL.GenerateId("PHONG_CHIEU", "MaPhongChieu", "PC");
                string tenPhong = txtTenPhong.Text.Trim();
                string maRap = "RAP001";
                int soHang = (int)nudSoHang.Value;
                int soCot = (int)nudSoGhe.Value;
                int sucChua = int.Parse(txtSucChua.Text);

                if (soHang * soCot != sucChua)
                {
                    MessageBox.Show("Sức chứa không khớp với số hàng và số ghế. Vui lòng kiểm tra lại.");
                    return;
                }
                if (string.IsNullOrEmpty(tenPhong))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                    return;
                }
                // kiểm tra sức chứa có phù hợp
                if (sucChua <= 0)
                {
                    MessageBox.Show("Sức chứa phải lớn hơn 0.");
                    return;
                }
                // kiểm tra số hàng với số ghế có phù hợp với sức chứa
                if (soHang <= 0 || soCot <= 0)
                {
                    MessageBox.Show("Số hàng và số ghế phải lớn hơn 0.");
                    return;
                }
                

                // Tạo đối tượng DTO
                PhongChieuDTO phong = new PhongChieuDTO
                {
                    MaPhongChieu = maPhong,
                    MaRapChieu = maRap,
                    TenPhongChieu = tenPhong,
                    SucChua = sucChua

                };

                // Gọi DAL thêm phòng và tạo ghế
                PhongChieuDAL dal = new PhongChieuDAL();
                dal.InsertWithSeats(phong, soHang, soCot);

                MessageBox.Show("Thêm phòng chiếu thành công kèm ghế!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phòng chiếu: " + ex.Message);
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDanhSachPhongChieu.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn phòng chiếu cần sửa.");
                    return;
                }
                // Lấy thông tin phòng chiếu từ dòng đã chọn
                DataGridViewRow selectedRow = dgvDanhSachPhongChieu.SelectedRows[0];
                string maPhong = selectedRow.Cells["MaPhongChieu"].Value.ToString();
                string tenPhong = txtTenPhong.Text.Trim();
                int soHang = (int)nudSoHang.Value;
                int soGhe = (int)nudSoGhe.Value;
                int sucChua = soHang * soGhe;
                if (string.IsNullOrEmpty(tenPhong))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                    return;
                }
                // kiểm tra sức chứa có phù hợp
                if (sucChua <= 0)
                {
                    MessageBox.Show("Sức chứa phải lớn hơn 0.");
                    return;
                }
                // kiểm tra số hàng với số ghế có phù hợp với sức chứa
                if (soHang <= 0 || soGhe <= 0)
                {
                    MessageBox.Show("Số hàng và số ghế phải lớn hơn 0.");
                    return;
                }
                if (soHang * soGhe != sucChua)
                {
                    MessageBox.Show("Sức chứa không khớp với số hàng và số ghế. Vui lòng kiểm tra lại.");
                    return;
                }

                PhongChieuDTO phong = new PhongChieuDTO
                {
                    MaRapChieu = "RAP001",
                    MaPhongChieu = maPhong,
                    TenPhongChieu = tenPhong,
                    SucChua = sucChua
                };
                // Gọi DAL để cập nhật phòng chiếu
                PhongChieuDAL dal = new PhongChieuDAL();
                dal.updateWithSeats(phong, soHang, soGhe);
                MessageBox.Show("Cập nhật phòng chiếu thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật phòng chiếu: " + ex.Message);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDanhSachPhongChieu.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn phòng chiếu cần xóa.");
                    return;
                }

                // Lấy mã phòng chiếu từ dòng đã chọn
                DataGridViewRow selectedRow = dgvDanhSachPhongChieu.SelectedRows[0];
                string maPhong = selectedRow.Cells["MaPhongChieu"].Value.ToString();
                // Gọi DAL để xóa phòng chiếu
                PhongChieuDAL dal = new PhongChieuDAL();
                dal.delete(maPhong);
                MessageBox.Show("Xóa phòng chiếu thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa phòng chiếu: " + ex.Message);
            }



        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenPhong.Clear();
            nudSoHang.Value = 1;
            nudSoGhe.Value = 1;
            txtSucChua.Clear();
            txtMaPhong.Clear();
            LoadData();
            MessageBox.Show("Đã làm mới dữ liệu!");

        }

        private void dgvDanhSachPhongChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSachPhongChieu.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvDanhSachPhongChieu.Rows[e.RowIndex];
                txtMaPhong.Text = selectedRow.Cells["MaPhongChieu"].Value.ToString();
                cboMaRap.Text = selectedRow.Cells["MaRapChieu"].Value.ToString();
                txtTenPhong.Text = selectedRow.Cells["TenPhongChieu"].Value.ToString();
                txtSucChua.Text = selectedRow.Cells["SucChua"].Value.ToString();
                // Cập nhật số hàng và số ghế từ sức chứa
                if (int.TryParse(txtSucChua.Text, out int sucChua))
                {
                    
                    int soHang = sucChua / 10;
                    int soGhe = 10; 
                    nudSoHang.Value = soHang > 0 ? soHang : 1; 
                    nudSoGhe.Value = soGhe > 0 ? soGhe : 1; 
                }




            }

        }
    }
}
