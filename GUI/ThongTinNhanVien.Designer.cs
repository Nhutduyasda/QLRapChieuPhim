namespace GUI
{
    partial class ThongTinNhanVien
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
<<<<<<< HEAD
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinNhanVien));
            label1 = new Label();
            label2 = new Label();
            lblEmail = new Label();
            label4 = new Label();
            btnThem = new Button();
            btnLamMoi = new Button();
            btnCapNhat = new Button();
            btnXoa = new Button();
            txtHoTen = new TextBox();
            txtSoDienThoai = new TextBox();
            label5 = new Label();
            dgvDanhSachNV = new DataGridView();
            label6 = new Label();
            txtMaNhanVien = new TextBox();
            cboChucVu = new ComboBox();
            label7 = new Label();
            txtEmail = new TextBox();
            txtMatKhau = new TextBox();
            lblMatKhau = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
=======
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            label7 = new Label();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
>>>>>>> 4dbe4da3c264a95b1fbc116326ee64df3a6dc462
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(42, 72);
            label1.Name = "label1";
            label1.Size = new Size(240, 28);
            label1.TabIndex = 0;
            label1.Text = "Thông tin các nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(41, 200);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
<<<<<<< HEAD
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblEmail.Location = new Point(41, 419);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 23);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
=======
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(41, 346);
            label3.Name = "label3";
            label3.Size = new Size(86, 23);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
>>>>>>> 4dbe4da3c264a95b1fbc116326ee64df3a6dc462
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
<<<<<<< HEAD
            label4.Location = new Point(42, 498);
=======
            label4.Location = new Point(42, 421);
>>>>>>> 4dbe4da3c264a95b1fbc116326ee64df3a6dc462
            label4.Name = "label4";
            label4.Size = new Size(74, 23);
            label4.TabIndex = 3;
            label4.Text = "Chức vụ";
            label4.Click += label4_Click;
            // 
<<<<<<< HEAD
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(0, 192, 0);
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(41, 578);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(106, 37);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(0, 192, 0);
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(216, 657);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(106, 37);
            btnLamMoi.TabIndex = 5;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.FromArgb(0, 192, 0);
            btnCapNhat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnCapNhat.ForeColor = Color.White;
            btnCapNhat.Location = new Point(41, 657);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(106, 37);
            btnCapNhat.TabIndex = 6;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(0, 192, 0);
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(216, 578);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(106, 37);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(41, 226);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(241, 27);
            txtHoTen.TabIndex = 8;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(42, 298);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(241, 27);
            txtSoDienThoai.TabIndex = 10;
=======
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(42, 511);
            button1.Name = "button1";
            button1.Size = new Size(94, 37);
            button1.TabIndex = 4;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 0);
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(217, 590);
            button2.Name = "button2";
            button2.Size = new Size(94, 37);
            button2.TabIndex = 5;
            button2.Text = "Làm mới";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 192, 0);
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(42, 590);
            button3.Name = "button3";
            button3.Size = new Size(94, 37);
            button3.TabIndex = 6;
            button3.Text = "Cập nhật";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 192, 0);
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(217, 511);
            button4.Name = "button4";
            button4.Size = new Size(94, 37);
            button4.TabIndex = 7;
            button4.Text = "Xoá";
            button4.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(41, 226);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 27);
            textBox1.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(42, 298);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(241, 27);
            textBox3.TabIndex = 10;
>>>>>>> 4dbe4da3c264a95b1fbc116326ee64df3a6dc462
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(354, 72);
            label5.Name = "label5";
            label5.Size = new Size(169, 28);
            label5.TabIndex = 11;
            label5.Text = "Tất cả nhân viên";
            // 
<<<<<<< HEAD
            // dgvDanhSachNV
            // 
            dgvDanhSachNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachNV.Location = new Point(354, 108);
            dgvDanhSachNV.Name = "dgvDanhSachNV";
            dgvDanhSachNV.RowHeadersWidth = 51;
            dgvDanhSachNV.Size = new Size(763, 565);
            dgvDanhSachNV.TabIndex = 12;
            dgvDanhSachNV.CellClick += dgvDanhSachNV_CellClick;
            dgvDanhSachNV.CellContentClick += dgvDanhSachNV_CellContentClick;
