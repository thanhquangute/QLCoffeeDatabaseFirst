using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QLCHCF_DatabaseFirst
{
   public class BussinessChiTietOder
    {
        QLCP_BCCK1Entities dbs = new QLCP_BCCK1Entities();

        public List<CTODER> getCTODer()
        {
            return dbs.CTODERs.ToList();
        }
        public bool ThemChiTietOder(ref string err, string MaOder, string MaSP, string MaBan, string SoLuong)
        {
            bool flag = false;
            try
            {
                CTODER ctod = new CTODER();
                ctod.MaOder = MaOder;
                ctod.MaSP = MaSP;
                ctod.MaBan = MaBan;
                ctod.SoLuong = SoLuong;
                //add vao
                dbs.CTODERs.Add(ctod);
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

        public bool XoaChiTietOD(ref string err, string MaOder, string MaSP, string MaBan)
        {
            bool flag = false;
            var toDelete = dbs.CTODERs.Find(MaOder, MaSP,MaBan);

            if (toDelete != null)
            {
                dbs.CTODERs.Remove(toDelete);

                dbs.SaveChanges();
                flag = true;
            }

            return flag;
        }

        public bool CapNhatChiTietOD(ref string err, string MaOder, string MaSP, string MaBan, string SoLuong)
        {
            bool flag = false;
            try
            {
                var ctod = dbs.CTODERs.Find(MaOder, MaSP,MaBan);
                if (ctod != null)
                {
                    ctod.SoLuong = SoLuong;
                    

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

