//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class NHANVIEN
    {
        public NHANVIEN()
        {
            this.TAIKHOANs = new HashSet<TAIKHOAN>();
            this.PHIEUNHAPs = new HashSet<PHIEUNHAP>();
        }
    
        public string MANV { get; set; }
        public string TENNV { get; set; }
        public int MAVT { get; set; }
        public decimal LUONG { get; set; }
        public double HESO { get; set; }
        public string SODT { get; set; }
        public string EMAIL { get; set; }
        public string DIACHI { get; set; }
    
        public virtual ICollection<TAIKHOAN> TAIKHOANs { get; set; }
        public virtual VAITRO VAITRO { get; set; }
        public virtual ICollection<PHIEUNHAP> PHIEUNHAPs { get; set; }
    }
}
