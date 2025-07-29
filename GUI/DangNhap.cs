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
    public partial class frmDangNhap : Form
    {
        NhanVienDAL nvDAL = new NhanVienDAL();
        public frmDangNhap()
        {
            InitializeComponent();
            SetUpColors();
        }
        public void SetUpColors()
        {
            this.BackColor = ColorTranslator.FromHtml("#ace3de");
            this.panel1.BackColor = ColorTranslator.FromHtml("#e8ebeb");
            this.btnDangNhap.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnDangNhap.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.btnThoat.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnThoat.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.chkHienThi.ForeColor = ColorTranslator.FromHtml("#000000");
            this.txtTaiKhoan.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.txtTaiKhoan.ForeColor = ColorTranslator.FromHtml("#000000");
            this.txtMatKhau.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.txtMatKhau.ForeColor = ColorTranslator.FromHtml("#000000");
            this.txtTaiKhoan.BorderStyle = BorderStyle.FixedSingle;
            this.txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            this.txtTaiKhoan.Font = new Font("Arial", 12);
            this.label1.ForeColor = ColorTranslator.FromHtml("#000000");
            this.label2.ForeColor = ColorTranslator.FromHtml("#000000");
            this.chkHienThi.Font = new Font("Arial", 10);

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string MaNhanVien = txtTaiKhoan.Text.Trim();
            string password = txtMatKhau.Text.Trim();
            NhanVienDTO nhanVien = nvDAL.selectById(MaNhanVien);
            if (nhanVien == null)
            {
                MessageBox.Show("Tài khoản không tồn tại!");

            }
            else if (!nhanVien.MatKhau.Equals(password))
            {
                MessageBox.Show("Mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AuthUtil.user = nhanVien;
                this.Dispose();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }



        private void chkHienThi_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = chkHienThi.Checked ? '\0' : '*';
        }

    }
}
