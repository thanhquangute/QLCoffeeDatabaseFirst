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
    public partial class FrmOder : Form
    {
        BussinessOder odBussiness = new BussinessOder();
        bool them = true;
        public FrmOder()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {

                // Đưa dữ liệu lên DataGridView  
                dgvOder.DataSource = odBussiness.getOder();
                // Thay đổi độ rộng cột 
                dgvOder.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel 
                this.txtMaOder.ResetText();
                this.txtMaBan.ResetText();
                this.txtMaNV.ResetText();
                this.txtMaKH.ResetText();
                this.dateTimePicker1.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy 
                this.btnSave.Enabled = false;
                this.btnCanCel.Enabled = false;

                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát 
                this.btnInsert.Enabled = true;
                this.btnEdit.Enabled = true;
                this.btnRemove.Enabled = true;
                this.btnExit.Enabled = true;
                dgvOder_CellContentClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table CUAHANG. Lỗi rồi!!!");
            }
        }
        private void FrmOder_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvOder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Thứ tự dòng hiện hành 
            int r = dgvOder.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtMaOder.Text =
            dgvOder.Rows[r].Cells[0].Value.ToString();
            this.txtMaBan.Text =
            dgvOder.Rows[r].Cells[1].Value.ToString();
            this.txtMaNV.Text =
           dgvOder.Rows[r].Cells[2].Value.ToString();
            this.txtMaKH.Text =
           dgvOder.Rows[r].Cells[3].Value.ToString();
            this.dateTimePicker1.Text =
           dgvOder.Rows[r].Cells[4].Value.ToString();
           dgvOder.Columns[5].Visible = false;
            dgvOder.Columns[6].Visible = false;
            dgvOder.Columns[7].Visible = false;
            dgvOder.Columns[8].Visible = false;
            dgvOder.Columns[9].Visible = false;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them 
            them = true;
            // Xóa trống các đối tượng trong Group box
            this.txtMaOder.ResetText();
            this.txtMaBan.ResetText();
            this.txtMaNV.ResetText();
            this.txtMaKH.ResetText();
            this.dateTimePicker1.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy 
            this.btnSave.Enabled = true;
            this.btnCanCel.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát /tro ve
            this.btnInsert.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnRemove.Enabled = false;
            this.btnEdit.Enabled = false;
            // Đưa con trỏ đến TextField txtMaOder 
            this.txtMaOder.Focus();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa 
            them = false;

            // Cho thao tác trên các nút Lưu / Hủy /
            this.btnSave.Enabled = true;
            this.btnCanCel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.btnInsert.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnRemove.Enabled = false;
            this.btnEdit.Enabled = false;
            // Đưa con trỏ đến TextField txtMaOder
            this.txtMaOder.Enabled = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {

                // Lấy thứ tự record hiện hành 
                int r = dgvOder.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                this.txtMaOder.Text = 
                dgvOder.Rows[r].Cells[0].Value.ToString();

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
                    kq = odBussiness.XoaOder(ref err, txtMaOder.Text);
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
            if (them)
            {
                try
                {
                    kq = odBussiness.ThemOder(ref err, txtMaOder.Text, txtMaBan.Text, txtMaNV.Text, txtMaKH.Text, DateTime.Parse(dateTimePicker1.Text));
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
                int r = dgvOder.CurrentCell.RowIndex;
                // MaOD hiện hành 
                this.txtMaOder.Text =
                dgvOder.Rows[r].Cells[0].Value.ToString();

                // Câu lệnh SQL 
                kq = odBussiness.CapNhatOder(ref err, txtMaOder.Text, txtMaBan.Text, txtMaNV.Text, txtMaKH.Text, DateTime.Parse(dateTimePicker1.Text));
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

        private void btnCanCel_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Group box 
            this.txtMaOder.ResetText();
            this.txtMaBan.ResetText();
            this.txtMaNV.ResetText();
            this.txtMaKH.ResetText();
            this.dateTimePicker1.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            this.btnInsert.Enabled = true;
            this.btnEdit.Enabled = true;
            this.btnRemove.Enabled = true;
            this.btnExit.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnSave.Enabled = false;
            this.btnCanCel.Enabled = false;
            dgvOder_CellContentClick(null, null);
        }
    }
}
