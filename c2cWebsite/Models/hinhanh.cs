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
    
    public partial class hinhanh
    {
        public int hinhanh_id { get; set; }
        public string noidunghinhanh { get; set; }
        public Nullable<int> sanpham_id { get; set; }
    
        public virtual sanpham sanpham { get; set; }
    }
}