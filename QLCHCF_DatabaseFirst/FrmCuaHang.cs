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
    public partial class FrmCuaHang : Form
    {
        BussinessCuaHang chBussiness = new BussinessCuaHang();
        bool Them=true;
        public FrmCuaHang()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {

                // Đưa dữ liệu lên DataGridView  
                dgvCuaHang.DataSource = chBussiness.getCuaHang();
                // Thay đổi độ rộng cột 
                dgvCuaHang.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel 
                this.txtMCH.ResetText();
                this.txtTCH.ResetText();
                this.txtTKV.ResetText();
                this.txtDC.ResetText();
                this.txtSDT.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy 
                this.btnSave.Enabled = false;
                this.btnCanCel.Enabled = false;
                
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát 
                this.btnInsert.Enabled = true;
                this.btnEdit.Enabled = true;
                this.btnRemove.Enabled = true;
                this.btnExit.Enabled = true;
               dgvCuaHang_CellContentClick(null, null); 
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table CUAHANG. Lỗi rồi!!!");
            }
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
            this.txtMCH.ResetText();
            this.txtTCH.ResetText();
            this.txtTKV.ResetText();
            this.txtDC.ResetText();
            this.txtSDT.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy 
            this.btnSave.Enabled = true;
            this.btnCanCel.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát /tro ve
            this.btnInsert.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnRemove.Enabled = false;
            this.btnEdit.Enabled = false;
            // Đưa con trỏ đến TextField txtMaCH 
            this.txtMCH.Focus();
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
            this.txtMCH.Enabled = false;
            
           
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {

                // Lấy thứ tự record hiện hành 
                int r = dgvCuaHang.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                string strCUAHANG =
                dgvCuaHang.Rows[r].Cells[0].Value.ToString();

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
                    kq = chBussiness.XoaCuaHang(ref err, txtMCH.Text);
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
                    // Thực hiện câu lệnh SQL
                    kq = chBussiness.ThemCuaHang(ref err, txtMCH.Text, txtTCH.Text, txtTKV.Text, txtDC.Text,txtSDT.Text);
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
                int r = dgvCuaHang.CurrentCell.RowIndex;
                // MaCH hiện hành 
                string strCuaHang =
                dgvCuaHang.Rows[r].Cells[0].Value.ToString();

                // Câu lệnh SQL 
                kq = chBussiness.CapNhatCuaHang(ref err, txtMCH.Text, txtTCH.Text, txtTKV.Text, txtDC.Text, txtSDT.Text);
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

        private void FrmCuaHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
       

        private void btnCanCel_Click(object sender, EventArgs e)
        {

            // Xóa trống các đối tượng trong Group box 
            this.txtMCH.ResetText();
            this.txtTCH.ResetText();
            this.txtTKV.ResetText();
            this.txtDC.ResetText();
            this.txtSDT.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            this.btnInsert.Enabled = true;
            this.btnEdit.Enabled = true;
            this.btnRemove.Enabled = true;
            this.btnExit.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnSave.Enabled = false;
            this.btnCanCel.Enabled = false;
            dgvCuaHang_CellContentClick(null, null);
        }

        private void FrmCuaHang_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCuaHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvCuaHang.CurrentCell.RowIndex;
            // Chuyển thông tin lên Group box
            this.txtMCH.Text =
            dgvCuaHang.Rows[r].Cells[0].Value.ToString();
            this.txtTCH.Text =
            dgvCuaHang.Rows[r].Cells[1].Value.ToString();
            this.txtTKV.Text =
           dgvCuaHang.Rows[r].Cells[2].Value.ToString();
            this.txtDC.Text =
           dgvCuaHang.Rows[r].Cells[3].Value.ToString();
            this.txtSDT.Text =
           dgvCuaHang.Rows[r].Cells[4].Value.ToString();
            dgvCuaHang.Columns[5].Visible = false;
        }
    }
}
