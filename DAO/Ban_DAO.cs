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
    public class Ban_DAO
    {
        static SqlConnection conn;

        public static List<Ban_DTO> LayDSBan()
        {
            string str = "exec xem_phieuban";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(str, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Ban_DTO> lstBan = new List<Ban_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Ban_DTO ban = new Ban_DTO();
                ban.SMaHDB = dt.Rows[i]["mahdban"].ToString();
                ban.SMaNV = dt.Rows[i]["manv"].ToString();
                ban.SHolot = dt.Rows[i]["holot"].ToString();
                ban.STennv = dt.Rows[i]["tennv"].ToString();
                ban.SMaHH = dt.Rows[i]["mahh"].ToString();
                ban.STenHH = dt.Rows[i]["tenhanghoa"].ToString();
                ban.SMaKH = dt.Rows[i]["makh"].ToString();
                ban.SHolotKH = dt.Rows[i]["holotkh"].ToString();
                ban.STenKH = dt.Rows[i]["tenkh"].ToString();
                ban.SMaCH = dt.Rows[i]["mach"].ToString();
                ban.STenCH = dt.Rows[i]["tench"].ToString();
                ban.ISoLuong = int.Parse(dt.Rows[i]["soluong"].ToString());
                ban.FDonGia = float.Parse(dt.Rows[i]["dongia"].ToString());
                ban.DThanhTien = Double.Parse(dt.Rows[i]["thanhtien"].ToString());
                ban.DTongTienBan = Double.Parse(dt.Rows[i]["tongtienban"].ToString());
                ban.SNgayBan = DateTime.Parse(dt.Rows[i]["ngayban"].ToString());
                lstBan.Add(ban);
            }
            DataProvider.DongKetNoi(conn);
            return lstBan;
        }
        public static List<Ban_DTO> LayDSBan_TheoMa(string ma)
        {
            string str = string.Format("HoaDon_BanHang '{0}'",ma);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(str, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Ban_DTO> lstBan = new List<Ban_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Ban_DTO ban = new Ban_DTO();
                ban.SMaHDB = dt.Rows[i]["mahdban"].ToString();
                ban.SMaNV = dt.Rows[i]["manv"].ToString();
                ban.SHolot = dt.Rows[i]["holot"].ToString();
                ban.STennv = dt.Rows[i]["tennv"].ToString();
                ban.SMaHH = dt.Rows[i]["mahh"].ToString();
                ban.STenHH = dt.Rows[i]["tenhanghoa"].ToString();
                ban.SMaKH = dt.Rows[i]["makh"].ToString();
                ban.SHolotKH = dt.Rows[i]["holotkh"].ToString();
                ban.STenKH = dt.Rows[i]["tenkh"].ToString();
                ban.SMaCH = dt.Rows[i]["mach"].ToString();
                ban.STenCH = dt.Rows[i]["tench"].ToString();
                ban.ISoLuong = int.Parse(dt.Rows[i]["soluong"].ToString());
                ban.FDonGia = float.Parse(dt.Rows[i]["dongia"].ToString());
                ban.DThanhTien = Double.Parse(dt.Rows[i]["thanhtien"].ToString());
                ban.DTongTienBan = Double.Parse(dt.Rows[i]["tongtienban"].ToString());
                ban.SNgayBan = DateTime.Parse(dt.Rows[i]["ngayban"].ToString());
                lstBan.Add(ban);
            }
            DataProvider.DongKetNoi(conn);
            return lstBan;
        }
        public static List<HoaDonBan_DTO> LayDSHD()
        {
            string str = "select * from hoadon_ban";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(str, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDonBan_DTO> lstBan = new List<HoaDonBan_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDonBan_DTO ban = new HoaDonBan_DTO();
                ban.SMaHDB = dt.Rows[i]["mahdban"].ToString();
                ban.SMaNV = dt.Rows[i]["manv"].ToString();
                ban.SMaKH = dt.Rows[i]["makh"].ToString();
                ban.DTongTienban  = Double.Parse(dt.Rows[i]["tongtienban"].ToString());
                ban.SNgayBan = DateTime.Parse(dt.Rows[i]["ngayban"].ToString());
                lstBan.Add(ban);
            }
            DataProvider.DongKetNoi(conn);
            return lstBan;
        }

        public static List<Ban_DTO> baocaohoadonban(string ma)
        {
            string str = string.Format("xem_phieuban_theomahd '{0}'",ma);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(str, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Ban_DTO> lstBan = new List<Ban_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Ban_DTO ban = new Ban_DTO();
                ban.SMaHDB = dt.Rows[i]["mahdban"].ToString();
                ban.SMaNV = dt.Rows[i]["manv"].ToString();
                ban.SHolot = dt.Rows[i]["holot"].ToString();
                ban.STennv = dt.Rows[i]["tennv"].ToString();
                ban.SMaHH = dt.Rows[i]["mahh"].ToString();
                ban.STenHH = dt.Rows[i]["tenhanghoa"].ToString();
                ban.SMaKH = dt.Rows[i]["makh"].ToString();
                ban.SHolotKH = dt.Rows[i]["holotkh"].ToString();
                ban.STenKH = dt.Rows[i]["tenkh"].ToString();
                ban.SMaCH = dt.Rows[i]["mach"].ToString();
                ban.STenCH = dt.Rows[i]["tench"].ToString();
                ban.ISoLuong = int.Parse(dt.Rows[i]["soluong"].ToString());
                ban.FDonGia = float.Parse(dt.Rows[i]["dongia"].ToString());
                ban.DTongTienBan = Double.Parse(dt.Rows[i]["tongtienban"].ToString());
                ban.SNgayBan = DateTime.Parse(dt.Rows[i]["ngayban"].ToString());
                lstBan.Add(ban);
            }
            DataProvider.DongKetNoi(conn);
            return lstBan;
        }
        public static bool ThemHDBan(Ban_DTO ban)
        {
            string str = string.Format(@"insert_hoadon_ban '{0}', '{1}', '{2}', '{3}' ", ban.SMaHDB, ban.SNgayBan, ban.SMaKH, ban.SMaNV);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(str, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static bool UpdatePhieuBan(Ban_DTO ban)
        {
            string str = string.Format(@"update_hoadon_ban '{0}', '{1}', '{2}', '{3}'", ban.SMaHDB, ban.SNgayBan, ban.SMaKH, ban.SMaNV);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(str, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static bool DeletePhieuBan(string ma)
        {
            string str = string.Format(@"Delete_hoaban_ban '{0}'", ma);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(str, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }


        public static bool ThemPhieuBan(Ban_DTO ban)
        {
            string str = string.Format(@"insert_ct_hd_ban '{0}', '{1}', {2},{3}", ban.SMaHDB,ban.SMaHH,ban.ISoLuong, ban.FDonGia);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(str, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static Ban_DTO TimMaNV(string manv)
        {
            string str = string.Format(@"select * from Ban where manv='{0}'", manv);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(str, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            Ban_DTO ban = new Ban_DTO();
            ban.SMaNV = dt.Rows[0]["manv"].ToString();
            ban.SMaKH = dt.Rows[0]["mahh"].ToString();
            ban.SMaCH = dt.Rows[0]["makh"].ToString();
            ban.SMaHH = dt.Rows[0]["mach"].ToString();
            ban.ISoLuong = int.Parse(dt.Rows[0]["soluong"].ToString());
            ban.FDonGia = float.Parse(dt.Rows[0]["dongia"].ToString());
            ban.SNgayBan = DateTime.Parse(dt.Rows[0]["ngayban"].ToString());

            DataProvider.DongKetNoi(conn);
            return ban;
        }
        public static bool XoaPhieuBan_sanpham(string mahh, string mahdb)
        {
            string str = string.Format(@"Delete_hoadon_sanpham_ban '{0}','{1}'", mahh, mahdb);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(str, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static bool SuaPhieuBan_sanpham(Ban_DTO ban)
        {
            string str = string.Format(@"update_ct_hd_ban '{0}', '{1}',{2} , {3} ", ban.SMaHDB,ban.SMaHH, ban.ISoLuong, ban.FDonGia);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(str, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
    }
}
