using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DAO
{
    public class ChucVu_DAO
    {
        static SqlConnection conn;
        public static List<ChucVu_DTO> LayChucVu()
        {
            string str = "select * from chucvu";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(str, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChucVu_DTO> lstChucVu = new List<ChucVu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChucVu_DTO cv = new ChucVu_DTO();
                cv.SMaCV = dt.Rows[i]["macv"].ToString();
                cv.STenCV = dt.Rows[i]["tencv"].ToString();
                cv.FHSPhuCap = float.Parse(dt.Rows[i]["hsphucap"].ToString());
                lstChucVu.Add(cv);
            }
            DataProvider.DongKetNoi(conn);
            return lstChucVu;
        }
        public static List<ChucVu_DTO> LayChucVu_TheoMa(string ma)
        {
            string str = string.Format("select * from chucvu where macv = '{0}'",ma);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(str, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChucVu_DTO> lstChucVu = new List<ChucVu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChucVu_DTO cv = new ChucVu_DTO();
                cv.SMaCV = dt.Rows[i]["macv"].ToString();
                cv.STenCV = dt.Rows[i]["tencv"].ToString();
                cv.FHSPhuCap = float.Parse(dt.Rows[i]["hsphucap"].ToString());
                lstChucVu.Add(cv);
            }
            DataProvider.DongKetNoi(conn);
            return lstChucVu;
        }
        public static bool ThemChucVu(ChucVu_DTO cv)
        {
            string str = string.Format(@"insert into chucvu values('{0}', N'{1}',{2})", cv.SMaCV, cv.STenCV, cv.FHSPhuCap);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(str, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static ChucVu_DTO TimMaChucVu(string ma)
        {
            string str = string.Format(@"select * from ChucVu where macv=N'{0}'", ma);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(str, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            ChucVu_DTO cv = new ChucVu_DTO();
            cv.SMaCV = dt.Rows[0]["macv"].ToString();
            cv.STenCV = dt.Rows[0]["tencv"].ToString();
            cv.FHSPhuCap = float.Parse(dt.Rows[0]["hsphucap"].ToString());
            DataProvider.DongKetNoi(conn);
            return cv;
        }
        public static bool XoaChucVu(string ma)
        {
            string str = string.Format(@"EXEC Delete_ChucVu '{0}' ", ma);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(str, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static bool SuaChucVu(ChucVu_DTO cv)
        {
            string str = string.Format(@"update chucvu set tencv = N'{1}', hsphucap = {2} where macv = '{0}'", cv.SMaCV, cv.STenCV, cv.FHSPhuCap);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(str, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
    }
}
