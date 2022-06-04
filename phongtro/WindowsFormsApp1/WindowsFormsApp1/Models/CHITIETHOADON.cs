namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("CHITIETHOADON")]
    public partial class CHITIETHOADON
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string MAHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string TENDV { get; set; }

        public int? SOLUONG { get; set; }

        public int? DONGIA { get; set; }

        public virtual HOADON HOADON { get; set; }

        public static List<CHITIETHOADON> GetChiTietHoaDon(string maHD)
        {
            Model1 context = new Model1();
            return context.CHITIETHOADONs.Where(p => p.MAHD == maHD).ToList();
        }

        public void InsertUpdate()
        {
            Model1 context = new Model1();
            context.CHITIETHOADONs.AddOrUpdate(this);
            context.SaveChanges();
        }
    }
}
