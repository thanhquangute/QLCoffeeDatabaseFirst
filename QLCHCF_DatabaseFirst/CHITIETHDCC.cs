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
    
    public partial class CHITIETHDCC
    {
        public string MaHDCC { get; set; }
        public string MaNL { get; set; }
        public string SoLuong { get; set; }
        public string DonGia { get; set; }
        public string DonViTinh { get; set; }
    
        public virtual HOPDONGCC HOPDONGCC { get; set; }
        public virtual NGUYENLIEU NGUYENLIEU { get; set; }
    }
}
