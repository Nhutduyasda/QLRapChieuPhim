namespace GUI
{
    partial class FrmQuanLiPhongChieu
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
            lblTitle = new Label();
            label2 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            panel1 = new Panel();
            label8 = new Label();
            nudSoHang = new NumericUpDown();
            label1 = new Label();
            nudSoGhe = new NumericUpDown();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnThemVoiGhe = new Button();
            btnSua = new Button();
            label7 = new Label();
            cboMaRap = new ComboBox();
            txtSucChua = new TextBox();
            label6 = new Label();
            txtTenPhong = new TextBox();
            label5 = new Label();
            txtMaPhong = new TextBox();
            label4 = new Label();
            dgvDanhSachPhongChieu = new DataGridView();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSoGhe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachPhongChieu).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTitle.Location = new Point(402, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(196, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Quản Lí Phòng Vé";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(243, 72);
            label2.Name = "label2";
            label2.Size = new Size(85, 21);
            label2.TabIndex = 1;
            label2.Text = "Tìm kiếm:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(360, 74);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(308, 23);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(732, 70);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(108, 27);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(nudSoHang);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(nudSoGhe);
            panel1.Controls.Add(btnLamMoi);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThemVoiGhe);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cboMaRap);
            panel1.Controls.Add(txtSucChua);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtTenPhong);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtMaPhong);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 121);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1017, 204);
            panel1.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label8.Location = new Point(764, 73);
            label8.Name = "label8";
            label8.Size = new Size(90, 20);
            label8.TabIndex = 18;
            label8.Text = "Số Cột Ghế:";
            // 
            // nudSoHang
            // 
            nudSoHang.Location = new Point(877, 18);
            nudSoHang.Name = "nudSoHang";
            nudSoHang.Size = new Size(120, 23);
            nudSoHang.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(764, 18);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 16;
            label1.Text = "Số Hàng Ghế: ";
            // 
            // nudSoGhe
            // 
            nudSoGhe.Location = new Point(877, 74);
            nudSoGhe.Name = "nudSoGhe";
            nudSoGhe.Size = new Size(120, 23);
            nudSoGhe.TabIndex = 15;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(764, 146);
            btnLamMoi.Margin = new Padding(3, 2, 3, 2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(142, 33);
            btnLamMoi.TabIndex = 14;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(537, 146);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(142, 33);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThemVoiGhe
            // 
            btnThemVoiGhe.Location = new Point(73, 146);
            btnThemVoiGhe.Margin = new Padding(3, 2, 3, 2);
            btnThemVoiGhe.Name = "btnThemVoiGhe";
            btnThemVoiGhe.Size = new Size(142, 33);
            btnThemVoiGhe.TabIndex = 12;
            btnThemVoiGhe.Text = "Thêm";
            btnThemVoiGhe.UseVisualStyleBackColor = true;
            btnThemVoiGhe.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(291, 146);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(142, 33);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label7.Location = new Point(426, 17);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 10;
            label7.Text = "Mã Rạp:";
            // 
            // cboMaRap
            // 
            cboMaRap.FormattingEnabled = true;
            cboMaRap.Location = new Point(537, 14);
            cboMaRap.Margin = new Padding(3, 2, 3, 2);
            cboMaRap.Name = "cboMaRap";
            cboMaRap.Size = new Size(200, 23);
            cboMaRap.TabIndex = 9;
            // 
            // txtSucChua
            // 
            txtSucChua.Location = new Point(537, 73);
            txtSucChua.Margin = new Padding(3, 2, 3, 2);
            txtSucChua.Name = "txtSucChua";
            txtSucChua.Size = new Size(200, 23);
            txtSucChua.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.Location = new Point(426, 73);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 7;
            label6.Text = "Sức Chứa:";
            // 
            // txtTenPhong
            // 
            txtTenPhong.Location = new Point(146, 70);
            txtTenPhong.Margin = new Padding(3, 2, 3, 2);
            txtTenPhong.Name = "txtTenPhong";
            txtTenPhong.Size = new Size(200, 23);
            txtTenPhong.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(35, 70);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 5;
            label5.Text = "Tên Phòng: ";
            // 
            // txtMaPhong
            // 
            txtMaPhong.Location = new Point(146, 14);
            txtMaPhong.Margin = new Padding(3, 2, 3, 2);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.ReadOnly = true;
            txtMaPhong.Size = new Size(200, 23);
            txtMaPhong.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(35, 16);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 2;
            label4.Text = "Mã phòng: ";
            // 
            // dgvDanhSachPhongChieu
            // 
            dgvDanhSachPhongChieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachPhongChieu.Location = new Point(0, 350);
            dgvDanhSachPhongChieu.Margin = new Padding(3, 2, 3, 2);
            dgvDanhSachPhongChieu.Name = "dgvDanhSachPhongChieu";
            dgvDanhSachPhongChieu.RowHeadersWidth = 51;
            dgvDanhSachPhongChieu.Size = new Size(1017, 249);
            dgvDanhSachPhongChieu.TabIndex = 5;
            dgvDanhSachPhongChieu.CellClick += dgvDanhSachPhongChieu_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(405, 327);
            label3.Name = "label3";
            label3.Size = new Size(193, 21);
            label3.TabIndex = 6;
            label3.Text = "Danh Sách Phòng Chiếu";
            // 
            // FrmQuanLiPhongChieu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 610);
            Controls.Add(label3);
            Controls.Add(dgvDanhSachPhongChieu);
            Controls.Add(panel1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label2);
            Controls.Add(lblTitle);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmQuanLiPhongChieu";
            Text = "FrmQuanLiPhongChieu";
            Load += FrmQuanLiPhongChieu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSoGhe).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachPhongChieu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label2;
        private TextBox txtSearch;
        private Button btnSearch;
        private Panel panel1;
        private Label label7;
        private TextBox txtSucChua;
        private Label label6;
        private TextBox txtTenPhong;
        private Label label5;
        private TextBox txtMaPhong;
        private Label label4;
        private DataGridView dgvDanhSachPhongChieu;
        private Label label3;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnThemVoiGhe;
        private Button btnSua;
        private NumericUpDown nudSoGhe;
        private NumericUpDown nudSoHang;
        private Label label1;
        private Label label8;
        private ComboBox cboMaRap;
    }
}