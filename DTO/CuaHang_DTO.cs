using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CuaHang_DTO
    {
        private string sMaCH;
        public string SMaCH
        {
            get { return sMaCH; }
            set { sMaCH = value; }
        }

        private string sTenCH;

        public string STenCH
        {
            get { return sTenCH; }
            set { sTenCH = value; }
        }

        private string sDiaChi;

        public string SDiaChi
        {
            get { return sDiaChi; }
            set { sDiaChi = value; }
        }
    }
}
