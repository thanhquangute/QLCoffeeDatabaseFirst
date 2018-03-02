using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QLCHCF_DatabaseFirst
{
    public class BussinessLogin
    {
        QLCP_BCCK1Entities lgBussiness = new QLCP_BCCK1Entities();
      //  bool Them = true;
        public NHANVIEN LayThongTinLogin(string user,string pass)
        {
            NHANVIEN nv = new NHANVIEN();
            nv = (from n in lgBussiness.NHANVIENs
                  where n.TaiKhoan == user
                  where n.MatKhau == pass
                  select n).FirstOrDefault<NHANVIEN>();
            return nv;           
        }
    }
}
