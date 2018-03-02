using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QLCHCF_DatabaseFirst
{
    class BussinessChiTietHopDongCC
    {
        // Lay database
        QLCP_BCCK1Entities dbs = new QLCP_BCCK1Entities();
        //LayBang san Pham
        public List<CHITIETHDCC> getChiTietHDCC()
        {
            return dbs.CHITIETHDCCs.ToList();
        }
        public bool ThemChiTietHDCC(ref string err, string MaHDCC, string MaNL, string SoLuong, string DonGia, string DonViTinh)
        {
            bool flag = false;
            try
            {
                CHITIETHDCC ct = new CHITIETHDCC();
                ct.MaHDCC = MaHDCC;
                ct.MaNL = MaNL;
                ct.SoLuong = SoLuong;
                ct.DonGia = DonGia;
                ct.DonViTinh = DonViTinh;

                //add vao
                dbs.CHITIETHDCCs.Add(ct);
                //luu lai luu duoc thi flag=true, ko thi false
                dbs.SaveChanges();
                flag = true;
            }
            catch (SqlException)
            {
                err = "Loi roi";
            }
            return flag;
        }
        public DataTable ThongTin()
        {
            DataTable dt = new DataTable();
            var cthdcc = from p in dbs.CHITIETHDCCs
                         select p;
            dt.Columns.Add("MaHDCC");
            dt.Columns.Add("MaNL");
            dt.Columns.Add("SoLuong");
            dt.Columns.Add("DonGia");
            dt.Columns.Add("DonViTinh");
            dt.Columns.Add("TongTien");
            foreach (var c in cthdcc)
                dt.Rows.Add(c.MaHDCC, c.MaNL, c.SoLuong, c.DonGia, c.DonViTinh, Int32.Parse(c.SoLuong) * Double.Parse(c.DonGia));
            return dt;
        }
        public bool XoaChiTietHDCC(ref string err, string MaHDCC,string MaNL)
        {
            bool flag = false;
            var toDelete = dbs.CHITIETHDCCs.Find(MaHDCC,MaNL);
           
            if (toDelete != null)
            {
                dbs.CHITIETHDCCs.Remove(toDelete);
               
                dbs.SaveChanges();
                flag = true;
            }
            
            return flag;
        }

        public bool CapNhatChiTietHDCC(ref string err, string MaHDCC, string MaNL, string SoLuong, string DonGia, string DonViTinh)
        {
            bool flag = false;
            try
            {
                var ct = dbs.CHITIETHDCCs.Find(MaHDCC,MaNL);
                if (ct != null )
                {
                   // ct.MaNL = MaNL;
                    ct.SoLuong = SoLuong;
                    ct.DonGia = DonGia;
                    ct.DonViTinh = DonViTinh;
                  
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
