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
    }
}
