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
    
    public partial class PHANCONG
    {
        public int MaCa { get; set; }
        public int MaNV { get; set; }
        public Nullable<int> HeSo { get; set; }
    
        public virtual CA CA { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
