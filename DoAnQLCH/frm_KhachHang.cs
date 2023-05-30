using BUS;
using DTO;
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
    public partial class frm_KhachHang : Form
    {
        public frm_KhachHang()
        {
            InitializeComponent();
        }

        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            hienkh();
        }

        public void hienkh()
        {
            List<KhachHang_DTO> kh = KhachHang_BUS.LayKhacHang();
            dgvKhachHang.DataSource = kh;

            dgvKhachHang.Columns["SMaKH"].HeaderText = "Mã Khách Hàng";
            dgvKhachHang.Columns["SHolotKH"].HeaderText = "Họ Lót";
            dgvKhachHang.Columns["STenKH"].HeaderText = "Tên Khách Hàng";
            dgvKhachHang.Columns["SPhai"].HeaderText = "Phái";
            dgvKhachHang.Columns["SNgaySinh"].HeaderText = "Ngày Sinh";

            dgvKhachHang.Columns["SMaKH"].Width = 80;
            dgvKhachHang.Columns["SHolotKH"].Width = 80;
            dgvKhachHang.Columns["STenKH"].Width = 80;
            dgvKhachHang.Columns["SPhai"].Width = 80;
            dgvKhachHang.Columns["SNgaySinh"].Width = 80;
        }

        private void dgvKhachHang_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = dgvKhachHang.SelectedRows[0];
            txtMaKH.Text = r.Cells["SMaKH"].Value.ToString();
            txtHolotKH.Text = r.Cells["SHolotKH"].Value.ToString();
            txtTenKH.Text = r.Cells["STenKH"].Value.ToString();
            if (r.Cells["SPhai"].Value.ToString() == "Nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            dtpNgaySinh.Value = DateTime.Parse(r.Cells["SNgaySinh"].Value.ToString());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KhachHang_DTO kh = new KhachHang_DTO();
            kh.SMaKH = txtMaKH.Text;
            kh.SHoLotKH = txtHolotKH.Text;
            kh.STenKH = txtTenKH.Text;
            if(radNam.Checked == true)
            {
                kh.SPhai = "Nam";
            }
            else
            {
                kh.SPhai = "Nữ";
            }
            kh.SNgaySinh = DateTime.Parse(dtpNgaySinh.Text);
            if (KhachHang_BUS.ThemKhachHang(kh) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            MessageBox.Show("Thêm khách hàng thành công");
            hienkh();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult traloisua;
            traloisua = MessageBox.Show("Bạn có muốn sửa khách hàng không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloisua == DialogResult.OK)
            {
                KhachHang_DTO kh = new KhachHang_DTO();
                kh.SMaKH = txtMaKH.Text;
                kh.SHoLotKH = txtHolotKH.Text;
                kh.STenKH = txtTenKH.Text;
                if (radNam.Checked == true)
                {
                    kh.SPhai = "Nam";
                }
                else
                {
                    kh.SPhai = "Nữ";
                }
                kh.SNgaySinh = DateTime.Parse(dtpNgaySinh.Text);
                if (KhachHang_BUS.SuaKhachHang(kh)== true)
                {
                    MessageBox.Show("Đã sữa thành công");
                }
                else
                {
                    MessageBox.Show("Sửa Không Thành Công");
                    return;
                }
                hienkh();
            }

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvKhachHang.SelectedRows[0];
            String makh = r.Cells["SMaKH"].Value.ToString();
            if (KhachHang_BUS.XoaKhachHang(makh) == true)
            {
                MessageBox.Show("Đã xóa khách hàng");
            }
            hienkh();
        }
    }
}
