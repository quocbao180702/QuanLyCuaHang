using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQLCH
{
    public partial class frm_HangHoa : Form
    {
        public frm_HangHoa()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHH.Text == "" || txtTenHH.Text == "" || txtDVT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            if (txtMaHH.Text.Length < 5)
            {
                MessageBox.Show("Mã cửa hàng phải đủ 6 ký tự!");
                return;
            }
            /*if (HangHoa_BUS.TimMaHangHoa(txtMaHH.Text) != null)
            {
                MessageBox.Show("Mã Cửa Hàng Đã Tồn Tại");
                return;
            }*/
            HangHoa_DTO hh = new HangHoa_DTO();
            hh.SMaHH = txtMaHH.Text;
            hh.STenHH = txtTenHH.Text;
            hh.SDVT = txtDVT.Text;
            hh.SMaLoai = cboLoai.SelectedValue.ToString(); ;
            hh.SMaCH = cboCuaHang.SelectedValue.ToString(); ;
            hh.ISoLuong = (int)numSoLuong.Value;
            if (HangHoa_BUS.ThemHangHoa(hh) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiHangHoa();
            MessageBox.Show("Thêm cửa hàng thành công");

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaHH.ResetText();
            txtTenHH.ResetText();
            txtDVT.ResetText();
            cboLoai.ResetText();
            cboCuaHang.ResetText();
            numSoLuong.ResetText();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvHangHoa.SelectedRows[0];
            String mahh = r.Cells["SMaHH"].Value.ToString();
            MessageBox.Show(mahh);
            if (HangHoa_BUS.XoaHangHoa(mahh) == true)
            {
                MessageBox.Show("Đã xóa hàng hóa");
            }
            HienThiHangHoa();
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            frm_HangHoa_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult traloisua;
            traloisua = MessageBox.Show("Bạn có muốn sửa hàng hóa không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloisua == DialogResult.OK)
            {
                HangHoa_DTO hh = new HangHoa_DTO();
                hh.SMaHH = txtMaHH.Text;
                hh.STenHH = txtTenHH.Text;
                hh.SDVT = txtDVT.Text;
                hh.SMaLoai = cboLoai.SelectedValue.ToString();
                hh.SMaCH = cboCuaHang.SelectedValue.ToString();
                hh.ISoLuong = (int)numSoLuong.Value;

                if (HangHoa_BUS.SuaHangHoa(hh) == true)
                {
              

                    MessageBox.Show("Đã sữa thành công");
                    HienThiHangHoa();
                }
                else
                {
                    MessageBox.Show("Sửa Không Thành Công");
                    return;
                }
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {

        }

        private void btnXemLoai_Click(object sender, EventArgs e)
        {
            string ma = cboLoaiXem.SelectedValue.ToString();
            List<object> lst = HangHoa_BUS.LayAllHangHoa_TheoLoai(ma);
            dgvHangHoa.DataSource = lst;
        }

        private void btnXemCH_Click(object sender, EventArgs e)
        {
            String ma = cboCuaHangLoc.SelectedValue.ToString();
            List<object> lst = HangHoa_BUS.LayAllHangHoa_TheoCuaHang(ma);
            dgvHangHoa.DataSource = lst;
        }

        private void dgvHangHoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = dgvHangHoa.SelectedRows[0];
            txtMaHH.Text = r.Cells["SMaHH"].Value.ToString();
            txtTenHH.Text = r.Cells["STenHH"].Value.ToString();
            txtDVT.Text = r.Cells["SDVT"].Value.ToString();
            cboLoai.SelectedValue = r.Cells["SMaLoai"].Value.ToString();
            cboCuaHang.SelectedValue = r.Cells["SMaCH"].Value.ToString();
            numSoLuong.Value = int.Parse(r.Cells["ISoLuong"].Value.ToString());
        }

        private void frm_HangHoa_Load(object sender, EventArgs e)
        {
            HienThiHangHoa();
            LoadLoai();
            CuaHang();
        }
        public void HienThiHangHoa()
        {
            List<object> lst = HangHoa_BUS.LayAllHangHoa();
            dgvHangHoa.DataSource = lst;
            dgvHangHoa.Columns["SMaHH"].HeaderText = "Mã Hàng Hóa";
            dgvHangHoa.Columns["STenHH"].HeaderText = "Tên Hàng Hóa";
            dgvHangHoa.Columns["SDVT"].HeaderText = "Đơn Vị Tính";
            dgvHangHoa.Columns["SMaLoai"].HeaderText = "Mã Loại";
            dgvHangHoa.Columns["STenLoai"].HeaderText = "Tên Loại";
            dgvHangHoa.Columns["SMaCH"].HeaderText = "Mã Cửa Hàng";
            dgvHangHoa.Columns["STenCH"].HeaderText = "Tên Cửa Hàng";
            dgvHangHoa.Columns["ISoLuong"].HeaderText = "Số Lượng";

            // dgvChucVu.Columns["SMaCV"].Width = 80;

            dgvHangHoa.Columns["SMaHH"].Width = 60; 
            dgvHangHoa.Columns["STenHH"].Width = 100 ;
            dgvHangHoa.Columns["SDVT"].Width = 60;
            dgvHangHoa.Columns["SMaLoai"].Width = 60;
            dgvHangHoa.Columns["STenLoai"].Width = 100;
            dgvHangHoa.Columns["SMaCH"].Width = 60;
            dgvHangHoa.Columns["STenCH"].Width = 120;
            dgvHangHoa.Columns["ISoLuong"].Width = 40;



        }
        public void LoadLoai()
        {
            List<LoaiHangHoa_DTO> lstLoai = LoaiHangHoa_BUS.LayLoaiHangHoa();
            cboLoai.DataSource = lstLoai;
            cboLoai.ValueMember = "SMaLoai";
            cboLoai.DisplayMember = "STenLoai";

            cboLoaiXem.DataSource = lstLoai;
            cboLoaiXem.ValueMember = "SMaLoai";
            cboLoaiXem.DisplayMember = "STenLoai";
        }
        public void CuaHang()
        {
            List<CuaHang_DTO> lstCuaHang = CuaHang_BUS.LayCuaHang();
            cboCuaHang.DataSource = lstCuaHang;
            cboCuaHang.DisplayMember = "STenCH";
            cboCuaHang.ValueMember = "SMaCH";

            cboCuaHangLoc.DataSource = lstCuaHang;
            cboCuaHangLoc.DisplayMember = "STenCH";
            cboCuaHangLoc.ValueMember = "SMaCH";

        }
    }
}
