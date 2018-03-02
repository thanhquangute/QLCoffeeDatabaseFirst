using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace QLCHCF_DatabaseFirst
{
   
    class BussinessChiTietHoaDon
    {
        //Lay database 
        QLCP_BCCK1Entities dbs = new QLCP_BCCK1Entities();
        //Lay bang Chi Tiet Hoa Don
        public List<CTHOADON> getChiTietHoaDon()
        {
            return dbs.CTHOADONs.ToList();
        }
        public bool ThemChiTietHoaDon(ref string err, string MaHD, string MaSP, string TenSP, string SoLuong, string DonGia)
        {
            bool flag = false;
            try
            {
                CTHOADON cthd = new CTHOADON();
                cthd.MaHD = MaHD;
                cthd.MaSP = MaSP;
                cthd.TenSP = TenSP;
                cthd.SoLuong = SoLuong;
                cthd.DonGia = DonGia;
                //add vao
                dbs.CTHOADONs.Add(cthd);
                
                dbs.SaveChanges();
                flag = true;
            }
            catch (SqlException)
            {
                err = "Loi roi";
            }
            return flag;
        }
        //Tinh thanh tien CTHD
        public DataTable ThongTin()
        {
            DataTable dt = new DataTable();
            var hoadon = from p in dbs.CTHOADONs
                         select p;
            dt.Columns.Add("MaHD");
            dt.Columns.Add("MaSP");
            dt.Columns.Add("TenSP");
            dt.Columns.Add("SoLuong");
            dt.Columns.Add("DonGia");
            dt.Columns.Add("TongTien");
            foreach (var c in hoadon)
                dt.Rows.Add(c.MaHD, c.MaSP, c.TenSP, c.SoLuong, c.DonGia, Int32.Parse(c.SoLuong) * Double.Parse(c.DonGia));
            return dt;
        }
        public bool XoaChiTietHoaDon(ref string err, string MaHD, string MaSP)
        {
            bool flag = false;
            var toDelete = dbs.CTHOADONs.Find(MaHD, MaSP);

            if (toDelete != null)
            {
                dbs.CTHOADONs.Remove(toDelete);

                dbs.SaveChanges();
                flag = true;
            }

            return flag;
        }

        public bool CapNhatChiTietHoaDon(ref string err, string MaHD, string MaSP, string TenSP, string SoLuong, string DonGia)
        {
            bool flag = false;
            try
            {
                var cthd = dbs.CTHOADONs.Find(MaHD, MaSP);
                if (cthd != null)
                {
                     cthd.TenSP = TenSP;
                    cthd.SoLuong = SoLuong;
                    cthd.DonGia = DonGia;
                    

                    dbs.SaveChanges();

                    flag = true;
                }

            }
            catch (SqlException)
            {
                err = "Loi rui!!!";
            }
            return flag;
        }
    }
}

