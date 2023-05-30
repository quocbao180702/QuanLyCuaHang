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
    public class HangHoa_DAO
    {
        static SqlConnection conn;
        public static List<HangHoa_DTO> LayHangHoa()
        {
            string str = "select * from hanghoa";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(str, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HangHoa_DTO> lst = new List<HangHoa_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HangHoa_DTO hh = new HangHoa_DTO();
                hh.SMaHH = dt.Rows[i]["mahh"].ToString();
                hh.STenHH = dt.Rows[i]["tenhanghoa"].ToString();
                hh.SDVT = dt.Rows[i]["dvt"].ToString();
                hh.SMaLoai = dt.Rows[i]["maloai"].ToString();
                hh.SMaCH = dt.Rows[i]["mach"].ToString();
                hh.ISoLuong = int.Parse(dt.Rows[i]["soluong"].ToString());
                lst.Add(hh);
            }
            DataProvider.DongKetNoi(conn);
            return lst;
        }
        public static bool ThemHangHoa(HangHoa_DTO hh)
        {
            string str = string.Format(@"InsertHangHoa '{0}', N'{1}', N'{2}','{3}','{4}' ", hh.SMaHH, hh.STenHH, hh.SDVT,hh.SMaLoai,hh.SMaCH);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(str, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        public static List<HangHoa_DTO> TimTenLoaiHangHoa(string ma)
        {
            string str = string.Format(@"exec loc_hanghoa_loai '{0}'", ma);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(str, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HangHoa_DTO> lst = new List<HangHoa_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HangHoa_DTO hh = new HangHoa_DTO();
                hh.SMaHH = dt.Rows[i]["mahh"].ToString();
                hh.STenHH = dt.Rows[i]["tenhanghoa"].ToString();
                hh.SDVT = dt.Rows[i]["dvt"].ToString();
                hh.SMaLoai = dt.Rows[i]["maloai"].ToString();
                hh.SMaCH = dt.Rows[i]["mach"].ToString();
                hh.ISoLuong = int.Parse(dt.Rows[i]["soluong"].ToString());
                lst.Add(hh);
            }
            return lst;
        }

        public static List<HangHoa_DTO> TimMaCuaHang(string ma)
        {
            string str = string.Format(@"exec loc_hanghoa_ch '{0}'", ma);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(str, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HangHoa_DTO> lst = new List<HangHoa_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HangHoa_DTO hh = new HangHoa_DTO();
                hh.SMaHH = dt.Rows[i]["mahh"].ToString();
                hh.STenHH = dt.Rows[i]["tenhanghoa"].ToString();
                hh.SDVT = dt.Rows[i]["dvt"].ToString();
                hh.SMaLoai = dt.Rows[i]["maloai"].ToString();
                hh.SMaCH = dt.Rows[i]["mach"].ToString();
                hh.ISoLuong = int.Parse(dt.Rows[i]["soluong"].ToString());
                lst.Add(hh);
            }
            return lst;
        }
        public static bool XoaHangHoa(string ma)
        {
            string str = string.Format(@"EXEC DeleteHangHoa '{0}' ", ma);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(str, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static bool SuaHangHoa(HangHoa_DTO hh)
        {
            string str = string.Format(@"update hanghoa set mahh = '{0}', tenhanghoa = N'{1}', dvt = N'{2}', maloai = '{3}', mach = '{4}', soluong = {5}  where mahh = '{0}'", hh.SMaHH, hh.STenHH, hh.SDVT, hh.SMaLoai, hh.SMaCH, hh.ISoLuong);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(str, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }


    }
}
