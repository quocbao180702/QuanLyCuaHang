using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoCao_DTO
    {
        private string mach;
        private string tench;
        private Double tongtien;

        public string Mach { get => mach; set => mach = value; }
        public string Tench { get => tench; set => tench = value; }
        public double Tongtien { get => tongtien; set => tongtien = value; }
    }
}
