using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BangLuong_BUS
    {
        public static List<BangLuong_DTO> LayBangLuong()
        {
            return BangLuong_DAO.LayBangLuong();
        }
        public static bool ThemNhanVien(BangLuong_DTO bll)
        {
            return BangLuong_DAO.ThemLuongLuong(bll);
        }
        public static List<BangLuong_DTO> NhanVienChucCoLuong()
        {
            return BangLuong_DAO.NhanVienChuaCoBangLuong();
        }
        public static bool XoaBangLuong(string ma)
        {
            return BangLuong_DAO.XoaBangLuong(ma);
        }
        public static bool SuaBangLuong(BangLuong_DTO bll)
        {
            return BangLuong_DAO.SuaBangLuong(bll);
        }
    }
}
