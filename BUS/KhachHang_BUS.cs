using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhachHang_BUS
    {
        public static List<KhachHang_DTO> LayKhacHang()
        {
            return KhachHang_DAO.LayKhachHang();
        }
        public static bool ThemKhachHang(KhachHang_DTO kh)
        {
            return KhachHang_DAO.ThemKhachHang(kh);
        }
        public static bool SuaKhachHang(KhachHang_DTO kh)
        {
            return KhachHang_DAO.SuaKhachHang(kh);
        }
        public static bool XoaKhachHang(string ma)
        {
            return KhachHang_DAO.XoaKhachHang(ma);
        }

    }
}
