﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class c2cwebsiteEntities : DbContext
    {
        public c2cwebsiteEntities()
            : base("name=c2cwebsiteEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<capdo> capdoes { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<hangsanpham> hangsanphams { get; set; }
        public virtual DbSet<hinhanh> hinhanhs { get; set; }
        public virtual DbSet<hinhthucthanhtoan> hinhthucthanhtoans { get; set; }
        public virtual DbSet<hoadonban> hoadonbans { get; set; }
        public virtual DbSet<hoadonmua> hoadonmuas { get; set; }
        public virtual DbSet<khuyenmai> khuyenmais { get; set; }
        public virtual DbSet<khuyenmaihethong> khuyenmaihethongs { get; set; }
        public virtual DbSet<loaisanpham> loaisanphams { get; set; }
        public virtual DbSet<mausac> mausacs { get; set; }
        public virtual DbSet<merchant> merchants { get; set; }
        public virtual DbSet<sanpham> sanphams { get; set; }
        public virtual DbSet<sanpham_khuyenmai> sanpham_khuyenmai { get; set; }
        public virtual DbSet<sanpham_khuyenmaihethong> sanpham_khuyenmaihethong { get; set; }
        public virtual DbSet<sanpham_mausac> sanpham_mausac { get; set; }
        public virtual DbSet<sanpham_thongsokythuat> sanpham_thongsokythuat { get; set; }
        public virtual DbSet<thongsokythuat> thongsokythuats { get; set; }
        public virtual DbSet<tinhtranggiaohang> tinhtranggiaohangs { get; set; }
        public virtual DbSet<tinhtrangton> tinhtrangtons { get; set; }
    }
}
