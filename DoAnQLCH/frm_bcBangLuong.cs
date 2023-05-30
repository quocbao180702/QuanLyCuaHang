using BUS;
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
    public partial class frm_bcBangLuong : Form
    {
        public frm_bcBangLuong()
        {
            InitializeComponent();
        }

        private void frm_bcBangLuong_Load(object sender, EventArgs e)
        {
            bangLuongDTOBindingSource.DataSource = BangLuong_BUS.LayBangLuong();
            this.reportViewer1.RefreshReport();
        }
    }
}
