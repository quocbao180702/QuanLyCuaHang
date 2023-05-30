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
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }


        private void ckbHienMK_Click(object sender, EventArgs e)
        {
            if(ckbHienMK.Checked==true)
            {
                txtMatKhau.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void lbkDoiMK_Click(object sender, EventArgs e)
        {
            frm_DoiMatKhau fdoi = new frm_DoiMatKhau();
            this.Hide();
            fdoi.ShowDialog();
            this.Close();
        }
        public void dangnhap()
        {
            DangNhap_DTO dn = new DangNhap_DTO();
            dn = DangNhap_BUS.LayNguoiDung(txtTaiKhoan.Text, txtMatKhau.Text);
            if (dn != null)//có dữ liệu 
            {
                frm_ThongTinCaNhan ftt = new frm_ThongTinCaNhan(dn.SUserName,dn.IQuyen);
                this.Hide();
                ftt.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài Khoản Hoặc Mật Khẩu Không Đúng");
                txtMatKhau.ResetText();
                txtTaiKhoan.ResetText();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            dangnhap();
        }
    }
}
