using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQLCH
{
    public partial class frm_ThemCuaHang : Form
    {
        public frm_ThemCuaHang()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtTenCH = new System.Windows.Forms.TextBox();
            this.lblTenCH = new System.Windows.Forms.Label();
            this.txtMaCH = new System.Windows.Forms.TextBox();
            this.lblMaCH = new System.Windows.Forms.Label();
            this.lblLoai = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(325, 234);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(98, 42);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(139, 234);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(98, 42);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // txtTenCH
            // 
            this.txtTenCH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCH.Location = new System.Drawing.Point(233, 166);
            this.txtTenCH.Name = "txtTenCH";
            this.txtTenCH.Size = new System.Drawing.Size(267, 30);
            this.txtTenCH.TabIndex = 7;
            // 
            // lblTenCH
            // 
            this.lblTenCH.AutoSize = true;
            this.lblTenCH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenCH.Location = new System.Drawing.Point(60, 168);
            this.lblTenCH.Name = "lblTenCH";
            this.lblTenCH.Size = new System.Drawing.Size(133, 23);
            this.lblTenCH.TabIndex = 5;
            this.lblTenCH.Text = "Tên Cửa Hàng";
            // 
            // txtMaCH
            // 
            this.txtMaCH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCH.Location = new System.Drawing.Point(233, 104);
            this.txtMaCH.Name = "txtMaCH";
            this.txtMaCH.Size = new System.Drawing.Size(267, 30);
            this.txtMaCH.TabIndex = 8;
            // 
            // lblMaCH
            // 
            this.lblMaCH.AutoSize = true;
            this.lblMaCH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaCH.Location = new System.Drawing.Point(60, 106);
            this.lblMaCH.Name = "lblMaCH";
            this.lblMaCH.Size = new System.Drawing.Size(129, 23);
            this.lblMaCH.TabIndex = 6;
            this.lblMaCH.Text = "Mã Cửa Hàng";
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoai.Location = new System.Drawing.Point(184, 34);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(205, 25);
            this.lblLoai.TabIndex = 4;
            this.lblLoai.Text = "THÊM CỬA HÀNG";
            // 
            // frm_ThemCuaHang
            // 
            this.ClientSize = new System.Drawing.Size(577, 325);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.txtTenCH);
            this.Controls.Add(this.lblTenCH);
            this.Controls.Add(this.txtMaCH);
            this.Controls.Add(this.lblMaCH);
            this.Controls.Add(this.lblLoai);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(595, 372);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(595, 372);
            this.Name = "frm_ThemCuaHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
