using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BaoCao_BUS
    {
        public static List<BaoCao_DTO> LayDSBan()
        {
            return baocao_DAO.LayDSNhap();
        }
    }
}
