//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectRestaurantManagement.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietHD
    {
        public string MaCTHD { get; set; }
        public string MaMonAn { get; set; }
        public string MaHD { get; set; }
        public int SoLuong { get; set; }
        public string TrangThaiMon { get; set; }
        public Nullable<System.DateTime> ThoiGianDatMon { get; set; }
        public Nullable<double> ThanhTien { get; set; }
    
        public virtual HoaDon HoaDon { get; set; }
        public virtual MonAn MonAn { get; set; }
    }
}
