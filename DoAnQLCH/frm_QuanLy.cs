using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace DoAnQLCH
{
    public partial class frm_QuanLy : Form
    {
        public frm_QuanLy()
        {
            InitializeComponent();
        }

        private void frm_QuanLy_Load(object sender, EventArgs e)
        {
            HienThiDSDatagridview();
            HienThiChucVu();
            HienThiCuaHang();
        }
        public void HienThiDSDatagridview()
        {
            /*List<NhanVien_DTO> lstNhanVien = NhanVien_BUS.LayDSNhanVien();
            dgvNhanVien.DataSource = lstNhanVien;*/
            List<object> lst = NhanVien_BUS.NhanVienWithChucVuWithCuaHang();
            dgvNhanVien.DataSource = lst;
        }
        public void HienThiChucVu()
        {
            List<ChucVu_DTO> lstChucVu = ChucVu_BUS.LayChucVu();
            cmbChucVu.DataSource = lstChucVu;
            cmbChucVu.DisplayMember = "STenCV";
            cmbChucVu.ValueMember = "SMaCV";
            cmbLocChucVu.DataSource = lstChucVu;
            cmbLocChucVu.DisplayMember = "STenCV";
            cmbLocChucVu.ValueMember = "SMaCV";
        }
        public void HienThiCuaHang()
        {
            List<CuaHang_DTO> lstCuaHang = CuaHang_BUS.LayCuaHang();
            cmbCuaHang.DataSource = lstCuaHang;
            cmbCuaHang.DisplayMember = "STenCH";
            cmbCuaHang.ValueMember = "SMaCH";
            cmbLocCuaHang.DataSource = lstCuaHang;
            cmbLocCuaHang.DisplayMember = "STenCH";
            cmbLocCuaHang.ValueMember = "SMaCH";
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvNhanVien.SelectedRows[0];
            txtMa.Text = r.Cells["SMaNV"].Value.ToString();
            txtHo.Text = r.Cells["SHoLot"].Value.ToString();
            txtTen.Text = r.Cells["STen"].Value.ToString();
            if (r.Cells["SPhai"].Value.ToString() == "Nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            dtpNgaySinh.Text = r.Cells["DtNgaySinh"].Value.ToString();
            txtSDT.Text = r.Cells["SSdt"].Value.ToString();
            txtEmail.Text = r.Cells["SEmail"].Value.ToString();
            txtLuongCoBan.Text = r.Cells["FLuongcb"].Value.ToString();
            txtDiaChi.Text = r.Cells["SDiaChi"].Value.ToString();
            cmbTinh.Text = r.Cells["STinh"].Value.ToString();
            cmbChucVu.Text = r.Cells["STenCV"].Value.ToString();
            cmbCuaHang.Text = r.Cells["STenCH"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống 
            if (txtMa.Text == "" || txtHo.Text == "" || txtTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            if (txtMa.Text.Length > 6)
            {
                MessageBox.Show("Mã nhân viên tối đa 5 ký tự!");
                return;
            }
            // Kiểm tra mã nhân viên có bị trùng không
            if (NhanVien_BUS.TimNhanVienTheoMa(txtMa.Text) != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
                return;
            }
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.SMaNV = txtMa.Text;
            nv.SHoLot = txtHo.Text;
            nv.STen = txtTen.Text;
            if (radNam.Checked == true)
            {
                nv.SPhai = "Nam";
            }
            else
            {
                nv.SPhai = "Nữ";
            }
            nv.DtNgaySinh = DateTime.Parse(dtpNgaySinh.Text);
            nv.SSdt = txtSDT.Text;
            nv.SEmail = txtEmail.Text;
            nv.FLuongcb = float.Parse(txtLuongCoBan.Text);
            nv.SDiaChi = txtDiaChi.Text;
            nv.STinh = cmbTinh.Text;
            nv.SMaCV = cmbChucVu.SelectedValue.ToString();
            nv.SMaCH = cmbCuaHang.SelectedValue.ToString();
            if (NhanVien_BUS.ThemNhanVien(nv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }

            HienThiDSDatagridview();
            MessageBox.Show("Đã thêm nhân viên.");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhanVien_DTO nv = new NhanVien_DTO();
            DialogResult traloisua;
            traloisua = MessageBox.Show("Bạn có muốn sửa nhân viên không không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloisua == DialogResult.OK)
                nv.SMaNV = txtMa.Text;
            nv.SHoLot = txtHo.Text;
            nv.STen = txtTen.Text;
            if (radNam.Checked == true)
            {
                nv.SPhai = "Nam";
            }
            else
            {
                nv.SPhai = "Nữ";
            }
            nv.DtNgaySinh = DateTime.Parse(dtpNgaySinh.Text);
            nv.SSdt = txtSDT.Text;
            nv.SEmail = txtEmail.Text;
            nv.FLuongcb = float.Parse(txtLuongCoBan.Text);
            nv.SDiaChi = txtDiaChi.Text;
            nv.STinh = cmbTinh.Text;
            nv.SMaCV = cmbChucVu.SelectedValue.ToString();
            nv.SMaCH = cmbCuaHang.SelectedValue.ToString();

            if (NhanVien_BUS.SuaNhanVien(nv) == true)
            {
                MessageBox.Show("Đã sữa thành công");
            }
            else
            {
                MessageBox.Show("Sửa Không Thành Công");
                return;
            }
            HienThiDSDatagridview();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvNhanVien.SelectedRows[0];
            String manv = r.Cells["SMaNV"].Value.ToString();
            if (NhanVien_BUS.XoaNhanVien(manv) == true)
            {
                MessageBox.Show("Đã xóa nhân viên");
            }
            HienThiDSDatagridview();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn reset không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                this.txtMa.ResetText();
                this.txtHo.ResetText();
                this.txtTen.ResetText();
                this.radNam.Checked = false;
                this.radNu.Checked = false;
                this.dtpNgaySinh.ResetText();
                this.txtSDT.ResetText();
                this.txtEmail.ResetText();
                this.txtLuongCoBan.ResetText();
                this.txtDiaChi.ResetText();
                this.cmbTinh.ResetText();
                this.cmbChucVu.ResetText();
                this.cmbCuaHang.ResetText();
            }
        }

        private void cmbLocChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string macv = cmbChucVu.SelectedValue.ToString();
            List<NhanVien_DTO> lst = NhanVien_BUS.TimNhanVienTheoMaChucVu(macv);
            dgvNhanVien.DataSource = lst;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string ten = txtTimTenNV.Text;
            List<NhanVien_DTO> lstnv = NhanVien_BUS.TimNhanVienTheoTen(ten);
            if (lstnv == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dgvNhanVien.DataSource = lstnv;
        }
    }
}
