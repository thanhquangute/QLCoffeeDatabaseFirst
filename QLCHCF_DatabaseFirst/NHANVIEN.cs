//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLCHCF_DatabaseFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            this.NHANVIEN1 = new HashSet<NHANVIEN>();
            this.ODERs = new HashSet<ODER>();
        }
    
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string MaNQL { get; set; }
        public string CMND { get; set; }
        public string MaCV { get; set; }
        public string MaCH { get; set; }
        public Nullable<System.DateTime> NgSinh { get; set; }
        public string Phai { get; set; }
        public string DiaChi { get; set; }
        public string SoDT { get; set; }
    
        public virtual CHUCVU CHUCVU { get; set; }
        public virtual CUAHANG CUAHANG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIEN> NHANVIEN1 { get; set; }
        public virtual NHANVIEN NHANVIEN2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ODER> ODERs { get; set; }
    }
}
