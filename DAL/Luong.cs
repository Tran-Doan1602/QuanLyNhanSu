//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Luong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Luong()
        {
            this.baoHiems = new HashSet<baoHiem>();
        }
    
        public string maLuong { get; set; }
        public string tenNV { get; set; }
        public int luongCB { get; set; }
        public Nullable<int> phuCap { get; set; }
        public int congThang { get; set; }
        public Nullable<int> tienThuong { get; set; }
        public string maCB { get; set; }
        public int maNV { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<baoHiem> baoHiems { get; set; }
        public virtual ChamCong ChamCong { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
