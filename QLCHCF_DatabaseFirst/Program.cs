using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHCF_DatabaseFirst
{
    static class Program
    {
        public static string MaOrder;
        public static string MaBan;
        public static string donGia;
        public static string soLuong;
        public static string tenSanpham;
        public static string masanpham;
        public static string mahoadon;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmLogin frmlogin = new FrmLogin();
           
        // Application.Run(new FrmChonMon());
            Application.Run(new Form1());
        }
    }
}
