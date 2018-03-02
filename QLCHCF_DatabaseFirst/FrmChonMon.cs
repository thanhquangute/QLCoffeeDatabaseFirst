using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLCHCF_DatabaseFirst;
using QLCHCF_DatabaseFirst.QLCP_BCCK1DataSetTableAdapters;
namespace QLCHCF_DatabaseFirst
{
    public partial class FrmChonMon : Form
    {
        BussinessChiTietHoaDon cthdBussiness = new BussinessChiTietHoaDon();
        BussinessChiTietOder ctodBussiness = new BussinessChiTietOder();
        BussinessKhachHang khBussiness = new BussinessKhachHang();
        BussinessOder odBussiness = new BussinessOder();
        BussinessQuanLyBan qlbBussiness = new BussinessQuanLyBan();
        BussinessQuanLyNhanVien qlnvBussiness = new BussinessQuanLyNhanVien();
        BussinessSanPham spBussiness = new BussinessSanPham();
        BussinessHoaDon hdBussiness = new BussinessHoaDon();
        bool them = true;



        public FrmChonMon()
        {
            InitializeComponent();

        }
        void LoadData()
        {
            try
            {
                // Load bảng sản phẩm lên dgv
                dgvsp.DataSource = spBussiness.getSanPham();
                dgvsp_CellContentClick(null, null);

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table SanPham. Lỗi rồi!!!");
            }
        }

        void LoadDataOder()
        {
            try
            {
                // load bảng Oder 
                dgvOder.DataSource = odBussiness.getOder();
               
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table ODER. Lỗi rồi!!!");
            }
        }
        void LoadDataHoaDon()
        {
            try
            {
                //Load hoa don
                dgvHoaDon.DataSource =hdBussiness.getHoaDon();

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table HOADON. Lỗi rồi!!!");
            }
        }
        void LoadDataCTOder()
        {
            try
            {
                // load chi tiết oder
                dgvCTOder.DataSource = ctodBussiness.getCTODer();
                dgvCTOder_CellContentClick(null, null);

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table SanPham. Lỗi rồi!!!");
            }
        }
        private void tutangMaOder()
        {
            // mã Oder tự động tăng
            string s = "";
            if (dgvOder.Rows.Count <= 0)
            {
                s = "00";
            }
            else
            {
                int k;
                k = Convert.ToInt32(dgvOder.Rows[dgvOder.Rows.Count - 1].Cells[0].Value.ToString().Substring(0, 2));
                k = k + 1;
                if (k < 10)
                    s = s + "0";
                s = s + k.ToString();
            }

            txtMaOder.Text = s;
        }

        private void tutangMaHD()
        {
            // Mã hóa đơn tự động tăng
            string s = "";
            if (dgvHoaDon.Rows.Count <= 0)
            {
                s = "HD00";
            }
            else
            {
                int k;
                s = "HD";
                k = Convert.ToInt32(dgvHoaDon.Rows[dgvHoaDon.Rows.Count - 1].Cells[0].Value.ToString().Substring(2, 2));
                k = k + 1;
                if (k < 10)
                    s = s + "0";
                s = s + k.ToString();
            }

            txtMaHD.Text = s;
        }

        private void FrmChonMon_Load(object sender, EventArgs e)
        {
            LoadDataOder();
            LoadData();
            LoadDataHoaDon();
            LoadDataCTOder();
            //combobox bàn
            this.cbMaBan.DataSource = qlbBussiness.getban();
            this.cbMaBan.DisplayMember = "MaBan";
            this.cbMaBan.ValueMember = "MaBan";

            //combobox Nhan Vien

            this.cbMaNV.DataSource = qlnvBussiness.getNhanVien();
            this.cbMaNV.DisplayMember = "MaNV";
            this.cbMaNV.ValueMember = "MaNV";

            //comboboc khach hang
            this.cbMaKH.DataSource = khBussiness.getKhachHang();
            this.cbMaKH.DisplayMember = "MaKH";
            this.cbMaKH.ValueMember = "MaKH";

            cbMaBan.Text = Program.MaBan;
        }

        private void dgvsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tắt những khóa ngoại ko cho hiên rthij trên dgv
            dgvsp.Columns[3].Visible = false;
            dgvsp.Columns[4].Visible = false;
            dgvsp.Columns[5].Visible = false;
        }


        private void btnCafeden_Click(object sender, EventArgs e)
        {
            // Lấy thứ tự dòng hiện hành
            int r = dgvsp.CurrentCell.RowIndex;
            // Lấy giá trị Mã SP, Đơn Giá , Tên SP 
            string Masp = dgvsp.Rows[r].Cells["MaSP"].Value.ToString();
            string donGia = dgvsp.Rows[r].Cells["DonGia"].Value.ToString();
            string tensanpham = dgvsp.Rows[r].Cells["TenSP"].Value.ToString();
          
            txtMaSP.Text = Masp;
            // Sử dụng biến tạm để lưu
            Program.masanpham = Masp;
            Program.donGia = donGia;
            Program.tenSanpham = tensanpham;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //group box
            gbctoder.Visible = true;
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            btnPhieuThu.Visible = true;
            btnHoaDon.Visible = true;

            //them hoa don
            string mess = "";

            string mahd = txtMaHD.Text;
            string maoder = txtMaOder.Text;
            string maBan = cbMaBan.Text;
            DateTime ngay = dtNgay.Value;

            bool f = hdBussiness.ThemHoaDon
                (ref mess, mahd, maoder, maBan, ngay);
            if (f)
            {
                LoadDataHoaDon();
                mess = "Them hoa don thanh cong";
            }
            MessageBox.Show(mess);

            Program.mahoadon = txtMaHD.Text;
            Program.soLuong = txtSoLuong.Text;
        }
        private void btnPhieuThu_Click(object sender, EventArgs e)
        {
            (new FrmTinhTien()).ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thứ tự record hiện hành 
                int r = dgvCTOder.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                string strSDH =
                dgvCTOder.Rows[r].Cells[0].Value.ToString();
                string strSDH2 =
                dgvCTOder.Rows[r].Cells[1].Value.ToString();
                string strSDH3 =
              dgvCTOder.Rows[r].Cells[2].Value.ToString();
                 // Khai báo biến traloi 
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                string err = "";
                if (traloi == DialogResult.Yes)
                {

                    // Thực hiện câu lệnh SQL 
                    bool f = ctodBussiness.XoaChiTietOD(ref err, strSDH, strSDH2, strSDH3);
                    if (f)
                    {
                        // Cập nhật lại DataGridView 
                        LoadData();
                        // Thông báo 
                        MessageBox.Show("Đã xóa xong!");
                    }
                    else
                    {
                        MessageBox.Show("Không xóa được!\n\r" + "Lỗi:" + err);
                    }
                }
                else
                {
                    // Thông báo 
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!!!");
            }
        }

      

