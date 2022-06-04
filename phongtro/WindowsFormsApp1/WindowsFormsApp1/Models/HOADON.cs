namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("HOADON")]
    public partial class HOADON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADON()
        {
            CHITIETHOADONs = new HashSet<CHITIETHOADON>();
        }

        [Key]
        [StringLength(5)]
        public string MAHD { get; set; }

        [StringLength(5)]
        public string MAKH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYHOADON { get; set; }

        [StringLength(5)]
        public string MAPHONG { get; set; }

        public int? TONGTIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADON> CHITIETHOADONs { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }
        public static List<HOADON> GetAll()
        {
            Model1 context = new Model1();
            return context.HOADONs.ToList();
        }
        public static HOADON GetHoaDon(string soPhong)
        {
            Model1 context = new Model1();
            return context.HOADONs.Where(p => p.MAPHONG == soPhong).OrderByDescending(p=>p.NGAYHOADON).FirstOrDefault();
        }
        public string GetTenKhachHang(string maKH)
        {
            Model1 context = new Model1();
            return context.KHACHHANGs.Where(p => p.MAKH == maKH).FirstOrDefault().HOTENKH;
        }
        public void InsertUpdate()
        {
            Model1 context = new Model1();
            context.HOADONs.Add(this);
            context.SaveChanges();
        }
    }
}
