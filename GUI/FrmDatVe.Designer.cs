namespace GUI
{
    partial class FrmDatVe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            label11 = new Label();
            label10 = new Label();
            button50 = new Button();
            button51 = new Button();
            panel1 = new Panel();
            lblDanhSachGheDaChon = new Label();
            lblTenPhim = new Label();
            lblSuatChieu = new Label();
            lblPhongChieu = new Label();
            txtTongTienVe = new TextBox();
            lblTime = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTieuDe.ForeColor = Color.DarkGreen;
            lblTieuDe.Location = new Point(319, 9);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(125, 41);
            lblTieuDe.TabIndex = 1;
            lblTieuDe.Text = "Tiêu Đề";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label11.ForeColor = Color.DarkGreen;
            label11.Location = new Point(74, 310);
            label11.Name = "label11";
            label11.Size = new Size(218, 40);
            label11.TabIndex = 0;
            label11.Text = "THANH TOÁN ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(37, 382);
            label10.Name = "label10";
            label10.Size = new Size(103, 25);
            label10.TabIndex = 2;
            label10.Text = "Tổng tiền:";
            // 
            // button50
            // 
            button50.BackColor = Color.DarkGreen;
            button50.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button50.ForeColor = Color.White;
            button50.Location = new Point(76, 511);
            button50.Margin = new Padding(3, 2, 3, 2);
            button50.Name = "button50";
            button50.Size = new Size(216, 38);
            button50.TabIndex = 55;
            button50.Text = "Xóa";
            button50.UseVisualStyleBackColor = false;
            button50.Click += button50_Click;
            // 
            // button51
            // 
            button51.BackColor = Color.DarkGreen;
            button51.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button51.ForeColor = Color.White;
            button51.Location = new Point(76, 448);
            button51.Margin = new Padding(3, 2, 3, 2);
            button51.Name = "button51";
            button51.Size = new Size(216, 38);
            button51.TabIndex = 56;
            button51.Text = "Mua";
            button51.UseVisualStyleBackColor = false;
            button51.Click += button51_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblDanhSachGheDaChon);
            panel1.Controls.Add(lblTenPhim);
            panel1.Controls.Add(lblSuatChieu);
            panel1.Controls.Add(lblPhongChieu);
            panel1.Controls.Add(txtTongTienVe);
            panel1.Controls.Add(button50);
            panel1.Controls.Add(button51);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Location = new Point(852, 44);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 571);
            panel1.TabIndex = 53;
            // 
            // lblDanhSachGheDaChon
            // 
            lblDanhSachGheDaChon.AutoSize = true;
            lblDanhSachGheDaChon.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblDanhSachGheDaChon.ForeColor = Color.DarkGreen;
            lblDanhSachGheDaChon.Location = new Point(37, 208);
            lblDanhSachGheDaChon.Name = "lblDanhSachGheDaChon";
            lblDanhSachGheDaChon.Size = new Size(154, 25);
            lblDanhSachGheDaChon.TabIndex = 62;
            lblDanhSachGheDaChon.Text = "Số ghế đã chọn:";
            // 
            // lblTenPhim
            // 
            lblTenPhim.AutoSize = true;
            lblTenPhim.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTenPhim.ForeColor = Color.DarkGreen;
            lblTenPhim.Location = new Point(37, 135);
            lblTenPhim.Name = "lblTenPhim";
            lblTenPhim.Size = new Size(79, 25);
            lblTenPhim.TabIndex = 60;
            lblTenPhim.Text = "Tiêu Đề";
            // 
            // lblSuatChieu
            // 
            lblSuatChieu.AutoSize = true;
            lblSuatChieu.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblSuatChieu.ForeColor = Color.DarkGreen;
            lblSuatChieu.Location = new Point(37, 19);
            lblSuatChieu.Name = "lblSuatChieu";
            lblSuatChieu.Size = new Size(79, 25);
            lblSuatChieu.TabIndex = 59;
            lblSuatChieu.Text = "Tiêu Đề";
            // 
            // lblPhongChieu
            // 
            lblPhongChieu.AutoSize = true;
            lblPhongChieu.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblPhongChieu.ForeColor = Color.DarkGreen;
            lblPhongChieu.Location = new Point(37, 75);
            lblPhongChieu.Name = "lblPhongChieu";
            lblPhongChieu.Size = new Size(79, 25);
            lblPhongChieu.TabIndex = 54;
            lblPhongChieu.Text = "Tiêu Đề";
            // 
            // txtTongTienVe
            // 
            txtTongTienVe.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTongTienVe.Location = new Point(146, 379);
            txtTongTienVe.Margin = new Padding(3, 2, 3, 2);
            txtTongTienVe.Name = "txtTongTienVe";
            txtTongTienVe.Size = new Size(177, 32);
            txtTongTienVe.TabIndex = 58;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTime.ForeColor = Color.DarkGreen;
            lblTime.Location = new Point(10, 20);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(59, 19);
            lblTime.TabIndex = 61;
            lblTime.Text = "Tiêu Đề";
            // 
            // FrmDatVe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 623);
            Controls.Add(lblTime);
            Controls.Add(panel1);
            Controls.Add(lblTieuDe);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmDatVe";
            Text = "FrmDatVe";
            Load += FrmDatVe_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Label label11;
        private Label label10;
        private Button button50;
        private Button button51;
        private Panel panel1;
        private TextBox txtTongTienVe;
        private Label lblPhongChieu;
        private Label lblTenPhim;
        private Label lblSuatChieu;
        private Label lblTime;
        private Label lblDanhSachGheDaChon;
    }
}