namespace GUI
{
<<<<<<< HEAD
    partial class frmDangNhap
=======
    partial class DangNhap
>>>>>>> 4dbe4da3c264a95b1fbc116326ee64df3a6dc462
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            btnThoat = new Button();
            label3 = new Label();
            label2 = new Label();
            txtTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
=======
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            button2 = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
>>>>>>> 4dbe4da3c264a95b1fbc116326ee64df3a6dc462
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
<<<<<<< HEAD
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTaiKhoan);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(btnDangNhap);
=======
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(button2);
>>>>>>> 4dbe4da3c264a95b1fbc116326ee64df3a6dc462
            groupBox1.Controls.Add(label1);
            groupBox1.Cursor = Cursors.Cross;
            groupBox1.Location = new Point(63, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(525, 470);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
<<<<<<< HEAD
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(455, 195);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.SeaGreen;
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(303, 326);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(127, 42);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            // 
=======
>>>>>>> 4dbe4da3c264a95b1fbc116326ee64df3a6dc462
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(48, 199);
            label3.Name = "label3";
            label3.Size = new Size(86, 23);
            label3.TabIndex = 8;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(48, 132);
            label2.Name = "label2";
            label2.Size = new Size(87, 23);
            label2.TabIndex = 7;
            label2.Text = "Tài khoản";
            // 
<<<<<<< HEAD
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(181, 128);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(249, 27);
            txtTaiKhoan.TabIndex = 5;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(181, 195);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '●';
            txtMatKhau.Size = new Size(249, 27);
            txtMatKhau.TabIndex = 4;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.SeaGreen;
            btnDangNhap.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(48, 326);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(127, 42);
            btnDangNhap.TabIndex = 2;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
=======
            // textBox2
            // 
            textBox2.Location = new Point(181, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(249, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(181, 195);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(249, 27);
            textBox1.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(344, 256);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(86, 24);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Hiển thị";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.SeaGreen;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(200, 326);
            button2.Name = "button2";
            button2.Size = new Size(127, 42);
            button2.TabIndex = 2;
            button2.Text = "Đăng nhập";
            button2.UseVisualStyleBackColor = false;
>>>>>>> 4dbe4da3c264a95b1fbc116326ee64df3a6dc462
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(181, 23);
            label1.Name = "label1";
            label1.Size = new Size(188, 38);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            // 
<<<<<<< HEAD
            // frmDangNhap
=======
            // DangNhap
>>>>>>> 4dbe4da3c264a95b1fbc116326ee64df3a6dc462
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(651, 550);
            Controls.Add(groupBox1);
<<<<<<< HEAD
            Name = "frmDangNhap";
            Text = "DangNhap";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
=======
            Name = "DangNhap";
            Text = "DangNhap";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
>>>>>>> 4dbe4da3c264a95b1fbc116326ee64df3a6dc462
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
<<<<<<< HEAD
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
        private Label label1;
        private Button btnThoat;
        private PictureBox pictureBox1;
=======
        private TextBox textBox2;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private Button button2;
        private Label label1;
>>>>>>> 4dbe4da3c264a95b1fbc116326ee64df3a6dc462
    }
}