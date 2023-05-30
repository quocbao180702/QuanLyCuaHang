using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiHangHoa_DTO
    {
        private string sMaLoai;

        public string SMaLoai {
            get { return sMaLoai; } 
            set { sMaLoai = value; } 
        }

        private string sTenLoai;
        public string STenLoai { 
            get {return  sTenLoai; } 
            set { sTenLoai = value; } 
        }

    }
}
