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
    public class LoaiHangHoa_DAO
    {
        static SqlConnection conn;
        public static List<LoaiHangHoa_DTO> LayLoaiHangHoa()
        {
            string str = "select * from loai";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(str, conn);
            if (dt.Rows.Count == 0)
            {

                return null;
            }
            List<LoaiHangHoa_DTO> lstLoaiHangHoa = new List<LoaiHangHoa_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LoaiHangHoa_DTO cv = new LoaiHangHoa_DTO();
                cv.SMaLoai = dt.Rows[i]["maloai"].ToString();
                cv.STenLoai = dt.Rows[i]["tenloai"].ToString();
                
                lstLoaiHangHoa.Add(cv);
            }
            DataProvider.DongKetNoi(conn);
            return lstLoaiHangHoa;
        }

        public static bool ThemLoaiHangHoa(LoaiHangHoa_DTO lhh)
        {
            string str = string.Format(@"insert into loai values('{0}', N'{1}')", lhh.SMaLoai, lhh.STenLoai);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(str, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }


        public static LoaiHangHoa_DTO TimMaLoaiHangHoa(string ma)
        {
            string str = string.Format(@"select * from loai where maloai=N'{0}'", ma);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(str, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            LoaiHangHoa_DTO lhh = new LoaiHangHoa_DTO();
            lhh.SMaLoai = dt.Rows[0]["maloai"].ToString();
            lhh.STenLoai = dt.Rows[0]["tenloai"].ToString();

            DataProvider.DongKetNoi(conn);
            return lhh;
        }
        public static bool SuaLoaiHangHoa(LoaiHangHoa_DTO ch)
        {
            string str = string.Format(@"update loai set maloai = '{0}', tenloai = N'{1}' where maloai = '{0}'", ch.SMaLoai, ch.STenLoai);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(str, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static bool XoaLoaiHangHoa(string ma)
        {
            string str = string.Format(@"delete loai where maloai = '{0}' ", ma);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(str, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
    }
}
