using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLCHCF_DatabaseFirst
{
    class BussinessHopDongCungCap
    {
        // Lay database
        QLCP_BCCK1Entities dbs = new QLCP_BCCK1Entities();
        //LayBang HDCC
        public List<HOPDONGCC> getHopDongCC()
        {
            return dbs.HOPDONGCCs.ToList();
        }
        public bool ThemHopDongCC(ref string err, string MaHDCC, string MaNCC, DateTime NgayHD)
        {
            bool flag = false;
            try
            {
                HOPDONGCC hdcc = new HOPDONGCC();
                hdcc.MaHDCC = MaHDCC;
                hdcc.MaNCC = MaNCC;
                hdcc.NgayHD = NgayHD;

                //add vao
                dbs.HOPDONGCCs.Add(hdcc);
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

        public bool XoaHopDongCC(ref string err, string MaHDCC)
        {
            bool flag = false;
            var toDelete = dbs.HOPDONGCCs.Find(MaHDCC);
            if (toDelete != null)
            {
                dbs.HOPDONGCCs.Remove(toDelete);
                dbs.SaveChanges();
                flag = true;
            }
            return flag;
        }

        public bool CapNhatHopDongCC(ref string err, string MaHDCC, string MaNCC, DateTime NgayHD)
        {
            bool flag = false;
            try
            {
                var hdcc = dbs.HOPDONGCCs.Find(MaHDCC);
                if (hdcc != null)
                {
                    hdcc.MaNCC = MaNCC;
                    hdcc.NgayHD = NgayHD;

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
