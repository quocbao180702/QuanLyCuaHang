using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhachHang_DAO
    {
        static SqlConnection conn;
        public static List<KhachHang_DTO> LayKhachHang()
        {
            string str = "select * from KhachHang";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(str, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhachHang_DTO> lst = new List<KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO kh = new KhachHang_DTO();
                kh.SMaKH = dt.Rows[i]["makh"].ToString();
                kh.SHoLotKH = dt.Rows[i]["holotkh"].ToString();
                kh.STenKH = dt.Rows[i]["tenkh"].ToString();
                kh.SPhai = dt.Rows[i]["phai"].ToString();
                kh.SNgaySinh = DateTime.Parse( dt.Rows[i]["ngaysinh"].ToString());
                lst.Add(kh);
            }
            DataProvider.DongKetNoi(conn);
            return lst;
        }
        public static bool ThemKhachHang(KhachHang_DTO kh)
        {
            string str = string.Format(@"insert into khachhang values('{0}', N'{1}', N'{2}', N'{3}', '{4}')", kh.SMaKH, kh.SHoLotKH,kh.STenKH, kh.SPhai, kh.SNgaySinh); ;
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(str, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static bool SuaKhachHang(KhachHang_DTO kh)
        {
            string str = string.Format(@"update khachhang set MaKH = '{0}', holotkh = N'{1}', tenkh = N'{2}', phai = N'{3}', ngaysinh = '{4}' where MaKH = '{0}'", kh.SMaKH, kh.SHoLotKH, kh.STenKH, kh.SPhai, kh.SNgaySinh);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(str, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static bool XoaKhachHang(string ma)
        {
            string str = string.Format(@"delete khachhang where makh =  '{0}'", ma);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(str, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
    }
}
