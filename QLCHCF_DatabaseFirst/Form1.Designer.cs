namespace QLCHCF_DatabaseFirst
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKH = new System.Windows.Forms.Button();
            this.btndaily = new System.Windows.Forms.Button();
            this.btnQLNhanVien = new System.Windows.Forms.Button();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btnQuanLiBan = new System.Windows.Forms.Button();
            this.btnCuaHang = new System.Windows.Forms.Button();
            this.gọiBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnKH);
            this.groupBox1.Controls.Add(this.btndaily);
            this.groupBox1.Controls.Add(this.btnQLNhanVien);
            this.groupBox1.Controls.Add(this.btnSanPham);
            this.groupBox1.Controls.Add(this.btnQuanLiBan);
            this.groupBox1.Controls.Add(this.btnCuaHang);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(9, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 303);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Mục";
            // 
            // btnKH
            // 
            this.btnKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKH.Image = ((System.Drawing.Image)(resources.GetObject("btnKH.Image")));
            this.btnKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKH.Location = new System.Drawing.Point(6, 259);
            this.btnKH.Name = "btnKH";
            this.btnKH.Size = new System.Drawing.Size(179, 41);
            this.btnKH.TabIndex = 5;
            this.btnKH.Text = "Khách Hàng";
            this.btnKH.UseVisualStyleBackColor = false;
            this.btnKH.Click += new System.EventHandler(this.btnKH_Click);
            // 
            // btndaily
            // 
            this.btndaily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btndaily.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndaily.Image = ((System.Drawing.Image)(resources.GetObject("btndaily.Image")));
            this.btndaily.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndaily.Location = new System.Drawing.Point(6, 210);
            this.btndaily.Name = "btndaily";
            this.btndaily.Size = new System.Drawing.Size(179, 47);
            this.btndaily.TabIndex = 4;
            this.btndaily.Text = "Đại lý/Nhà Cung Cấp";
            this.btndaily.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndaily.UseVisualStyleBackColor = false;
            this.btndaily.Click += new System.EventHandler(this.btndaily_Click);
            // 
            // btnQLNhanVien
            // 
            this.btnQLNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnQLNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnQLNhanVien.Image")));
            this.btnQLNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNhanVien.Location = new System.Drawing.Point(6, 164);
            this.btnQLNhanVien.Name = "btnQLNhanVien";
            this.btnQLNhanVien.Size = new System.Drawing.Size(179, 44);
            this.btnQLNhanVien.TabIndex = 3;
            this.btnQLNhanVien.Text = "Quản lí Nhân Viên";
            this.btnQLNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQLNhanVien.UseVisualStyleBackColor = false;
            this.btnQLNhanVien.Click += new System.EventHandler(this.btnQLNhanVien_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham.Image = ((System.Drawing.Image)(resources.GetObject("btnSanPham.Image")));
            this.btnSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanPham.Location = new System.Drawing.Point(6, 119);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(179, 41);
            this.btnSanPham.TabIndex = 2;
            this.btnSanPham.Text = "Sản Phẩm";
            this.btnSanPham.UseVisualStyleBackColor = false;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnQuanLiBan
            // 
            this.btnQuanLiBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnQuanLiBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLiBan.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanLiBan.Image")));
            this.btnQuanLiBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLiBan.Location = new System.Drawing.Point(6, 73);
            this.btnQuanLiBan.Name = "btnQuanLiBan";
            this.btnQuanLiBan.Size = new System.Drawing.Size(179, 41);
            this.btnQuanLiBan.TabIndex = 1;
            this.btnQuanLiBan.Text = "Quản Lí Bàn";
            this.btnQuanLiBan.UseVisualStyleBackColor = false;
            this.btnQuanLiBan.Click += new System.EventHandler(this.btnQuanLiBan_Click);
            // 
            // btnCuaHang
            // 
            this.btnCuaHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCuaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuaHang.Image = ((System.Drawing.Image)(resources.GetObject("btnCuaHang.Image")));
            this.btnCuaHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuaHang.Location = new System.Drawing.Point(6, 26);
            this.btnCuaHang.Name = "btnCuaHang";
            this.btnCuaHang.Size = new System.Drawing.Size(179, 42);
            this.btnCuaHang.TabIndex = 0;
            this.btnCuaHang.Text = "Cửa Hàng";
            this.btnCuaHang.UseVisualStyleBackColor = false;
            this.btnCuaHang.Click += new System.EventHandler(this.btnCuaHang_Click);
            // 
            // gọiBànToolStripMenuItem
            // 
            this.gọiBànToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gọiBànToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gọiBànToolStripMenuItem.Image")));
            this.gọiBànToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gọiBànToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.gọiBànToolStripMenuItem.Name = "gọiBànToolStripMenuItem";
            this.gọiBànToolStripMenuItem.Size = new System.Drawing.Size(113, 52);
            this.gọiBànToolStripMenuItem.Text = "Gọi Bàn";
            this.gọiBànToolStripMenuItem.Click += new System.EventHandler(this.gọiBànToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hToolStripMenuItem,
            this.gọiBànToolStripMenuItem,
            this.trợGiúpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(781, 56);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hToolStripMenuItem
            // 
            this.hToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.hToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.hToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hToolStripMenuItem.Image")));
            this.hToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.hToolStripMenuItem.Name = "hToolStripMenuItem";
            this.hToolStripMenuItem.Size = new System.Drawing.Size(144, 52);
            this.hToolStripMenuItem.Text = "Hệ Thống";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đăngXuấtToolStripMenuItem.Image")));
            this.đăngXuấtToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.đăngXuấtToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(175, 38);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(175, 38);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem1
            // 
            this.trợGiúpToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.trợGiúpToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("trợGiúpToolStripMenuItem1.Image")));
            this.trợGiúpToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trợGiúpToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.trợGiúpToolStripMenuItem1.Name = "trợGiúpToolStripMenuItem1";
            this.trợGiúpToolStripMenuItem1.Size = new System.Drawing.Size(118, 52);
            this.trợGiúpToolStripMenuItem1.Text = "Trợ Giúp";
            this.trợGiúpToolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.trợGiúpToolStripMenuItem1.Click += new System.EventHandler(this.trợGiúpToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(200, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(581, 303);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 357);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKH;
        private System.Windows.Forms.Button btndaily;
        private System.Windows.Forms.Button btnQLNhanVien;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnQuanLiBan;
        private System.Windows.Forms.Button btnCuaHang;
        private System.Windows.Forms.ToolStripMenuItem gọiBànToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

