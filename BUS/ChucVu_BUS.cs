using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class ChucVu_BUS
    {
        public static List<ChucVu_DTO> LayChucVu()
        {
            return ChucVu_DAO.LayChucVu();
        }
        public static List<ChucVu_DTO> LayChucVu_TheoMa(string ma)
        {
            return ChucVu_DAO.LayChucVu_TheoMa(ma);
        }
        public static bool ThemChucVu(ChucVu_DTO ch)
        {
            return ChucVu_DAO.ThemChucVu(ch);
        }

        public static ChucVu_DTO TimTheoMaChucVu(string ma)
        {
            return ChucVu_DAO.TimMaChucVu(ma);
        }
        
        public static bool XoaChucVu(string ma)
        {
            return ChucVu_DAO.XoaChucVu(ma);
        }
        public static bool SuaChucVu(ChucVu_DTO cv)
        {
            return ChucVu_DAO.SuaChucVu(cv);
        }
    }
}
