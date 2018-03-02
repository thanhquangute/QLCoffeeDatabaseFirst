using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QLCHCF_DatabaseFirst
{
    class BussinessViTri
    {
        QLCP_BCCK1Entities dbs = new QLCP_BCCK1Entities();
        public List<VITRI> getViTri()
        {
            return dbs.VITRIs.ToList();
        }
        public bool ThemViTri(ref string err, string MaVT, string TenVT)
        {
            bool flag = false;
            try
            {
                VITRI vt = new VITRI();
                vt.MaVT = MaVT;           //add vao
                vt.TenVT = TenVT;
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

        public bool XoaViTri(ref string err, string MaVT, string TenVT)
        {
            bool flag = false;
            var toDelete = dbs.VITRIs.Find(MaVT);

            if (toDelete != null)
            {
                dbs.VITRIs.Remove(toDelete);

                dbs.SaveChanges();
                flag = true;
            }

            return flag;
        }

        public bool CapNhatViTri(ref string err,string MaVT, string TenVT)
        {
            bool flag = false;
            try
            {
                var vt = dbs.VITRIs.Find(MaVT);
                if (vt != null)
                {
                    
                    vt.TenVT=TenVT;
                    
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
