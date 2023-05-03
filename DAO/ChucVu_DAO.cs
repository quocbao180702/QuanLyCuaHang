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
                cv.FHSPhuCap = dt.Rows[i]["hsphucap"].ToString();
                lstChucVu.Add(cv);
            }
            DataProvider.DongKetNoi(conn);
            return lstChucVu;
        }
    }
}
