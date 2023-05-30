using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DoAnQLCH
{
    public partial class frm_ThongTinCaNhan : Form
    {
        public frm_ThongTinCaNhan()
        {
            InitializeComponent();
        }
        public frm_ThongTinCaNhan(string user,int quyen)
        {
            InitializeComponent();
            this.ma = user;
            this.quyen = quyen;
        }
        string ma;
        int quyen;
        private void frm_ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            HienThiChucVu();
            HienThiCuaHang();
            HienThiDSDatagridview();
            if(quyen==1)
            {
            }
            else if(quyen ==2)
            {
                Tat1();
            }
            else
            {
                Tat();
            }
                MenuItemDangNhap.Enabled = false;
        }
        public void Tat1()
        {
            MenuItemBaoCao.Enabled = false;
            MenuItemTaoTaiKhoan.Enabled = false;
            MenuItemQuanLy.Enabled = false;
            cboCuaHang.Enabled = false;
            cboChucVu.Enabled = false;
        }

        public void Tat()
        {
            MenuItemBaoCao.Enabled = false;
            MenuItemTaoTaiKhoan.Enabled = false;
            MenuItemQuanLy.Enabled = false;
            MenuItemLapPhieu.Enabled = false;
            MenuItemNhanVien.Enabled = false;
            cboChucVu.Enabled = false;
            cboCuaHang.Enabled = false;
            MenuItemBangLuong.Enabled = false;
        }
        string macv = "";
        string mach = "";
        public void HienThiDSDatagridview()
        {
            List<NhanVien_DTO> lst = NhanVien_BUS.ThongTinNhanVien(ma);
            NhanVien_DTO nv = lst[0];
            txtMa.Text = nv.SMaNV.ToString();
            txtHo.Text = nv.SHoLot.ToString();
            txtTen.Text = nv.STen.ToString();
            string phai = nv.SPhai.ToString();
            if (phai == "Nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            dtpNgaySinh.Value = nv.DtNgaySinh;
            txtSDT.Text = nv.SSdt.ToString();
            txtEmail.Text = nv.SEmail.ToString();
            txtDiaChi.Text = nv.SDiaChi.ToString();
            cmbTinh.Text = nv.STinh.ToString();
            macv = nv.SMaCV.ToString();
            cboChucVu.SelectedValue = macv;
            mach = nv.SMaCH.ToString();
            cboCuaHang.SelectedValue = mach;

        }

        public void HienThiChucVu()
        {
            List<ChucVu_DTO> lstChucVu = ChucVu_BUS.LayChucVu();
            cboChucVu.DataSource = lstChucVu;
            cboChucVu.DisplayMember = "STenCV";
            cboChucVu.ValueMember = "SMaCV";
        }

        public void HienThiCuaHang()
        {
            List<CuaHang_DTO> lstCuaHang = CuaHang_BUS.LayCuaHang();
            cboCuaHang.DataSource = lstCuaHang;
            cboCuaHang.DisplayMember = "STenCH";
            cboCuaHang.ValueMember = "SMaCH";
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DialogResult traloisua;
            traloisua = MessageBox.Show("Bạn có muốn sửa nhân viên không không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloisua == DialogResult.OK)
            {
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
                nv.SDiaChi = txtDiaChi.Text;
                nv.STinh = cmbTinh.Text;
                if (quyen == 1)
                {
                    nv.SMaCV = cboChucVu.SelectedValue.ToString();
                    nv.SMaCH = cboCuaHang.SelectedValue.ToString();
                }
                else
                {
                    nv.SMaCV = macv;
                    nv.SMaCH = mach;

                }

                if (NhanVien_BUS.SuaNhanVien(nv) == true)
                {
                    MessageBox.Show("Đã sữa thành công");
                }
                else
                {
                    MessageBox.Show("Sửa Không Thành Công");
                    return;
                }
            }

        }

        frm_CuaHang fcuahang;
        frm_ChucVu fchucvu;
        frm_HangHoa fhanghoa;
        frm_LapPhieu fphieu;
        frm_Loai floai;
        frm_NhaCungCap fncc;
        frm_XemDanhSach fds;
        frm_QuanLy fquanly;
        frm_DangNhap fdangnhap;
        frm_DoiMatKhau fdmk;
        frm_TaoTaiKhoan fdangky;
        frm_BangLuong fbl;


        private void MenuItemCuaHang_Click(object sender, EventArgs e)
        {
            fcuahang = new frm_CuaHang();
            fcuahang.Show();
        }

        private void MenuItemLoai_Click(object sender, EventArgs e)
        {
            floai = new frm_Loai();
            floai.Show();
        }

        private void MenuItemNCC_Click(object sender, EventArgs e)
        {
            fncc = new frm_NhaCungCap();
            fncc.ShowDialog();
        }

        private void MenuItemChucVu_Click(object sender, EventArgs e)
        {
            fchucvu = new frm_ChucVu();
            fchucvu.ShowDialog();
        }

        private void MenuItemLapPhieu_Click(object sender, EventArgs e)
        {
                fphieu = new frm_LapPhieu();
                fphieu.Show();
        }

        private void MenuItemNhanVien_Click(object sender, EventArgs e)
        {
            fquanly = new frm_QuanLy();
            fquanly.Show();
        }

        private void MenuItemBaoCao_Click(object sender, EventArgs e)
        {
            
        }

        private void MenuItemXemDS_Click(object sender, EventArgs e)
        {
            fds = new frm_XemDanhSach();
            fds.Show();
        }

        private void MenuItemDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            fdangnhap = new frm_DangNhap();
            fdangnhap.ShowDialog();
        }

        private void MenuItemDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            fdangnhap = new frm_DangNhap();
            fdangnhap.ShowDialog();
            this.Close();
            /*List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {
                if(f.Name != "frm_DangNhap")
                {
                    f.Close();
                }
            }*/
        }

        private void MenuItemDoiMatKhau_Click(object sender, EventArgs e)
        {
            fdmk = new frm_DoiMatKhau();
            fdmk.Show();
        }

        private void MenuItemTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            fdangky = new frm_TaoTaiKhoan();
            fdangky.Show();
        }

        private void MenuItemThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuItemBangLuong_Click(object sender, EventArgs e)
        {
            fbl = new frm_BangLuong();
            fbl.Show();
        }

        private void MenuItemHangHoa_Click(object sender, EventArgs e)
        {
            fhanghoa = new frm_HangHoa();
            fhanghoa.Show();
        }

        private void MenuItemNhap_Click(object sender, EventArgs e)
        {
            frm_bcNhap fnhap = new frm_bcNhap();
            fnhap.Show();
        }

        private void MenuItemBan_Click(object sender, EventArgs e)
        {
            frm_bcBan fban = new frm_bcBan();
            fban.Show();
        }

        private void MenuItembcBangLuong_Click(object sender, EventArgs e)
        {
            frm_bcBangLuong fb = new frm_bcBangLuong();
            fb.Show();
        }

        private void MenuItemSaoLuu_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog saoluu = new FolderBrowserDialog();
            saoluu.Description = "Chọn thư mục lưu trữ";

            if (saoluu.ShowDialog() == DialogResult.OK)
            {
                string DuongDan = saoluu.SelectedPath;

                if (CSDL_BUS.SaoLuu(DuongDan))
                {
                    MessageBox.Show("Đã sao lưu dữ liệu vào " + DuongDan);
                }
                else
                {
                    MessageBox.Show("Thao tác không thành công");
                }
            }
        }

        private void MenuItemKhoiPhuc_Click(object sender, EventArgs e)
        {
            OpenFileDialog phuchoi = new OpenFileDialog();
            phuchoi.Filter = "*.bak|*.bak";
            phuchoi.Title = "Chọn tập tin phục hồi (.bak)";

            if (phuchoi.ShowDialog() == DialogResult.OK && phuchoi.CheckFileExists)
            {
                string DuongDan = phuchoi.FileName;

                if (CSDL_BUS.PhucHoi(DuongDan) == true)
                {
                    MessageBox.Show("Phục hồi dữ liệu thành công!");
                }
                else
                {
                    MessageBox.Show("Phục hồi dữ liệu thất bại!");
                }
            }
        }

        private void MenuItemKhachHang_Click(object sender, EventArgs e)
        {
            frm_KhachHang fkh = new frm_KhachHang();
            fkh.Show();
        }

        private void MenuItemDoanhThu_Click(object sender, EventArgs e)
        {
            frm_baocao fbc = new frm_baocao();
            fbc.Show();
        }

        private void MenuItemHuongDan_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "QLCHHELP.chm");
        }
    }
}
