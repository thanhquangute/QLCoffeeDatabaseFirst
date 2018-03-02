using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QLCHCF_DatabaseFirst
{
    class BussinessLoaiKhachHang
    {
        QLCP_BCCK1Entities dbs = new QLCP_BCCK1Entities();
        public List<LOAIKH> getLoaiKH()
        {
            return dbs.LOAIKHs.ToList();
        }
        public bool ThemLoaiKH(ref string err, string MaLoaiKH, string TenLoaiKH , string ChiecKhau)
        {
            bool flag = false;
            try
            {
                LOAIKH lkh = new LOAIKH();
                lkh.MaLoaiKH = MaLoaiKH;
                   lkh.TenLoaiKH=TenLoaiKH ;
                lkh.ChiecKhau = ChiecKhau;
                //add vao
                dbs.LOAIKHs.Add(lkh);
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

        public bool XoaLoaiKH(ref string err, string MaLoaiKH)
        {
            bool flag = false;
            var toDelete = dbs.LOAIKHs.Find(MaLoaiKH);

            if (toDelete != null)
            {
                dbs.LOAIKHs.Remove(toDelete);

                dbs.SaveChanges();
                flag = true;
            }

            return flag;
        }

        public bool CapNhatLoaiKH(ref string err, string MaLoaiKH, string TenLoaiKH, string ChiecKhau)
        {
            bool flag = false;
            try
            {
                var lkh = dbs.LOAIKHs.Find(MaLoaiKH);
                if (lkh
                    != null)
                {
                    
                    lkh.TenLoaiKH = TenLoaiKH;
                    lkh.ChiecKhau = ChiecKhau;
                    

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

 
