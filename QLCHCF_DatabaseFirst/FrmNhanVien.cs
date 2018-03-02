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
    public partial class FrmNhanVien : Form
    {
        BussinessQuanLyNhanVien qlnvBussiness = new BussinessQuanLyNhanVien();
        bool Them = true;
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {

                // Đưa dữ liệu lên DataGridView  
                dgvNhanVien.DataSource = qlnvBussiness.getNhanVien();
                // Thay đổi độ rộng cột 
                dgvNhanVien.AutoResizeColumns();
                // Xóa trống các đối tượng trong Group box 
                this.txtMaNV.ResetText();
                this.txtTenNV.ResetText();
                this.txtTaiKhoan.ResetText();
                this.txtMatKhau.ResetText();
                this.txtMaNQL.ResetText();
                this.txtCMND.ResetText();
                this.txtMaCV.ResetText();
                this.txtMaCH.ResetText();
                this.dateTimePicker1.ResetText();
                this.txtPhai.ResetText();
                this.txtDiaChi.ResetText();
                this.txtSDT.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy 
                this.btnSave.Enabled = false;
                this.btnCanCel.Enabled = false;

                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát 
                this.btnInsert.Enabled = true;
                this.btnEdit.Enabled = true;
                this.btnRemove.Enabled = true;
                this.btnExit.Enabled = true;
                dgvNhanVien_CellContentClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table CUAHANG. Lỗi rồi!!!");
            }
        }
        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvNhanVien.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtMaNV.Text =
            dgvNhanVien.Rows[r].Cells[0].Value.ToString();
            this.txtTenNV.Text =
            dgvNhanVien.Rows[r].Cells[1].Value.ToString();
            this.txtTaiKhoan.Text =
           dgvNhanVien.Rows[r].Cells[2].Value.ToString();
            this.txtMatKhau.Text =
           dgvNhanVien.Rows[r].Cells[3].Value.ToString();
            this.txtMaNQL.Text =
           dgvNhanVien.Rows[r].Cells[4].Value.ToString();
            this.txtCMND.Text =
           dgvNhanVien.Rows[r].Cells[5].Value.ToString();
            this.txtMaCV.Text =
           dgvNhanVien.Rows[r].Cells[6].Value.ToString();
            this.txtMaCH.Text =
           dgvNhanVien.Rows[r].Cells[7].Value.ToString();
            this.dateTimePicker1.Text =
           dgvNhanVien.Rows[r].Cells[8].Value.ToString();
            this.txtPhai.Text =
           dgvNhanVien.Rows[r].Cells[9].Value.ToString();
            this.txtDiaChi.Text =
           dgvNhanVien.Rows[r].Cells[10].Value.ToString();
            this.txtSDT.Text =
           dgvNhanVien.Rows[r].Cells[11].Value.ToString();
            //Không cho các cột khóa ngoại hiển thị trên dgv
            dgvNhanVien.Columns[12].Visible = false;
            dgvNhanVien.Columns[13].Visible = false;
            dgvNhanVien.Columns[14].Visible = false;
            dgvNhanVien.Columns[15].Visible = false;
            dgvNhanVien.Columns[16].Visible = false;
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
            this.txtMaNV.ResetText();
            this.txtTenNV.ResetText();
            this.txtTaiKhoan.ResetText();
            this.txtMatKhau.ResetText();
            this.txtMaNQL.ResetText();
            this.txtCMND.ResetText();
            this.txtMaCV.ResetText();
            this.txtMaCH.ResetText();
            this.dateTimePicker1.ResetText();
            this.txtPhai.ResetText();
            this.txtDiaChi.ResetText();
            this.txtSDT.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy 
            this.btnSave.Enabled = true;
            this.btnCanCel.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát /tro ve
            this.btnInsert.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnRemove.Enabled = false;
            this.btnEdit.Enabled = false;
            // Đưa con trỏ đến TextField txtMaNhanVien 
            this.txtMaNV.Focus();
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
            // Đưa con trỏ đến TextField txtMaNV
            this.txtMaNV.Enabled = false;
        }

        private void btnCanCel_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Group box 
            this.txtMaNV.ResetText();
            this.txtTenNV.ResetText();
            this.txtTaiKhoan.ResetText();
            this.txtMatKhau.ResetText();
            this.txtMaNQL.ResetText();
            this.txtCMND.ResetText();
            this.txtMaCV.ResetText();
            this.txtMaCH.ResetText();
            this.dateTimePicker1.ResetText();
            this.txtPhai.ResetText();
            this.txtDiaChi.ResetText();
            this.txtSDT.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            this.btnInsert.Enabled = true;
            this.btnEdit.Enabled = true;
            this.btnRemove.Enabled = true;
            this.btnExit.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnSave.Enabled = false;
            this.btnCanCel.Enabled = false;
            dgvNhanVien_CellContentClick(null, null);
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
                    //txtSG.Text = txtSG.ToString();
                    kq = qlnvBussiness.ThemNhanVien(ref err, txtMaNV.Text, txtTenNV.Text,
                        txtTaiKhoan.Text, txtMatKhau.Text, txtMaNQL.Text, txtCMND.Text, txtMaCV.Text, txtMaCH.Text,
                       DateTime.Parse(dateTimePicker1.Text), txtPhai.Text, txtDiaChi.Text, txtSDT.Text);
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
                int r = dgvNhanVien.CurrentCell.RowIndex;
                // MaBan hiện hành 
                string strNhanVien =
                dgvNhanVien.Rows[r].Cells[0].Value.ToString();

                // Câu lệnh 
                kq = qlnvBussiness.CapNhatNhanVien(ref err, txtMaNV.Text, txtTenNV.Text,
                        txtTaiKhoan.Text, txtMatKhau.Text, txtMaNQL.Text, txtCMND.Text, txtMaCV.Text, txtMaCH.Text,
                       DateTime.Parse(dateTimePicker1.Text), txtPhai.Text, txtDiaChi.Text, txtSDT.Text);
                if (kq)
                {
                    // Load lại dữ liệu trên DataGridView 
                    LoadData();
                    // Thông báo 
                    MessageBox.Show("Đã sửa xong!");
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {

                // Lấy thứ tự record hiện hành 
                int r = dgvNhanVien.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                string strNhanVien =
                dgvNhanVien.Rows[r].Cells[0].Value.ToString();

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
                    kq = qlnvBussiness.XoaNhanVien(ref err, txtMaNV.Text);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
