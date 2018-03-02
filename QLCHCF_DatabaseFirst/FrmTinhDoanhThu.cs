using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QLCHCF_DatabaseFirst
{
    public partial class FrmTinhDoanhThu : Form
    {
        public FrmTinhDoanhThu()
        {
            InitializeComponent();
        }

        private void FrmTinhDoanhThu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLCP_BCCK1DataSet5.VWDOANHTHU' table. You can move, or remove it, as needed.
            this.VWDOANHTHUTableAdapter.Fill(this.QLCP_BCCK1DataSet5.VWDOANHTHU);

            this.reportViewer1.RefreshReport();
        }

        private void Setparameters(string Ngay)
        {

            
            ReportParameter rp = new ReportParameter("Ngay");
            rp.Values.Add(Ngay);
            reportViewer1.LocalReport.SetParameters(rp);
        }
        
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            Setparameters(dateTimePicker1.Value.ToString());
            reportViewer1.RefreshReport();
        }
    }
}
