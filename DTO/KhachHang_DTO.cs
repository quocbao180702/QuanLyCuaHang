using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang_DTO
    {
        

        private string sMaKH;
        private string sHoLotKH;
        private string sTenKH;
        private string sPhai;
        private DateTime sNgaySinh;

        public string SMaKH 
        { 
            get { return sMaKH; } 
            set { sMaKH = value; } 
        }
        public string SHoLotKH 
        { 
            get {return sHoLotKH; } 
            set { sHoLotKH = value; }
        }

        public string STenKH 
        { 
            get { return sTenKH; } 
            set { sTenKH = value; } 
        }
        public string SPhai 
        { 
            get {return sPhai; } 
            set { sPhai = value; }
        }
        public DateTime SNgaySinh
        {
            get { return sNgaySinh; }
            set { sNgaySinh = value; }
        }
    }
}
