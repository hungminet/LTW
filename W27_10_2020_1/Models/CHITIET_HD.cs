//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace W27_10_2020_1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHITIET_HD
    {
        public int MaHD { get; set; }
        public int MaSP { get; set; }
        public Nullable<int> SoLuong { get; set; }
    
        public virtual HOADON HOADON { get; set; }
        public virtual SANPHAM SANPHAM { get; set; }
    }
}
