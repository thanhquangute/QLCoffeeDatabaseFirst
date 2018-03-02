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
    public partial class frmChiTietHopDongCungCap : Form
    {
        DataTable dtCTHDCC = new DataTable();
        BussinessChiTietHopDongCC cthdccBussiness = new BussinessChiTietHopDongCC();
        bool Them = true;
        public frmChiTietHopDongCungCap()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {

                // Đưa dữ liệu lên DataGridView  
                dgvCTHDCC.DataSource = cthdccBussiness.getChiTietHDCC();
                // Thay đổi độ rộng cột 
                dgvCTHDCC.AutoResizeColumns();
                // Xóa trống các đối tượng trong Group box 
                this.txtMHDCC.ResetText();
                this.txtNL.ResetText();
                this.txtSL.ResetText();
                this.txtDG.ResetText();
                this.txtDVT.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy 
                this.btnSave.Enabled = false;
                this.btnCanCel.Enabled = false;

                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát 
                this.btnInsert.Enabled = true;
                this.btnEdit.Enabled = true;
                this.btnRemove.Enabled = true;
                this.btnExit.Enabled = true;
                dgvCTHDCC_CellContentClick(null, null);
              

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table CUAHANG. Lỗi rồi!!!");
            }
        }

        private void frmChiTietHopDongCungCap_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadDatactoder();
        }
        void LoadDatactoder()
        {
            try
            {

                // Đưa dữ liệu lên DataGridView  
                dgvCTHDCC.DataSource = cthdccBussiness.getChiTietHDCC();
                DataTable dt = new DataTable();
                dt = cthdccBussiness.ThongTin();
                dgvCTHDCC.DataSource = dt;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table HOADON. Lỗi rồi!!!");
            }
        }
        private void dgvCTHDCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvCTHDCC.CurrentCell.RowIndex;
            // Chuyển thông tin lên gruop box
            this.txtMHDCC.Text =
            dgvCTHDCC.Rows[r].Cells[0].Value.ToString();
            this.txtNL.Text =
            dgvCTHDCC.Rows[r].Cells[1].Value.ToString();
            this.txtSL.Text =
           dgvCTHDCC.Rows[r].Cells[2].Value.ToString();
            this.txtDG.Text =
           dgvCTHDCC.Rows[r].Cells[3].Value.ToString();
            this.txtDVT.Text =
           dgvCTHDCC.Rows[r].Cells[4].Value.ToString();
            //Xoa cac cot khoa ngoai khong cho hien thi
            dgvCTHDCC.Columns[5].Visible = false;
            dgvCTHDCC.Columns[6].Visible = false;



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
            this.txtMHDCC.ResetText();
            this.txtNL.ResetText();
            this.txtSL.ResetText();
            this.txtDG.ResetText();
            this.txtDVT.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy 
            this.btnSave.Enabled = true;
            this.btnCanCel.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát /tro ve
            this.btnInsert.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnRemove.Enabled = false;
            this.btnEdit.Enabled = false;
            // Đưa con trỏ đến TextField txtMaHDCC 
            this.txtMHDCC.Focus();
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
            this.txtMHDCC.Enabled = false;
            this.txtNL.Enabled = false;



        }

        private void btnCanCel_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Group box 
            this.txtMHDCC.ResetText();
            this.txtNL.ResetText();
            this.txtSL.ResetText();
            this.txtDG.ResetText();
            this.txtDVT.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            this.btnInsert.Enabled = true;
            this.btnEdit.Enabled = true;
            this.btnRemove.Enabled = true;
            this.btnExit.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnSave.Enabled = false;
            this.btnCanCel.Enabled = false;
            dgvCTHDCC_CellContentClick(null, null);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {

                // Lấy thứ tự record hiện hành 
                int r = dgvCTHDCC.CurrentCell.RowIndex;
                // Lấy MaHDCC, MaNL của record hiện hành 
                string strCHITIETHDCC =
                dgvCTHDCC.Rows[r].Cells[0].Value.ToString();
                string strCHITIETHDCC1 =
               dgvCTHDCC.Rows[r].Cells[1].Value.ToString();

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
                    kq = cthdccBussiness.XoaChiTietHDCC(ref err, txtMHDCC.Text,txtNL.Text);
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
                    kq = cthdccBussiness.ThemChiTietHDCC(ref err, txtMHDCC.Text, txtNL.Text, txtSL.Text, txtDG.Text, txtDVT.Text);
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
                int r = dgvCTHDCC.CurrentCell.RowIndex;
                // MaCH hiện hành 
                string strCHITIETHDCC =
                dgvCTHDCC.Rows[r].Cells[0].Value.ToString();

                // Câu lệnh SQL 
                kq = cthdccBussiness.CapNhatChiTietHDCC(ref err, txtMHDCC.Text, txtNL.Text, txtSL.Text, txtDG.Text, txtDVT.Text);
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
