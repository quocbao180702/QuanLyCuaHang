using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DangNhap_DTO
    {
        private string sUserName;

        public string SUserName { get => sUserName; set => sUserName = value; }

        private string sPasswords;
        public string SPasswords { get => sPasswords; set => sPasswords = value; }

        private int iQuyen;
        public int IQuyen { get => iQuyen; set => iQuyen = value; }


    }
}
