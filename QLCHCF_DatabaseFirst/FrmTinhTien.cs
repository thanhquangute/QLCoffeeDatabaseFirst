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
    public partial class FrmTinhTien : Form
    {
        public FrmTinhTien()
        {
            InitializeComponent();
        }

        private void FrmTinhTien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLCP_BCCK1DataSet4.RPTINHTIEN' table. You can move, or remove it, as needed.
            this.RPTINHTIENTableAdapter.Fill(this.QLCP_BCCK1DataSet4.RPTINHTIEN);

            this.reportViewer1.RefreshReport();

        }
        private void Setparameters(string maoder)
        {
            //Add Setparameters Mã Oder
            ReportParameter rp = new ReportParameter("MaOder");
            rp.Values.Add(maoder);
            reportViewer1.LocalReport.SetParameters(rp);
        }
        
        private void btnThongke_Click(object sender, EventArgs e)
        {
            // Thống kê theo Mã Oder
            Setparameters(cbbMaOder.SelectedValue.ToString());
            //Refesh lại cái Report
            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
