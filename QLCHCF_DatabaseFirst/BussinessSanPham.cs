using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QLCHCF_DatabaseFirst
{
   public class BussinessSanPham
    {
        // Lay database
        QLCP_BCCK1Entities dbs = new QLCP_BCCK1Entities();
        //LayBang san Pham
        public List<SANPHAM> getSanPham()
        {
            return dbs.SANPHAMs.ToList();
        }
        public bool ThemSanPham(ref string err, string MaSP, string TenSP, string DonGia)
        {
            bool flag = false;
            try
            {
                SANPHAM sp = new SANPHAM();
                sp.MaSP = MaSP;
                sp.TenSP = TenSP;
                sp.DonGia = DonGia;
               
                //add vao
                dbs.SANPHAMs.Add(sp);
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

        public bool XoaSanPham(ref string err, string MaSP)
        {
            bool flag = false;
            var toDelete = dbs.SANPHAMs.Find(MaSP);
            if (toDelete != null)
            {
                dbs.SANPHAMs.Remove(toDelete);
                dbs.SaveChanges();
                flag = true;
            }
            return flag;
        }

        public bool CapNhatSanPham(ref string err, string MaSP, string TenSP, string DonGia)
        {
            bool flag = false;
            try
            {
                var sp = dbs.SANPHAMs.Find(MaSP);
                if (sp != null)
                {
                    sp.TenSP = TenSP;
                    sp.DonGia = DonGia;
                    
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

