namespace GUI
{
    partial class Ghe
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
            cboPhongChieu = new ComboBox();
            btnLoad = new Button();
            label3 = new Label();
            panel2 = new Panel();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            cboTrangThai = new ComboBox();
            txtTenGhe = new TextBox();
            txtMaGhe = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label10 = new Label();
            label11 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label4 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(406, 9);
            label1.Name = "label1";
            label1.Size = new Size(187, 41);
            label1.TabIndex = 0;
            label1.Text = "Quản lý ghế";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(307, 54);
            label2.Name = "label2";
            label2.Size = new Size(147, 30);
            label2.TabIndex = 1;
            label2.Text = "Phòng chiếu:";
            // 
            // cboPhongChieu
            // 
            cboPhongChieu.FormattingEnabled = true;
            cboPhongChieu.Location = new Point(460, 59);
            cboPhongChieu.Margin = new Padding(3, 2, 3, 2);
            cboPhongChieu.Name = "cboPhongChieu";
            cboPhongChieu.Size = new Size(116, 23);
            cboPhongChieu.TabIndex = 2;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnLoad.Location = new Point(601, 56);
            btnLoad.Margin = new Padding(3, 2, 3, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(96, 27);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(4, 60);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 5;
            label3.Text = "Sơ đồ ghế:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.PeachPuff;
            panel2.Controls.Add(btnLamMoi);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnLuu);
            panel2.Controls.Add(cboTrangThai);
            panel2.Controls.Add(txtTenGhe);
            panel2.Controls.Add(txtMaGhe);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(4, 503);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(887, 102);
            panel2.TabIndex = 6;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnLamMoi.Location = new Point(646, 56);
            btnLamMoi.Margin = new Padding(3, 2, 3, 2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(123, 29);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnXoa.Location = new Point(423, 56);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(123, 29);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnLuu.Location = new Point(170, 56);
            btnLuu.Margin = new Padding(3, 2, 3, 2);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(123, 29);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "Sửa";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(728, 15);
            cboTrangThai.Margin = new Padding(3, 2, 3, 2);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(141, 23);
            cboTrangThai.TabIndex = 5;
            // 
            // txtTenGhe
            // 
            txtTenGhe.Location = new Point(402, 15);
            txtTenGhe.Margin = new Padding(3, 2, 3, 2);
            txtTenGhe.Name = "txtTenGhe";
            txtTenGhe.Size = new Size(189, 23);
            txtTenGhe.TabIndex = 4;
            // 
            // txtMaGhe
            // 
            txtMaGhe.Location = new Point(105, 16);
            txtMaGhe.Margin = new Padding(3, 2, 3, 2);
            txtMaGhe.Name = "txtMaGhe";
            txtMaGhe.Size = new Size(189, 23);
            txtMaGhe.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(629, 13);
            label7.Name = "label7";
            label7.Size = new Size(86, 21);
            label7.TabIndex = 2;
            label7.Text = "Trạng thái:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(318, 14);
            label6.Name = "label6";
            label6.Size = new Size(71, 21);
            label6.TabIndex = 1;
            label6.Text = "Tên ghế:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 14);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 0;
            label5.Text = "Mã ghế:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Location = new Point(903, 146);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 23);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(934, 152);
            label9.Name = "label9";
            label9.Size = new Size(83, 19);
            label9.TabIndex = 9;
            label9.Text = "Ghế thường";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.LightGreen;
            pictureBox2.Location = new Point(903, 208);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 23);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.IndianRed;
            pictureBox3.Location = new Point(903, 265);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(26, 23);
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(934, 208);
            label10.Name = "label10";
            label10.Size = new Size(79, 19);
            label10.TabIndex = 13;
            label10.Text = "Ghế đã đặt";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.Location = new Point(934, 265);
            label11.Name = "label11";
            label11.Size = new Size(70, 19);
            label11.TabIndex = 14;
            label11.Text = "Ghế đang";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(1, 88);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(887, 390);
            flowLayoutPanel1.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(935, 284);
            label4.Name = "label4";
            label4.Size = new Size(55, 19);
            label4.TabIndex = 16;
            label4.Text = " bảo trì";
            // 
            // Ghe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1019, 607);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label9);
            Controls.Add(pictureBox1);
            Controls.Add(btnLoad);
            Controls.Add(cboPhongChieu);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Ghe";
            Text = "Ghe";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cboPhongChieu;
        private Button btnLoad;
        private Label label3;
        private Panel panel2;
        private TextBox txtMaGhe;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox cboTrangThai;
        private TextBox txtTenGhe;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnLuu;
        private PictureBox pictureBox1;
        private Label label9;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label10;
        private Label label11;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label4;
    }
}