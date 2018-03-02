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
    public partial class FrmChonBan : Form
    {
        // lấy dữ liệu từ 2 bảng bàn và vị trí
        BussinessViTri kvBussiness = new BussinessViTri();
        BussinessQuanLyBan qlbBussiness = new BussinessQuanLyBan();
        bool Them = true;
        public FrmChonBan()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {

                // Đưa dữ liệu lên DataGridView  
                dgvChonBan.DataSource = qlbBussiness.getban();
                // Thay đổi độ rộng cột 
                dgvChonBan.AutoResizeColumns();
                // Xóa trống các đối tượng trong group box
                this.cbBan.ResetText();
                this.cbKhuVuc.ResetText();
                
               dgvChonBan_CellContentClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table CUAHANG. Lỗi rồi!!!");
            }
        }
        private void FrmChonBan_Load(object sender, EventArgs e)
        {
           
            LoadData();
         // hiển thị tên vị trí theo mã vị trí
            cbKhuVuc.DataSource = kvBussiness.getViTri();
            cbKhuVuc.DisplayMember = "TenVT";
            cbKhuVuc.ValueMember = "MaVT";
        }

        private void dgvChonBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvChonBan.CurrentCell.RowIndex;
            dgvChonBan.Rows[r].Cells[0].Value.ToString();
            dgvChonBan.Rows[r].Cells[1].Value.ToString();
            dgvChonBan.Rows[r].Cells[2].Value.ToString();
            dgvChonBan.Rows[r].Cells[3].Value.ToString();
            dgvChonBan.Rows[r].Cells[4].Value.ToString();
            // tắt ko cho các khóa ngoại hiển thị trên dgv
            dgvChonBan.Columns[5].Visible = false;
        
             dgvChonBan.Columns[6].Visible = false;
            dgvChonBan.Columns[7].Visible = false;
            dgvChonBan.Columns[8].Visible = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            Program.MaBan = cbBan.Text;
            (new FrmChonMon()).ShowDialog();
        }

        private void cbKhuVuc_SelectedValueChanged(object sender, EventArgs e)
        {
            // Lấy mã bàn theo mã khu vực
            string Mahv = cbKhuVuc.SelectedValue.ToString();

            cbBan.DataSource = (new BussinessQuanLyBan()).getBanWithMakv(Mahv);
            cbBan.DisplayMember = "MaBan";
            cbBan.ValueMember = "MaBan";
        }
    }
}
