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
    
    public partial class FrmQuanLyBan : Form
    {
        BussinessQuanLyBan qlbBussiness = new BussinessQuanLyBan();
        bool Them = true;
        public FrmQuanLyBan()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {

                // Đưa dữ liệu lên DataGridView  
                dgvQLBan.DataSource = qlbBussiness.getban();
                // Thay đổi độ rộng cột 
                dgvQLBan.AutoResizeColumns();
                // Xóa trống các đối tượng trong Group box 
                this.txtMB.ResetText();
                this.txtTB.ResetText();
                this.txtMVT.ResetText();
                this.txtSG.ResetText();
                this.TT.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy 
                this.btnSave.Enabled = false;
                this.btnCanCel.Enabled = false;

                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát 
                this.btnInsert.Enabled = true;
                this.btnEdit.Enabled = true;
                this.btnRemove.Enabled = true;
                this.btnExit.Enabled = true;
                dgvQLBan_CellContentClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table CUAHANG. Lỗi rồi!!!");
            }
        }
        private void FrmQuanLyBan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvQLBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvQLBan.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtMB.Text =
            dgvQLBan.Rows[r].Cells[0].Value.ToString();
            this.txtTB.Text =
            dgvQLBan.Rows[r].Cells[1].Value.ToString();
            this.txtMVT.Text =
           dgvQLBan.Rows[r].Cells[2].Value.ToString();
            this.txtSG.Text =
           dgvQLBan.Rows[r].Cells[3].Value.ToString();
            this.TT.Text =
           dgvQLBan.Rows[r].Cells[4].Value.ToString();
            // xoa cac cot khoa ngoai khong cho xuat hien tren dgv
            dgvQLBan.Columns[5].Visible = false;
            dgvQLBan.Columns[6].Visible = false;
            dgvQLBan.Columns[7].Visible = false;
            dgvQLBan.Columns[8].Visible = false;


        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them 
            Them = true;
            // Xóa trống các đối tượng trong Group box
            this.txtMB.ResetText();
            this.txtTB.ResetText();
            this.txtMVT.ResetText();
            this.txtSG.ResetText();
            this.TT.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy 
            this.btnSave.Enabled = true;
            this.btnCanCel.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát /tro ve
            this.btnInsert.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnRemove.Enabled = false;
            this.btnEdit.Enabled = false;
            // Đưa con trỏ đến TextField txtMaBan 
            this.txtMB.Focus();
           
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
            // Đưa con trỏ đến TextField txtMaBan
            this.txtMB.Enabled = false;
            
        }

        private void btnCanCel_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Group box 
            this.txtMB.ResetText();
            this.txtTB.ResetText();
            this.txtMVT.ResetText();
            this.txtSG.ResetText();
            this.TT.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            this.btnInsert.Enabled = true;
            this.btnEdit.Enabled = true;
            this.btnRemove.Enabled = true;
            this.btnExit.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnSave.Enabled = false;
            this.btnCanCel.Enabled = false;
            dgvQLBan_CellContentClick(null, null);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {

                // Lấy thứ tự record hiện hành 
                int r = dgvQLBan.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                string strBAN =
                dgvQLBan.Rows[r].Cells[0].Value.ToString();

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
                    kq = qlbBussiness.XoaBan(ref err, txtMB.Text);
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
                   
                    kq = qlbBussiness.ThemBan(ref err, txtMB.Text, txtTB.Text, 
                        txtMVT.Text, int.Parse(txtSG.Text),checked(TT.Checked));
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
                int r = dgvQLBan.CurrentCell.RowIndex;
                // MaBan hiện hành 
                string strBan =
                dgvQLBan.Rows[r].Cells[0].Value.ToString();

                // Câu lệnh 
                kq = qlbBussiness.CapNhatBan(ref err, txtMB.Text, txtTB.Text, txtMVT.Text,
                    int.Parse(txtSG.Text), checked(TT.Checked));
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
    }
}
