using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQLCH
{
    public partial class frm_BangLuong : Form
    {
        public frm_BangLuong()
        {
            InitializeComponent();
        }

        private void frm_BangLuong_Load(object sender, EventArgs e)
        {
            load_MaNV();
            HienThiBangLuong();
        }
        public void HienThiBangLuong()
        {
            List<BangLuong_DTO> lst = BangLuong_BUS.LayBangLuong();
            dgvBangLuong.DataSource = lst;

            dgvBangLuong.Columns["SMaNV"].HeaderText = "Mã Nhân Viên";
            dgvBangLuong.Columns["SNgayBD"].HeaderText = "Ngày Bắt Đầu";
            dgvBangLuong.Columns["SThang"].HeaderText = "Tháng";
            dgvBangLuong.Columns["SNam"].HeaderText = "Năm";
            dgvBangLuong.Columns["ITongNgayCong"].HeaderText = "Ngày Công";
            dgvBangLuong.Columns["FLuongcb"].HeaderText = "Lương Cơ Bản";
            dgvBangLuong.Columns["FTienThuong"].HeaderText = "Tiền Thưởng";
            dgvBangLuong.Columns["FTongLuong"].HeaderText = "Tổng Lương";
            dgvBangLuong.Columns["STinhTrang"].HeaderText = "Đã Thanh Toán";
        }

        private void MenuItemThemLuong_Click(object sender, EventArgs e)
        {
            BangLuong_DTO bll = new BangLuong_DTO();
            bll.SMaNV = cboMaNV.SelectedValue.ToString();
            bll.SNgayBD = DateTime.Parse(dtpNgayBD.Text);
            bll.SThang = int.Parse(cboThang.Text);
            bll.SNam = int.Parse(txtNam.Text);
            bll.ITongNgayCong = int.Parse(numSoNgayLam.Value.ToString());
            bll.Fluongcb = Double.Parse(txtLuongCB.Text);
            bll.FTienThuong = Double.Parse(txtTienThuong.Text);
            if(chkThanhToan.Checked == true)
            {
                bll.STinhTrang = true;
            }
            else
            {
                bll.STinhTrang = false;
            }
            if (BangLuong_BUS.ThemNhanVien(bll) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiBangLuong();
            MessageBox.Show("Thêm Bảng lương thành công");
        }

        public void load_MaNV()
        {
            List<BangLuong_DTO> lst = BangLuong_BUS.NhanVienChucCoLuong();
            cboMaNV.DataSource = lst;
            cboMaNV.ValueMember = "SMaNV";
            cboMaNV.DisplayMember = "SMaNV";
        }

        private void MenuItemXoaLuong_Click(object sender, EventArgs e)
        {
            DataGridViewRow r;
            r = dgvBangLuong.SelectedRows[0];
            string ma = r.Cells["SMaNV"].Value.ToString();
            if (BangLuong_BUS.XoaBangLuong(ma) == true)
            {
                MessageBox.Show("Đã xóa Bảng Lương");
            }
            else
            {
                MessageBox.Show("Xóa Không Thành Công");
            }
            HienThiBangLuong();
        }

        private void dgvBangLuong_Click(object sender, EventArgs e)
        {
            DataGridViewRow r;
            r = dgvBangLuong.SelectedRows[0];

            cboMaNV.Text = r.Cells["SMaNV"].Value.ToString();
            dtpNgayBD.Value = DateTime.Parse(r.Cells["SNgayBD"].Value.ToString());
            cboThang.SelectedItem = r.Cells["SThang"].Value.ToString();
            txtNam.Text = r.Cells["SNam"].Value.ToString();
            numSoNgayLam.Value = int.Parse(r.Cells["ITongNgayCong"].Value.ToString());
            txtLuongCB.Text = r.Cells["Fluongcb"].Value.ToString();
            txtTienThuong.Text = r.Cells["FTienThuong"].Value.ToString();
            if (bool.Parse(r.Cells["STinhTrang"].Value.ToString()) == true)
            {
                chkThanhToan.Checked = true;
            }
            else
            {
                chkThanhToan.Checked = false;
            }
        }

        private void MenuItemSuaLuong_Click(object sender, EventArgs e)
        {
            DataGridViewRow r;
            r = dgvBangLuong.SelectedRows[0];

            DialogResult traloisua;
            traloisua = MessageBox.Show("Bạn có muốn sửa nhân viên không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloisua == DialogResult.OK)
            {
                BangLuong_DTO bll = new BangLuong_DTO();
                bll.SMaNV = cboMaNV.Text.ToString();
                bll.SNgayBD = DateTime.Parse(dtpNgayBD.Text);
                bll.SThang = int.Parse(cboThang.Text);
                bll.SNam = int.Parse(txtNam.Text);
                bll.ITongNgayCong = int.Parse(numSoNgayLam.Value.ToString());
                bll.Fluongcb = Double.Parse(txtLuongCB.Text);
                bll.FTienThuong = Double.Parse(txtTienThuong.Text);
                if (chkThanhToan.Checked == true)
                {
                    bll.STinhTrang = true;
                }
                else
                {
                    bll.STinhTrang = false;
                }
                if (BangLuong_BUS.SuaBangLuong(bll) == true)
                {
                    MessageBox.Show("Đã sữa thành công");
                }
                else
                {
                    MessageBox.Show("Sửa Không Thành Công");
                    MessageBox.Show(cboMaNV.Text.ToString());
                    return;
                }
                HienThiBangLuong();
            }
        }

        private void MenuItemBaoCaoLuong_Click(object sender, EventArgs e)
        {
            frm_bcBangLuong bc = new frm_bcBangLuong();
            this.Hide();
            bc.Show();
        }
    }
}
