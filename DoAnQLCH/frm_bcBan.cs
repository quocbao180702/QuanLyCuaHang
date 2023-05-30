using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQLCH
{
    public partial class frm_bcBan : Form
    {
        public frm_bcBan()
        {
            InitializeComponent();
        }
        public frm_bcBan(string ma)
        {
            InitializeComponent();
            this.ma = ma;
        }
        string ma;

        private void frm_bcBan_Load(object sender, EventArgs e)
        {
            banDTOBindingSource.DataSource = Ban_BUS.LayDSBan_TheoMa(ma);
            this.reportViewer1.RefreshReport();
        }
    }
}
