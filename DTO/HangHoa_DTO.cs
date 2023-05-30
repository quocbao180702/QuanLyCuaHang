using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HangHoa_DTO
    {
        private string sMaHH;

        public string SMaHH {
            get { return sMaHH; }
            set { sMaHH = value; } 
        }

        private string sTenHH;

        public string STenHH
        {
            get { return sTenHH; }
            set { sTenHH = value; }
        }

        private string sDVT;
        public string SDVT { 
            get { return sDVT; } 
            set { sDVT = value; }
        }

        private string sMaLoai;

        public string SMaLoai
        {
            get { return sMaLoai; }
            set { sMaLoai = value; }
        }

        private string sMaCH;

        public string SMaCH
        {
            get { return sMaCH; }
            set { sMaCH = value; }
        }
        private int iSoLuong;
        public int ISoLuong
        {
            get
            {
                return iSoLuong;
            }
            set
            {
                iSoLuong = value;
            }
        }
    }
}
