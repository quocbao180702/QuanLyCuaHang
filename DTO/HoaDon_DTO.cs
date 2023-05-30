using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon_DTO
    {
        private string sMaHDN;
        private string sMaNV;
        private string sMaNCC;
        private Double dTongTienNhap;
        private DateTime sNgayNhap;

        public string SMaHDN { get => sMaHDN; set => sMaHDN = value; }
        public string SMaNV { get => sMaNV; set => sMaNV = value; }
        public string SMaNCC { get => sMaNCC; set => sMaNCC = value; }
        public double DTongTienNhap { get => dTongTienNhap; set => dTongTienNhap = value; }
        public DateTime SNgayNhap { get => sNgayNhap; set => sNgayNhap = value; }
    }
}
