using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QLCHCF_DatabaseFirst
{
    public class BussinessOder
    {
        // Lay database
        QLCP_BCCK1Entities dbs = new QLCP_BCCK1Entities();
       //Lay bang Oder
        public List<ODER> getOder()
        {
            return dbs.ODERs.ToList();
        }
        public bool ThemOder(ref string err, string MaOder, string MaNV, string MaBan, string MaKH, DateTime Ngay)
        {
            bool flag = false;
            try
            {
                ODER od = new ODER();
                od.MaOder = MaOder;
                od.MaNV = MaNV;
                od.MaBan = MaBan;
                od.MaKH = MaKH;
                od.Ngay = Ngay;
                //add vao
                dbs.ODERs.Add(od);
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

        public bool XoaOder(ref string err, string MaOder)
        {
            bool flag = false;
            var toDelete = dbs.ODERs.Find(MaOder);

            if (toDelete != null)
            {
                dbs.ODERs.Remove(toDelete);

                dbs.SaveChanges();
                flag = true;
            }

            return flag;
        }

        public bool CapNhatOder(ref string err, string MaOder, string MaNV, string MaBan, string MaKH, DateTime Ngay)
        {
            bool flag = false;
            try
            {
                var od = dbs.ODERs.Find(MaOder);
                if (od != null)
                {
                    
                    od.MaOder = MaOder;
                    od.MaNV = MaNV;
                    od.MaBan = MaBan;
                    od.MaKH = MaKH;
                    od.Ngay = Ngay;

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
