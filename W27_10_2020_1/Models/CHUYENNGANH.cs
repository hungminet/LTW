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
    
    public partial class CHUYENNGANH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHUYENNGANH()
        {
            this.DANGKies = new HashSet<DANGKY>();
            this.GIANGVIENs = new HashSet<GIANGVIEN>();
            this.SINHVIENs = new HashSet<SINHVIEN>();
        }
    
        public int MaCN { get; set; }
        public string TenCN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANGKY> DANGKies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIANGVIEN> GIANGVIENs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SINHVIEN> SINHVIENs { get; set; }
    }
}
