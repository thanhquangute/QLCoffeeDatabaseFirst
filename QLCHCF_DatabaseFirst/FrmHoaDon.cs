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
namespace QLCHCF_DatabaseFirst
{
    public partial class FrmHoaDon : Form
    {

        BussinessHoaDon hdbus = new BussinessHoaDon();

        BussinessChiTietHoaDon cthdbus = new BussinessChiTietHoaDon();
        bool Them = true;
        public FrmHoaDon()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {

                dgvHoaDon.DataSource = hdbus.getHoaDon();


                dgvHoaDon_CellContentClick(null, null);

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table HOADON. Lỗi rồi!!!");
            }
        }
        void LoadDatactoder()
        {
            try
            {

                // Đưa dữ liệu lên DataGridView  
                DataTable dt = new DataTable();
                dt = cthdbus.ThongTin();
                dgvCTHD.DataSource = dt;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table HOADON. Lỗi rồi!!!");
            }
        }
       
        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xoa các cột khóa ngoại không cho hiển thị trên dgv
            dgvHoaDon.Columns[4].Visible = false;
            dgvHoaDon.Columns[5].Visible = false;
            dgvHoaDon.Columns[6].Visible = false;
        }

        private void dgvCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xoa các cột khóa ngoại không cho hiển thị trên dgv
            dgvCTHD.Columns[5].Visible = false;
            dgvCTHD.Columns[6].Visible = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string mess = "";

            string mahd = Program.mahoadon;
            string masp = Program.masanpham;
            string tensp = Program.tenSanpham;
            string soluong = Program.soLuong;
            string dongia = Program.donGia;
            try
            {
                bool j = cthdbus.ThemChiTietHoaDon
               (ref mess, mahd, masp, tensp, soluong, dongia);
                if (j)
                {
                    LoadDatactoder();
                    mess = "Them ct hoa don thanh cong";
                }
                MessageBox.Show(mess);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadDatactoder();
        }

        private void bntDoanhThu_Click(object sender, EventArgs e)
        {
            (new FrmTinhDoanhThu()).ShowDialog();
        }
    }
}
