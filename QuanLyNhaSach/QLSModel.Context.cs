﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyNhaSach
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLySachEntities : DbContext
    {
        public QuanLySachEntities()
            : base("name=QuanLySachEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CHITIETHOADON> CHITIETHOADONs { get; set; }
        public DbSet<CHITIETPHIEUNHAP> CHITIETPHIEUNHAPs { get; set; }
        public DbSet<HOADON> HOADONs { get; set; }
        public DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public DbSet<NHANVIEN> NHANVIENs { get; set; }
        public DbSet<PHIEUNHAP> PHIEUNHAPs { get; set; }
        public DbSet<PHIEUTHUTIEN> PHIEUTHUTIENs { get; set; }
        public DbSet<QUYDINH> QUYDINHs { get; set; }
        public DbSet<SACH> SACHes { get; set; }
        public DbSet<TACGIA> TACGIAs { get; set; }
        public DbSet<TAIKHOAN> TAIKHOANs { get; set; }
        public DbSet<THELOAI> THELOAIs { get; set; }
        public DbSet<VAITRO> VAITROes { get; set; }
    }
}
