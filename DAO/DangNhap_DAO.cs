
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DangNhap_DAO
    {
        static SqlConnection conn;

        // Lấy thông tin người dùng có tên đăng nhập và mật khẩu tương ứng, trả về null nếu không thấy
        public static DangNhap_DTO LayNguoiDung(string ten, string matkhau)
        {
            string sTruyVan = string.Format(@"select * from dangnhap where username=N'{0}' and passwords='{1}'", ten, matkhau);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            DangNhap_DTO nd = new DangNhap_DTO();
            nd.SUserName = dt.Rows[0]["username"].ToString();
            nd.SPasswords = dt.Rows[0]["passwords"].ToString();
            nd.IQuyen = int.Parse(dt.Rows[0]["quyen"].ToString());

            DataProvider.DongKetNoi(conn);
            return nd;
        }
 

        public static bool CapNhatNguoiDung(DangNhap_DTO nd)
        {
            string sql = string.Format(@"update dangnhap set passwords='{0}' where username ='{1}'", nd.SPasswords, nd.SUserName);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sql, conn);
            return kq;
        }

        public static List<DangNhap_DTO> NhanVienChuaCoTaiKhoan()
        {
            string sql = string.Format(@"SELECT nhanvien.manv
                                        FROM nhanvien
                                        WHERE manv NOT IN (SELECT username FROM dangnhap)");
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sql, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DangNhap_DTO> lstdn = new List<DangNhap_DTO>();
            for(int i = 0;i<dt.Rows.Count; i++)
            {
                DangNhap_DTO dn = new DangNhap_DTO();
                dn.SUserName = dt.Rows[i]["manv"].ToString();
                lstdn.Add(dn);
            }
            DataProvider.DongKetNoi(conn);
            return lstdn;
        }
        public static bool ThemTaiKhoan(DangNhap_DTO dn)
        {
            string str = string.Format(@"insert into dangnhap values('{0}','{1}',{2})", dn.SUserName,dn.SPasswords,dn.IQuyen);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(str, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

    }
}