        private void btnOKChuyen_Click(object sender, EventArgs e)
        {
            string mess = "";
            string maSp = txtMaSP.Text;
            string Maorder = txtMaOder.Text;

            string MaBan = cbMaBan.Text;
            string SL = txtSoLuong.Text;
            // Thêm Chi Tiết Oder
            bool f = ctodBussiness.ThemChiTietOder(ref mess, Maorder, maSp, MaBan, SL);
            if (f)
            {
                LoadData();
                mess = "Them chi tiet order thanh cong";
            }
            MessageBox.Show(mess);

            //add listview

            string msp = Program.masanpham;
            string tsp = Program.tenSanpham;
            string dg = Program.donGia;
            //Tạo colums Trong ListView 
            listView1.Columns.Add("Mã SP", 50);
            listView1.Columns.Add("Tên SP", 100);
            listView1.Columns.Add("Đơn Giá", 90);
            listView1.Columns.Add("Số Lượng", 100);
            //Tạo mớ dòng đầu tiên là Mã SP:ListViewItem
            //Tạo mới dòng tên sản phẩm lấy từ mã sản phẩm vừa thêm trước đó
            //Tạo mới dòng đơn giá lấy từ mã sản phẩm vừa thêm trước đó
            //Tạo mới dòng số lượng lấy từ mã sản phẩm vừa thêm trước đó
            ListViewItem masp = new ListViewItem(txtMaSP.Text);
            ListViewItem.ListViewSubItem ltsp = new ListViewItem.ListViewSubItem(masp, tsp);
            ListViewItem.ListViewSubItem ldg = new ListViewItem.ListViewSubItem(masp, dg);
            ListViewItem.ListViewSubItem lsl = new ListViewItem.ListViewSubItem(masp, txtSoLuong.Text);
            // Add vào listView 
            masp.SubItems.Add(ltsp);
            masp.SubItems.Add(ldg);
            masp.SubItems.Add(lsl);
            listView1.Items.Add(masp);

            LoadDataCTOder();
        }

        

        private void btnThemOder_Click(object sender, EventArgs e)
        {
            // khi thêm IDer thì Mã Oder và Mã HD tự tăng
            tutangMaOder();
            tutangMaHD();
            listView1.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            them = true;
            // Thêm dữ liệu 
            string err = "";
            if (them)
            {
                try
                {

                    // Lệnh Insert InTo 
                    bool f = odBussiness.ThemOder(ref err,
                     this.txtMaOder.Text.ToString(),
                     this.cbMaNV.Text.ToString(),
                   this.cbMaBan.Text.ToString(),
                   this.cbMaKH.Text.ToString(),
                   DateTime.Parse(this.dtNgay.Text.ToString()));

                    if (f)
                    {
                        // Load lại dữ liệu trên DataGridView 
                        LoadDataOder();
                        // Thông báo 
                        MessageBox.Show("Đã thêm xong!");
                    }
                    else
                    {
                        MessageBox.Show("Đã thêm chưa xong!\n\r" + "Lỗi:" + err);
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else // Sua du lieu
            {
                try
                {

                    // Lệnh Insert InTo 
                    bool f = odBussiness.CapNhatOder(ref err,
                     this.txtMaOder.Text.ToString(),
                     this.cbMaNV.Text.ToString(),
                   this.cbMaBan.Text.ToString(),
                   this.cbMaKH.Text.ToString(),
                   DateTime.Parse(this.dtNgay.Text.ToString()));
                    if (f)
                    {
                        // Load lại dữ liệu trên DataGridView 
                        LoadDataOder();
                        // Thông báo 
                        MessageBox.Show("Đã cập nhật xong!");
                    }
                    else
                    {
                        MessageBox.Show("Đã cập nhật chưa xong!\n\r" + "Lỗi:" + err);
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không cập nhật được. Lỗi rồi!");
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            (new FrmOder()).ShowDialog();
        }

        private void dgvCTOder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tắt các ô khóa ngoại không cho hiển thị trên dgv
            dgvCTOder.Columns[4].Visible = false;
            dgvCTOder.Columns[5].Visible = false;
            dgvCTOder.Columns[6].Visible = false;
        }

       
        

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            (new FrmHoaDon()).ShowDialog();
        }

        
        private void btnGoiMon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new FrmKhachHang()).ShowDialog();
        }
    }
}
