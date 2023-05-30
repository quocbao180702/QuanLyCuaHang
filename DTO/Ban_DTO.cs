using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DTO
{
    public class Ban_DTO
    {
        private string sMaHDB;
		private string sMaNV;
        private string sHolot;
        private string sTennv;
		private string sMaHH;
        private string sTenHH;
		private string sMaKH;
        private string sHolotKH;
        private string sTenKH;
		private string sMaCH;
        private string sTenCH;
		private int iSoLuong;
		private float fDonGia;
        private Double dTongTienBan;
        private Double dThanhTien;
		private DateTime sNgayBan;

        public string SMaHDB { get => sMaHDB; set => sMaHDB = value; }
        public string SMaNV { get => sMaNV; set => sMaNV = value; }
        public string SHolot { get => sHolot; set => sHolot = value; }
        public string STennv { get => sTennv; set => sTennv = value; }
        public string SMaHH { get => sMaHH; set => sMaHH = value; }
        public string STenHH { get => sTenHH; set => sTenHH = value; }
        public string SMaKH { get => sMaKH; set => sMaKH = value; }
        public string SHolotKH { get => sHolotKH; set => sHolotKH = value; }
        public string STenKH { get => sTenKH; set => sTenKH = value; }
        public string SMaCH { get => sMaCH; set => sMaCH = value; }
        public string STenCH { get => sTenCH; set => sTenCH = value; }
        public int ISoLuong { get => iSoLuong; set => iSoLuong = value; }
        public float FDonGia { get => fDonGia; set => fDonGia = value; }
        public double DThanhTien { get => dThanhTien; set => dThanhTien = value; }
        public double DTongTienBan { get => dTongTienBan; set => dTongTienBan = value; }
        public DateTime SNgayBan { get => sNgayBan; set => sNgayBan = value; }
    }
}
