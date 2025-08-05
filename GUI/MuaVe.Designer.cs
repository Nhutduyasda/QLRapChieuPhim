namespace GUI
{
    partial class MuaVe
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
            dgvSuatChieuPhim = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            btnChonPhim = new Button();
            btnHuy = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSuatChieuPhim).BeginInit();
            SuspendLayout();
            // 
            // dgvSuatChieuPhim
            // 
            dgvSuatChieuPhim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuatChieuPhim.Location = new Point(12, 126);
            dgvSuatChieuPhim.Margin = new Padding(3, 2, 3, 2);
            dgvSuatChieuPhim.Name = "dgvSuatChieuPhim";
            dgvSuatChieuPhim.RowHeadersWidth = 51;
            dgvSuatChieuPhim.Size = new Size(998, 286);
            dgvSuatChieuPhim.TabIndex = 5;
            dgvSuatChieuPhim.CellContentClick += dgvSuatChieuPhim_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(139, 21);
            label2.TabIndex = 4;
            label2.Text = "Phim đang chiếu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(309, 32);
            label1.TabIndex = 3;
            label1.Text = "Cinema - Suất Chiếu Phim";
            // 
            // btnChonPhim
            // 
            btnChonPhim.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnChonPhim.Location = new Point(249, 441);
            btnChonPhim.Margin = new Padding(3, 2, 3, 2);
            btnChonPhim.Name = "btnChonPhim";
            btnChonPhim.Size = new Size(133, 38);
            btnChonPhim.TabIndex = 6;
            btnChonPhim.Text = "Chọn Phim";
            btnChonPhim.UseVisualStyleBackColor = true;
            btnChonPhim.Click += btnChonPhim_Click;
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnHuy.Location = new Point(551, 441);
            btnHuy.Margin = new Padding(3, 2, 3, 2);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(133, 38);
            btnHuy.TabIndex = 7;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // MuaVe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 537);
            Controls.Add(btnHuy);
            Controls.Add(btnChonPhim);
            Controls.Add(dgvSuatChieuPhim);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MuaVe";
            Text = "MuaVe";
            ((System.ComponentModel.ISupportInitialize)dgvSuatChieuPhim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSuatChieuPhim;
        private Label label2;
        private Label label1;
        private Button btnChonPhim;
        private Button btnHuy;
    }
}