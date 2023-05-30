using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DangNhap_BUS
    {
        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        public static DangNhap_DTO LayNguoiDung(string user, string pass)
        {
            MD5 md5Hash = MD5.Create();
            string matkhau_mahoa = GetMd5Hash(md5Hash, pass);
            return DangNhap_DAO.LayNguoiDung(user,matkhau_mahoa);
        }

        public static bool DoiMatKhau(DangNhap_DTO nd, string matkhaumoi)
        {
            MD5 md5Hash = MD5.Create();
            string matkhau_mahoa = GetMd5Hash(md5Hash, matkhaumoi);
            nd.SPasswords = matkhau_mahoa;
            return DangNhap_DAO.CapNhatNguoiDung(nd);
        }
        public static List<DangNhap_DTO> NhanVienChuaCoTaiKhoan()
        {
            return DangNhap_DAO.NhanVienChuaCoTaiKhoan();
        }
        public static bool ThemNguoiDung(DangNhap_DTO dn, string makhaumoi)
        {
            MD5 md5Hash = MD5.Create();
            string matkhau = GetMd5Hash(md5Hash, makhaumoi);
            dn.SPasswords = matkhau;
            return DangNhap_DAO.ThemTaiKhoan(dn) ;
        }
    }
}
