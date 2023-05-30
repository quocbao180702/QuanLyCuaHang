using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class NhaCungCap_DAO
    {
        static SqlConnection conn;
        public static List<NhaCungCap_DTO> LayNhaCungCap()
        {
            string str = "select * from NhaCungCap";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(str, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhaCungCap_DTO> lst = new List<NhaCungCap_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhaCungCap_DTO ncc = new NhaCungCap_DTO();
                ncc.SMaNCC = dt.Rows[i]["mancc"].ToString();
                ncc.STenNCC = dt.Rows[i]["tenncc"].ToString();
                ncc.SDiaChi = dt.Rows[i]["diachi"].ToString();
                ncc.SSdt = dt.Rows[i]["sdt"].ToString();
                lst.Add(ncc);
            }
            DataProvider.DongKetNoi(conn);
            return lst;
        }

        public static bool ThemNhaCungCap(NhaCungCap_DTO ncc)
        {
            string str = string.Format(@"insert into nhacungcap values('{0}',N'{1}',N'{2}','{3}')", ncc.SMaNCC, ncc.STenNCC, ncc.SDiaChi, ncc.SSdt);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(str, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        public static NhaCungCap_DTO TimMaNhaCungCap(string ma)
        {
            string str = string.Format(@"select * from nhacungcap where mancc = '{0}'", ma);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(str, conn);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
             NhaCungCap_DTO ncc = new NhaCungCap_DTO();
             ncc.SMaNCC = dt.Rows[0]["mancc"].ToString();
             ncc.STenNCC = dt.Rows[0]["tenncc"].ToString();
             ncc.SDiaChi = dt.Rows[0]["diachi"].ToString();
             ncc.SSdt = dt.Rows[0]["sdt"].ToString();
             DataProvider.DongKetNoi(conn);
             return ncc;
        }

        public static bool XoaNhaCungCap(string ma)
        {
            string str = string.Format(@"EXEC delete_nhacungcap '{0}'", ma);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(str, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        public static bool SuaNhaCungCap(NhaCungCap_DTO ncc)
        {
            string str = string.Format(@"update nhacungcap set mancc = '{0}', tenncc = N'{1}', diachi = N'{2}', sdt = '{3}' where mancc = '{0}'", ncc.SMaNCC, ncc.STenNCC, ncc.SDiaChi,ncc.SSdt);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(str, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
    }
}
