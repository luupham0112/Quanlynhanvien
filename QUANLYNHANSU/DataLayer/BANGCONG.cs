//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class BANGCONG
    {
        public int MABC { get; set; }
        public Nullable<int> NAM { get; set; }
        public Nullable<int> THANG { get; set; }
        public Nullable<int> NGAY { get; set; }
        public Nullable<int> MANV { get; set; }
        public Nullable<int> IDBANGCONG { get; set; }
    
        public virtual LOAICONG LOAICONG { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}