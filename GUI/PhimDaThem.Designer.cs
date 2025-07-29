namespace GUI
{
    partial class PhimDaThem
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            dgvDSPhim = new DataGridView();
            label1 = new Label();
            lblName = new Label();
            lblNV = new Label();
            lblNgay = new Label();
            lblNumber = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSPhim).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 0);
            panel1.Controls.Add(lblNumber);
            panel1.Controls.Add(lblName);
            panel1.Location = new Point(87, 62);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 94);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 192, 0);
            panel2.Controls.Add(lblNV);
            panel2.Location = new Point(384, 62);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(219, 94);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 192, 0);
            panel3.Controls.Add(lblNgay);
            panel3.Location = new Point(687, 62);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(219, 94);
            panel3.TabIndex = 1;
            // 
            // dgvDSPhim
            // 
            dgvDSPhim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSPhim.Location = new Point(50, 238);
            dgvDSPhim.Margin = new Padding(3, 2, 3, 2);
            dgvDSPhim.Name = "dgvDSPhim";
            dgvDSPhim.RowHeadersWidth = 51;
            dgvDSPhim.Size = new Size(918, 256);
            dgvDSPhim.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(50, 197);
            label1.Name = "label1";
            label1.Size = new Size(137, 30);
            label1.TabIndex = 3;
            label1.Text = "Phim có sẵn";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblName.Location = new Point(44, 53);
            lblName.Name = "lblName";
            lblName.Size = new Size(129, 22);
            lblName.TabIndex = 0;
            lblName.Text = "Phim Có Sẵn";
            // 
            // lblNV
            // 
            lblNV.AutoSize = true;
            lblNV.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblNV.Location = new Point(53, 53);
            lblNV.Name = "lblNV";
            lblNV.Size = new Size(104, 22);
            lblNV.TabIndex = 1;
            lblNV.Text = "Nhân Viên";
            // 
            // lblNgay
            // 
            lblNgay.AutoSize = true;
            lblNgay.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblNgay.Location = new Point(81, 53);
            lblNgay.Name = "lblNgay";
            lblNgay.Size = new Size(57, 22);
            lblNgay.TabIndex = 1;
            lblNgay.Text = "Ngày";
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblNumber.Location = new Point(109, 15);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(44, 22);
            lblNumber.TabIndex = 1;
            lblNumber.Text = "text";
            // 
            // PhimDaThem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 537);
            Controls.Add(label1);
            Controls.Add(dgvDSPhim);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PhimDaThem";
            Text = "PhimDaThem";
            Load += PhimDaThem_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSPhim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvDSPhim;
        private Label label1;
        private Label lblName;
        private Label lblNV;
        private Label lblNgay;
        private Label lblNumber;
    }
}