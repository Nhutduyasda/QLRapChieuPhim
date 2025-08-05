using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_Service;
using DTO_Model;
using UTIL_Valication;

namespace GUI
{
    public partial class frmTaoSuatChieu : Form
    {
        SuatChieuDAL suatChieu;
        public frmTaoSuatChieu()
        {
            InitializeComponent();
            dtpGioKetThuc.Enabled = false;
            SetUpDataGirdView();
            LoadDataGridView();
            LoadComboBoxPhim();
            LoadComBoxPhongChieu();
            SetUpColors();
            dateTimePicker_NgayChieu.Format = DateTimePickerFormat.Custom;
            dateTimePicker_NgayChieu.CustomFormat = "dd/MM";
            txtGiaVe.TextChanged += (s, e) =>
            {
                if (decimal.TryParse(txtGiaVe.Text, out decimal giaVe))
                {
                    txtGiaVe.Text = giaVe.ToString("N0");
                    txtGiaVe.SelectionStart = txtGiaVe.Text.Length; 
                }
                else
                {
                    txtGiaVe.Text = "0";
                }
            };
            txtGiaVe.TextAlign = HorizontalAlignment.Right;



        }
        public void SetUpColors()
        {
            this.BackColor = ColorTranslator.FromHtml("#ace3de");
            this.dgvSuatChieuPhim.BackgroundColor = ColorTranslator.FromHtml("#FFFFFF");
            this.dgvSuatChieuPhim.DefaultCellStyle.SelectionForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.dgvSuatChieuPhim.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#000000");
            this.dgvSuatChieuPhim.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            //Button colors
            this.btnThem.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnThem.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.btnXoa.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnXoa.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.btnSua.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnSua.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.btnLamMoi.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnLamMoi.ForeColor = ColorTranslator.FromHtml("#FFFFFF");


        }
        public string MaSuatChieu => txtMaSuatChieu.Text.Trim();

