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
    public partial class frm_Loai : Form
    {
        public frm_Loai()
        {
            InitializeComponent();
        }

        private void frm_ThemLoai_Load(object sender, EventArgs e)
        {
            HienThiLoaiHangHoa();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.Text == "" || txtTenLoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            if (txtMaLoai.Text.Length < 1)
            {
                MessageBox.Show("Mã Loại phải đủ 2 ký tự!");
                return;
            }
            if (LoaiHangHoa_BUS.TimMaLoaiHangHoa(txtMaLoai.Text) != null)
            {
                MessageBox.Show("Mã Loại Đã Tồn Tại");
                return;
            }
            LoaiHangHoa_DTO lhh = new LoaiHangHoa_DTO();
            lhh.SMaLoai = txtMaLoai.Text;
            lhh.STenLoai = txtTenLoai.Text;

            if (LoaiHangHoa_BUS.ThemLoaiHangHoa(lhh) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiLoaiHangHoa();
            MessageBox.Show("Thêm Loại thành công");

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvLoai.SelectedRows[0];
            String maloai = r.Cells["SMaLoai"].Value.ToString(); ;
            if (LoaiHangHoa_BUS.XoaLoaiHangHoa(maloai) == true)
            {
                MessageBox.Show("Đã xóa loại hàng hóa");
            }
            else
            {
                MessageBox.Show("Xóa Không Thành Công");
            }
            HienThiLoaiHangHoa();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult traloisua;
            traloisua = MessageBox.Show("Bạn có muốn sửa loại hàng hóa không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloisua == DialogResult.OK)
            {
                LoaiHangHoa_DTO ch = new LoaiHangHoa_DTO();
                ch.SMaLoai = txtMaLoai.Text;
                ch.STenLoai = txtTenLoai.Text;
                if (LoaiHangHoa_BUS.SuaLoaiHangHoa(ch) == true)
                {
                    MessageBox.Show("Đã sữa thành công");
                }
                else
                {
                    MessageBox.Show("Sửa Không Thành Công");
                    return;
                }
                HienThiLoaiHangHoa();
            }
        }
        public void HienThiLoaiHangHoa()
        {
           List<LoaiHangHoa_DTO> lhh = LoaiHangHoa_BUS.LayLoaiHangHoa();
            dgvLoai.DataSource = lhh;
            dgvLoai.Columns["SMaLoai"].HeaderText = "Mã Loại";
            dgvLoai.Columns["STenLoai"].HeaderText = "Tên Loại";

            dgvLoai.Columns["SMaLoai"].Width = 60;
            dgvLoai.Columns["STenLoai"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        }


        private void dgvLoai_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = dgvLoai.SelectedRows[0];
            txtMaLoai.Text = r.Cells["SMaLoai"].Value.ToString();
            txtTenLoai.Text = r.Cells["STenLoai"].Value.ToString();
        }
    }
}
