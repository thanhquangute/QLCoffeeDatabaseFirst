namespace QLCHCF_DatabaseFirst
{
    partial class FrmTinhTien
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RPTINHTIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLCP_BCCK1DataSet4 = new QLCHCF_DatabaseFirst.QLCP_BCCK1DataSet4();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RPTINHTIENTableAdapter = new QLCHCF_DatabaseFirst.QLCP_BCCK1DataSet4TableAdapters.RPTINHTIENTableAdapter();
            this.cbbMaOder = new System.Windows.Forms.ComboBox();
            this.btnThongke = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RPTINHTIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLCP_BCCK1DataSet4)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RPTINHTIENBindingSource
            // 
            this.RPTINHTIENBindingSource.DataMember = "RPTINHTIEN";
            this.RPTINHTIENBindingSource.DataSource = this.QLCP_BCCK1DataSet4;
            // 
            // QLCP_BCCK1DataSet4
            // 
            this.QLCP_BCCK1DataSet4.DataSetName = "QLCP_BCCK1DataSet4";
            this.QLCP_BCCK1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Location = new System.Drawing.Point(12, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 516);
            this.panel1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RPTINHTIENBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLCHCF_DatabaseFirst.ReportTinhTien.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(721, 516);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // RPTINHTIENTableAdapter
            // 
            this.RPTINHTIENTableAdapter.ClearBeforeFill = true;
            // 
            // cbbMaOder
            // 
            this.cbbMaOder.DataSource = this.RPTINHTIENBindingSource;
            this.cbbMaOder.DisplayMember = "MaOder";
            this.cbbMaOder.FormattingEnabled = true;
            this.cbbMaOder.Location = new System.Drawing.Point(181, 50);
            this.cbbMaOder.Name = "cbbMaOder";
            this.cbbMaOder.Size = new System.Drawing.Size(121, 21);
            this.cbbMaOder.TabIndex = 1;
            this.cbbMaOder.ValueMember = "MaOder";
            // 
            // btnThongke
            // 
            this.btnThongke.Location = new System.Drawing.Point(345, 50);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(75, 23);
            this.btnThongke.TabIndex = 2;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.UseVisualStyleBackColor = true;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // FrmTinhTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 568);
            this.Controls.Add(this.btnThongke);
            this.Controls.Add(this.cbbMaOder);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTinhTien";
            this.Text = "FrmTinhTien";
            this.Load += new System.EventHandler(this.FrmTinhTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RPTINHTIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLCP_BCCK1DataSet4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RPTINHTIENBindingSource;
        private QLCP_BCCK1DataSet4 QLCP_BCCK1DataSet4;
        private QLCP_BCCK1DataSet4TableAdapters.RPTINHTIENTableAdapter RPTINHTIENTableAdapter;
        private System.Windows.Forms.ComboBox cbbMaOder;
        private System.Windows.Forms.Button btnThongke;
    }
}