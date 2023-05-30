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
    public partial class frm_ChucVu : Form
    {
        public frm_ChucVu()
        {
            InitializeComponent();
        }


        public void HienThiChucVu()
        {
            List<ChucVu_DTO> lst = ChucVu_BUS.LayChucVu();
            dgvChucVu.DataSource = lst;
            dgvChucVu.Columns["SMaCV"].HeaderText = "Mã Chức Vụ";
            dgvChucVu.Columns["STenCV"].HeaderText = "Tên Chức Vụ";
            dgvChucVu.Columns["FHSPhuCap"].HeaderText = "Hệ Số Phụ Cấp";
            // dgvChucVu.Columns["SMaCV"].Width = 80;

            dgvChucVu.Columns["SMaCV"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dgvChucVu.Columns["STenCV"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dgvChucVu.Columns["FHSPhuCap"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaCV.Text == "" || txtTenCV.Text == "" || txtHsPhuCap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            if (txtMaCV.Text.Length <1)
            {
                MessageBox.Show("Mã cửa hàng phải đủ 2 ký tự!");
                return;
            }
            if (ChucVu_BUS.TimTheoMaChucVu(txtMaCV.Text) != null)
            {
                MessageBox.Show("Mã Cửa Hàng Đã Tồn Tại");
                return;
            }
            ChucVu_DTO cv = new ChucVu_DTO();
            cv.SMaCV = txtMaCV.Text;
            cv.STenCV = txtTenCV.Text;
            cv.FHSPhuCap = float.Parse(txtHsPhuCap.Text);
            if (ChucVu_BUS.ThemChucVu(cv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiChucVu();
            MessageBox.Show("Thêm cửa hàng thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvChucVu.SelectedRows[0];
            String mach = r.Cells["SMaCV"].Value.ToString(); ;
            if (ChucVu_BUS.XoaChucVu(mach) == true)
            {
                MessageBox.Show("Đã xóa nhân viên");
            }
            else
            {
                MessageBox.Show("Xóa Không Thành Công");
            }
            HienThiChucVu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult traloisua;
            traloisua = MessageBox.Show("Bạn có muốn sửa nhân viên không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloisua == DialogResult.OK)
            {
                ChucVu_DTO ch = new ChucVu_DTO();
                ch.SMaCV = txtMaCV.Text;
                ch.STenCV = txtTenCV.Text;
                ch.FHSPhuCap = float.Parse(txtHsPhuCap.Text);
                if (ChucVu_BUS.SuaChucVu(ch) == true)
                {
                    MessageBox.Show("Đã sữa thành công");
                }
                else
                {
                    MessageBox.Show("Sửa Không Thành Công");
                    return;
                }
                HienThiChucVu();
            }
        }

        private void frm_ChucVu_Load(object sender, EventArgs e)
        {
            HienThiChucVu();
        }

        private void dgvChucVu_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = dgvChucVu.SelectedRows[0];
            txtMaCV.Text = r.Cells["SMaCV"].Value.ToString();
            txtTenCV.Text = r.Cells["STenCV"].Value.ToString();
            txtHsPhuCap.Text = r.Cells["FHSPhuCap"].Value.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaCV.ResetText();
            txtTenCV.ResetText();
            txtHsPhuCap.ResetText();
        }
    }
}
