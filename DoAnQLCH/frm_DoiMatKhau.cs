using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQLCH
{
    public partial class frm_DoiMatKhau : Form
    {
        public frm_DoiMatKhau()
        {
            InitializeComponent();
        }

        private void frm_DoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            DangNhap_DTO dn = new DangNhap_DTO();
            dn = DangNhap_BUS.LayNguoiDung(txtTaiKhoan.Text, txtMatKhau.Text);
            if (dn != null)//có dữ liệu 
            {

                if (txtMatKhauMoi.Text != txtXacNhanMK.Text)
                {
                    MessageBox.Show("Mật Khẩu Mới và Xác Nhận Mật Khẩu Mới phải giống nhau");
                    txtXacNhanMK.ResetText();
                    return;
                }
                if (txtTaiKhoan.Text == "" || txtXacNhanMK.Text == "" || txtMatKhau.Text == "" || txtXacNhanMK.Text == "")
                {
                    MessageBox.Show("Vui Lòng Điền Đầy Đủ ");
                    return;
                }

                DialogResult traloisua;
                traloisua = MessageBox.Show("Bạn Có Muốn Đổi Mật Khẩu Không?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloisua == DialogResult.OK)
                {
                    DangNhap_DTO dnn = new DangNhap_DTO();
                    dnn.SUserName = txtTaiKhoan.Text;
                    string ma = txtMatKhauMoi.Text;

                    if (DangNhap_BUS.DoiMatKhau(dnn, ma) == false)
                    {
                        MessageBox.Show("Đổi Mật Khẩu Không Thành Công");
                        txtMatKhau.ResetText();
                        txtMatKhauMoi.ResetText();
                        txtXacNhanMK.ResetText();
                        return;
                    }
                }
                MessageBox.Show("Đổi Mật Khẩu Thành Công Vui Lòng Đăng Nhập Lại");
                this.Hide();
                frm_DangNhap fdangnhap = new frm_DangNhap();
                fdangnhap.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài Khoản Hoặc Mật Khẩu Không Đúng");
            } 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtMatKhauMoi.PasswordChar = '\0';
                txtMatKhau.PasswordChar = '\0';
                txtXacNhanMK.PasswordChar = '\0';
            }
            else
            {
                txtMatKhauMoi.PasswordChar = '*';
                txtMatKhau.PasswordChar = '*';
                txtXacNhanMK.PasswordChar = '*';
            }
        }
    }
}