=======
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(354, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(763, 519);
            dataGridView1.TabIndex = 12;
>>>>>>> 4dbe4da3c264a95b1fbc116326ee64df3a6dc462
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.Location = new Point(41, 126);
            label6.Name = "label6";
            label6.Size = new Size(117, 23);
            label6.TabIndex = 13;
            label6.Text = "Mã nhân viên";
            // 
<<<<<<< HEAD
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(42, 152);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.ReadOnly = true;
            txtMaNhanVien.Size = new Size(241, 27);
            txtMaNhanVien.TabIndex = 14;
            // 
            // cboChucVu
            // 
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Location = new Point(41, 524);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(241, 28);
            cboChucVu.TabIndex = 15;
=======
            // textBox2
            // 
            textBox2.Location = new Point(42, 152);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(241, 27);
            textBox2.TabIndex = 14;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(41, 447);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(241, 28);
            comboBox1.TabIndex = 15;
>>>>>>> 4dbe4da3c264a95b1fbc116326ee64df3a6dc462
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label7.Location = new Point(41, 272);
            label7.Name = "label7";
            label7.Size = new Size(116, 23);
            label7.TabIndex = 16;
            label7.Text = "Số điện thoại";
            // 
<<<<<<< HEAD
            // txtEmail
            // 
            txtEmail.Location = new Point(41, 445);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(241, 27);
            txtEmail.TabIndex = 17;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(42, 373);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '●';
            txtMatKhau.Size = new Size(241, 27);
            txtMatKhau.TabIndex = 19;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblMatKhau.Location = new Point(42, 347);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(86, 23);
            lblMatKhau.TabIndex = 18;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(289, 373);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
=======
            // textBox4
            // 
            textBox4.Location = new Point(41, 372);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(241, 27);
            textBox4.TabIndex = 17;
>>>>>>> 4dbe4da3c264a95b1fbc116326ee64df3a6dc462
            // 
            // ThongTinNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 716);
<<<<<<< HEAD
            Controls.Add(pictureBox1);
            Controls.Add(txtMatKhau);
            Controls.Add(lblMatKhau);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(cboChucVu);
            Controls.Add(txtMaNhanVien);
            Controls.Add(label6);
            Controls.Add(dgvDanhSachNV);
            Controls.Add(label5);
            Controls.Add(txtSoDienThoai);
            Controls.Add(txtHoTen);
            Controls.Add(btnXoa);
            Controls.Add(btnCapNhat);
            Controls.Add(btnLamMoi);
            Controls.Add(btnThem);
            Controls.Add(label4);
            Controls.Add(lblEmail);
=======
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
>>>>>>> 4dbe4da3c264a95b1fbc116326ee64df3a6dc462
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ThongTinNhanVien";
            Text = "NhanVien";
<<<<<<< HEAD
            Load += ThongTinNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
=======
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
>>>>>>> 4dbe4da3c264a95b1fbc116326ee64df3a6dc462
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
<<<<<<< HEAD
        private Label lblEmail;
        private Label label4;
        private Button btnThem;
        private Button btnLamMoi;
        private Button btnCapNhat;
        private Button btnXoa;
        private TextBox txtHoTen;
        private TextBox txtSoDienThoai;
        private Label label5;
        private DataGridView dgvDanhSachNV;
        private Label label6;
        private TextBox txtMaNhanVien;
        private ComboBox cboChucVu;
        private Label label7;
        private TextBox txtEmail;
        private TextBox txtMatKhau;
        private Label lblMatKhau;
        private PictureBox pictureBox1;
=======
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label5;
        private DataGridView dataGridView1;
        private Label label6;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label label7;
        private TextBox textBox4;
>>>>>>> 4dbe4da3c264a95b1fbc116326ee64df3a6dc462
    }
}