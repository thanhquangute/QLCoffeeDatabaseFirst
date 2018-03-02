using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLCHCF_DatabaseFirst
{
    class BussinessQuanLyNhanVien
    {
        // Lay database
        QLCP_BCCK1Entities dbs = new QLCP_BCCK1Entities();
        //LayBang Nhan Vien
        public List<NHANVIEN> getNhanVien()
        {
            return dbs.NHANVIENs.ToList();
        }
        public bool ThemNhanVien(ref string err, string MaNV, string TenNV, string TaiKhoan, string MatKhau,
            string MaNQL, string CMND, string MaCV, string MaCH, DateTime NgSinh, string Phai, string DiaChi, string SoDT)
        {
            bool flag = false;
            try
            {
                NHANVIEN nv = new NHANVIEN();
                nv.MaNV = MaNV;
                nv.TenNV = TenNV;
                nv.TaiKhoan = TaiKhoan;
                nv.MatKhau = MatKhau;
                nv.MaNQL = MaNQL;
                nv.CMND = CMND;
                nv.MaCV = MaCV;
                nv.MaCH = MaCH;
                nv.NgSinh = NgSinh;
                nv.Phai = Phai;
                nv.DiaChi = DiaChi;
                nv.SoDT = SoDT;


                //add vao
                dbs.NHANVIENs.Add(nv);
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

        public bool XoaNhanVien(ref string err, string MaNV)
        {
            bool flag = false;
            var toDelete = dbs.NHANVIENs.Find(MaNV);
            if (toDelete != null)
            {
                dbs.NHANVIENs.Remove(toDelete);
                dbs.SaveChanges();
                flag = true;
            }
            return flag;
        }

        public bool CapNhatNhanVien(ref string err, string MaNV, string TenNV, string TaiKhoan, string MatKhau,
            string MaNQL, string CMND, string MaCV, string MaCH, DateTime NgSinh, string Phai, string DiaChi, string SoDT)
        {
            bool flag = false;
            try
            {
                var nv = dbs.NHANVIENs.Find(MaNV);
                if (nv != null)
                {
                    nv.TenNV = TenNV;
                    nv.TaiKhoan = TaiKhoan;
                    nv.MatKhau = MatKhau;
                    nv.MaNQL = MaNQL;
                    nv.CMND = CMND;
                    nv.MaCV = MaCV;
                    nv.NgSinh = NgSinh;
                    nv.Phai = Phai;
                    nv.DiaChi = DiaChi;
                    nv.SoDT = SoDT;

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

