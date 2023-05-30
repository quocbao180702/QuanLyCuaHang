using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQLCH
{
    public partial class frm_bcNhap : Form
    {
        public frm_bcNhap()
        {
            InitializeComponent();
        }
        public frm_bcNhap(string mahd)
        {
            InitializeComponent();
            this.mahd = mahd;
            
        }
        string mahd;

        private void frm_bcNhap_Load(object sender, EventArgs e)
        {
            nhapDTOBindingSource.DataSource = Nhap_BUS.LayDSHDN(mahd);
            this.reportViewer1.RefreshReport();
        }
    }
}
