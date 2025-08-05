namespace GUI
{
    partial class frmLSGD
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
            txtTongTien = new TextBox();
            label7 = new Label();
            txtMaGD = new TextBox();
            label6 = new Label();
            dgvLichSuGiaoDich = new DataGridView();
            label5 = new Label();
            txtTenNhanVien = new TextBox();
            txtKhachHang = new TextBox();
            btnLamMoi = new Button();
            lblEmail = new Label();
            label2 = new Label();
            label1 = new Label();
            txtThoiGianDatVe = new TextBox();
            label3 = new Label();
            txtTenPhongChieu = new TextBox();
            label4 = new Label();
            txtMaSuatChieu = new TextBox();
            label8 = new Label();
            txtTenPhim = new TextBox();
            label9 = new Label();
            txtMaGhe = new TextBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLichSuGiaoDich).BeginInit();
            SuspendLayout();
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(49, 409);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(241, 27);
            txtTongTien.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label7.Location = new Point(47, 260);
            label7.Name = "label7";
            label7.Size = new Size(124, 23);
            label7.TabIndex = 35;
            label7.Text = "Tên Nhân Viên";
            // 
            // txtMaGD
            // 
            txtMaGD.Location = new Point(49, 163);
            txtMaGD.Name = "txtMaGD";
            txtMaGD.ReadOnly = true;
            txtMaGD.Size = new Size(241, 27);
            txtMaGD.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.Location = new Point(48, 137);
            label6.Name = "label6";
            label6.Size = new Size(117, 23);
            label6.TabIndex = 32;
            label6.Text = "Mã Giao Dịch";
            // 
            // dgvLichSuGiaoDich
            // 
            dgvLichSuGiaoDich.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichSuGiaoDich.Location = new Point(334, 77);
            dgvLichSuGiaoDich.Name = "dgvLichSuGiaoDich";
            dgvLichSuGiaoDich.RowHeadersWidth = 51;
            dgvLichSuGiaoDich.Size = new Size(805, 617);
            dgvLichSuGiaoDich.TabIndex = 31;
            dgvLichSuGiaoDich.CellClick += dgvLichSuGiaoDich_CellClick;
            dgvLichSuGiaoDich.CellContentClick += dgvDanhSachKH_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(334, 47);
            label5.Name = "label5";
            label5.Size = new Size(178, 28);
            label5.TabIndex = 30;
            label5.Text = "Lịch Sử Giao Dịch";
            label5.Click += label5_Click;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(48, 287);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.ReadOnly = true;
            txtTenNhanVien.Size = new Size(241, 27);
            txtTenNhanVien.TabIndex = 29;
            // 
            // txtKhachHang
            // 
            txtKhachHang.Location = new Point(47, 227);
            txtKhachHang.Name = "txtKhachHang";
            txtKhachHang.ReadOnly = true;
            txtKhachHang.Size = new Size(241, 27);
            txtKhachHang.TabIndex = 28;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(0, 192, 0);
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(69, 721);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(171, 44);
            btnLamMoi.TabIndex = 25;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblEmail.Location = new Point(49, 381);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(90, 23);
            lblEmail.TabIndex = 22;
            lblEmail.Text = "Tổng TIền";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(47, 200);
            label2.Name = "label2";
            label2.Size = new Size(138, 23);
            label2.TabIndex = 21;
            label2.Text = "Tên Khách Hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(38, 47);
            label1.Name = "label1";
            label1.Size = new Size(114, 28);
            label1.TabIndex = 20;
            label1.Text = "Thông Tin ";
            // 
            // txtThoiGianDatVe
            // 
            txtThoiGianDatVe.Location = new Point(49, 348);
            txtThoiGianDatVe.Name = "txtThoiGianDatVe";
            txtThoiGianDatVe.ReadOnly = true;
            txtThoiGianDatVe.Size = new Size(241, 27);
            txtThoiGianDatVe.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(47, 443);
            label3.Name = "label3";
            label3.Size = new Size(126, 23);
            label3.TabIndex = 37;
            label3.Text = "Mã Suất Chiếu";
            // 
            // txtTenPhongChieu
            // 
            txtTenPhongChieu.Location = new Point(47, 532);
            txtTenPhongChieu.Name = "txtTenPhongChieu";
            txtTenPhongChieu.ReadOnly = true;
            txtTenPhongChieu.Size = new Size(241, 27);
            txtTenPhongChieu.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(49, 504);
            label4.Name = "label4";
            label4.Size = new Size(143, 23);
            label4.TabIndex = 39;
            label4.Text = "Tên Phòng Chiếu";
            // 
            // txtMaSuatChieu
            // 
            txtMaSuatChieu.Location = new Point(49, 471);
            txtMaSuatChieu.Name = "txtMaSuatChieu";
            txtMaSuatChieu.ReadOnly = true;
            txtMaSuatChieu.Size = new Size(241, 27);
            txtMaSuatChieu.TabIndex = 42;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label8.Location = new Point(49, 320);
            label8.Name = "label8";
            label8.Size = new Size(145, 23);
            label8.TabIndex = 41;
            label8.Text = "Thời Gian Đặt Vé";
            // 
            // txtTenPhim
            // 
            txtTenPhim.Location = new Point(49, 592);
            txtTenPhim.Name = "txtTenPhim";
            txtTenPhim.ReadOnly = true;
            txtTenPhim.Size = new Size(241, 27);
            txtTenPhim.TabIndex = 44;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label9.Location = new Point(49, 565);
            label9.Name = "label9";
            label9.Size = new Size(83, 23);
            label9.TabIndex = 43;
            label9.Text = "Tên Phim";
            // 
            // txtMaGhe
            // 
            txtMaGhe.Location = new Point(49, 652);
            txtMaGhe.Name = "txtMaGhe";
            txtMaGhe.ReadOnly = true;
            txtMaGhe.Size = new Size(241, 27);
            txtMaGhe.TabIndex = 46;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label10.Location = new Point(49, 625);
            label10.Name = "label10";
            label10.Size = new Size(71, 23);
            label10.TabIndex = 45;
            label10.Text = "Mã Ghế";
            // 
            // frmLSGD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 837);
            Controls.Add(txtMaGhe);
            Controls.Add(label10);
            Controls.Add(txtTenPhim);
            Controls.Add(label9);
            Controls.Add(txtMaSuatChieu);
            Controls.Add(label8);
            Controls.Add(txtTenPhongChieu);
            Controls.Add(label4);
            Controls.Add(txtThoiGianDatVe);
            Controls.Add(label3);
            Controls.Add(txtTongTien);
            Controls.Add(label7);
            Controls.Add(txtMaGD);
            Controls.Add(label6);
            Controls.Add(dgvLichSuGiaoDich);
            Controls.Add(label5);
            Controls.Add(txtTenNhanVien);
            Controls.Add(txtKhachHang);
            Controls.Add(btnLamMoi);
            Controls.Add(lblEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLSGD";
            Text = "frmKhachHang";
            ((System.ComponentModel.ISupportInitialize)dgvLichSuGiaoDich).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtTongTien;
        private Label label7;
        private TextBox txtMaGD;
        private Label label6;
        private DataGridView dgvLichSuGiaoDich;
        private Label label5;
        private TextBox txtTenNhanVien;
        private TextBox txtKhachHang;
        private Button btnLamMoi;
        private Label lblEmail;
        private Label label2;
        private Label label1;
        private TextBox txtThoiGianDatVe;
        private Label label3;
        private TextBox txtTenPhongChieu;
        private Label label4;
        private TextBox txtMaSuatChieu;
        private Label label8;
        private TextBox txtTenPhim;
        private Label label9;
        private TextBox txtMaGhe;
        private Label label10;
    }
}