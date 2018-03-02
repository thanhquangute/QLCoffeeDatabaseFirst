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
    public partial class FrmLogin : Form
    {
        BussinessLogin qlnv = new BussinessLogin();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                string user = txtUser.Text.Trim();
                string pass = txtPass.Text.Trim();

                NHANVIEN nv = new NHANVIEN();
                nv = qlnv.LayThongTinLogin(user, pass);
                if (nv == null)
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng!!", "Lỗi",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    txtUser.ResetText();
                    txtPass.ResetText();
                    txtUser.Focus();
                }
                else
                    this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời đi bạn!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtPass.Focus();
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnDangnhap.Focus();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
        }
    }
}
