using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhaCungCap_BUS
    {
        public static List<NhaCungCap_DTO> LayNhaCungCap()
        {
            return NhaCungCap_DAO.LayNhaCungCap();
        }

        public static NhaCungCap_DTO TimMaNhaCungCap(string ma)
        {
            return NhaCungCap_DAO.TimMaNhaCungCap(ma);
        }

        public static bool ThemNhaCungCap(NhaCungCap_DTO ncc)
        {
            return NhaCungCap_DAO.ThemNhaCungCap(ncc);
        }

        public static bool SuaNhaCungCap(NhaCungCap_DTO ncc)
        {
            return NhaCungCap_DAO.SuaNhaCungCap(ncc);
        }

        public static bool XoaNhaCungCap(string ma)
        {
            return NhaCungCap_DAO.XoaNhaCungCap(ma);
        }

    }
}
