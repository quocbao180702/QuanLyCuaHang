using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCap_DTO
    {

        private string sMaNCC;
        public string SMaNCC 
        { 
            get { return sMaNCC; } 
            set { sMaNCC = value; } 
        }

        private string sTenNCC;
        public string STenNCC 
        {
            get { return sTenNCC; }
            set { sTenNCC = value; }
        }

        private string sDiaChi;
        public string SDiaChi 
        { 
            get { return sDiaChi; }
            set { sDiaChi = value; }
        }

        private string sSdt;
        public string SSdt 
        { 
            get { return sSdt; }
            set { sSdt = value; }
        }
    }
}
