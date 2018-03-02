using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QLCHCF_DatabaseFirst
{
    class DaiLyNhanCungCapBussiness
    {
        // Lay database
        QLCP_BCCK1Entities dbs = new QLCP_BCCK1Entities();
        //LayBang san Pham
        public List<NHACUNGCAP> getNhaCungCap()
        {
            return dbs.NHACUNGCAPs.ToList();
        }
        public bool ThemNhaCungCap(ref string err, string MaNCC, string TenNCC, string DiaChi, string SoDT)
        {
            bool flag = false;
            try
            {
                NHACUNGCAP ncc  = new NHACUNGCAP();
                ncc.MaNCC = MaNCC;
                ncc.TenNCC = TenNCC;
                ncc.DiaChi = DiaChi;
                ncc.SoDT = SoDT;

                //add vao
                dbs.NHACUNGCAPs.Add(ncc);
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

        public bool XoaNhaCungCap(ref string err, string MaNCC)
        {
            bool flag = false;
            var toDelete = dbs.NHACUNGCAPs.Find(MaNCC);
            if (toDelete != null)
            {
                dbs.NHACUNGCAPs.Remove(toDelete);
                dbs.SaveChanges();
                flag = true;
            }
            return flag;
        }

        public bool CapNhatNhaCungCap(ref string err, string MaNCC, string TenNCC, string DiaChi, string SoDT)
        {
            bool flag = false;
            try
            {
                var ncc = dbs.NHACUNGCAPs.Find(MaNCC);
                if (ncc != null)
                {
                    ncc.TenNCC = TenNCC;
                    ncc.DiaChi = DiaChi;

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
