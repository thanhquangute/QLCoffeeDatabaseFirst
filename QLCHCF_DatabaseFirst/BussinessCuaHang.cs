using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QLCHCF_DatabaseFirst
{
    public class BussinessCuaHang
    {
        //Lay database 
        QLCP_BCCK1Entities dbs = new QLCP_BCCK1Entities();
        //Lay bamg CuaHAng
        public List <CUAHANG> getCuaHang()
        {
            return dbs.CUAHANGs.ToList();
        }
        public bool ThemCuaHang(ref string err, string MaCH, string TenCH, string TenKV, string DiaChi, string SoDT)
        {
            bool flag = false;
            try
            {
                CUAHANG ch = new CUAHANG();
                ch.MaCH = MaCH;
                ch.TenCH = TenCH;
                ch.TenKV = TenKV;
                ch.DiaChi = DiaChi;
                ch.SoDT = SoDT;
                //add vao
                dbs.CUAHANGs.Add(ch);
                //luu lai luu duoc thi flag=true, ko thi false
                dbs.SaveChanges();
                flag = true;
            }
            catch(SqlException)
            {
                err = "Loi roi";
            }
            return flag;
        }

        public bool XoaCuaHang(ref string err, string MaCH)
        {
            bool flag = false;
            var toDelete = dbs.CUAHANGs.Find(MaCH);
            if (toDelete != null)
            {
                dbs.CUAHANGs.Remove(toDelete);
                dbs.SaveChanges();
                flag = true;
            }
            return flag;
        }

        public bool CapNhatCuaHang(ref string err, string MaCH, string TenCH, string TenKV, string DiaChi, string SoDT)
        {
            bool flag = false;
            try
            {
                var ch = dbs.CUAHANGs.Find(MaCH);
                if (ch != null)
                {
                    ch.TenCH = TenCH;
                    ch.TenKV = TenKV;
                    ch.DiaChi = DiaChi;
                    ch.SoDT = SoDT;
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
