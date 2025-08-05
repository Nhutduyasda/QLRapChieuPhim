namespace GUI
{
    partial class frmTaoSuatChieu
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
            label1 = new Label();
            label2 = new Label();
            dgvSuatChieuPhim = new DataGridView();
            txtMaSuatChieu = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label8 = new Label();
            btnXoa = new Button();
            txtGiaVe = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label6 = new Label();
            label7 = new Label();
            dateTimePicker_NgayChieu = new DateTimePicker();
            btnThem = new Button();
            btnSua = new Button();
            btnLamMoi = new Button();
            cboPhim = new ComboBox();
            cboPhongChieu = new ComboBox();
            dtpGioBatDau = new DateTimePicker();
            dtpGioKetThuc = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvSuatChieuPhim).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(10, 27);
            label1.Name = "label1";
            label1.Size = new Size(184, 32);
            label1.TabIndex = 0;
            label1.Text = "Tạo Suất Chiếu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(10, 70);
            label2.Name = "label2";
            label2.Size = new Size(161, 21);
            label2.TabIndex = 1;
            label2.Text = "Suất Chiếu Đang Có";
            // 
            // dgvSuatChieuPhim
            // 
            dgvSuatChieuPhim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuatChieuPhim.Location = new Point(10, 93);
            dgvSuatChieuPhim.Margin = new Padding(3, 2, 3, 2);
            dgvSuatChieuPhim.Name = "dgvSuatChieuPhim";
            dgvSuatChieuPhim.RowHeadersWidth = 51;
            dgvSuatChieuPhim.Size = new Size(998, 197);
            dgvSuatChieuPhim.TabIndex = 2;
            dgvSuatChieuPhim.CellClick += dgvSuatChieuPhim_CellClick;
            dgvSuatChieuPhim.CellContentClick += dgvSuatChieuPhim_CellContentClick;
            // 
            // txtMaSuatChieu
            // 
            txtMaSuatChieu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMaSuatChieu.Location = new Point(139, 314);
            txtMaSuatChieu.Margin = new Padding(3, 2, 3, 2);
            txtMaSuatChieu.Name = "txtMaSuatChieu";
            txtMaSuatChieu.ReadOnly = true;
            txtMaSuatChieu.Size = new Size(174, 29);
            txtMaSuatChieu.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(352, 320);
            label4.Name = "label4";
            label4.Size = new Size(85, 21);
            label4.TabIndex = 6;
            label4.Text = "Tên phim:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(348, 376);
            label5.Name = "label5";
            label5.Size = new Size(74, 21);
            label5.TabIndex = 8;
            label5.Text = "Bắt Đầu:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label8.Location = new Point(662, 374);
            label8.Name = "label8";
            label8.Size = new Size(80, 21);
            label8.TabIndex = 14;
            label8.Text = "Kết Thúc:";
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnXoa.Location = new Point(575, 489);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(138, 37);
            btnXoa.TabIndex = 20;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtGiaVe
            // 
            txtGiaVe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtGiaVe.Location = new Point(461, 422);
            txtGiaVe.Margin = new Padding(3, 2, 3, 2);
            txtGiaVe.Name = "txtGiaVe";
            txtGiaVe.Size = new Size(174, 29);
            txtGiaVe.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label9.Location = new Point(352, 426);
            label9.Name = "label9";
            label9.Size = new Size(62, 21);
            label9.TabIndex = 24;
            label9.Text = "Giá Vé:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label10.Location = new Point(662, 316);
            label10.Name = "label10";
            label10.Size = new Size(143, 21);
            label10.TabIndex = 22;
            label10.Text = "Tên Phòng Chiếu:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.Location = new Point(26, 374);
            label6.Name = "label6";
            label6.Size = new Size(103, 21);
            label6.TabIndex = 28;
            label6.Text = "Ngày Chiếu:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label7.Location = new Point(26, 314);
            label7.Name = "label7";
            label7.Size = new Size(61, 21);
            label7.TabIndex = 27;
            label7.Text = "Mã SC:";
            // 
            // dateTimePicker_NgayChieu
            // 
            dateTimePicker_NgayChieu.Location = new Point(139, 377);
            dateTimePicker_NgayChieu.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker_NgayChieu.Name = "dateTimePicker_NgayChieu";
            dateTimePicker_NgayChieu.Size = new Size(174, 23);
            dateTimePicker_NgayChieu.TabIndex = 31;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnThem.Location = new Point(105, 489);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(135, 37);
            btnThem.TabIndex = 32;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSua.Location = new Point(344, 489);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(135, 37);
            btnSua.TabIndex = 33;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += button1_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnLamMoi.Location = new Point(803, 489);
            btnLamMoi.Margin = new Padding(3, 2, 3, 2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(142, 37);
            btnLamMoi.TabIndex = 34;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // cboPhim
            // 
            cboPhim.FormattingEnabled = true;
            cboPhim.Location = new Point(461, 320);
            cboPhim.Margin = new Padding(3, 2, 3, 2);
            cboPhim.Name = "cboPhim";
            cboPhim.Size = new Size(174, 23);
            cboPhim.TabIndex = 35;
            cboPhim.SelectedIndexChanged += cboPhim_SelectedIndexChanged;
            // 
            // cboPhongChieu
            // 
            cboPhongChieu.FormattingEnabled = true;
            cboPhongChieu.Location = new Point(820, 316);
            cboPhongChieu.Margin = new Padding(3, 2, 3, 2);
            cboPhongChieu.Name = "cboPhongChieu";
            cboPhongChieu.Size = new Size(174, 23);
            cboPhongChieu.TabIndex = 36;
            // 
            // dtpGioBatDau
            // 
            dtpGioBatDau.Format = DateTimePickerFormat.Time;
            dtpGioBatDau.Location = new Point(461, 375);
            dtpGioBatDau.Name = "dtpGioBatDau";
            dtpGioBatDau.ShowUpDown = true;
            dtpGioBatDau.Size = new Size(174, 23);
            dtpGioBatDau.TabIndex = 41;
            dtpGioBatDau.ValueChanged += dtpGioBatDau_ValueChanged;
            // 
            // dtpGioKetThuc
            // 
            dtpGioKetThuc.Format = DateTimePickerFormat.Time;
            dtpGioKetThuc.Location = new Point(817, 372);
            dtpGioKetThuc.Name = "dtpGioKetThuc";
            dtpGioKetThuc.ShowUpDown = true;
            dtpGioKetThuc.Size = new Size(174, 23);
            dtpGioKetThuc.TabIndex = 42;
            // 
            // frmTaoSuatChieu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 537);
            Controls.Add(dtpGioKetThuc);
            Controls.Add(dtpGioBatDau);
            Controls.Add(cboPhongChieu);
            Controls.Add(cboPhim);
            Controls.Add(btnLamMoi);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dateTimePicker_NgayChieu);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtGiaVe);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(btnXoa);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtMaSuatChieu);
            Controls.Add(dgvSuatChieuPhim);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmTaoSuatChieu";
            Text = "v";
            ((System.ComponentModel.ISupportInitialize)dgvSuatChieuPhim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dgvSuatChieuPhim;
        private TextBox txtMaSuatChieu;
        private TextBox txtTenSuatChieu;
        private Label label4;
        private Label label5;
        private TextBox txtDoTuoi;
        private Label label8;
        private Button btnXoa;
        private TextBox txtGiaVe;
        private Label label9;
        private Label label10;
        private Label label6;
        private Label label7;
        private DateTimePicker dateTimePicker_NgayChieu;
        private Button btnThem;
        private Button btnSua;
        private Button btnLamMoi;
        private ComboBox cboPhim;
        private ComboBox cboPhongChieu;
        private DateTimePicker dtpGioBatDau;
        private DateTimePicker dtpGioKetThuc;
    }
}