using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTIL_Valication;

namespace GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Init();
            CheckRole();
            SetUpComponent();
            SetUpColors();
        }
        private void SetUpColors()
        {
            this.BackColor = ColorTranslator.FromHtml("#ace3de");
            this.button6.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.button7.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnBangDieuKhien.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnBaoCaoDoanhThu.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnMuaVe.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnThemNhanVien.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnThemSanPham.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.button6.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.button7.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.btnBangDieuKhien.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.btnBaoCaoDoanhThu.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.btnMuaVe.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.btnThemNhanVien.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.btnThemSanPham.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.btnQLPhongChieu.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnQLPhongChieu.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.btnQLGhe.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnQLGhe.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
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

        private void CheckRole()
        {
            if (!AuthUtil.IsLogin())
            {
                MessageBox.Show("Bạn chưa đăng nhập!");
                return;
            }

            // Các nút chung vẫn hiện
            btnMuaVe.Visible = true;
            btnBangDieuKhien.Visible = true;
            button6.Visible = true;

            if (AuthUtil.IsManager())
            {
                // Quản lý được quyền nhìn thấy và thao tác
                btnThemNhanVien.Visible = true;
                btnThemSanPham.Visible = true;
                btnBaoCaoDoanhThu.Visible = true;

                btnThemNhanVien.Enabled = true;
                btnThemSanPham.Enabled = true;
                btnBaoCaoDoanhThu.Enabled = true;
            }
            else
            {
                // Nhân viên không được nhìn thấy các chức năng quản lý
                btnThemNhanVien.Visible = false;
                btnThemSanPham.Visible = false;
                btnBaoCaoDoanhThu.Visible = false;
            }
        }
        private void Init()
        {
            frmDangNhap frmDangNhap = new frmDangNhap();
            var result = frmDangNhap.ShowDialog();

            if (result != DialogResult.OK || !AuthUtil.IsLogin())
            {
                MessageBox.Show("Bạn phải đăng nhập để sử dụng ứng dụng.");
                Application.Exit();
            }
            CheckRole();

        }

        private void SetUpComponent()
        {
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void ShowFormInPanel(Form form)
        {
            pnl_Main.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnl_Main.Controls.Add(form);
            form.Show();

        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new ThongTinNhanVien());

        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new ThemPhim());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn form Main hiện tại

            frmDangNhap frmDangNhap = new frmDangNhap();
            var result = frmDangNhap.ShowDialog();

            if (result == DialogResult.OK && AuthUtil.IsLogin())
            {
                // Đăng nhập lại thành công → hiện lại Main
                this.Show();
                CheckRole(); // Cập nhật quyền theo tài khoản mới
            }
            else
            {
                // Đăng nhập thất bại hoặc bị đóng → thoát chương trình
                Application.Exit();
            }
        }

        private void btnBangDieuKhien_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new PhimDaThem());
        }

        private void btnMuaVe_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new MuaVe());
        }

        private void btnBaoCaoDoanhThu_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmTaoSuatChieu());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmLSGD());
        }

        private void btnQLPhongChieu_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FrmQuanLiPhongChieu());

        }

        private void btnQLGhe_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new Ghe());
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Dictionary<PictureBox, string> imageMap = new Dictionary<PictureBox, string>()
            {
                { pictureBox1, "https://t3.ftcdn.net/jpg/01/25/57/92/360_F_125579217_HL9SYmJR8KzVZ5Jfddr4BPyD3QxSSHtZ.jpg" },
                { pictureBox2, "https://cdn-icons-png.flaticon.com/128/1101/1101793.png" },
                { pictureBox3, "https://cdn-icons-png.flaticon.com/128/2298/2298687.png" },
                { pictureBox4, "https://cdn-icons-png.flaticon.com/128/5520/5520204.png" },
                { pictureBox5, "https://cdn-icons-png.flaticon.com/128/2352/2352167.png" },
                { pictureBox6, "https://cdn-icons-png.flaticon.com/128/5697/5697997.png" },
                { pictureBox7, "https://cdn-icons-png.flaticon.com/128/10133/10133762.png" },
                { pictureBox8, "https://cdn-icons-png.flaticon.com/128/7886/7886492.png" },
                { pictureBox9, "https://cdn-icons-png.flaticon.com/128/115/115352.png" },
                { pictureBox10, "https://cdn-icons-png.flaticon.com/128/1286/1286853.png" },

            };

            foreach (var pair in imageMap)
            {
                LoadImageToPictureBox(pair.Key, pair.Value);
            }
        }
    }
}
