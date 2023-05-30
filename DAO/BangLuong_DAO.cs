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
    public class BangLuong_DAO
    {
        static SqlConnection conn;

        public static List<BangLuong_DTO> LayBangLuong()
        {
            string str = "xem_luong";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(str, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<BangLuong_DTO> lstBangLuong = new List<BangLuong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BangLuong_DTO bcc = new BangLuong_DTO();
                bcc.SMaNV = dt.Rows[i]["manv"].ToString();
                bcc.SNgayBD = DateTime.Parse(dt.Rows[i]["ngaybd"].ToString());
                bcc.SThang = int.Parse(dt.Rows[i]["thang"].ToString());
                bcc.SNam = int.Parse(dt.Rows[i]["nam"].ToString());
                bcc.ITongNgayCong = int.Parse(dt.Rows[i]["tongngaycong"].ToString());
                bcc.Fluongcb = Double.Parse(dt.Rows[i]["luongcb"].ToString());
                bcc.FTienThuong = Double.Parse(dt.Rows[i]["tienthuong"].ToString());
                bcc.FTongLuong = Double.Parse(dt.Rows[i]["tongluong"].ToString());
                bcc.STinhTrang = bool.Parse(dt.Rows[i]["tinhtrang"].ToString());
                bcc.SHolot = dt.Rows[i]["holot"].ToString();
                bcc.STennv = dt.Rows[i]["tennv"].ToString();
                bcc.STenCH = dt.Rows[i]["tench"].ToString();
                bcc.STenCV = dt.Rows[i]["tencv"].ToString();
                lstBangLuong.Add(bcc);
            }
            DataProvider.DongKetNoi(conn);
            return lstBangLuong;
        }
        public static bool ThemLuongLuong(BangLuong_DTO bll)
        {
            string str = string.Format(@"exec insert_bangluong '{0}','{1}',{2},{3},{4},{5},{6},{7}", bll.SMaNV, bll.SNgayBD, bll.SThang, bll.SNam, bll.ITongNgayCong,bll.Fluongcb, bll.FTienThuong, bll.STinhTrang);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(str,conn);
            return kq;
        }
        public static List<BangLuong_DTO> NhanVienChuaCoBangLuong()
        {
            string sql = string.Format(@"SELECT nhanvien.manv
                                        FROM nhanvien
                                        WHERE manv NOT IN (SELECT bangluong.manv FROM bangluong)");
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sql, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<BangLuong_DTO> lstbl = new List<BangLuong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BangLuong_DTO bll = new BangLuong_DTO();
                bll.SMaNV = dt.Rows[i]["manv"].ToString();
                lstbl.Add(bll);
            }
            DataProvider.DongKetNoi(conn);
            return lstbl;
        }
        public static bool XoaBangLuong(string ma)
        {
            string str = string.Format(@"delete bangluong where manv = '{0}'", ma);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(str, conn);
            return kq;
        }
        public static bool SuaBangLuong(BangLuong_DTO bll)
        {
            string str = string.Format(@"exec update_bangluong '{0}','{1}',{2},{3},{4},{5},{6},{7}", bll.SMaNV, bll.SNgayBD, bll.SThang, bll.SNam, bll.ITongNgayCong, bll.Fluongcb, bll.FTienThuong, bll.STinhTrang);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(str, conn);
            return kq;
        }
    }
}
