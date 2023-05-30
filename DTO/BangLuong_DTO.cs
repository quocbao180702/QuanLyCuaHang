using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BangLuong_DTO
    {
        private string sMaNV;
        private string sHolot;
        private string sTennv;
        private string sTenCH;
        private string sTenCV;
        private DateTime sNgayBD;
        private int sThang;
        private int sNam;
        private int iTongNgayCong;
        private Double fluongcb;
        private Double fTienThuong;
        private Double fTongLuong;
        private bool sTinhTrang;

        public string SMaNV { get => sMaNV; set => sMaNV = value; }
        public string SHolot { get => sHolot; set => sHolot = value; }
        public string STennv { get => sTennv; set => sTennv = value; }
        public string STenCH { get => sTenCH; set => sTenCH = value; }
        public string STenCV { get => sTenCV; set => sTenCV = value; }
        public DateTime SNgayBD { get => sNgayBD; set => sNgayBD = value; }
        public int SThang { get => sThang; set => sThang = value; }
        public int SNam { get => sNam; set => sNam = value; }
        public int ITongNgayCong { get => iTongNgayCong; set => iTongNgayCong = value; }
        public double Fluongcb { get => fluongcb; set => fluongcb = value; }
        public double FTienThuong { get => fTienThuong; set => fTienThuong = value; }
        public double FTongLuong { get => fTongLuong; set => fTongLuong = value; }
        public bool STinhTrang { get => sTinhTrang; set => sTinhTrang = value; }
    }
}
