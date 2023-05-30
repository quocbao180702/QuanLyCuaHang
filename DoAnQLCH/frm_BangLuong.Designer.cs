namespace DoAnQLCH
{
    partial class frm_BangLuong
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemThemLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemXoaLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSuaLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemBaoCaoLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvBangLuong = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.chkThanhToan = new System.Windows.Forms.CheckBox();
            this.txtTienThuong = new System.Windows.Forms.TextBox();
            this.numSoNgayLam = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLuongCB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNgayLam)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemThemLuong,
            this.MenuItemXoaLuong,
            this.MenuItemSuaLuong,
            this.MenuItemBaoCaoLuong});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(196, 688);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemThemLuong
            // 
            this.MenuItemThemLuong.BackColor = System.Drawing.Color.Cornsilk;
            this.MenuItemThemLuong.Margin = new System.Windows.Forms.Padding(0, 150, 0, 20);
            this.MenuItemThemLuong.Name = "MenuItemThemLuong";
            this.MenuItemThemLuong.Padding = new System.Windows.Forms.Padding(0);
            this.MenuItemThemLuong.Size = new System.Drawing.Size(183, 35);
            this.MenuItemThemLuong.Text = "Thêm Lương";
            this.MenuItemThemLuong.Click += new System.EventHandler(this.MenuItemThemLuong_Click);
            // 
            // MenuItemXoaLuong
            // 
            this.MenuItemXoaLuong.BackColor = System.Drawing.Color.Bisque;
            this.MenuItemXoaLuong.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.MenuItemXoaLuong.Name = "MenuItemXoaLuong";
            this.MenuItemXoaLuong.Size = new System.Drawing.Size(183, 35);
            this.MenuItemXoaLuong.Text = "Xóa Lương";
            this.MenuItemXoaLuong.Click += new System.EventHandler(this.MenuItemXoaLuong_Click);
            // 
            // MenuItemSuaLuong
            // 
            this.MenuItemSuaLuong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MenuItemSuaLuong.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.MenuItemSuaLuong.Name = "MenuItemSuaLuong";
            this.MenuItemSuaLuong.Size = new System.Drawing.Size(183, 35);
            this.MenuItemSuaLuong.Text = "Sửa Lương";
            this.MenuItemSuaLuong.Click += new System.EventHandler(this.MenuItemSuaLuong_Click);
            // 
            // MenuItemBaoCaoLuong
            // 
            this.MenuItemBaoCaoLuong.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MenuItemBaoCaoLuong.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.MenuItemBaoCaoLuong.Name = "MenuItemBaoCaoLuong";
            this.MenuItemBaoCaoLuong.Size = new System.Drawing.Size(183, 35);
            this.MenuItemBaoCaoLuong.Text = "Báo Cáo Lương";
            this.MenuItemBaoCaoLuong.Click += new System.EventHandler(this.MenuItemBaoCaoLuong_Click);
            // 
            // dgvBangLuong
            // 
            this.dgvBangLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBangLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangLuong.Location = new System.Drawing.Point(225, 196);
            this.dgvBangLuong.Name = "dgvBangLuong";
            this.dgvBangLuong.RowHeadersWidth = 51;
            this.dgvBangLuong.RowTemplate.Height = 24;
            this.dgvBangLuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBangLuong.Size = new System.Drawing.Size(1119, 492);
            this.dgvBangLuong.TabIndex = 2;
            this.dgvBangLuong.Click += new System.EventHandler(this.dgvBangLuong_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.cboMaNV);
            this.panel1.Controls.Add(this.chkThanhToan);
            this.panel1.Controls.Add(this.txtTienThuong);
            this.panel1.Controls.Add(this.numSoNgayLam);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtLuongCB);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtNam);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboThang);
            this.panel1.Controls.Add(this.dtpNgayBD);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(225, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 190);
            this.panel1.TabIndex = 3;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(965, 24);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(123, 43);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // cboMaNV
            // 
            this.cboMaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(149, 34);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(170, 30);
            this.cboMaNV.TabIndex = 10;
            // 
            // chkThanhToan
            // 
            this.chkThanhToan.AutoSize = true;
            this.chkThanhToan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkThanhToan.Location = new System.Drawing.Point(659, 33);
            this.chkThanhToan.Name = "chkThanhToan";
            this.chkThanhToan.Size = new System.Drawing.Size(152, 26);
            this.chkThanhToan.TabIndex = 9;
            this.chkThanhToan.Text = "Đã Thanh Toán";
            this.chkThanhToan.UseVisualStyleBackColor = true;
            // 
            // txtTienThuong
            // 
            this.txtTienThuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienThuong.Location = new System.Drawing.Point(149, 135);
            this.txtTienThuong.Name = "txtTienThuong";
            this.txtTienThuong.Size = new System.Drawing.Size(168, 30);
            this.txtTienThuong.TabIndex = 8;
            // 
            // numSoNgayLam
            // 
            this.numSoNgayLam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSoNgayLam.Location = new System.Drawing.Point(791, 85);
            this.numSoNgayLam.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numSoNgayLam.Name = "numSoNgayLam";
            this.numSoNgayLam.Size = new System.Drawing.Size(120, 30);
            this.numSoNgayLam.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tiền Thưởng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(652, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số Ngày Làm";
            // 
            // txtLuongCB
            // 
            this.txtLuongCB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuongCB.Location = new System.Drawing.Point(500, 138);
            this.txtLuongCB.Name = "txtLuongCB";
            this.txtLuongCB.Size = new System.Drawing.Size(142, 30);
            this.txtLuongCB.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(368, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "Lương Cơ Bản";
            // 
            // txtNam
            // 
            this.txtNam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam.Location = new System.Drawing.Point(455, 88);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(142, 30);
            this.txtNam.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(371, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Năm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(371, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tháng";
            // 
            // cboThang
            // 
            this.cboThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboThang.Location = new System.Drawing.Point(455, 34);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(121, 30);
            this.cboThang.TabIndex = 3;
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBD.Location = new System.Drawing.Point(149, 85);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(200, 30);
            this.dtpNgayBD.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày Bắt Đầu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // frm_BangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1344, 688);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvBangLuong);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frm_BangLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_BangLuong";
            this.Load += new System.EventHandler(this.frm_BangLuong_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNgayLam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemThemLuong;
        private System.Windows.Forms.ToolStripMenuItem MenuItemXoaLuong;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSuaLuong;
        private System.Windows.Forms.ToolStripMenuItem MenuItemBaoCaoLuong;
        private System.Windows.Forms.DataGridView dgvBangLuong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkThanhToan;
        private System.Windows.Forms.TextBox txtTienThuong;
        private System.Windows.Forms.NumericUpDown numSoNgayLam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtLuongCB;
        private System.Windows.Forms.Label label7;
    }
}