        public void SetUpDataGirdView()
        {
            dgvSuatChieuPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSuatChieuPhim.AutoGenerateColumns = true;
            dgvSuatChieuPhim.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SuatChieuDAL dal = new SuatChieuDAL();
            var list = dal.SelectViewThayDoiTrangThaiPhim();
            foreach (var suat in list)
            {
                DateTime ngayChieu;
                TimeSpan thoiGianKetThuc;

                if (DateTime.TryParse(suat.NgayChieu, out ngayChieu) && TimeSpan.TryParse(suat.ThoiGianKetThuc, out thoiGianKetThuc))
                {
                    DateTime gioKetThuc = ngayChieu.Date + thoiGianKetThuc;
                    if (DateTime.Now > gioKetThuc && suat.TinhTrang != "Ngừng chiếu")
                    {
                        suat.TinhTrang = "Ngừng chiếu";
                        dal.UpdateTinhTrang(suat.MaSuatChieu, "Ngừng chiếu");
                    }
                }
            }

            if (!dgvSuatChieuPhim.Columns.Contains("TinhTrang"))
            {
                DataGridViewTextBoxColumn tinhTrangColumn = new DataGridViewTextBoxColumn
                {
                    Name = "TinhTrang",
                    HeaderText = "Tình Trạng",
                    DataPropertyName = "TinhTrang",

                };
                dgvSuatChieuPhim.Columns.Add(tinhTrangColumn);

            }
            ;      
            dgvSuatChieuPhim.CellFormatting += (s, e) =>
            {
                if (e.ColumnIndex == dgvSuatChieuPhim.Columns["TinhTrang"].Index && e.Value != null)
                {
                    string tinhTrang = e.Value.ToString();
                    if (tinhTrang == "Ngừng chiếu")
                    {
                        e.CellStyle.BackColor = Color.LightGray;
                        e.CellStyle.ForeColor = Color.Red;
                    }
                }
            };






        }
        public void LoadDataGridView()
        {

            suatChieu = new SuatChieuDAL();
            List<ViewSuatChieu> list = suatChieu.viewSuatChieu();
            list.Reverse();
            dgvSuatChieuPhim.DataSource = null;
            dgvSuatChieuPhim.DataSource = list;
            dgvSuatChieuPhim.Columns["GiaVe"].DefaultCellStyle.Format = "N0";
            dgvSuatChieuPhim.Columns["ThoiGianBatDau"].DefaultCellStyle.Format = "hh\\:mm";
            dgvSuatChieuPhim.Columns["ThoiGianKetThuc"].DefaultCellStyle.Format = "hh\\:mm";

            dtpGioBatDau.Format = DateTimePickerFormat.Custom;
            dtpGioBatDau.CustomFormat = "HH:mm";
            dtpGioKetThuc.Format = DateTimePickerFormat.Custom;
            dtpGioKetThuc.CustomFormat = "HH:mm";



        }
        public void LoadComboBoxPhim()
        {
            PhimDAL phimDAL = new PhimDAL();
            List<PhimDTO> listPhim = phimDAL.selectAll();

            // Chỉ chọn phim đang chiếu
            var listDangChieu = listPhim.Where(p => p.TinhTrang != "Ngừng chiếu").ToList();

            cboPhim.DataSource = listDangChieu;
            cboPhim.DisplayMember = "TenPhim";
            cboPhim.ValueMember = "MaPhim";
        }
        public void LoadComBoxPhongChieu()
        {
            PhongChieuDAL phongChieuDAL = new PhongChieuDAL();
            List<PhongChieuDTO> listPhongChieu = phongChieuDAL.selectAll();
            cboPhongChieu.DataSource = listPhongChieu;
            cboPhongChieu.DisplayMember = "TenPhongChieu";
            cboPhongChieu.ValueMember = "MaPhongChieu";

        }
        public void NextForm(Form nextForm)
        {
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }
        private void btnChonPhim_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra ngày chiếu không ở quá khứ
            if (!Valication.IsValidFutureDate(dateTimePicker_NgayChieu.Value.Date))
            {
                MessageBox.Show("Ngày chiếu không được ở quá khứ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(dtpGioBatDau.Text) ||
                string.IsNullOrWhiteSpace(dtpGioKetThuc.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtGiaVe.Text) || !decimal.TryParse(txtGiaVe.Text, out decimal giaVe) || giaVe <= 0)
            {
                MessageBox.Show("Giá vé phải là số dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (dgvSuatChieuPhim.SelectedRows.Count > 0)
                {
                    SuatChieuDTO suatChieuDTO = new SuatChieuDTO
                    {
                        MaSuatChieu = dgvSuatChieuPhim.SelectedRows[0].Cells["MaSuatChieu"].Value.ToString(),
                        MaPhim = cboPhim.SelectedValue.ToString(),
                        MaPhongChieu = cboPhongChieu.SelectedValue.ToString(),
                        NgayChieu = dateTimePicker_NgayChieu.Value.Date,
                        GioBatDau = dtpGioBatDau.Value.TimeOfDay,
                        GioKetThuc = dtpGioKetThuc.Value.TimeOfDay,
                        GiaVe = decimal.Parse(txtGiaVe.Text),
                        TinhTrang = "Đang Chiếu"
                    };
                    suatChieu.Update(suatChieuDTO);
                    ClearInputFields();
                    LoadDataGridView();
                    MessageBox.Show("Cập nhật suất chiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một suất chiếu để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật suất chiếu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DateTime thoiGianBatDau = dtpGioBatDau.Value;      
            DateTime thoiGianKetThuc = dtpGioKetThuc.Value;   

            PhimDTO selectedPhim = cboPhim.SelectedItem as PhimDTO;

            if (selectedPhim == null)
            {
                MessageBox.Show("Vui lòng chọn phim!", "Thông báo");
                return;
            }

            int thoiLuongPhim = selectedPhim.ThoiLuong;




            
            int thoiLuongTinhToan = (int)(thoiGianKetThuc - thoiGianBatDau).TotalMinutes;

            if (thoiLuongTinhToan != thoiLuongPhim)
            {
                MessageBox.Show($"Thời gian bắt đầu và kết thúc không khớp với thời lượng phim!\n" +
                                $"Thời lượng phim: {thoiLuongPhim} phút\n" +
                                $"Bạn đã chọn: {thoiLuongTinhToan} phút",
                                "Lỗi logic", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (!Valication.IsValidFutureDate(dateTimePicker_NgayChieu.Value.Date))
            {
                MessageBox.Show("Ngày chiếu không được ở quá khứ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                SuatChieuDTO suatChieuDTO = new SuatChieuDTO
                {
                    MaSuatChieu = suatChieu.GenerateAutoMaSuatChieu("SUAT_CHIEU", "MaSuatChieu", "SC"),
                    MaPhim = cboPhim.SelectedValue.ToString(),
                    MaPhongChieu = cboPhongChieu.SelectedValue.ToString(),
                    NgayChieu = dateTimePicker_NgayChieu.Value.Date,
                    GioBatDau = dtpGioBatDau.Value.TimeOfDay,
                    GioKetThuc = dtpGioKetThuc.Value.TimeOfDay,
                    GiaVe = decimal.Parse(txtGiaVe.Text)


                };
                suatChieu.Insert(suatChieuDTO);
                ClearInputFields();
                LoadDataGridView();
                MessageBox.Show("Thêm suất chiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm suất chiếu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSuatChieuPhim.SelectedRows.Count > 0)
                {
                    // Lấy mã suất chiếu từ dòng được chọn
                    string maSuatChieu = dgvSuatChieuPhim.SelectedRows[0].Cells["MaSuatChieu"].Value.ToString();
                    suatChieu.Delete(maSuatChieu);
                    ClearInputFields();
                    LoadDataGridView();
                    MessageBox.Show("Xóa suất chiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một suất chiếu để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa suất chiếu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ClearInputFields()
        {
            txtMaSuatChieu.Clear();
            cboPhim.SelectedIndex = -1;
            cboPhongChieu.SelectedIndex = -1;
            dateTimePicker_NgayChieu.Value = DateTime.Now;
            dtpGioBatDau.Value = DateTime.Now;
            dtpGioKetThuc.Value = DateTime.Now.AddHours(2);
            txtGiaVe.Clear();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            LoadDataGridView();
            MessageBox.Show("Làm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dgvSuatChieuPhim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSuatChieuPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSuatChieuPhim.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvSuatChieuPhim.Rows[e.RowIndex];

                txtMaSuatChieu.Text = selectedRow.Cells["MaSuatChieu"].Value.ToString();

                string tenPhim = selectedRow.Cells["TenPhim"].Value.ToString();
                cboPhim.SelectedIndex = cboPhim.FindStringExact(tenPhim);

                string tenPhongChieu = selectedRow.Cells["TenPhongChieu"].Value.ToString();
                cboPhongChieu.SelectedIndex = cboPhongChieu.FindStringExact(tenPhongChieu);

                dateTimePicker_NgayChieu.Value = Convert.ToDateTime(selectedRow.Cells["NgayChieu"].Value);

                dtpGioBatDau.Value = DateTime.Today.Add((TimeSpan)selectedRow.Cells["ThoiGianBatDau"].Value);
                dtpGioKetThuc.Value = DateTime.Today.Add((TimeSpan)selectedRow.Cells["ThoiGianKetThuc"].Value);

                txtGiaVe.Text = selectedRow.Cells["GiaVe"].Value.ToString();
            }

        }
        private void cboPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhGioKetThuc();
        }

        private void dtpGioBatDau_ValueChanged(object sender, EventArgs e)
        {
            TinhGioKetThuc();
        }
        private void TinhGioKetThuc()
        {
            if (cboPhim.SelectedItem is PhimDTO selectedPhim)
            {
                int thoiLuong = selectedPhim.ThoiLuong;
                DateTime gioBatDau = dtpGioBatDau.Value;
                DateTime gioKetThuc = gioBatDau.AddMinutes(thoiLuong);
                dtpGioKetThuc.Value = gioKetThuc;
            }
            else
            {
                dtpGioKetThuc.Value = dtpGioBatDau.Value; 
            }
            
        }


    }
}
