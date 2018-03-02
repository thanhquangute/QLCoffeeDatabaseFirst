using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QLCHCF_DatabaseFirst
{
    class BussinessKhachHang
    {

        // Lay database
        QLCP_BCCK1Entities dbs = new QLCP_BCCK1Entities();
        //LayBang HDCC
        public List<KHACHHANG> getKhachHang()
        {
            return dbs.KHACHHANGs.ToList();
        }
        public bool ThemKhachHang(ref string err, string MaKH, string TenKH, string MaLoaiKH, string SoNguoi)
        {
            bool flag = false;
            try
            {
                KHACHHANG kh = new KHACHHANG();
                kh.MaKH = MaKH;
                kh.TenKH = TenKH;
                kh.MaLoaiKH = MaLoaiKH;
                kh.SoNguoi = SoNguoi;

                //add vao
                dbs.KHACHHANGs.Add(kh);
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

        public bool XoaKhachHang(ref string err, string MaKH)
        {
            bool flag = false;
            var toDelete = dbs.KHACHHANGs.Find(MaKH);
            if (toDelete != null)
            {
                dbs.KHACHHANGs.Remove(toDelete);
                dbs.SaveChanges();
                flag = true;
            }
            return flag;
        }

        public bool CapNhatKhachHang(ref string err, string MaKH, string TenKH, string MaLoaiKH, string SoNguoi)
        {
            bool flag = false;
            try
            {
                var kh = dbs.KHACHHANGs.Find(MaKH);
                if (kh != null)
                {
                    kh.TenKH = TenKH;
                    kh.MaLoaiKH = MaLoaiKH;
                    kh.SoNguoi = SoNguoi;
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

 
