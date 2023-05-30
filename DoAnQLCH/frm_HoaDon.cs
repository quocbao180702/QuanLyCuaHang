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
    public partial class frm_HoaDon : Form
    {
        public frm_HoaDon()
        {
            InitializeComponent();
        }

        private void dgvHoaDon_Click(object sender, EventArgs e)
        {
            DataGridViewRow dt = dgvHoaDon.SelectedRows[0];
            txtHoaDonNhap.Text = dt.Cells["SMaHDN"].Value.ToString();
            txtMaNV.Text = dt.Cells["SMaNV"].Value.ToString();
            txtNCC.Text = dt.Cells["SMaNCC"].Value.ToString();
            dtpNgayLap.Value = DateTime.Parse(dt.Cells["SNgayNhap"].Value.ToString());
        }

        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        public void HienThi()
        {
            List<HoaDon_DTO> lstnhap = Nhap_BUS.LayDSHD();
            dgvHoaDon.DataSource = lstnhap;
            dgvHoaDon.Columns["SMaHDN"].HeaderText = "Mã Hóa Đơn Nhập";
            dgvHoaDon.Columns["SMaNV"].HeaderText = "Mã Nhân Viên";
            dgvHoaDon.Columns["SMaNCC"].HeaderText = "Mã Nhà Cung Cấp";


            dgvHoaDon.Columns["SNgayNhap"].HeaderText = "Ngày Nhập";
            dgvHoaDon.Columns["DTongTienNhap"].HeaderText = "Tổng Tiền";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Nhap_DTO nhap = new Nhap_DTO();
            nhap.SMaHDN = txtHoaDonNhap.Text;
            nhap.SMaNV = txtMaNV.Text;
            nhap.SMaNCC = txtNCC.Text;
            nhap.SNgayNhap = DateTime.Parse(dtpNgayLap.Text);
            if (Nhap_BUS.ThemPhieuNhapHD(nhap) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            MessageBox.Show("Thêm thành công được.");
            HienThi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult traloisua;
            traloisua = MessageBox.Show("Bạn có muốn sửa hóa đơn nhập không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloisua == DialogResult.OK)
            {
                Nhap_DTO nhap = new Nhap_DTO();
                nhap.SMaHDN = txtHoaDonNhap.Text;
                nhap.SMaNV = txtMaNV.Text;
                nhap.SMaNCC = txtNCC.Text;
                nhap.SNgayNhap = DateTime.Parse(dtpNgayLap.Text);

                if (Nhap_BUS.SuaPhieuNhapHD(nhap) == false)
                {
                    MessageBox.Show("Không sửa được.");
                    return;
                }
                MessageBox.Show("Đã sửa thành công.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvHoaDon.SelectedRows[0];
            String mahdn = r.Cells["SMaHDN"].Value.ToString();
            if (Nhap_BUS.XoaPhieuNhapHD(mahdn) == true)
            {
                MessageBox.Show("Đã xóa hóa đơn");
                HienThi();
            }
            else
            {
                MessageBox.Show("Đã xóa hóa đơn không thành công");
            }
        }
    }
}
