using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QLCHCF_DatabaseFirst
{
    class BussinessChucVu
    {
        QLCP_BCCK1Entities dbs = new QLCP_BCCK1Entities();
        public List<CHUCVU> getChucVu()
        {
            return dbs.CHUCVUs.ToList();
        }
        public bool ThemChucVu(ref string err, string MaCV, string TenCV)
        {
            bool flag = false;
            try
            {
                CHUCVU cv = new CHUCVU();
                cv.MaCV = MaCV;
                cv.TenCV = TenCV;
                //add vao
                dbs.CHUCVUs.Add(cv);
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

        public bool XoaChucVu(ref string err, string MaCV, string TenCV)
        {
            bool flag = false;
            var toDelete = dbs.CHUCVUs.Find(MaCV);

            if (toDelete != null)
            {
                dbs.CHUCVUs.Remove(toDelete);

                dbs.SaveChanges();
                flag = true;
            }

            return flag;
        }

        public bool CapNhatChucVu(ref string err, string MaCV, string TenCV)
        {
            bool flag = false;
            try
            {
                var cv = dbs.CHUCVUs.Find(MaCV);
                if (cv != null)
                {
                    // ct.MaNL = MaNL;
                    cv.TenCV = TenCV;
                    
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
