namespace QLCHCF_DatabaseFirst
{
    partial class FrmTinhDoanhThu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.VWDOANHTHUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLCP_BCCK1DataSet5 = new QLCHCF_DatabaseFirst.QLCP_BCCK1DataSet5();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VWDOANHTHUTableAdapter = new QLCHCF_DatabaseFirst.QLCP_BCCK1DataSet5TableAdapters.VWDOANHTHUTableAdapter();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.VWDOANHTHUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLCP_BCCK1DataSet5)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VWDOANHTHUBindingSource
            // 
            this.VWDOANHTHUBindingSource.DataMember = "VWDOANHTHU";
            this.VWDOANHTHUBindingSource.DataSource = this.QLCP_BCCK1DataSet5;
            // 
            // QLCP_BCCK1DataSet5
            // 
            this.QLCP_BCCK1DataSet5.DataSetName = "QLCP_BCCK1DataSet5";
            this.QLCP_BCCK1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Location = new System.Drawing.Point(119, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 164);
            this.panel1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.VWDOANHTHUBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLCHCF_DatabaseFirst.TinhDoanhThu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(612, 164);
            this.reportViewer1.TabIndex = 0;
            // 
            // VWDOANHTHUTableAdapter
            // 
            this.VWDOANHTHUTableAdapter.ClearBeforeFill = true;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(417, 78);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(75, 23);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 77);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2016, 5, 27, 0, 0, 0, 0);
            // 
            // FrmTinhDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 343);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTinhDoanhThu";
            this.Text = "FrmTinhDoanhThu";
            this.Load += new System.EventHandler(this.FrmTinhDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VWDOANHTHUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLCP_BCCK1DataSet5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VWDOANHTHUBindingSource;
        private QLCP_BCCK1DataSet5 QLCP_BCCK1DataSet5;
        private QLCP_BCCK1DataSet5TableAdapters.VWDOANHTHUTableAdapter VWDOANHTHUTableAdapter;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}