using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Nhap_BUS
    {
        public static List<Nhap_DTO> LayDSNhap()
        {
            return Nhap_DAO.LayDSNhap();
        }
        public static List<HoaDon_DTO> LayDSHD()
        {
            return Nhap_DAO.LayDSHD();
        }
        public static List<Nhap_DTO> LayDSHDN(string ma)
        {
            return Nhap_DAO.LayHoaDon_TheoMa(ma);
        }
        public static bool ThemPhieuNhapHD(Nhap_DTO nhap)
        {
            return Nhap_DAO.ThemPhieuNhap(nhap);
        }
        public static List<Nhap_DTO> TimMaNV(string ma)
        {
            return Nhap_DAO.TimMaNV(ma);
        }
        public static List<Nhap_DTO> TimMaNCC(string ma)
        {
            return Nhap_DAO.TimMaNCC(ma);
        }

        public static bool XoaPhieuNhapHD(string ma)
        {
            return Nhap_DAO.DeletePhieuNhap(ma);
        }
        public static bool SuaPhieuNhapHD(Nhap_DTO nhap)
        {
            return Nhap_DAO.UpdatePhieuNhap(nhap);
        }
        public static bool ThemSanPham_PhieuNhap(Nhap_DTO nhap)
        {
            return Nhap_DAO.ThemSanPham_Nhap(nhap);
        }
        public static bool XoaSanPham_PhieuNhap(string mahd, string mahh)
        {
            return Nhap_DAO.XoaSanPham_HoaDon(mahh, mahd);
        }
        public static bool SuaSanPham_Phieu(Nhap_DTO nhap)
        {
            return Nhap_DAO.SuaSanPhamNhap(nhap);
        }
        public static List<Nhap_DTO> LayTheoMaHD(string hdnhap)
        {
            return Nhap_DAO.LayTheoMaHD(hdnhap);
        }

    }
}
