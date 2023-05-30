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
    public partial class frmHoaDon_Ban : Form
    {
        public frmHoaDon_Ban()
        {
            InitializeComponent();
        }

        private void dgvHoaDonBan_Click(object sender, EventArgs e)
        {
            DataGridViewRow dt = dgvHoaDonBan.SelectedRows[0];
            txtHoaDonNhap.Text = dt.Cells["SMaHDB"].Value.ToString();
            txtMaNV.Text = dt.Cells["SMaNV"].Value.ToString();
            txtMaKH.Text = dt.Cells["SMaKH"].Value.ToString();
            dtpNgayLap.Value = DateTime.Parse(dt.Cells["SNgayBan"].Value.ToString());
        }

        private void frmHoaDon_Ban_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        public void HienThi()
        {
            List<HoaDonBan_DTO> lstban = Ban_BUS.LayDSHD();
            dgvHoaDonBan.DataSource = lstban;
            dgvHoaDonBan.Columns["SMaHDB"].HeaderText = "Mã Hóa Đơn Nhập";
            dgvHoaDonBan.Columns["SMaNV"].HeaderText = "Mã Nhân Viên";
            dgvHoaDonBan.Columns["SMaKH"].HeaderText = "Mã Khách Hàng";
            dgvHoaDonBan.Columns["SNgayBan"].HeaderText = "Ngày Nhập";
            dgvHoaDonBan.Columns["DTongTienBan"].HeaderText = "Tổng Tiền";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Ban_DTO ban = new Ban_DTO();
            ban.SMaHDB = txtHoaDonNhap.Text;
            ban.SMaNV = txtMaNV.Text;
            ban.SMaKH = txtMaKH.Text;
            ban.SMaNV = txtMaNV.Text;
            ban.SNgayBan = DateTime.Parse(dtpNgayLap.Text);
            if (Ban_BUS.ThemHDBAn(ban) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            MessageBox.Show("Thêm thành công.");
            HienThi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Ban_DTO ban = new Ban_DTO();
            ban.SMaHDB = txtHoaDonNhap.Text;
            ban.SMaNV = txtMaNV.Text;
            ban.SMaKH = txtMaKH.Text;
            ban.SMaNV = txtMaNV.Text;
            ban.SNgayBan = DateTime.Parse(dtpNgayLap.Text);
            if (Ban_BUS.SuaHDBan(ban)== false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            MessageBox.Show("Thêm thành công được.");
            HienThi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvHoaDonBan.SelectedRows[0];
            String mahdn = r.Cells["SMaHDB"].Value.ToString();
            if (Ban_BUS.XoaHDBAn(mahdn) == true)
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
