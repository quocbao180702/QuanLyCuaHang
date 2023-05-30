using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonBan_DTO
    {
        private string sMaHDB;
        private string sMaNV;
        private string sMaKH;
        private Double dTongTienban;
        private DateTime sNgayBan;

        public string SMaHDB { get => sMaHDB; set => sMaHDB = value; }
        public string SMaNV { get => sMaNV; set => sMaNV = value; }
        public string SMaKH { get => sMaKH; set => sMaKH = value; }
        public double DTongTienban { get => dTongTienban; set => dTongTienban = value; }
        public DateTime SNgayBan { get => sNgayBan; set => sNgayBan = value; }
    }
}
