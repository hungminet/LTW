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
    
    public partial class DETAI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DETAI()
        {
            this.SINHVIENs = new HashSet<SINHVIEN>();
        }
    
        public int MaDT { get; set; }
        public string TenDT { get; set; }
        public Nullable<int> MaLDT { get; set; }
        public Nullable<int> GVHD { get; set; }
        public Nullable<int> GVPB { get; set; }
    
        public virtual CHITIETDETAI CHITIETDETAI { get; set; }
        public virtual GIANGVIEN GIANGVIEN { get; set; }
        public virtual GIANGVIEN GIANGVIEN1 { get; set; }
        public virtual LOAIDETAI LOAIDETAI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SINHVIEN> SINHVIENs { get; set; }
    }
}
