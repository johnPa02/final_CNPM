namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [Key]
        [StringLength(5)]
        public string MANV { get; set; }

        [Required]
        [StringLength(30)]
        public string HOTEN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYSINH { get; set; }

        [StringLength(11)]
        public string SDT { get; set; }

        [StringLength(30)]
        public string QUEQUAN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYVAOLAM { get; set; }
    }
}
