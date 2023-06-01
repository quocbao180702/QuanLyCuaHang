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
    public class Nhap_DAO
    {
        static SqlConnection conn;

        public static List<Nhap_DTO> LayDSNhap()
        {
            string str = "exec xem_phieunhap";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(str, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Nhap_DTO> lstNhap = new List<Nhap_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Nhap_DTO Nhap = new Nhap_DTO();
                Nhap.SMaHDN = dt.Rows[i]["mahdnhap"].ToString();
                Nhap.SMaNV = dt.Rows[i]["manv"].ToString();
                Nhap.SHolot= dt.Rows[i]["holot"].ToString();
                Nhap.STennv= dt.Rows[i]["tennv"].ToString();
                Nhap.SMaHH = dt.Rows[i]["mahh"].ToString();
                Nhap.STenHH = dt.Rows[i]["tenhanghoa"].ToString();
                Nhap.SMaNCC = dt.Rows[i]["mancc"].ToString();
                Nhap.STenNCC = dt.Rows[i]["tenncc"].ToString();
                Nhap.SMaCH = dt.Rows[i]["mach"].ToString();
                Nhap.STenCH = dt.Rows[i]["tench"].ToString();
                Nhap.ISoLuong = int.Parse(dt.Rows[i]["soluong"].ToString());
                Nhap.FDonGia = float.Parse(dt.Rows[i]["dongia"].ToString());
                Nhap.DThanhTien = Double.Parse(dt.Rows[i]["thanhtien"].ToString());
                Nhap.DTongTienNhap = Double.Parse(dt.Rows[i]["tongtiennhap"].ToString());
                Nhap.SNgayNhap = DateTime.Parse(dt.Rows[i]["ngayban"].ToString());
                lstNhap.Add(Nhap);
            }
            DataProvider.DongKetNoi(conn);
            return lstNhap;
        }

        public static List<Nhap_DTO> LayHoaDon_TheoMa(string ma)
        {
            string str = string.Format("HoaDon_NhapHang '{0}'",ma);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(str, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Nhap_DTO> lstNhap = new List<Nhap_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Nhap_DTO Nhap = new Nhap_DTO();
                Nhap.SMaHDN = dt.Rows[i]["mahdnhap"].ToString();
                Nhap.SMaNV = dt.Rows[i]["manv"].ToString();
                Nhap.SHolot = dt.Rows[i]["holot"].ToString();
                Nhap.STennv = dt.Rows[i]["tennv"].ToString();
                Nhap.SMaHH = dt.Rows[i]["mahh"].ToString();
                Nhap.STenHH = dt.Rows[i]["tenhanghoa"].ToString();
                Nhap.SMaNCC = dt.Rows[i]["mancc"].ToString();
                Nhap.STenNCC = dt.Rows[i]["tenncc"].ToString();
                Nhap.SMaCH = dt.Rows[i]["mach"].ToString();
                Nhap.STenCH = dt.Rows[i]["tench"].ToString();
                Nhap.ISoLuong = int.Parse(dt.Rows[i]["soluong"].ToString());
                Nhap.FDonGia = float.Parse(dt.Rows[i]["dongia"].ToString());
                Nhap.DThanhTien = Double.Parse(dt.Rows[i]["thanhtien"].ToString());
                Nhap.DTongTienNhap = Double.Parse(dt.Rows[i]["tongtiennhap"].ToString());
                Nhap.SNgayNhap = DateTime.Parse(dt.Rows[i]["ngayban"].ToString());
                lstNhap.Add(Nhap);
            }
            DataProvider.DongKetNoi(conn);
            return lstNhap;
        }

        public static List<HoaDon_DTO> LayDSHD()
        {
            string str = "select * from hoadon_nhap";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(str, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDon_DTO> lstNhap = new List<HoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDon_DTO Nhap = new HoaDon_DTO();
                Nhap.SMaHDN = dt.Rows[i]["mahdnhap"].ToString();
                Nhap.SMaNV = dt.Rows[i]["manv"].ToString();
                Nhap.SMaNCC = dt.Rows[i]["mancc"].ToString();
                Nhap.DTongTienNhap = Double.Parse(dt.Rows[i]["tongtiennhap"].ToString());
                Nhap.SNgayNhap = DateTime.Parse(dt.Rows[i]["ngayban"].ToString());
                lstNhap.Add(Nhap);
            }
            DataProvider.DongKetNoi(conn);
            return lstNhap;
        }


        //Liên quan tới hóa đơn nè
        public static bool ThemPhieuNhap(Nhap_DTO nhap)
        {
            string str = string.Format(@"insert_hoadon_nhap '{0}','{1}','{2}', '{3}'", nhap.SMaHDN, nhap.SNgayNhap, nhap.SMaNV, nhap.SMaNCC);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(str, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static bool UpdatePhieuNhap(Nhap_DTO nhap)
        {
            string str = string.Format(@"update_hoadon_nhap '{0}', '{1}','{2}', '{3}'", nhap.SMaHDN, nhap.SNgayNhap, nhap.SMaNV, nhap.SMaNCC);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(str, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static bool DeletePhieuNhap(string ma)
        {
            string str = string.Format(@"Delete_hoadon_nhap '{0}'", ma);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(str, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }


        //liên quan tới sản phẩm vào hóa đơn nè
        public static bool ThemSanPham_Nhap(Nhap_DTO nhap )
        {
            string str = string.Format(@"insert_ct_hd_nhap '{0}', '{1}',{2}, {3}", nhap.SMaHDN, nhap.SMaHH, nhap.ISoLuong, nhap.FDonGia);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(str, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static bool SuaSanPhamNhap(Nhap_DTO nhap)
        {
            string str = string.Format(@"update_ct_hd_nhap '{0}', '{1}', {2}, {3}", nhap.SMaHDN, nhap.SMaHH, nhap.ISoLuong, nhap.FDonGia);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(str, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        public static bool XoaSanPham_HoaDon(string mahh, string mahd)
        {
            string str = string.Format(@"Delete_hoadon_sanpham_nhap '{0}', '{1}'", mahh, mahd);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(str, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }


        public static List<Nhap_DTO> TimMaNV(string manv)
        {
            string str = string.Format(@"select * from hoadon_nhap where hoadon_nhap.manv  = '{0}'", manv);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(str, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Nhap_DTO> lst = new List<Nhap_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Nhap_DTO Nhap = new Nhap_DTO();
                Nhap.SMaHDN = dt.Rows[i]["mahdnhap"].ToString();
                Nhap.SMaNV = dt.Rows[i]["manv"].ToString();
                Nhap.SMaNCC = dt.Rows[i]["mancc"].ToString();
                Nhap.DTongTienNhap = Double.Parse(dt.Rows[i]["tongtiennhap"].ToString());
                Nhap.SNgayNhap = DateTime.Parse(dt.Rows[i]["ngayban"].ToString());
                lst.Add(Nhap);
            }
            DataProvider.DongKetNoi(conn);
            return lst;
        }

        public static List<Nhap_DTO> TimMaNCC(string mancc)
        {
            string str = string.Format(@"select * from hoadon_nhap where hoadon_nhap.mancc = '{0}'", mancc);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(str, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Nhap_DTO> lst = new List<Nhap_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Nhap_DTO Nhap = new Nhap_DTO();
                Nhap.SMaHDN = dt.Rows[i]["mahdnhap"].ToString();
                Nhap.SMaNV = dt.Rows[i]["manv"].ToString();
                Nhap.SMaNCC = dt.Rows[i]["mancc"].ToString();
                Nhap.DTongTienNhap = Double.Parse(dt.Rows[i]["tongtiennhap"].ToString());
                Nhap.SNgayNhap = DateTime.Parse(dt.Rows[i]["ngayban"].ToString());
                lst.Add(Nhap);
            }
            DataProvider.DongKetNoi(conn);
            return lst;
        }



        public static List<Nhap_DTO> LayTheoMaHD(string mahd)
        {
            string str = string.Format(@"xem_phieunhap_theomahd '{0}'", mahd);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(str, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Nhap_DTO> lst = new List<Nhap_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Nhap_DTO Nhap = new Nhap_DTO();
                Nhap.SMaHDN = dt.Rows[i]["mahdnhap"].ToString();
                Nhap.SMaNV = dt.Rows[i]["manv"].ToString();
                Nhap.SHolot = dt.Rows[i]["holot"].ToString();
                Nhap.STennv = dt.Rows[i]["tennv"].ToString();
                Nhap.SMaHH = dt.Rows[i]["mahh"].ToString();
                Nhap.STenHH = dt.Rows[i]["tenhanghoa"].ToString();
                Nhap.SMaNCC = dt.Rows[i]["mancc"].ToString();
                Nhap.STenNCC = dt.Rows[i]["tenncc"].ToString();
                Nhap.SMaCH = dt.Rows[i]["mach"].ToString();
                Nhap.STenCH = dt.Rows[i]["tench"].ToString();
                Nhap.ISoLuong = int.Parse(dt.Rows[i]["soluong"].ToString());
                Nhap.FDonGia = float.Parse(dt.Rows[i]["dongia"].ToString());
                Nhap.DTongTienNhap = Double.Parse(dt.Rows[i]["tongtiennhap"].ToString());
                Nhap.SNgayNhap = DateTime.Parse(dt.Rows[i]["ngaynhap"].ToString());
                lst.Add(Nhap);
            }
            DataProvider.DongKetNoi(conn);
            return lst;
        }


    }
}
