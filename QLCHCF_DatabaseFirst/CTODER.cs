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
    
    public partial class CTODER
    {
        public string MaOder { get; set; }
        public string MaSP { get; set; }
        public string MaBan { get; set; }
        public string SoLuong { get; set; }
    
        public virtual BAN BAN { get; set; }
        public virtual ODER ODER { get; set; }
        public virtual SANPHAM SANPHAM { get; set; }
    }
}
