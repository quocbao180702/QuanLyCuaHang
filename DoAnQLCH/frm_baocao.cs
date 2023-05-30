using BUS;
using DTO;
using Microsoft.Reporting.WinForms;
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
    public partial class frm_baocao : Form
    {
        public frm_baocao()
        {
            InitializeComponent();
        }

        private void frm_baocao_Load(object sender, EventArgs e)
        {
            List<BaoCao_DTO> fbc = BaoCao_BUS.LayDSBan();
            reportViewer1.LocalReport.ReportPath = "baocao.rdlc";
            var source = new ReportDataSource("DataSet1", fbc);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
        }
    }
}
