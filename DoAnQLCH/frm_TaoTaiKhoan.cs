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
    public partial class frm_TaoTaiKhoan : Form
    {
        public frm_TaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void frm_TaoTaiKhoan_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        public void hienthi()
        {
            List<DangNhap_DTO> lst = DangNhap_BUS.NhanVienChuaCoTaiKhoan();
            cboTaiKhoan.DataSource = lst;
            cboTaiKhoan.ValueMember = "SUserName";
            cboTaiKhoan.DisplayMember = "SUserName";
            
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if(txtMatKhau.Text != txtXacNhanMK.Text)
            {
                MessageBox.Show("Mật Khẩu và Xác Nhận Mật Khẩu phải giống nhau");
                txtXacNhanMK.ResetText();
                return;
            }
            if(txtXacNhanMK.Text == "" || txtMatKhau.Text =="" ||cboQuyen.SelectedItem == null)
            {
                MessageBox.Show("Vui Lòng Điền Đầy Đủ ");
                return;
            }
            DangNhap_DTO dn = new DangNhap_DTO();
            dn.SUserName = cboTaiKhoan.SelectedValue.ToString();
            string ma = txtMatKhau.Text;
            dn.IQuyen = int.Parse(cboQuyen.SelectedItem.ToString());
            if (DangNhap_BUS.ThemNguoiDung(dn, ma)== false)
            {
                MessageBox.Show("Thêm Tài Khoản Không Thành Công");
            }
            DialogResult traloisua;
            traloisua = MessageBox.Show("Bạn Đã Tạo Tài Khoản Thành Công. Đăng Nhập Ngay?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloisua == DialogResult.OK)
            {
                this.Hide();
                frm_DangNhap fdangnhap = new frm_DangNhap();
                fdangnhap.ShowDialog();
                this.Close();
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtMatKhau.PasswordChar = '\0';
                txtXacNhanMK.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
                txtXacNhanMK.PasswordChar = '*';
            }
        }
    }
}
