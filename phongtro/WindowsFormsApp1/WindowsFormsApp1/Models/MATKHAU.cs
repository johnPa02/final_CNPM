namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("MATKHAU")]
    public partial class MATKHAU
    {
        [Key]
        [StringLength(30)]
        public string USERNAME { get; set; }

        [StringLength(30)]
        public string PW { get; set; }
        
    }
    public partial class MATKHAU
    {
        public List<MATKHAU> GetAll()
        {
            Model1 context = new Model1();
            return context.MATKHAUs.ToList();
        }
    }
}
