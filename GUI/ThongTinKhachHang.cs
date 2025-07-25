using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using DAL_Service;
using DTO_Model;
using UTIL_Valication;
=======
>>>>>>> 4dbe4da3c264a95b1fbc116326ee64df3a6dc462

namespace GUI
{
    public partial class ThongTinKhachHang : Form
    {
<<<<<<< HEAD
        private KhachHangDAL khachHangDAL;
        public ThongTinKhachHang()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            khachHangDAL = new KhachHangDAL();
=======
        public ThongTinKhachHang()
        {
            InitializeComponent();
>>>>>>> 4dbe4da3c264a95b1fbc116326ee64df3a6dc462
        }

        private void ThongTinKhachHang_Load(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra số điện thoại
            if (!Valication.IsValidPhoneNumber(txtSoDienThoai.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra email
            if (!Valication.IsValidGmail(txtEmail.Text))
            {
                MessageBox.Show("Email phải là Gmail hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                KhachHang khachHang = new KhachHang
                {
                    MaKhachHang = khachHangDAL.generateAutoMaKhachHang("KHACH_HANG", "MaKhachHang", "KH"),
                    TenKhachHang = txtHoTen.Text,
                    Email = txtEmail.Text,
                    SoDienThoai = txtSoDienThoai.Text

                };
                khachHangDAL.Insert(khachHang);
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm khách hàng: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

=======
    }
}
>>>>>>> 4dbe4da3c264a95b1fbc116326ee64df3a6dc462
