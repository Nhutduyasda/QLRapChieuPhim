namespace GUI
{
    partial class frmMuaVe
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
            dgvPhim = new DataGridView();
            label3 = new Label();
            txtMaPhim = new TextBox();
            txtTenPhim = new TextBox();
            label4 = new Label();
            txtTheLoai = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtThoiLuong = new TextBox();
            label7 = new Label();
            txtDoTuoi = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtTinhTrang = new TextBox();
            pictureBox_Phim = new PictureBox();
            btnChonPhim = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPhim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Phim).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(505, 62);
            label1.TabIndex = 0;
            label1.Text = "Cinema - Đặt Vé Phim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(12, 93);
            label2.Name = "label2";
            label2.Size = new Size(171, 28);
            label2.TabIndex = 1;
            label2.Text = "Phim đang chiếu";
            // 
            // dgvPhim
            // 
            dgvPhim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhim.Location = new Point(12, 124);
            dgvPhim.Name = "dgvPhim";
            dgvPhim.RowHeadersWidth = 51;
            dgvPhim.Size = new Size(1141, 263);
            dgvPhim.TabIndex = 2;
            dgvPhim.CellClick += dgvPhim_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(499, 427);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 3;
            label3.Text = "Mã phim:";
            // 
            // txtMaPhim
            // 
            txtMaPhim.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMaPhim.Location = new Point(606, 424);
            txtMaPhim.Name = "txtMaPhim";
            txtMaPhim.Size = new Size(198, 34);
            txtMaPhim.TabIndex = 5;
            // 
            // txtTenPhim
            // 
            txtTenPhim.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTenPhim.Location = new Point(606, 492);
            txtTenPhim.Name = "txtTenPhim";
            txtTenPhim.Size = new Size(198, 34);
            txtTenPhim.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(499, 495);
            label4.Name = "label4";
            label4.Size = new Size(104, 28);
            label4.TabIndex = 6;
            label4.Text = "Tên phim:";
            // 
            // txtTheLoai
            // 
            txtTheLoai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTheLoai.Location = new Point(606, 561);
            txtTheLoai.Name = "txtTheLoai";
            txtTheLoai.Size = new Size(198, 34);
            txtTheLoai.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(507, 561);
            label5.Name = "label5";
            label5.Size = new Size(93, 28);
            label5.TabIndex = 8;
            label5.Text = "Thể loại:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.Location = new Point(833, 424);
            label6.Name = "label6";
            label6.Size = new Size(116, 28);
            label6.TabIndex = 10;
            label6.Text = "Tình trạng:";
            // 
            // txtThoiLuong
            // 
            txtThoiLuong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtThoiLuong.Location = new Point(955, 495);
            txtThoiLuong.Name = "txtThoiLuong";
            txtThoiLuong.Size = new Size(198, 34);
            txtThoiLuong.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label7.Location = new Point(833, 495);
            label7.Name = "label7";
            label7.Size = new Size(122, 28);
            label7.TabIndex = 12;
            label7.Text = "Thời lượng:";
            // 
            // txtDoTuoi
            // 
            txtDoTuoi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtDoTuoi.Location = new Point(955, 561);
            txtDoTuoi.Name = "txtDoTuoi";
            txtDoTuoi.Size = new Size(198, 34);
            txtDoTuoi.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label8.Location = new Point(861, 564);
            label8.Name = "label8";
            label8.Size = new Size(88, 28);
            label8.TabIndex = 14;
            label8.Text = "Độ tuổi:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label9.Location = new Point(144, 620);
            label9.Name = "label9";
            label9.Size = new Size(106, 28);
            label9.TabIndex = 16;
            label9.Text = "Hình Ảnh:";
            // 
            // txtTinhTrang
            // 
            txtTinhTrang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTinhTrang.Location = new Point(955, 421);
            txtTinhTrang.Name = "txtTinhTrang";
            txtTinhTrang.Size = new Size(198, 34);
            txtTinhTrang.TabIndex = 17;
            // 
            // pictureBox_Phim
            // 
            pictureBox_Phim.Location = new Point(69, 421);
            pictureBox_Phim.Name = "pictureBox_Phim";
            pictureBox_Phim.Size = new Size(283, 192);
            pictureBox_Phim.TabIndex = 18;
            pictureBox_Phim.TabStop = false;
            // 
            // btnChonPhim
            // 
            btnChonPhim.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnChonPhim.Location = new Point(606, 639);
            btnChonPhim.Name = "btnChonPhim";
            btnChonPhim.Size = new Size(153, 38);
            btnChonPhim.TabIndex = 19;
            btnChonPhim.Text = "Chọn Phim";
            btnChonPhim.UseVisualStyleBackColor = true;
            btnChonPhim.Click += btnChonPhim_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnXoa.Location = new Point(887, 639);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(153, 38);
            btnXoa.TabIndex = 20;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // frmMuaVe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 716);
            Controls.Add(btnXoa);
            Controls.Add(btnChonPhim);
            Controls.Add(pictureBox_Phim);
            Controls.Add(txtTinhTrang);
            Controls.Add(label9);
            Controls.Add(txtDoTuoi);
            Controls.Add(label8);
            Controls.Add(txtThoiLuong);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtTheLoai);
            Controls.Add(label5);
            Controls.Add(txtTenPhim);
            Controls.Add(label4);
            Controls.Add(txtMaPhim);
            Controls.Add(label3);
            Controls.Add(dgvPhim);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmMuaVe";
            Text = "v";
            ((System.ComponentModel.ISupportInitialize)dgvPhim).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Phim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dgvPhim;
        private Label label3;
        private TextBox txtMaPhim;
        private TextBox txtTenPhim;
        private Label label4;
        private TextBox txtTheLoai;
        private Label label5;
        private Label label6;
        private TextBox txtThoiLuong;
        private Label label7;
        private TextBox txtDoTuoi;
        private Label label8;
        private Label label9;
        private TextBox txtTinhTrang;
        private PictureBox pictureBox_Phim;
        private Button btnChonPhim;
        private Button btnXoa;
    }
}