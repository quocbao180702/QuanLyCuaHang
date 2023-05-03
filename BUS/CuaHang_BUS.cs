using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class CuaHang_BUS
    {
        public static List<CuaHang_DTO>LayCuaHang()
        {
            return CuaHang_DAO.LayCuaHang();
        }
    }
}
