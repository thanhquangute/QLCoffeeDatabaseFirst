namespace QLCHCF_DatabaseFirst
{
    partial class FrmChonBan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbBan = new System.Windows.Forms.ComboBox();
            this.vITRIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCP_BCCK1DataSet = new QLCHCF_DatabaseFirst.QLCP_BCCK1DataSet();
            this.cbKhuVuc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCP_BCCK1DataSet3 = new QLCHCF_DatabaseFirst.QLCP_BCCK1DataSet3();
            this.dgvChonBan = new System.Windows.Forms.DataGridView();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.vITRITableAdapter = new QLCHCF_DatabaseFirst.QLCP_BCCK1DataSetTableAdapters.VITRITableAdapter();
            this.bANTableAdapter = new QLCHCF_DatabaseFirst.QLCP_BCCK1DataSet3TableAdapters.BANTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vITRIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCP_BCCK1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCP_BCCK1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonBan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbBan);
            this.panel1.Controls.Add(this.cbKhuVuc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 110);
            this.panel1.TabIndex = 0;
            // 
            // cbBan
            // 
            this.cbBan.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vITRIBindingSource, "MaVT", true));
            this.cbBan.FormattingEnabled = true;
            this.cbBan.Location = new System.Drawing.Point(124, 59);
            this.cbBan.Name = "cbBan";
            this.cbBan.Size = new System.Drawing.Size(121, 21);
            this.cbBan.TabIndex = 3;
            // 
            // vITRIBindingSource
            // 
            this.vITRIBindingSource.DataMember = "VITRI";
            this.vITRIBindingSource.DataSource = this.qLCP_BCCK1DataSet;
            // 
            // qLCP_BCCK1DataSet
            // 
            this.qLCP_BCCK1DataSet.DataSetName = "QLCP_BCCK1DataSet";
            this.qLCP_BCCK1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbKhuVuc
            // 
            this.cbKhuVuc.FormattingEnabled = true;
            this.cbKhuVuc.Location = new System.Drawing.Point(124, 17);
            this.cbKhuVuc.Name = "cbKhuVuc";
            this.cbKhuVuc.Size = new System.Drawing.Size(121, 21);
            this.cbKhuVuc.TabIndex = 2;
            this.cbKhuVuc.SelectedValueChanged += new System.EventHandler(this.cbKhuVuc_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bàn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khu Vực";
            // 
            // bANBindingSource
            // 
            this.bANBindingSource.DataMember = "BAN";
            this.bANBindingSource.DataSource = this.qLCP_BCCK1DataSet3;
            // 
            // qLCP_BCCK1DataSet3
            // 
            this.qLCP_BCCK1DataSet3.DataSetName = "QLCP_BCCK1DataSet3";
            this.qLCP_BCCK1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvChonBan
            // 
            this.dgvChonBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChonBan.Location = new System.Drawing.Point(22, 160);
            this.dgvChonBan.Name = "dgvChonBan";
            this.dgvChonBan.Size = new System.Drawing.Size(410, 125);
            this.dgvChonBan.TabIndex = 1;
            this.dgvChonBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChonBan_CellContentClick);
            // 
            // btnChon
            // 
            this.btnChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Location = new System.Drawing.Point(319, 29);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 49);
            this.btnChon.TabIndex = 2;
            this.btnChon.Text = "GỌI MÓN";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(319, 101);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 34);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // vITRITableAdapter
            // 
            this.vITRITableAdapter.ClearBeforeFill = true;
            // 
            // bANTableAdapter
            // 
            this.bANTableAdapter.ClearBeforeFill = true;
            // 
            // FrmChonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(437, 297);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.dgvChonBan);
            this.Controls.Add(this.panel1);
            this.Name = "FrmChonBan";
            this.Text = "FrmChonBan";
            this.Load += new System.EventHandler(this.FrmChonBan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vITRIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCP_BCCK1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCP_BCCK1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbBan;
        private System.Windows.Forms.ComboBox cbKhuVuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvChonBan;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnThoat;
        private QLCP_BCCK1DataSet qLCP_BCCK1DataSet;
        private System.Windows.Forms.BindingSource vITRIBindingSource;
        private QLCP_BCCK1DataSetTableAdapters.VITRITableAdapter vITRITableAdapter;
        private QLCP_BCCK1DataSet3 qLCP_BCCK1DataSet3;
        private System.Windows.Forms.BindingSource bANBindingSource;
        private QLCP_BCCK1DataSet3TableAdapters.BANTableAdapter bANTableAdapter;
    }
}