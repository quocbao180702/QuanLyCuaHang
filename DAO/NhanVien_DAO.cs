using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class NhanVien_DAO
    {
        static SqlConnection conn;

        public static List<NhanVien_DTO> LayDSNhanVien()
        {
            string str = "select * from nhanvien";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(str, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVien_DTO> lstNhanVien = new List<NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.SMaNV = dt.Rows[i]["manv"].ToString();
                nv.SHoLot = dt.Rows[i]["holot"].ToString();
                nv.STen = dt.Rows[i]["tennv"].ToString();
                nv.SPhai = dt.Rows[i]["gioitinh"].ToString();
                nv.DtNgaySinh = DateTime.Parse(dt.Rows[i]["ngaysinh"].ToString());
                nv.SSdt = dt.Rows[i]["sdt"].ToString();
                nv.SEmail = dt.Rows[i]["email"].ToString();
                nv.FLuongcb = float.Parse(dt.Rows[i]["luongcb"].ToString());
                nv.SDiaChi = dt.Rows[i]["diachi"].ToString();
                nv.STinh = dt.Rows[i]["tinh"].ToString();
                nv.SMaCV = dt.Rows[i]["macv"].ToString();
                nv.SMaCH = dt.Rows[i]["mach"].ToString();
                lstNhanVien.Add(nv);
            }
            DataProvider.DongKetNoi(conn);
            return lstNhanVien;
        }

        public static bool ThemNhanVien(NhanVien_DTO nv)
        {
            string sTruyVan = string.Format(@"insert into nhanvien values(N'{0}',N'{1}',N'{2}',N'{3}','{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}',N'{10}',N'{11}')", nv.SMaNV, nv.SHoLot, nv.STen, nv.SPhai, nv.DtNgaySinh,nv.SSdt, nv.SEmail,nv.FLuongcb,nv.SDiaChi,nv.STinh, nv.SMaCV, nv.SMaCH);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static NhanVien_DTO TimNhanVienTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from nhanvien where manv=N'{0}'", ma);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.SMaNV = dt.Rows[0]["manv"].ToString();
            nv.SHoLot = dt.Rows[0]["holot"].ToString();
            nv.STen = dt.Rows[0]["tennv"].ToString();
            nv.SPhai = dt.Rows[0]["gioitinh"].ToString();
            nv.DtNgaySinh = DateTime.Parse(dt.Rows[0]["ngaysinh"].ToString());
            nv.SSdt = dt.Rows[0]["sdt"].ToString();
            nv.SEmail = dt.Rows[0]["email"].ToString();
            nv.FLuongcb = float.Parse(dt.Rows[0]["luongcb"].ToString());
            nv.SDiaChi = dt.Rows[0]["diachi"].ToString();
            nv.STinh = dt.Rows[0]["tinh"].ToString();
            nv.SMaCV = dt.Rows[0]["macv"].ToString();
            nv.SMaCH = dt.Rows[0]["mach"].ToString();
            DataProvider.DongKetNoi(conn);
            return nv;
        }

        public static bool SuaNhanVien(NhanVien_DTO nv)
        {
            string sTruyVan = string.Format(@"update nhanvien set manv = '{0}', holot = N'{1}', tennv = N'{2}',gioitinh = N'{3}',ngaysinh = '{4}',sdt = N'{5}',email = '{6}',luongcb = '{7}',diachi = N'{8}',tinh = N'{9}',macv = '{10}',mach = '{11}' where manv = '{0}'", nv.SMaNV, nv.SHoLot, nv.STen, nv.SPhai, nv.DtNgaySinh,nv.SSdt, nv.SEmail, nv.FLuongcb, nv.SDiaChi, nv.STinh, nv.SMaCV, nv.SMaCH, nv.SMaCV);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        
        public static bool XoaNhanVien(string ma)
        {
            string str = string.Format(@"delete from nhanvien where manv = N'{0}'", ma);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(str, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        public static List<NhanVien_DTO> LayDSNhanVienTheoMaChucVu(string ma)
        {
            string sTruyVan = string.Format(@"select * from nhanvien where macv=N'{0}'", ma);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVien_DTO> lstNhanVien = new List<DTO.NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.SMaNV = dt.Rows[0]["manv"].ToString();
                nv.SHoLot = dt.Rows[0]["holot"].ToString();
                nv.STen = dt.Rows[0]["tennv"].ToString();
                nv.SPhai = dt.Rows[0]["gioitinh"].ToString();
                nv.DtNgaySinh = DateTime.Parse(dt.Rows[0]["ngaysinh"].ToString());
                nv.SSdt = dt.Rows[0]["sdt"].ToString();
                nv.SEmail = dt.Rows[0]["email"].ToString();
                nv.FLuongcb = float.Parse(dt.Rows[0]["luongcb"].ToString());
                nv.SDiaChi = dt.Rows[0]["diachi"].ToString();
                nv.STinh = dt.Rows[0]["tinh"].ToString();
                nv.SMaCV = dt.Rows[0]["macv"].ToString();
                nv.SMaCH = dt.Rows[0]["mach"].ToString();
                lstNhanVien.Add(nv);
            }
            DataProvider.DongKetNoi(conn);
            return lstNhanVien;
        }

        public static List<NhanVien_DTO> TimNhanVienTheoTen(string ten)
        {
            string sTruyVan = string.Format(@"select * from nhanvien where tennv like N'%{0}%'", ten);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVien_DTO> listNhanVien = new List<DTO.NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.SMaNV = dt.Rows[0]["manv"].ToString();
                nv.SHoLot = dt.Rows[0]["holot"].ToString();
                nv.STen = dt.Rows[0]["tennv"].ToString();
                nv.SPhai = dt.Rows[0]["gioitinh"].ToString();
                nv.DtNgaySinh = DateTime.Parse(dt.Rows[0]["ngaysinh"].ToString());
                nv.SSdt = dt.Rows[0]["sdt"].ToString();
                nv.SEmail = dt.Rows[0]["email"].ToString();
                nv.FLuongcb = float.Parse(dt.Rows[0]["luongcb"].ToString());
                nv.SDiaChi = dt.Rows[0]["diachi"].ToString();
                nv.STinh = dt.Rows[0]["tinh"].ToString();
                nv.SMaCV = dt.Rows[0]["macv"].ToString();
                nv.SMaCH = dt.Rows[0]["mach"].ToString();
                listNhanVien.Add(nv);
            }
            DataProvider.DongKetNoi(conn);
            return listNhanVien;
        }

    }
}
