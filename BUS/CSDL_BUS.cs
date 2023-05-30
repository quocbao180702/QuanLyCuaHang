using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CSDL_BUS
    {
            public static bool SaoLuu(string DuongDan)
            {
                return CSDL_DAO.SaoLuuDuLieu(DuongDan);
            }
            public static bool PhucHoi(string DuongDan)
            {
                return CSDL_DAO.PhucHoiDuLieu(DuongDan);
            }
    }
}
