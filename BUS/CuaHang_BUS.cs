using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class CuaHang_BUS
    {
        public static List<CuaHang_DTO>LayCuaHang()
        {
            return CuaHang_DAO.LayCuaHang();
        }
        public static bool ThemCuaHang(CuaHang_DTO ch)
        {
            return CuaHang_DAO.ThemCuaHang(ch);
        }
        public static List<CuaHang_DTO> LayCuaHang_TheoMa(string ma)
        {
            return CuaHang_DAO.LayCuaHang_TheoMa(ma);
        }

        public static CuaHang_DTO TimTheoMaCuaHang(string ma)
        {
            return CuaHang_DAO.TimMaCuaHang(ma);
        }
        public static bool SuaCuaHang(CuaHang_DTO ch)
        {
            return CuaHang_DAO.SuaCuaHang(ch);
        }

        public static bool XoaCuaHang(string ch)
        {
            return CuaHang_DAO.XoaCuaHang(ch);
        }
    }
}
