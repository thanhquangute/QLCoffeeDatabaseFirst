namespace QLCHCF_DatabaseFirst
{
    partial class FrmChonMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChonMon));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "",
            ""}, -1);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnGoiMon = new System.Windows.Forms.Button();
            this.btnPhieuThu = new System.Windows.Forms.Button();
            this.gbChonMon = new System.Windows.Forms.GroupBox();
            this.dgvsp = new System.Windows.Forms.DataGridView();
            this.btnCafeden = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvOder = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnMaSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTenSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThemOder = new System.Windows.Forms.Button();
            this.gbctoder = new System.Windows.Forms.GroupBox();
            this.dgvCTOder = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.txt = new System.Windows.Forms.GroupBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbMaBan = new System.Windows.Forms.ComboBox();
            this.cbMaKH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaOder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbChuyenBan = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.btnOKChuyen = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbChonMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOder)).BeginInit();
            this.gbctoder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTOder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.txt.SuspendLayout();
            this.gbChuyenBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnHoaDon);
            this.groupBox1.Controls.Add(this.btnTinhTien);
            this.groupBox1.Controls.Add(this.btnGoiMon);
            this.groupBox1.Controls.Add(this.btnPhieuThu);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1071, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 346);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn:";
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnHoaDon.Image")));
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.Location = new System.Drawing.Point(48, 164);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(128, 61);
            this.btnHoaDon.TabIndex = 51;
            this.btnHoaDon.Text = "HÓA ĐƠN";
            this.btnHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Visible = false;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Image = ((System.Drawing.Image)(resources.GetObject("btnTinhTien.Image")));
            this.btnTinhTien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTinhTien.Location = new System.Drawing.Point(48, 40);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(128, 55);
            this.btnTinhTien.TabIndex = 11;
            this.btnTinhTien.Text = "TÍNH TIỀN";
            this.btnTinhTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnGoiMon
            // 
            this.btnGoiMon.Image = ((System.Drawing.Image)(resources.GetObject("btnGoiMon.Image")));
            this.btnGoiMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoiMon.Location = new System.Drawing.Point(48, 231);
            this.btnGoiMon.Name = "btnGoiMon";
            this.btnGoiMon.Size = new System.Drawing.Size(128, 55);
            this.btnGoiMon.TabIndex = 0;
            this.btnGoiMon.Text = "EXIT";
            this.btnGoiMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGoiMon.UseVisualStyleBackColor = true;
            this.btnGoiMon.Click += new System.EventHandler(this.btnGoiMon_Click);
            // 
            // btnPhieuThu
            // 
            this.btnPhieuThu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuThu.Image = ((System.Drawing.Image)(resources.GetObject("btnPhieuThu.Image")));
            this.btnPhieuThu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhieuThu.Location = new System.Drawing.Point(48, 101);
            this.btnPhieuThu.Name = "btnPhieuThu";
            this.btnPhieuThu.Size = new System.Drawing.Size(128, 61);
            this.btnPhieuThu.TabIndex = 50;
            this.btnPhieuThu.Text = "PHIẾU THU";
            this.btnPhieuThu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPhieuThu.UseVisualStyleBackColor = true;
            this.btnPhieuThu.Visible = false;
            this.btnPhieuThu.Click += new System.EventHandler(this.btnPhieuThu_Click);
            // 
            // gbChonMon
            // 
            this.gbChonMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gbChonMon.Controls.Add(this.dgvsp);
            this.gbChonMon.Controls.Add(this.btnCafeden);
            this.gbChonMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbChonMon.Location = new System.Drawing.Point(348, 222);
            this.gbChonMon.Name = "gbChonMon";
            this.gbChonMon.Size = new System.Drawing.Size(700, 203);
            this.gbChonMon.TabIndex = 65;
            this.gbChonMon.TabStop = false;
            this.gbChonMon.Text = "2.  Chọn Món:";
            // 
            // dgvsp
            // 
            this.dgvsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsp.Location = new System.Drawing.Point(6, 22);
            this.dgvsp.Name = "dgvsp";
            this.dgvsp.Size = new System.Drawing.Size(628, 132);
            this.dgvsp.TabIndex = 55;
            this.dgvsp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsp_CellContentClick);
            // 
            // btnCafeden
            // 
            this.btnCafeden.Image = ((System.Drawing.Image)(resources.GetObject("btnCafeden.Image")));
            this.btnCafeden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCafeden.Location = new System.Drawing.Point(6, 160);
            this.btnCafeden.Name = "btnCafeden";
            this.btnCafeden.Size = new System.Drawing.Size(99, 37);
            this.btnCafeden.TabIndex = 10;
            this.btnCafeden.Text = "CHỌN";
            this.btnCafeden.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCafeden.UseVisualStyleBackColor = true;
            this.btnCafeden.Click += new System.EventHandler(this.btnCafeden_Click);
            // 
            // button7
            // 
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(733, 84);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(128, 37);
            this.button7.TabIndex = 52;
            this.button7.Text = "Xem Oder";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(733, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 39);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvOder
            // 
            this.dgvOder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOder.Location = new System.Drawing.Point(1071, 574);
            this.dgvOder.Name = "dgvOder";
            this.dgvOder.Size = new System.Drawing.Size(200, 137);
            this.dgvOder.TabIndex = 66;
            this.dgvOder.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(348, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 37);
            this.button2.TabIndex = 67;
            this.button2.Text = "Xem CTOder";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMaSP,
            this.columnTenSP,
            this.columnDonGia,
            this.columnSoLuong});
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(24, 250);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(318, 187);
            this.listView1.TabIndex = 62;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnMaSP
            // 
            this.columnMaSP.Text = "Mã SP";
            this.columnMaSP.Width = 83;
            // 
            // columnTenSP
            // 
            this.columnTenSP.Text = "Tên SP";
            // 
            // columnDonGia
            // 
            this.columnDonGia.Text = "Đơn Giá";
            // 
            // columnSoLuong
            // 
            this.columnSoLuong.Text = "Số Lượng";
            // 
            // btnThemOder
            // 
            this.btnThemOder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemOder.Location = new System.Drawing.Point(348, 12);
            this.btnThemOder.Name = "btnThemOder";
            this.btnThemOder.Size = new System.Drawing.Size(111, 30);
            this.btnThemOder.TabIndex = 69;
            this.btnThemOder.Text = "Thêm Oder";
            this.btnThemOder.UseVisualStyleBackColor = true;
            this.btnThemOder.Click += new System.EventHandler(this.btnThemOder_Click);
            // 
            // gbctoder
            // 
            this.gbctoder.Controls.Add(this.dgvCTOder);
            this.gbctoder.Controls.Add(this.btnRemove);
            this.gbctoder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbctoder.Location = new System.Drawing.Point(348, 468);
            this.gbctoder.Name = "gbctoder";
            this.gbctoder.Size = new System.Drawing.Size(700, 238);
            this.gbctoder.TabIndex = 68;
            this.gbctoder.TabStop = false;
            this.gbctoder.Text = "4.  Chọn CT Oder:";
            this.gbctoder.Visible = false;
            // 
            // dgvCTOder
            // 
            this.dgvCTOder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTOder.Location = new System.Drawing.Point(6, 19);
            this.dgvCTOder.Name = "dgvCTOder";
            this.dgvCTOder.Size = new System.Drawing.Size(647, 154);
            this.dgvCTOder.TabIndex = 53;
            this.dgvCTOder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTOder_CellContentClick);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(12, 186);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(99, 41);
            this.btnRemove.TabIndex = 56;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(39, 443);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(259, 165);
            this.dgvHoaDon.TabIndex = 70;
            this.dgvHoaDon.Visible = false;
            // 
            // txt
            // 
            this.txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txt.Controls.Add(this.txtMaHD);
            this.txt.Controls.Add(this.label8);
            this.txt.Controls.Add(this.cbMaBan);
            this.txt.Controls.Add(this.button7);
            this.txt.Controls.Add(this.btnSave);
            this.txt.Controls.Add(this.cbMaKH);
            this.txt.Controls.Add(this.label1);
            this.txt.Controls.Add(this.dtNgay);
            this.txt.Controls.Add(this.cbMaNV);
            this.txt.Controls.Add(this.label5);
            this.txt.Controls.Add(this.label4);
            this.txt.Controls.Add(this.txtMaOder);
            this.txt.Controls.Add(this.label3);
            this.txt.Controls.Add(this.label2);
            this.txt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(348, 48);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(889, 137);
            this.txt.TabIndex = 60;
            this.txt.TabStop = false;
            this.txt.Text = "1.  Nhập thông tin:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(453, 100);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(133, 26);
            this.txtMaHD.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(345, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 56;
            this.label8.Text = "Mã Hóa Đơn:";
            // 
            // cbMaBan
            // 
            this.cbMaBan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaBan.FormattingEnabled = true;
            this.cbMaBan.Location = new System.Drawing.Point(138, 65);
            this.cbMaBan.Name = "cbMaBan";
            this.cbMaBan.Size = new System.Drawing.Size(200, 26);
            this.cbMaBan.TabIndex = 54;
            // 
            // cbMaKH
            // 
            this.cbMaKH.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaKH.FormattingEnabled = true;
            this.cbMaKH.Location = new System.Drawing.Point(453, 20);
            this.cbMaKH.Name = "cbMaKH";
            this.cbMaKH.Size = new System.Drawing.Size(269, 26);
            this.cbMaKH.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã KH:";
            // 
            // dtNgay
            // 
            this.dtNgay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgay.Location = new System.Drawing.Point(453, 60);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(269, 26);
            this.dtNgay.TabIndex = 8;
            this.dtNgay.Value = new System.DateTime(2016, 5, 27, 0, 0, 0, 0);
            // 
            // cbMaNV
            // 
            this.cbMaNV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(138, 105);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(200, 26);
            this.cbMaNV.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(344, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã NV:";
            // 
            // txtMaOder
            // 
            this.txtMaOder.Enabled = false;
            this.txtMaOder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaOder.Location = new System.Drawing.Point(138, 24);
            this.txtMaOder.Name = "txtMaOder";
            this.txtMaOder.Size = new System.Drawing.Size(200, 26);
            this.txtMaOder.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Oder:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Bàn:";
            // 
            // gbChuyenBan
            // 
            this.gbChuyenBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gbChuyenBan.Controls.Add(this.label7);
            this.gbChuyenBan.Controls.Add(this.label6);
            this.gbChuyenBan.Controls.Add(this.txtMaSP);
            this.gbChuyenBan.Controls.Add(this.btnOKChuyen);
            this.gbChuyenBan.Controls.Add(this.txtSoLuong);
            this.gbChuyenBan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChuyenBan.Location = new System.Drawing.Point(36, 48);
            this.gbChuyenBan.Name = "gbChuyenBan";
            this.gbChuyenBan.Size = new System.Drawing.Size(262, 196);
            this.gbChuyenBan.TabIndex = 63;
            this.gbChuyenBan.TabStop = false;
            this.gbChuyenBan.Text = "3.  Số Lượng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 54;
            this.label7.Text = "số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 19);
            this.label6.TabIndex = 53;
            this.label6.Text = "Mã SP";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(149, 41);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(107, 26);
            this.txtMaSP.TabIndex = 35;
            // 
            // btnOKChuyen
            // 
            this.btnOKChuyen.Location = new System.Drawing.Point(32, 143);
            this.btnOKChuyen.Name = "btnOKChuyen";
            this.btnOKChuyen.Size = new System.Drawing.Size(75, 27);
            this.btnOKChuyen.TabIndex = 33;
            this.btnOKChuyen.Text = "OK";
            this.btnOKChuyen.UseVisualStyleBackColor = true;
            this.btnOKChuyen.Click += new System.EventHandler(this.btnOKChuyen_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(149, 100);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(107, 26);
            this.txtSoLuong.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(525, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 37);
            this.button1.TabIndex = 56;
            this.button1.Text = "THÊM KHÁCH HÀNG";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmChonMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 741);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbChonMon);
            this.Controls.Add(this.dgvOder);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnThemOder);
            this.Controls.Add(this.gbctoder);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.gbChuyenBan);
            this.Name = "FrmChonMon";
            this.Text = "FrmChonMon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmChonMon_Load);
            this.groupBox1.ResumeLayout(false);
            this.gbChonMon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOder)).EndInit();
            this.gbctoder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTOder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.txt.ResumeLayout(false);
            this.txt.PerformLayout();
            this.gbChuyenBan.ResumeLayout(false);
            this.gbChuyenBan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnGoiMon;
        private System.Windows.Forms.Button btnPhieuThu;
        private System.Windows.Forms.GroupBox gbChonMon;
        private System.Windows.Forms.DataGridView dgvsp;
        private System.Windows.Forms.Button btnCafeden;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvOder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnMaSP;
        private System.Windows.Forms.ColumnHeader columnTenSP;
        private System.Windows.Forms.ColumnHeader columnDonGia;
        private System.Windows.Forms.ColumnHeader columnSoLuong;
        private System.Windows.Forms.Button btnThemOder;
        private System.Windows.Forms.GroupBox gbctoder;
        private System.Windows.Forms.DataGridView dgvCTOder;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.GroupBox txt;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbMaBan;
        private System.Windows.Forms.ComboBox cbMaKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaOder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbChuyenBan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Button btnOKChuyen;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button button1;
    }
}