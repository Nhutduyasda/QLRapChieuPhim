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

namespace GUI
{
    public partial class frmMuaVe : Form
    {
        PhimDAL phim;
        public frmMuaVe()
        {
            InitializeComponent();
            SetUpDataGirdView();
            LoadDataGridView();

        }

        public void SetUpDataGirdView()
        {
            dgvPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhim.AutoGenerateColumns = true;
            dgvPhim.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public void LoadDataGridView()
        {
            phim = new PhimDAL();
            List<DTO_Model.PhimDTO> list = phim.selectAll();
            dgvPhim.DataSource = null;
            dgvPhim.DataSource = list;
            if (list.Count > 0 && list != null)
            {
                dgvPhim.DataSource = list;

            }
        }
        public void NextForm(Form nextForm)
        {
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }
        private void btnChonPhim_Click(object sender, EventArgs e)
        {
            NextForm(new FrmDatVe());
        }

        private void dgvPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvPhim.Rows.Count)
            {
                DataGridViewRow row = dgvPhim.Rows[e.RowIndex];
                txtMaPhim.Text = row.Cells["MaPhim"].Value.ToString();
                txtTenPhim.Text = row.Cells["TenPhim"].Value.ToString();
                txtTheLoai.Text = row.Cells["TheLoai"].Value.ToString();
                txtThoiLuong.Text = row.Cells["ThoiLuong"].Value.ToString();
                pictureBox_Phim.ImageLocation = row.Cells["HinhAnh"].Value.ToString();
                txtTinhTrang.Text = row.Cells["TinhTrang"].Value.ToString();
                txtDoTuoi.Text = row.Cells["DoTuoi"].Value.ToString();

            }

        }
    }
}
