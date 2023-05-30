using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQLCH
{
    public partial class frm_NhaCungCap : Form
    {
        public frm_NhaCungCap()
        {
            InitializeComponent();
        }

        private void frm_NhaCungCap_Load(object sender, EventArgs e)
        {
            HienThiNhaCungCap();
        }

        public void HienThiNhaCungCap()
        {
            List<NhaCungCap_DTO> lst = NhaCungCap_BUS.LayNhaCungCap();
            dgvNhaCungCap.DataSource = lst;
            dgvNhaCungCap.Columns["SMaNCC"].HeaderText = "Mã Cửa Hàng";
            dgvNhaCungCap.Columns["STenNCC"].HeaderText = "Tên Cửa Hàng";
            dgvNhaCungCap.Columns["SDiaChi"].HeaderText = "Địa Chỉ";
            dgvNhaCungCap.Columns["SSDT"].HeaderText = "Số Điện Thoại";
            //dgvNhaCungCap.Columns["SMaCV"].Width = 80;
            dgvNhaCungCap.Columns["SMaNCC"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dgvNhaCungCap.Columns["STenNCC"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dgvNhaCungCap.Columns["SDiaChi"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dgvNhaCungCap.Columns["SSDT"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dgvNhaCungCap_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = dgvNhaCungCap.SelectedRows[0];
            txtMaNCC.Text = r.Cells["SMaNCC"].Value.ToString();
            txtTenNCC.Text = r.Cells["STenNCC"].Value.ToString();
            txtDiaChi.Text = r.Cells["SDiaChi"].Value.ToString();
            txtSDT.Text = r.Cells["SSdt"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            if (txtMaNCC.Text.Length < 5)
            {
                MessageBox.Show("Mã cửa hàng phải đủ 6 ký tự!");
                return;
            }
            if (NhaCungCap_BUS.TimMaNhaCungCap(txtMaNCC.Text) != null)
            {
                MessageBox.Show("Mã Cửa Hàng Đã Tồn Tại");
                return;
            }
            NhaCungCap_DTO ncc = new NhaCungCap_DTO();
            ncc.SMaNCC = txtMaNCC.Text;
            ncc.STenNCC = txtTenNCC.Text;
            ncc.SDiaChi = txtDiaChi.Text;
            ncc.SSdt = txtSDT.Text;

            if (NhaCungCap_BUS.ThemNhaCungCap(ncc) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiNhaCungCap();
            MessageBox.Show("Thêm cửa hàng thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvNhaCungCap.SelectedRows[0];
            String mancc = r.Cells["SMaNCC"].Value.ToString();
            if (NhaCungCap_BUS.XoaNhaCungCap(mancc) == true)
            {
                MessageBox.Show("Đã xóa Nhà Cung Cấp");
            }
            HienThiNhaCungCap();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult traloisua;
            traloisua = MessageBox.Show("Bạn có muốn sửa nhân viên không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloisua == DialogResult.OK)
            {
                NhaCungCap_DTO ncc = new NhaCungCap_DTO();
                ncc.SMaNCC = txtMaNCC.Text;
                ncc.STenNCC = txtTenNCC.Text;
                ncc.SDiaChi = txtDiaChi.Text;
                ncc.SSdt = txtSDT.Text;
                if (NhaCungCap_BUS.SuaNhaCungCap(ncc) == true)
                {
                    MessageBox.Show("Đã sữa thành công");
                }
                else
                {
                    MessageBox.Show("Sửa Không Thành Công");
                    return;
                }
                HienThiNhaCungCap();
            }
        }
    }
}
