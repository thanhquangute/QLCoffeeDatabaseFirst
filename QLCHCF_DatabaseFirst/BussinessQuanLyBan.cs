using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLCHCF_DatabaseFirst
{
   public class BussinessQuanLyBan
    {
        //Lay database 
        QLCP_BCCK1Entities dbs = new QLCP_BCCK1Entities();
        //Lay bamg Ban
        public List<BAN> getban()
        {
            return dbs.BANs.ToList();
        }
        public bool ThemBan(ref string err, string MaBan, string TenBan, string MaVT, int SoGhe, bool TrangThai)
        {
            bool flag = false;
            try
            {
                BAN b = new BAN();
                b.MaBan = MaBan;
                b.TenBan = TenBan;
                b.MaVT = MaVT;
                b.SoGhe = SoGhe;
                b.TrangThai = TrangThai;
                //add vao
                dbs.BANs.Add(b);
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

        public bool XoaBan(ref string err, string MaBan)
        {
            bool flag = false;
            var toDelete = dbs.BANs.Find(MaBan);
            if (toDelete != null)
            {
                dbs.BANs.Remove(toDelete);
                dbs.SaveChanges();
                flag = true;
            }
            return flag;
        }

        public bool CapNhatBan(ref string err, string MaBan, string TenBan, string MaVT, int SoGhe, bool TrangThai)
        {
            bool flag = false;
            try
            {
                var b = dbs.BANs.Find(MaBan);
                if (b != null)
                {
                    b.TenBan = TenBan;
                    b.MaVT = MaVT;
                    b.SoGhe = SoGhe;
                    b.TrangThai = TrangThai;
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
        public List<BAN> getBanWithMakv(string makv)
        {
            List<BAN> ban = new List<BAN>();
            ban = (from a in dbs.BANs
                   where a.MaVT == makv
                   select a).ToList<BAN>();
            return ban;
        }
    }

}
