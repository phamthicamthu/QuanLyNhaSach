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
    
    public partial class VAITRO
    {
        public VAITRO()
        {
            this.NHANVIENs = new HashSet<NHANVIEN>();
        }
    
        public int MAVT { get; set; }
        public string TENVT { get; set; }
    
        public virtual ICollection<NHANVIEN> NHANVIENs { get; set; }
    }
}