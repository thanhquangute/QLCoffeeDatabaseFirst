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
    public partial class FrmDaiLyNhaCungCap : Form
    {
        // Lấy bảng nhà cung cấp
        DaiLyNhanCungCapBussiness dlnccBussiness = new DaiLyNhanCungCapBussiness();
        bool Them = true;
        public FrmDaiLyNhaCungCap()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {

                // Đưa dữ liệu lên DataGridView  
                dgvNCC.DataSource = dlnccBussiness.getNhaCungCap();
                // Thay đổi độ rộng cột 
                dgvNCC.AutoResizeColumns();
                // Xóa trống các đối tượng trong Group box 
                this.txtMNCC.ResetText();
                this.txtTNCC.ResetText();
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
                dgvNCC_CellContentClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table CUAHANG. Lỗi rồi!!!");
            }
        }
        private void FrmDaiLyNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvNCC.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtMNCC.Text =
            dgvNCC.Rows[r].Cells[0].Value.ToString();
            this.txtTNCC.Text =
            dgvNCC.Rows[r].Cells[1].Value.ToString();
            this.txtDC.Text =
           dgvNCC.Rows[r].Cells[2].Value.ToString();
            this.txtSDT.Text =
           dgvNCC.Rows[r].Cells[3].Value.ToString();
            //Xoa cot khoa ngoai HDCC
            dgvNCC.Columns[4].Visible = false;
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
            this.txtMNCC.ResetText();
            this.txtTNCC.ResetText();
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
            // Đưa con trỏ đến TextField txtMaNCC
            this.txtMNCC.Focus();
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
            this.txtMNCC.Enabled = false;
        }

        private void btnCanCel_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Group box 
            this.txtMNCC.ResetText();
            this.txtTNCC.ResetText();
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
            dgvNCC_CellContentClick(null, null);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {

                // Lấy thứ tự record hiện hành 
                int r = dgvNCC.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                string strNhaCungCap =
                dgvNCC.Rows[r].Cells[0].Value.ToString();

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
                    kq = dlnccBussiness.XoaNhaCungCap(ref err, txtMNCC.Text);
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
                    //txtSG.Text = txtSG.ToString();
                    kq = dlnccBussiness.ThemNhaCungCap(ref err, txtMNCC.Text, txtTNCC.Text,
                        txtDC.Text, txtSDT.Text);
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
                int r = dgvNCC.CurrentCell.RowIndex;
                // MaBan hiện hành 
                string strNhaCungCap =
                dgvNCC.Rows[r].Cells[0].Value.ToString();

                // Câu lệnh 
                kq = dlnccBussiness.CapNhatNhaCungCap(ref err, txtMNCC.Text, txtTNCC.Text,
                        txtDC.Text, txtSDT.Text);
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
            (new frmChiTietHopDongCungCap()).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new FrmHopDongCC()).ShowDialog();
        }
    }
}
