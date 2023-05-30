using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DTO
{
    public class Nhap_DTO
    {
        private string sMaHDN;
        private string sMaNV;
        private string sHolot;
        private string sTennv;
        private string sMaHH;
        private string sTenHH;
        private string sMaNCC;
        private string sTenNCC;
        private string sMaCH;
        private string sTenCH;
        private int iSoLuong;
        private float fDonGia;
        private Double dTongTienNhap;
        private Double dThanhTien;
        private DateTime sNgayNhap;

        public string SMaHDN { get => sMaHDN; set => sMaHDN = value; }
        public string SMaNV { get => sMaNV; set => sMaNV = value; }
        public string SHolot { get => sHolot; set => sHolot = value; }
        public string STennv { get => sTennv; set => sTennv = value; }
        public string SMaHH { get => sMaHH; set => sMaHH = value; }
        public string STenHH { get => sTenHH; set => sTenHH = value; }
        public string SMaNCC { get => sMaNCC; set => sMaNCC = value; }
        public string STenNCC { get => sTenNCC; set => sTenNCC = value; }
        public string SMaCH { get => sMaCH; set => sMaCH = value; }
        public string STenCH { get => sTenCH; set => sTenCH = value; }
        public int ISoLuong { get => iSoLuong; set => iSoLuong = value; }
        public float FDonGia { get => fDonGia; set => fDonGia = value; }
        public double DTongTienNhap { get => dTongTienNhap; set => dTongTienNhap = value; }
        public double DThanhTien { get => dThanhTien; set => dThanhTien = value; }
        public DateTime SNgayNhap { get => sNgayNhap; set => sNgayNhap = value; }
    }
}
