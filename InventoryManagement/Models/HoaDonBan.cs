//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InventoryManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HoaDonBan
    {
        public int ID_HoaDonBan { get; set; }
        public Nullable<int> ID_KhachHang { get; set; }
        public Nullable<System.DateTime> NgayBan { get; set; }
        public Nullable<int> ID_NhanVien { get; set; }
        public Nullable<int> ID_Kho { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Created_At { get; set; }
        public string Updated_By { get; set; }
        public Nullable<System.DateTime> Updated_At { get; set; }
        public Nullable<int> ID_Xoa { get; set; }
    
        public virtual CT_HoaDonBan CT_HoaDonBan { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual Kho Kho { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual Xoa Xoa { get; set; }
    }
}
