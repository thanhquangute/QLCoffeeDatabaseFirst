namespace QLCHCF_DatabaseFirst
{
    partial class FrmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoaDon));
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.gbCTHD = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.gbHD = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.bntDoanhThu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.gbCTHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.gbHD.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 22);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(630, 116);
            this.dgvHoaDon.TabIndex = 1;
            this.dgvHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellContentClick);
            // 
            // gbCTHD
            // 
            this.gbCTHD.Controls.Add(this.label9);
            this.gbCTHD.Controls.Add(this.dgvCTHD);
            this.gbCTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbCTHD.Location = new System.Drawing.Point(12, 199);
            this.gbCTHD.Name = "gbCTHD";
            this.gbCTHD.Size = new System.Drawing.Size(634, 141);
            this.gbCTHD.TabIndex = 5;
            this.gbCTHD.TabStop = false;
            this.gbCTHD.Text = "Chi Tiết Hóa Đơn:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(-108, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Mã Hóa Đơn:";
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Location = new System.Drawing.Point(0, 22);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.Size = new System.Drawing.Size(630, 96);
            this.dgvCTHD.TabIndex = 2;
            this.dgvCTHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHD_CellContentClick);
            // 
            // gbHD
            // 
            this.gbHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gbHD.Controls.Add(this.bntDoanhThu);
            this.gbHD.Controls.Add(this.dgvHoaDon);
            this.gbHD.Controls.Add(this.btnOK);
            this.gbHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbHD.Location = new System.Drawing.Point(12, 3);
            this.gbHD.Name = "gbHD";
            this.gbHD.Size = new System.Drawing.Size(634, 190);
            this.gbHD.TabIndex = 4;
            this.gbHD.TabStop = false;
            this.gbHD.Text = "Thông tin hóa đơn:";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(0, 147);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(190, 43);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "Xác nhận Hóa Đơn:";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // bntDoanhThu
            // 
            this.bntDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bntDoanhThu.Image = ((System.Drawing.Image)(resources.GetObject("bntDoanhThu.Image")));
            this.bntDoanhThu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntDoanhThu.Location = new System.Drawing.Point(448, 144);
            this.bntDoanhThu.Name = "bntDoanhThu";
            this.bntDoanhThu.Size = new System.Drawing.Size(129, 43);
            this.bntDoanhThu.TabIndex = 7;
            this.bntDoanhThu.Text = "Doanh Thu";
            this.bntDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntDoanhThu.UseVisualStyleBackColor = true;
            this.bntDoanhThu.Click += new System.EventHandler(this.bntDoanhThu_Click);
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 333);
            this.Controls.Add(this.gbCTHD);
            this.Controls.Add(this.gbHD);
            this.Name = "FrmHoaDon";
            this.Text = "FrmHoaDon";
            this.Load += new System.EventHandler(this.FrmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.gbCTHD.ResumeLayout(false);
            this.gbCTHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.gbHD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.GroupBox gbCTHD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.GroupBox gbHD;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button bntDoanhThu;
    }
}