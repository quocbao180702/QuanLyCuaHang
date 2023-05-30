using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CSDL_DAO
    {
        static SqlConnection conn;

        public static bool SaoLuuDuLieu(string DuongDan)
        {
            string ten = "\\QLNV(" + DateTime.Now.Day.ToString() + "_" +
                DateTime.Now.Month.ToString() + "_" +
                DateTime.Now.Year.ToString() + "_" +
                DateTime.Now.Hour.ToString() + "_" +
                DateTime.Now.Minute.ToString() + ").bak";
            string sql = "BACKUP DATABASE QLNV TO DISK = N'" + DuongDan + ten + "'";
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sql, conn);
            return kq;
        }

        public static bool PhucHoiDuLieu(string DuongDan)
        {
            try
            {
                conn = DataProvider.MoKetNoi();
                string sql = "RESTORE DATABASE QLNV FROM DISK = N'" + DuongDan + "'";
                bool kq = DataProvider.TruyVanKhongLayDuLieu(sql, conn);
                conn.Close();
                return kq;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi phục hồi dữ liệu: " + ex.Message);
                return false;
            }
        }
    }
}
