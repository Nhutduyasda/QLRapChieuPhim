using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class frmwelcome : Form
    {
        public frmwelcome()
        {
            InitializeComponent();
            // Cấu hình kiểu cho thanh progress bar
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.MarqueeAnimationSpeed = 30;
            // Thực hiện thao tác load chờ 3 giây
            Task.Delay(3000).ContinueWith(t =>
            {
                Invoke(new Action(() =>
                {
                    this.Dispose();
                }));
            });
        }

        private void Welcome_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ngăn chặn người dùng ngắt ứng dụng
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

    }
}
