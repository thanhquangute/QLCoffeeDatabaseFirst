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
    public partial class FrmKhachHang : Form
    {
        BussinessKhachHang khBussiness = new BussinessKhachHang();
        bool Them = true;
        public FrmKhachHang()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {

                // Đưa dữ liệu lên DataGridView  
                dgvKH.DataSource = khBussiness.getKhachHang();
                // Thay đổi độ rộng cột 
                dgvKH.AutoResizeColumns();
                // Xóa trống các đối tượng trong Group box 
                this.txtKH.ResetText();
                this.txtTKH.ResetText();
                this.txtMLKH.ResetText();
                this.txtSN.ResetText();
                
                // Không cho thao tác trên các nút Lưu / Hủy 
                this.btnSave.Enabled = false;
                this.btnCanCel.Enabled = false;

                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát 
                this.btnInsert.Enabled = true;
                this.btnEdit.Enabled = true;
                this.btnRemove.Enabled = true;
                this.btnExit.Enabled = true;
                dgvKH_CellContentClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table CUAHANG. Lỗi rồi!!!");
            }
        }
        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        // Tự tăng Mã Khách hàng khi Insert
        private void tutangMaKH()
        {
            string s = "";
            if (dgvKH.Rows.Count <= 0)
            {
                s = "KH01";
            }
            else
            {
                int k;
                s = "KH";
                k = Convert.ToInt32(dgvKH.Rows[dgvKH.Rows.Count - 1].Cells[0].Value.ToString().Substring(2, 2));
                k = k + 1;
                if (k < 10)
                    s = s + "0";
                s = s + k.ToString();
            }

            txtKH.Text = s;
        }
        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvKH.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtKH.Text =
            dgvKH.Rows[r].Cells[0].Value.ToString();
            this.txtTKH.Text =
            dgvKH.Rows[r].Cells[1].Value.ToString();
            this.txtMLKH.Text =
           dgvKH.Rows[r].Cells[2].Value.ToString();
            this.txtSN.Text =
           dgvKH.Rows[r].Cells[3].Value.ToString();
           
            // xoa cac cot khoa ngoai loaiKH, Oders
            dgvKH.Columns[4].Visible = false;
            dgvKH.Columns[5].Visible = false;
           
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            // Kich hoạt biến Them 
            Them = true;
            // Xóa trống các đối tượng trong Group box
            tutangMaKH();
            //this.txtKH.ResetText();
            this.txtTKH.ResetText();
            this.txtMLKH.ResetText();
            this.txtSN.ResetText();

            // Cho thao tác trên các nút Lưu / Hủy 
            this.btnSave.Enabled = true;
            this.btnCanCel.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát /tro ve
            this.btnInsert.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnRemove.Enabled = false;
            this.btnEdit.Enabled = false;
            // Đưa con trỏ đến TextField txtMaCH 
            this.txtKH.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa 
            Them = false;

            // Cho thao tác trên các nút Lưu / Hủy /
            this.btnSave.Enabled = true;
            this.btnCanCel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.btnInsert.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnRemove.Enabled = false;
            this.btnEdit.Enabled = false;
            // Đưa con trỏ đến TextField txtMaCH
            this.txtKH.Enabled = false;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Group box 
            this.txtKH.ResetText();
            this.txtTKH.ResetText();
            this.txtMLKH.ResetText();
            this.txtSN.ResetText();
            
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            this.btnInsert.Enabled = true;
            this.btnEdit.Enabled = true;
            this.btnRemove.Enabled = true;
            this.btnExit.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnSave.Enabled = false;
            this.btnCanCel.Enabled = false;
            dgvKH_CellContentClick(null, null);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {

                // Lấy thứ tự record hiện hành 
                int r = dgvKH.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                string strKHACHHANG =
                dgvKH.Rows[r].Cells[0].Value.ToString();

                // Hiện thông báo xác nhận việc xóa mẫu tin 
                // Khai báo biến traloi 
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                if (traloi == DialogResult.Yes)
                {
                    // Thực hiện câu lệnh SQL 
                    kq = khBussiness.XoaKhachHang(ref err, txtKH.Text);
                    if (kq)
                    {
                        // Cập nhật lại DataGridView 
                        LoadData();
                        // Thông báo 
                        MessageBox.Show("Đã xóa xong!");
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
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            // Thêm dữ liệu 
            if (Them)
            {
                try
                {
                    kq = khBussiness.ThemKhachHang(ref err, txtKH.Text, txtTKH.Text, txtMLKH.Text, txtSN.Text);
                    if (kq)
                    {
                        // Load lại dữ liệu trên DataGridView 
                        LoadData();
                        // Thông báo 
                        MessageBox.Show("Đã thêm xong!");
                    }

                }
                catch (SqlException)
                {
                    err = "Không thêm được. Lỗi rồi";
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                kq = false;
                // Thứ tự dòng hiện hành 
                int r = dgvKH.CurrentCell.RowIndex;
                // MaCH hiện hành 
                string strKHACHHANG =
                dgvKH.Rows[r].Cells[0].Value.ToString();

                // Câu lệnh SQL 
                kq = khBussiness.CapNhatKhachHang(ref err, txtKH.Text, txtTKH.Text, txtMLKH.Text, txtSN.Text);
                if (kq)
                {
                    // Load lại dữ liệu trên DataGridView 
                    LoadData();
                    // Thông báo 
                    MessageBox.Show("Đã sửa xong!");
                }
            }
        }
 

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new FrmChonMon()).ShowDialog();
        }
    }
}
