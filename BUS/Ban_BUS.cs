using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Ban_BUS
    {
        public static  List<Ban_DTO> LayDSBan()
        {
            return Ban_DAO.LayDSBan();
        }
        public static List<Ban_DTO> LayDSBan_TheoMa(string ma)
        {
            return Ban_DAO.LayDSBan_TheoMa(ma);
        }
        public static List<HoaDonBan_DTO> LayDSHD()
        {
            return Ban_DAO.LayDSHD();
         }

        public static bool ThemHDBAn(Ban_DTO ban)
        {
            return Ban_DAO.ThemHDBan(ban);
        }

        public static bool SuaHDBan(Ban_DTO ban)
        {
            return Ban_DAO.UpdatePhieuBan(ban);
        }
        public static bool XoaHDBAn(string ma)
        {
            return Ban_DAO.DeletePhieuBan(ma);
        }
        public static bool ThemPhieuBan(Ban_DTO ban)
        {
            return Ban_DAO.ThemPhieuBan(ban);
        }
        public static Ban_DTO TimMaBan(string ma)
        {
            return Ban_DAO.TimMaNV(ma);
        }

        public static bool XoaPhieuBan(string mahh, string mahdb)
        {
            return Ban_DAO.XoaPhieuBan_sanpham(mahh,mahdb);
        }
        public static bool SuaPhieuBan(Ban_DTO ban)
        {
            return Ban_DAO.SuaPhieuBan_sanpham(ban);
        }
    }
}
