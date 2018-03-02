using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QLCHCF_DatabaseFirst
{
    class BussinessNguyenLieu
    {
        // Lay database
        QLCP_BCCK1Entities dbs = new QLCP_BCCK1Entities();
        //LayBang san Pham
        public List<NGUYENLIEU> getNguyenLieu()
        {
            return dbs.NGUYENLIEUx.ToList();
        }
        public bool ThemNguyenLieu(ref string err, string MaNL, string TenNL, string GiaThanh,string DonViTinh)
        {
            bool flag = false;
            try
            {
                NGUYENLIEU nl = new NGUYENLIEU();
                nl.MaNL = MaNL;
                nl.TenNL = TenNL;
                nl.GiaThanh = GiaThanh;
                nl.DonViTinh = DonViTinh; 

                //add vao
                dbs.NGUYENLIEUx.Add(nl);
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

        public bool XoaNguyenLieu(ref string err, string MaNL)
        {
            bool flag = false;
            var toDelete = dbs.NGUYENLIEUx.Find(MaNL);
            if (toDelete != null)
            {
                dbs.NGUYENLIEUx.Remove(toDelete);
                dbs.SaveChanges();
                flag = true;
            }
            return flag;
        }

        public bool CapNhatNguyenLieu(ref string err, string MaNL, string TenNL, string GiaThanh, string DonViTinh)
        {
            bool flag = false;
            try
            {
                var nl = dbs.NGUYENLIEUx.Find(MaNL);
                if (nl != null)
                {
                    nl.TenNL = TenNL;
                    nl.GiaThanh = GiaThanh;
                    nl.DonViTinh = DonViTinh;
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
