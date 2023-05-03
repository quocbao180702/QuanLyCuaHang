using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVien_BUS
    {
        public static List<NhanVien_DTO> LayDSNhanVien()
        {
            return NhanVien_DAO.LayDSNhanVien();
        }
        public static List<object> NhanVienWithChucVuWithCuaHang()
        {

            List<NhanVien_DTO> lstNhanVien = NhanVien_DAO.LayDSNhanVien();
            List<ChucVu_DTO> lstChucVu = ChucVu_DAO.LayChucVu();
            List<CuaHang_DTO> lstCuaHang = CuaHang_DAO.LayCuaHang();

            if (lstNhanVien != null && lstChucVu != null && lstCuaHang != null)
            {
                var query = from nv in lstNhanVien
                            join cv in lstChucVu on nv.SMaCV equals cv.SMaCV
                            join ch in lstCuaHang on nv.SMaCH equals ch.SMaCH
                            select new
                            {
                                SMaNV = nv.SMaNV,
                                SHoLot = nv.SHoLot,
                                STen = nv.STen,
                                SPhai = nv.SPhai,
                                DtNgaySinh = nv.DtNgaySinh,
                                SSdt = nv.SSdt,
                                SEmail = nv.SEmail,
                                FLuongcb = nv.FLuongcb,
                                SDiaChi = nv.SDiaChi,
                                STinh = nv.STinh,

                                SMaCV = nv.SMaCV,
                                STenCV = cv.STenCV,

                                SMaCH = nv.SMaCH,
                                STenCH = ch.STenCH,
                            };
                return query.ToList<object>();
            }
            else
            {
                // Handle the case when one or more of the collections is null
                return new List<object>();
            }
        }
        public static bool ThemNhanVien(NhanVien_DTO nv)
        {
            return NhanVien_DAO.ThemNhanVien(nv);
        }
        public static NhanVien_DTO TimNhanVienTheoMa(string ma)
        {
            return NhanVien_DAO.TimNhanVienTheoMa(ma);
        }

        public static bool SuaNhanVien(NhanVien_DTO nv)
        {
            return NhanVien_DAO.SuaNhanVien(nv);
        }
        public static bool XoaNhanVien(string ma)
        {
            return NhanVien_DAO.XoaNhanVien(ma);
        }
        public static List<NhanVien_DTO> TimNhanVienTheoMaChucVu(string ma)
        {
            return NhanVien_DAO.LayDSNhanVienTheoMaChucVu(ma);
        }
        public static List<NhanVien_DTO> TimNhanVienTheoTen(string ten)
        {
            return NhanVien_DAO.TimNhanVienTheoTen(ten);
        }

    }
}
