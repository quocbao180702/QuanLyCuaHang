using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQLCH
{
    public partial class frm_CuaHang : Form
    {
        public frm_CuaHang()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtTenCH = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtMaCH = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblTenCH = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblMaCH = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvCuahang = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuahang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.txtTenCH);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.txtMaCH);
            this.panel1.Controls.Add(this.lblDiaChi);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.lblTenCH);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.lblMaCH);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 325);
            this.panel1.TabIndex = 0;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(227, 186);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(221, 30);
            this.txtDiaChi.TabIndex = 24;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(383, 258);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 42);
            this.btnSua.TabIndex = 27;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtTenCH
            // 
            this.txtTenCH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCH.Location = new System.Drawing.Point(227, 127);
            this.txtTenCH.Name = "txtTenCH";
            this.txtTenCH.Size = new System.Drawing.Size(221, 30);
            this.txtTenCH.TabIndex = 25;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(259, 258);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 42);
            this.btnXoa.TabIndex = 27;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMaCH
            // 
            this.txtMaCH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCH.Location = new System.Drawing.Point(227, 65);
            this.txtMaCH.Name = "txtMaCH";
            this.txtMaCH.Size = new System.Drawing.Size(221, 30);
            this.txtMaCH.TabIndex = 26;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(54, 188);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(73, 23);
            this.lblDiaChi.TabIndex = 21;
            this.lblDiaChi.Text = "Địa Chỉ";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(144, 258);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(98, 42);
            this.btnThem.TabIndex = 27;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblTenCH
            // 
            this.lblTenCH.AutoSize = true;
            this.lblTenCH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenCH.Location = new System.Drawing.Point(54, 129);
            this.lblTenCH.Name = "lblTenCH";
            this.lblTenCH.Size = new System.Drawing.Size(133, 23);
            this.lblTenCH.TabIndex = 22;
            this.lblTenCH.Text = "Tên Cửa Hàng";
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(29, 258);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(98, 42);
            this.btnHuy.TabIndex = 28;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lblMaCH
            // 
            this.lblMaCH.AutoSize = true;
            this.lblMaCH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaCH.Location = new System.Drawing.Point(54, 67);
            this.lblMaCH.Name = "lblMaCH";
            this.lblMaCH.Size = new System.Drawing.Size(129, 23);
            this.lblMaCH.TabIndex = 23;
            this.lblMaCH.Text = "Mã Cửa Hàng";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(170, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(165, 32);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "CỬA HÀNG";
            // 
            // dgvCuahang
            // 
            this.dgvCuahang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuahang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCuahang.Location = new System.Drawing.Point(0, 331);
            this.dgvCuahang.Name = "dgvCuahang";
            this.dgvCuahang.RowHeadersWidth = 51;
            this.dgvCuahang.RowTemplate.Height = 24;
            this.dgvCuahang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCuahang.Size = new System.Drawing.Size(527, 278);
            this.dgvCuahang.TabIndex = 27;
            this.dgvCuahang.Click += new System.EventHandler(this.dgvCuahang_Click);
            // 
            // frm_CuaHang
            // 
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(527, 609);
            this.Controls.Add(this.dgvCuahang);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_CuaHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frm_ThemCuaHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuahang)).EndInit();
            this.ResumeLayout(false);

        }



        private void frm_ThemCuaHang_Load(object sender, EventArgs e)
        {
            HienThiCuaHang();
        }
        public void HienThiCuaHang()
        {
            List<CuaHang_DTO> lst = CuaHang_BUS.LayCuaHang();
            dgvCuahang.DataSource = lst;
            dgvCuahang.Columns["SMaCH"].HeaderText = "Mã Cửa Hàng";
            dgvCuahang.Columns["STenCH"].HeaderText = "Tên Cửa Hàng";
            dgvCuahang.Columns["SDiaChi"].HeaderText = "Địa Chỉ";
            // dgvChucVu.Columns["SMaCV"].Width = 80;

            dgvCuahang.Columns["SMaCH"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dgvCuahang.Columns["STenCH"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dgvCuahang.Columns["SDiaChi"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        }
      

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaCH.Text == "" || txtTenCH.Text == "" || txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            if (txtMaCH.Text.Length < 5)
            {
                MessageBox.Show("Mã cửa hàng phải đủ 6 ký tự!");
                return;
            }
            if(CuaHang_BUS.TimTheoMaCuaHang(txtMaCH.Text) != null)
            {
                MessageBox.Show("Mã Cửa Hàng Đã Tồn Tại");
                return;
            }
            CuaHang_DTO ch = new CuaHang_DTO();
            ch.SMaCH = txtMaCH.Text;
            ch.STenCH = txtTenCH.Text;
            ch.SDiaChi = txtDiaChi.Text;
            if (CuaHang_BUS.ThemCuaHang(ch) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiCuaHang();
            MessageBox.Show("Thêm cửa hàng thành công");
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult traloisua;
            traloisua = MessageBox.Show("Bạn có muốn xóa cửa hàng không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloisua == DialogResult.OK)
            {
                DataGridViewRow r = new DataGridViewRow();
                r = dgvCuahang.SelectedRows[0];
                String mach = r.Cells["SMaCH"].Value.ToString();
                if (CuaHang_BUS.XoaCuaHang(mach) == true)
                {
                    MessageBox.Show("Đã xóa cửa hàng");
                }
                HienThiCuaHang();
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult traloisua;
            traloisua = MessageBox.Show("Bạn có muốn sửa cửa hàng không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloisua == DialogResult.OK)
            {
                CuaHang_DTO ch = new CuaHang_DTO();
                ch.SMaCH = txtMaCH.Text;
                ch.STenCH = txtTenCH.Text;
                ch.SDiaChi = txtDiaChi.Text;
                if (CuaHang_BUS.SuaCuaHang(ch) == true)
                {
                    MessageBox.Show("Đã sữa thành công");
                }
                else
                {
                    MessageBox.Show("Sửa Không Thành Công");
                    return;
                }
                HienThiCuaHang();
            }
        }

        private void dgvCuahang_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = dgvCuahang.SelectedRows[0];
            txtMaCH.Text = r.Cells["SMaCH"].Value.ToString();
            txtTenCH.Text = r.Cells["STenCH"].Value.ToString();
            txtDiaChi.Text = r.Cells["SDiaChi"].Value.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaCH.ResetText();
            txtTenCH.ResetText();
            txtDiaChi.ResetText();
        }
    }
}
