//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace c2cWebsite.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class merchant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public merchant()
        {
            this.hoadonbans = new HashSet<hoadonban>();
            this.khuyenmais = new HashSet<khuyenmai>();
            this.sanphams = new HashSet<sanpham>();
        }
    
        public int merchant_id { get; set; }
        public string cmnd { get; set; }
        public string tenshop { get; set; }
        public string anhshop { get; set; }
        public Nullable<short> diemdanhgia { get; set; }
        public Nullable<System.DateTime> ngaydangky { get; set; }
        public string taikhoanpaypal { get; set; }
        public Nullable<int> capdo_id { get; set; }
        public Nullable<int> customer_id { get; set; }
    
        public virtual capdo capdo { get; set; }
        public virtual customer customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hoadonban> hoadonbans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<khuyenmai> khuyenmais { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sanpham> sanphams { get; set; }
    }
}
