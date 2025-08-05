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
    public partial class MuaVe : Form
    {
        private SuatChieuDAL suatChieu;
        public string SelectedMaSuat { get; private set; }
        public string SelectedTenPhim { get; private set; }
        public string SelectedTenPhongChieu { get; private set; }
        public string SelectedMaPhongChieu { get; private set; }
        public TimeSpan SelectedGioBatDau { get; private set; }
        public TimeSpan SelectedGioKetThuc { get; private set; }
        public MuaVe()
        {
            InitializeComponent();
            suatChieu = new SuatChieuDAL();
            SetUpDataGirdView();
            //LoadDataGridView();
            SetUpColors();

        }
        private void SetUpColors()
        {
            this.BackColor = ColorTranslator.FromHtml("#ace3de");
            this.dgvSuatChieuPhim.BackgroundColor = ColorTranslator.FromHtml("#FFFFFF");
            this.dgvSuatChieuPhim.DefaultCellStyle.SelectionForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.dgvSuatChieuPhim.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#000000");
            this.dgvSuatChieuPhim.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.btnChonPhim.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnChonPhim.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.btnHuy.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnHuy.ForeColor = ColorTranslator.FromHtml("#FFFFFF");


        }
        private void SetUpDataGirdView()
        {
            dgvSuatChieuPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSuatChieuPhim.AutoGenerateColumns = true;
            dgvSuatChieuPhim.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            SuatChieuDAL dal = new SuatChieuDAL();
            var danhSach = dal.SelectViewPhimSuatChieu();
            var list = dal.SelectViewThayDoiTrangThaiPhim();

            dgvSuatChieuPhim.Columns.Clear();
            dgvSuatChieuPhim.Rows.Clear();



            //// Tạo các cột (trừ HinhAnh)
            dgvSuatChieuPhim.Columns.Add("MaSuatChieu", "Mã Suất Chiếu");
            dgvSuatChieuPhim.Columns.Add("TenPhim", "Tên phim");
            dgvSuatChieuPhim.Columns.Add("MaPhongChieu", "Mã phòng chiếu");
            dgvSuatChieuPhim.Columns["MaPhongChieu"].Visible = false; 
            dgvSuatChieuPhim.Columns.Add("TenPhongChieu", "Tên phòng chiếu");
            dgvSuatChieuPhim.Columns.Add("TinhTrang", "Tình trạng");
            dgvSuatChieuPhim.Columns["TinhTrang"].Visible = false;
            dgvSuatChieuPhim.Columns.Add("GiaVe", "Giá vé");

            //// Thêm cột hình ảnh kiểu hình ảnh
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.Name = "AnhPhim";
            imgCol.HeaderText = "Hình ảnh";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;

            dgvSuatChieuPhim.Columns.Add(imgCol);

            dgvSuatChieuPhim.Columns["MaSuatChieu"].Width = 110;
            dgvSuatChieuPhim.Columns["TenPhim"].Width = 180;
            dgvSuatChieuPhim.Columns["TenPhongChieu"].Width = 180;
            dgvSuatChieuPhim.Columns["TinhTrang"].Width = 110;
            dgvSuatChieuPhim.Columns["GiaVe"].Width = 100;
            dgvSuatChieuPhim.Columns["AnhPhim"].Width = 150; // Để ảnh to hơn
            dgvSuatChieuPhim.RowTemplate.Height = 120;
            foreach (var item in danhSach)
            {
                // Lấy thông tin suất chiếu từ database
                var sc = suatChieu.selectByMa(item.MaSuatChieu);
                if (sc == null)
                    continue;

                // Thời gian kết thúc thực tế của suất chiếu
                DateTime thoiGianKetThuc = sc.NgayChieu.Date + sc.GioKetThuc;

                // Nếu suất chiếu đã kết thúc thì bỏ qua
                if (DateTime.Now > thoiGianKetThuc)
                    continue;

                Image img = null;
                if (!string.IsNullOrEmpty(item.HinhAnh) && System.IO.File.Exists(item.HinhAnh))
                {
                    img = Image.FromFile(item.HinhAnh);
                }
                // kiểm tra tình trạng phim
                string tinhTrang = "Đang chiếu";
                if (list.Any(x => x.MaSuatChieu == item.MaSuatChieu && x.TinhTrang == "Ngừng chiếu"))
                {
                    tinhTrang = "Ngừng chiếu";
                }
                if (tinhTrang == "Ngừng chiếu")
                {
                    continue;
                }
                dgvSuatChieuPhim.Rows.Add(
                    item.MaSuatChieu,
                    item.TenPhim,
                    item.MaPhongChieu,
                    item.TenPhongChieu,
                    item.TinhTrang,
                    item.GiaVe,
                    img
                );
            }
            // Thêm các dòng trạng thái phim
            dgvSuatChieuPhim.AllowUserToAddRows = false;
        }
        public void LoadDataGridView()
        {
            //suatChieu = new SuatChieuDAL();
            //List<DTO_Model.SuatChieuDTO> list = suatChieu.selectAll();
            //dgvSuatChieuPhim.Columns.Clear();
            //dgvSuatChieuPhim.Rows.Clear();


        }

        private void dgvSuatChieuPhim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnChonPhim_Click(object sender, EventArgs e)
        {
            
            if (dgvSuatChieuPhim.CurrentRow != null)
            {
                string maSuat = dgvSuatChieuPhim.CurrentRow.Cells["MaSuatChieu"].Value.ToString();
                string tenPhim = dgvSuatChieuPhim.CurrentRow.Cells["TenPhim"].Value.ToString();
                string tenPhongChieu = dgvSuatChieuPhim.CurrentRow.Cells["TenPhongChieu"].Value.ToString();
                string maPhongChieu = dgvSuatChieuPhim.CurrentRow.Cells["MaPhongChieu"].Value.ToString();
                SuatChieuDTO sc = suatChieu.selectByMa(maSuat);
                if (sc == null)
                {
                    MessageBox.Show("Không lấy được thời gian suất chiếu!", "Lỗi");
                    return;
                }
                TimeSpan gioBatDau = sc.GioBatDau;
                TimeSpan gioKetThuc = sc.GioKetThuc;





                // Lấy form Main (cha chứa panel)
                Main mainForm = (Main)(this.MdiParent ?? this.TopLevelControl);

                // Ẩn form Main
                mainForm.Hide();

                // Mở form DatVe
                FrmDatVe frm = new FrmDatVe(maSuat, tenPhim, tenPhongChieu, maPhongChieu,gioBatDau,gioKetThuc);

                frm.StartPosition = FormStartPosition.CenterScreen;

                // Khi FrmDatVe đóng thì hiện lại form Main và load lại MuaVe
                frm.FormClosed += (s, args) =>
                {
                    mainForm.Show();

                    // Gọi hàm load lại MuaVe nếu cần (tùy bạn)
                    // ((Main)mainForm).LoadMuaVe(); 
                };

                frm.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn suất chiếu!", "Thông báo");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // bỏ chọn trên DataGridView
            if (dgvSuatChieuPhim.CurrentRow != null)
            {
                dgvSuatChieuPhim.ClearSelection();
                SelectedMaSuat = string.Empty;
                SelectedTenPhim = string.Empty;
                SelectedTenPhongChieu = string.Empty;
            }
            else
            {
                MessageBox.Show("Không có suất chiếu nào được chọn để hủy!", "Thông báo");
            }

        }
    }
}
