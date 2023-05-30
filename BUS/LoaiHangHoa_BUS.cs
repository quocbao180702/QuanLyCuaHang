using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LoaiHangHoa_BUS
    {
        public static List<LoaiHangHoa_DTO> LayLoaiHangHoa()
        {
            return LoaiHangHoa_DAO.LayLoaiHangHoa();
        }
        public static bool ThemLoaiHangHoa(LoaiHangHoa_DTO lhh)
        {
            return LoaiHangHoa_DAO.ThemLoaiHangHoa(lhh);
        }
        public static LoaiHangHoa_DTO TimMaLoaiHangHoa(string ma)
        {
            return LoaiHangHoa_DAO.TimMaLoaiHangHoa(ma);
        }
        
        public static bool XoaLoaiHangHoa(string ma)
        {
            return LoaiHangHoa_DAO.XoaLoaiHangHoa(ma);
        }
        public static bool SuaLoaiHangHoa(LoaiHangHoa_DTO lhh)
        {
            return LoaiHangHoa_DAO.SuaLoaiHangHoa(lhh);
        }
    }
}
