using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HangHoa_BUS
    {
        public static List<HangHoa_DTO> LayHangHoa()
        {
            return HangHoa_DAO.LayHangHoa();
        }
        public static List<object> LayAllHangHoa()
        {

            List<HangHoa_DTO> lstHangHoa = HangHoa_DAO.LayHangHoa();
            List<LoaiHangHoa_DTO> lstloai = LoaiHangHoa_DAO.LayLoaiHangHoa();
            List<CuaHang_DTO> lstCuaHang = CuaHang_DAO.LayCuaHang();

            if (lstHangHoa != null && lstloai != null && lstCuaHang != null)
            {
                var query = from hh in lstHangHoa
                            join loai in lstloai on hh.SMaLoai equals loai.SMaLoai
                            join ch in lstCuaHang on hh.SMaCH equals ch.SMaCH
                            select new
                            {
                                SMaHH = hh.SMaHH,

                                STenHH = hh.STenHH,

                                SDVT = hh.SDVT,

                                SMaLoai = hh.SMaLoai,

                                STenLoai = loai.STenLoai,

                                SMaCH = hh.SMaCH,
                                STenCH = ch.STenCH,

                                ISoLuong = hh.ISoLuong
                            };
                return query.ToList<object>();
            }
            else
            {
                // Handle the case when one or more of the collections is null
                return new List<object>();
            }
        }

        public static List<object> LayAllHangHoa_TheoLoai(string ma)
        {

            List<HangHoa_DTO> lstHangHoa = HangHoa_DAO.TimTenLoaiHangHoa(ma);
            List<LoaiHangHoa_DTO> lstloai = LoaiHangHoa_DAO.LayLoaiHangHoa();
            List<CuaHang_DTO> lstCuaHang = CuaHang_DAO.LayCuaHang();

            if (lstHangHoa != null && lstloai != null && lstCuaHang != null)
            {
                var query = from hh in lstHangHoa
                            join loai in lstloai on hh.SMaLoai equals loai.SMaLoai
                            join ch in lstCuaHang on hh.SMaCH equals ch.SMaCH
                            select new
                            {
                                SMaHH = hh.SMaHH,

                                STenHH = hh.STenHH,

                                SDVT = hh.SDVT,

                                SMaLoai = hh.SMaLoai,

                                STenLoai = loai.STenLoai,

                                SMaCH = hh.SMaCH,
                                STenCH = ch.STenCH,

                                ISoLuong = hh.ISoLuong
                            };
                return query.ToList<object>();
            }
            else
            {
                // Handle the case when one or more of the collections is null
                return new List<object>();
            }
        }

        public static List<object> LayAllHangHoa_TheoCuaHang(string ma)
        {

            List<HangHoa_DTO> lstHangHoa = HangHoa_DAO.TimMaCuaHang(ma);
            List<LoaiHangHoa_DTO> lstloai = LoaiHangHoa_DAO.LayLoaiHangHoa();
            List<CuaHang_DTO> lstCuaHang = CuaHang_DAO.LayCuaHang();

            if (lstHangHoa != null && lstloai != null && lstCuaHang != null)
            {
                var query = from hh in lstHangHoa
                            join loai in lstloai on hh.SMaLoai equals loai.SMaLoai
                            join ch in lstCuaHang on hh.SMaCH equals ch.SMaCH
                            select new
                            {
                                SMaHH = hh.SMaHH,

                                STenHH = hh.STenHH,

                                SDVT = hh.SDVT,

                                SMaLoai = hh.SMaLoai,

                                STenLoai = loai.STenLoai,

                                SMaCH = hh.SMaCH,
                                STenCH = ch.STenCH,

                                ISoLuong = hh.ISoLuong
                            };
                return query.ToList<object>();
            }
            else
            {
                // Handle the case when one or more of the collections is null
                return new List<object>();
            }
        }

        public static bool ThemHangHoa(HangHoa_DTO hh)
        {
            return HangHoa_DAO.ThemHangHoa(hh);
        }
        public static List<HangHoa_DTO> TimMaCuaHang(string ma)
        {
            return HangHoa_DAO.TimMaCuaHang(ma);
        }

        public static bool XoaHangHoa(string hh)
        {
            return HangHoa_DAO.XoaHangHoa(hh);
        }
        public static bool SuaHangHoa(HangHoa_DTO hh)
        {
            return HangHoa_DAO.SuaHangHoa(hh);
        }

    }
}
