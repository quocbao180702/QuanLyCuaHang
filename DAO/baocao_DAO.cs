using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class baocao_DAO
    {
        static SqlConnection conn;

        public static List<BaoCao_DTO> LayDSNhap()
        {
            string str = "exec baocao";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(str, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<BaoCao_DTO> lstbaocao = new List<BaoCao_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BaoCao_DTO bc = new BaoCao_DTO();
                bc.Mach = dt.Rows[i]["mach"].ToString();
                bc.Tench = dt.Rows[i]["tench"].ToString();
                bc.Tongtien = Double.Parse(dt.Rows[i]["doanhthu"].ToString());
                lstbaocao.Add(bc);
            }
            DataProvider.DongKetNoi(conn);
            return lstbaocao;
        }
    }
}
