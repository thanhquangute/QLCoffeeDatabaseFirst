using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QLCHCF_DatabaseFirst
{
  public  class BussinessHoaDon
    {
        QLCP_BCCK1Entities dbs = new QLCP_BCCK1Entities();
        public List<HOADON> getHoaDon()
        {
            return dbs.HOADONs.ToList();
        }
        public bool ThemHoaDon(ref string err, string MaHD, string MaOder, string MaBan, DateTime Ngay)
        {
            bool flag = false;
            try
            {
                HOADON hd = new HOADON();
                hd.MaHD = MaHD;
                hd.MaOder = MaOder;
                hd.MaBan = MaBan;
                hd.Ngay = Ngay;
                
                //add vao
                dbs.HOADONs.Add(hd);
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

        public bool XoaHoaDon(ref string err, string MaHD)
        {
            bool flag = false;
            var toDelete = dbs.HOADONs.Find(MaHD);

            if (toDelete != null)
            {
                dbs.HOADONs.Remove(toDelete);

                dbs.SaveChanges();
                flag = true;
            }

            return flag;
        }

        public bool CapNhatHoaDon(ref string err, string MaHD, string MaOder, string MaBan, DateTime Ngay)
        {
            bool flag = false;
            try
            {
                var hd = dbs.HOADONs.Find(MaHD);
                if (hd != null)
                {
                    hd.MaOder = MaOder;
                    hd.MaBan = MaBan;
                    hd.Ngay = Ngay;


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

