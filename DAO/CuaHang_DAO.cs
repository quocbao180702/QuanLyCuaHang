using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class CuaHang_DAO
    {
        static SqlConnection conn;
        public static List<CuaHang_DTO> LayCuaHang()
        {
            string str = "select * from cuahang";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(str,conn);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            List<CuaHang_DTO> lst = new List<CuaHang_DTO>();
            for(int i = 0;i < dt.Rows.Count;i++)
            {
                CuaHang_DTO ch = new CuaHang_DTO();
                ch.SMaCH = dt.Rows[i]["mach"].ToString();
                ch.STenCH = dt.Rows[i]["tench"].ToString();
                ch.SDiaChi = dt.Rows[i]["diachi"].ToString();
                lst.Add(ch);
            }
            DataProvider.DongKetNoi(conn);
            return lst;
        }

        public static List<CuaHang_DTO> LayCuaHang_TheoMa(string ma)
        {
            string str = string.Format("select * from cuahang where mach = {0}", ma);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(str, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<CuaHang_DTO> lst = new List<CuaHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CuaHang_DTO ch = new CuaHang_DTO();
                ch.SMaCH = dt.Rows[i]["mach"].ToString();
                ch.STenCH = dt.Rows[i]["tench"].ToString();
                ch.SDiaChi = dt.Rows[i]["diachi"].ToString();
                lst.Add(ch);
            }
            DataProvider.DongKetNoi(conn);
            return lst;
        }

        public static bool ThemCuaHang(CuaHang_DTO ch)
        {
            string str = string.Format(@"insert into cuahang values('{0}', N'{1}',N'{2}')", ch.SMaCH, ch.STenCH, ch.SDiaChi);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(str, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static CuaHang_DTO TimMaCuaHang(string ma)
        {
            string str = string.Format(@"select * from cuahang where mach=N'{0}'", ma);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(str, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            CuaHang_DTO ch = new CuaHang_DTO();
            ch.SMaCH = dt.Rows[0]["mach"].ToString();
            ch.STenCH = dt.Rows[0]["tench"].ToString();
            ch.SDiaChi = dt.Rows[0]["diachi"].ToString();
            DataProvider.DongKetNoi(conn);
            return ch;
        }
        public static bool SuaCuaHang(CuaHang_DTO ch)
        {
            string str = string.Format(@"update cuahang set mach = '{0}', tench = N'{1}', diachi = N'{2}' where mach = '{0}'", ch.SMaCH, ch.STenCH, ch.SDiaChi);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(str, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static bool XoaCuaHang(string ma)
        {
            string str = string.Format(@"EXEC Delete_CuaHang '{0}' ", ma);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(str, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
    }
}
