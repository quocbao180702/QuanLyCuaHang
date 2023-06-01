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
    public partial class frm_LapPhieu : Form
    {
        public frm_LapPhieu()
        {
            InitializeComponent();
        }

        private void frm_LapPhieu_Load(object sender, EventArgs e)
        {
            LoadHangHoa();
            LoadCuaHang();
            LoadNhaCungCap();
            HienThiNhap();
            HienThiBan();
        }
        public void HienThiNhap()
        {
            List<Nhap_DTO> lstnhap = Nhap_BUS.LayDSNhap();
            dgvNhap.DataSource = lstnhap;
            dgvNhap.Columns["SMaHDN"].HeaderText = "Mã Hóa Đơn Nhập";
            dgvNhap.Columns["SMaNV"].HeaderText = "Mã Nhân Viên";
            dgvNhap.Columns["SMaNCC"].HeaderText = "Mã Nhà Cung Cấp";
            dgvNhap.Columns["SMaCH"].HeaderText = "Mã Cửa Hàng";
            dgvNhap.Columns["SMaHH"].HeaderText = "Mã Hàng Hóa";
            dgvNhap.Columns["ISoLuong"].HeaderText = "Số Lượng";
            dgvNhap.Columns["FDonGia"].HeaderText = "Đơn Giá";
            dgvNhap.Columns["SNgayNhap"].HeaderText = "Ngày Nhập";
            dgvNhap.Columns["DTongTienNhap"].HeaderText = "Tổng Tiền";
            dgvNhap.Columns["STenCH"].HeaderText = "Tên Cửa Hàng";
            dgvNhap.Columns["SHoLot"].HeaderText = "Họ Lót NV Nhập";
            dgvNhap.Columns["STennv"].HeaderText = "Tên NV Nhập";
            dgvNhap.Columns["STenNCC"].HeaderText = "Tên Nhà Cung Cấp";
            dgvNhap.Columns["STenHH"].HeaderText = "Tên Hàng Hóa";

            dgvNhap.Columns["SMaHDN"].Width = 80;
            dgvNhap.Columns["SMaNV"].Width = 80;
            dgvNhap.Columns["SMaNCC"].Width = 90;
            dgvNhap.Columns["SMaCH"].Width = 90;
            dgvNhap.Columns["SMaHH"].Width = 60;
            dgvNhap.Columns["ISoLuong"].Width = 60;
            dgvNhap.Columns["FDonGia"].Width = 60;
            dgvNhap.Columns["SNgayNhap"].Width = 90;
            dgvNhap.Columns["DTongTienNhap"].Width = 70;
            dgvNhap.Columns["STenCH"].Width = 160;
            dgvNhap.Columns["SHoLot"].Width = 100;
            dgvNhap.Columns["STennv"].Width = 100;
            dgvNhap.Columns["STenNCC"].Width = 120;
            dgvNhap.Columns["STenHH"].Width = 100;
        }
        public void HienThiBan()
        {
            List<Ban_DTO> lstban = Ban_BUS.LayDSBan();
            dgvPhieuXuat.DataSource = lstban;
            dgvPhieuXuat.Columns["SMaHDB"].HeaderText = "Mã Hóa Đơn Bán";
            dgvPhieuXuat.Columns["SMaNV"].HeaderText = "Mã Nhân Viên";
            dgvPhieuXuat.Columns["SMaKH"].HeaderText = "Mã Khách Hàng";
            dgvPhieuXuat.Columns["SMaHH"].HeaderText = "Mã Hàng Hóa";
            dgvPhieuXuat.Columns["ISoLuong"].HeaderText = "Số Lượng";
            dgvPhieuXuat.Columns["FDonGia"].HeaderText = "Đơn Giá";
            dgvPhieuXuat.Columns["DTongTienBan"].HeaderText = "Tổng Tiền";
            dgvPhieuXuat.Columns["SNgayBan"].HeaderText = "Ngày Bán";
            dgvPhieuXuat.Columns["STenCH"].HeaderText = "Tên Cửa Hàng";
            dgvPhieuXuat.Columns["SHoLot"].HeaderText = "Họ Lót NV Bán";
            dgvPhieuXuat.Columns["STennv"].HeaderText = "Tên NV Bán";
            dgvPhieuXuat.Columns["SHoLotKH"].HeaderText = "Họ Lót KH Mua";
            dgvPhieuXuat.Columns["STenKH"].HeaderText = "Tên KH Mua";
            dgvPhieuXuat.Columns["STenHH"].HeaderText = "Tên Hàng Hóa";
            
            dgvPhieuXuat.Columns["SMaHDB"].Width = 90;
            dgvPhieuXuat.Columns["SMaNV"].Width = 90;
            dgvPhieuXuat.Columns["SMaKH"].Width = 100;
            dgvPhieuXuat.Columns["SMaCH"].Width = 100;
            dgvPhieuXuat.Columns["SMaHH"].Width = 100;
            dgvPhieuXuat.Columns["ISoLuong"].Width = 90;
            dgvPhieuXuat.Columns["FDonGia"].Width = 90;
            dgvPhieuXuat.Columns["SNgayBan"].Width = 100;
            dgvPhieuXuat.Columns["DTongTienBan"].Width = 90;
            dgvPhieuXuat.Columns["STenCH"].Width = 160;
            dgvPhieuXuat.Columns["SHoLot"].Width = 100;
            dgvPhieuXuat.Columns["STennv"].Width = 100;
            dgvPhieuXuat.Columns["SHoLotKH"].Width = 100;
            dgvPhieuXuat.Columns["STenKH"].Width = 100;
            dgvPhieuXuat.Columns["STenHH"].Width = 100;
        }
        public void LoadHangHoa()
        {
            List<HangHoa_DTO> lsthh = HangHoa_BUS.LayHangHoa();
            cboTenHHN.DataSource = lsthh;
            cboTenHHN.DisplayMember = "STenHH";
            cboTenHHN.ValueMember = "SMaHH";

            cboHangHoaX.DataSource = lsthh;
            cboHangHoaX.DisplayMember = "STenHH";
            cboHangHoaX.ValueMember = "SMaHH";
        }
        public void LoadCuaHang()
        {
            List<CuaHang_DTO> lstcuahang = CuaHang_BUS.LayCuaHang();
            cboTenCHN.DataSource = lstcuahang;
            cboTenCHN.DisplayMember = "STenCH";
            cboTenCHN.ValueMember = "SMaCH";

            cboCuaHangX.DataSource = lstcuahang;
            cboCuaHangX.DisplayMember = "STenCH";
            cboCuaHangX.ValueMember = "SMaCH";
        }
        public void LoadNhaCungCap()
        {
            List<NhaCungCap_DTO> lstncc = NhaCungCap_BUS.LayNhaCungCap();
            cboTenNCC.DataSource = lstncc;
            cboTenNCC.DisplayMember = "STenNCC";
            cboTenNCC.ValueMember = "SMaNCC";
        }
        private void dgvPhieuNhap_Click(object sender, EventArgs e)
        {
            DataGridViewRow dt = dgvNhap.SelectedRows[0];
            txtMaHDN.Text = dt.Cells["SMaHDN"].Value.ToString();
            txtMaNVN.Text = dt.Cells["SMaNV"].Value.ToString();
            txtDonGiaN.Text = dt.Cells["FDonGia"].Value.ToString();
            numSoLuongN.Value = (int)dt.Cells["ISoLuong"].Value;
            dtpNgayNhapN.Value = DateTime.Parse(dt.Cells["SNgayNhap"].Value.ToString());
            txtTongTienNhap.Text = dt.Cells["DTongTienNhap"].Value.ToString();
            cboTenCHN.SelectedValue = dt.Cells["SMaCH"].Value.ToString();
            cboTenHHN.SelectedValue = dt.Cells["SMaHH"].Value.ToString();
            cboTenNCC.SelectedValue = dt.Cells["SMaNCC"].Value.ToString();

        }

        private void btnThemN_Click(object sender, EventArgs e)
        {
            Nhap_DTO nhap = new Nhap_DTO();
            nhap.SMaHDN = txtMaHDN.Text;
            nhap.SMaHH = cboTenHHN.SelectedValue.ToString();
            nhap.ISoLuong = (int)numSoLuongN.Value;
            nhap.FDonGia = float.Parse(txtDonGiaN.Text);
            if (Nhap_BUS.ThemSanPham_PhieuNhap(nhap)== false)
            {
                MessageBox.Show("Không thêm được.");
                MessageBox.Show(nhap.SMaHDN + nhap.SMaHH + nhap.ISoLuong + nhap.FDonGia);
                return;
            }

            HienThiNhap();
            MessageBox.Show("Đã thêm thành công.");
        }

        private void btnHuyN_Click(object sender, EventArgs e)
        {
            txtMaHDN.ResetText();
            txtMaNVN.ResetText();
            txtDonGiaN.ResetText();
            numSoLuongN.ResetText();
            dtpNgayNhapN.ResetText();
            txtTongTienNhap.ResetText();
            cboTenCHN.ResetText();
            cboTenHHN.ResetText();
            cboTenNCC.ResetText();
        }

        private void btnSuaN_Click(object sender, EventArgs e)
        {
            DialogResult traloisua;
            traloisua = MessageBox.Show("Bạn có muốn sửa phiếu nhập không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloisua == DialogResult.OK)
            {
                Nhap_DTO nhap = new Nhap_DTO();
                nhap.SMaHDN = txtMaHDN.Text;
                nhap.SMaHH = cboTenHHN.SelectedValue.ToString();
                nhap.ISoLuong = (int)numSoLuongN.Value;
                nhap.FDonGia = float.Parse(txtDonGiaN.Text);

                if (Nhap_BUS.SuaSanPham_Phieu(nhap) == true)
                {
                    MessageBox.Show("Sửa Thành Công");
                    
                }
                else
                {
                    MessageBox.Show("Không sửa được.");
                    MessageBox.Show(nhap.SMaHDN + nhap.SMaHH + nhap.ISoLuong + nhap.FDonGia);
                    return;
                }
                HienThiNhap();
                MessageBox.Show("Đã sửa thành công.");
            }
        }

        private void btnXoaN_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvNhap.SelectedRows[0];
            String mahdn = r.Cells["SMaHDN"].Value.ToString();
            String mahh = r.Cells["SMaHH"].Value.ToString();
            if (Nhap_BUS.XoaSanPham_PhieuNhap(mahdn,mahh) == true)
            {
                MessageBox.Show("Đã xóa sản phẩm");
            }
            else
            {
                MessageBox.Show("Đã xóa đã xóa sẩn phẩm không thành công");
                return;
            }
            HienThiNhap();
        }

        private void btnQuayLaiN_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_ThongTinCaNhan fthongtin = new frm_ThongTinCaNhan();
            fthongtin.Show();
            this.Close();
        }

        private void btnRefeshN_Click(object sender, EventArgs e)
        {
            frm_LapPhieu_Load(sender, e);
        }

        private void dgvPhieuXuat_Click(object sender, EventArgs e)
        {
            DataGridViewRow dt = dgvPhieuXuat.SelectedRows[0];
            txtMaHDB.Text = dt.Cells["SMaHDB"].Value.ToString();
            txtMaNVX.Text = dt.Cells["SMaNV"].Value.ToString();
            txtMaKHX.Text = dt.Cells["SMaKH"].Value.ToString();
            numSoLuongX.Value = (int)dt.Cells["ISoLuong"].Value;
            txtDonGiaX.Text = dt.Cells["FDonGia"].Value.ToString();
            txtTongTienBan.Text = dt.Cells["DTongTienBan"].Value.ToString();
            dtpNgayXuatX.Value = DateTime.Parse(dt.Cells["SNgayban"].Value.ToString());
            cboHangHoaX.SelectedValue = dt.Cells["SMaHH"].Value.ToString();
            cboCuaHangX.SelectedValue = dt.Cells["SMaCH"].Value.ToString();
        }

        private void btnThemX_Click(object sender, EventArgs e)
        {
            Ban_DTO  ban = new Ban_DTO();
            ban.SMaHDB = txtMaHDB.Text;
            ban.SMaNV = txtMaNVX.Text;
            ban.SMaKH = txtMaKHX.Text;
            ban.SMaCH = cboCuaHangX.SelectedValue.ToString();
            ban.SMaHH = cboHangHoaX.SelectedValue.ToString();
            ban.ISoLuong = (int)numSoLuongX.Value;
            ban.FDonGia = float.Parse(txtDonGiaX.Text);
            ban.SNgayBan = DateTime.Parse(dtpNgayXuatX.Text);

            if (Ban_BUS.ThemPhieuBan(ban) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }

            HienThiBan();
            MessageBox.Show("Đã thêm thành công.");
        }

        private void btnSuaX_Click(object sender, EventArgs e)
        {
            DialogResult traloisua;
            traloisua = MessageBox.Show("Bạn có muốn sửa phiếu xuất không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloisua == DialogResult.OK)
            {
                Ban_DTO ban = new Ban_DTO();
                ban.SMaHDB = txtMaHDB.Text;
                ban.SMaNV = txtMaNVX.Text;
                ban.SMaKH = txtMaKHX.Text;
                ban.SMaCH = cboCuaHangX.SelectedValue.ToString();
                ban.SMaHH = cboHangHoaX.SelectedValue.ToString();
                ban.ISoLuong = (int)numSoLuongX.Value;
                ban.FDonGia = float.Parse(txtDonGiaX.Text);
                ban.SNgayBan = DateTime.Parse(dtpNgayXuatX.Text);

                if(Ban_BUS.SuaPhieuBan(ban) == false)
                {
                    MessageBox.Show("Không Sửa được.");
                    return;
                }

                HienThiBan();
                MessageBox.Show("Đã sửa thành công.");

            }
        }


        private void btnXoaX_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvPhieuXuat.SelectedRows[0];
            String mahdb = r.Cells["SMaHDB"].Value.ToString();
            String mahh = r.Cells["SMaHH"].Value.ToString();
            if (Ban_BUS.XoaPhieuBan(mahh,mahdb) == true)
            {
                MessageBox.Show("Đã xóa phiếu xuất");
            }
            else
            {
                MessageBox.Show("Không Xóa Được");
                return;
            }
            HienThiBan();
        }

        private void btnQuayLaiX_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_ThongTinCaNhan fc = new frm_ThongTinCaNhan();
            fc.Show();
            this.Close();
        }

        private void btnRefeshX_Click(object sender, EventArgs e)
        {
            frm_LapPhieu_Load(sender, e);
        }

        private void btnHuyX_Click(object sender, EventArgs e)
        {
            txtMaHDB.ResetText();
            txtMaNVX.ResetText();
            txtDonGiaX.ResetText();
            numSoLuongX.ResetText();
            dtpNgayXuatX.ResetText();
            cboCuaHangX.ResetText();
            cboHangHoaX.ResetText();
            txtMaKHX.ResetText();
            txtTongTienBan.ResetText();
        }

        private void btnTimN_Click(object sender, EventArgs e)
        {
            if (txtMaNVN_Tim.Text != "")
            {
                String ma = txtMaNVN_Tim.Text;
                List<Nhap_DTO> lst = Nhap_BUS.LayDSHDN(ma);
                dgvNhap.DataSource = lst;
            }
            else
            {
                MessageBox.Show("Bạn được phép tìm Mã Hóa Đơn");
                txtMaNVN_Tim.ResetText();
            }
        }

        private void frm_LapPhieu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            frm_LapPhieu fphieu = null;
        }

        private void btnXuatHDN_Click(object sender, EventArgs e)
        {
            DataGridViewRow dt = dgvNhap.SelectedRows[0];
            string mahd = dt.Cells["SMaHDN"].Value.ToString();
            frm_bcNhap fbcn = new frm_bcNhap(mahd);
            fbcn.Show();
        }

        private void btnXuatHDB_Click(object sender, EventArgs e)
        {
            DataGridViewRow dt = dgvPhieuXuat.SelectedRows[0];
            string mahd = dt.Cells["SMaHDB"].Value.ToString();
            frm_bcBan fbcn = new frm_bcBan(mahd);
            fbcn.Show();
        }



        private void btnXemHD_Click(object sender, EventArgs e)
        {
            frm_HoaDon fhoadon = new frm_HoaDon();
            fhoadon.ShowDialog();
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            frmHoaDon_Ban fhdb = new frmHoaDon_Ban();
            fhdb.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnDs_Click(object sender, EventArgs e)
        {
            frm_NhaCungCap fncc = new frm_NhaCungCap();
            fncc.Show();
        }

        private void btnKhacHang_Click(object sender, EventArgs e)
        {
            frm_KhachHang fkh = new frm_KhachHang();
            fkh.Show();
        }

        private void btnTimX_Click(object sender, EventArgs e)
        {
            if (txtTimHDB.Text != "")
            {
                String ma = txtTimHDB.Text;
                List<Ban_DTO> lst = Ban_BUS.LayDSBan_TheoMa(ma);
                dgvPhieuXuat.DataSource = lst;
            }
            else
            {
                MessageBox.Show("Bạn được phép tìm Mã Hóa Đơn");
                txtMaNVN_Tim.ResetText();
            }
        }
    }
}
