using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHCF_DatabaseFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void frmLogin()
        {
            Form frm = new FrmLogin();
            frm.ShowDialog();
        }

        private void btnCuaHang_Click(object sender, EventArgs e)
        {
            (new FrmCuaHang()).ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmLogin();
        }

        private void btnQuanLiBan_Click(object sender, EventArgs e)
        {
            (new FrmQuanLyBan()).ShowDialog();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            (new FrmSanPham()).ShowDialog();
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            (new FrmNhanVien()).ShowDialog();
        }

        private void btndaily_Click(object sender, EventArgs e)
        {
            (new FrmDaiLyNhaCungCap()).ShowDialog();
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            (new FrmKhachHang()).ShowDialog();
        }

        private void chọnBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FrmChonBan()).ShowDialog();
        }

        private void gọiBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FrmChonBan()).ShowDialog();
        }

        private void trợGiúpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Để khắc phục lỗi liên hệ Designer:01629404342");
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Khai báo biến traloi 
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp 
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không? 
            if (traloi == DialogResult.OK) this.Close();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FrmLogin()).ShowDialog();
            
        }
    }
}
