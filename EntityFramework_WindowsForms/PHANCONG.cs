namespace EntityFramework_WindowsForms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHANCONG")]
    public partial class PHANCONG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string MANV { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MADA { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime THOIGIAN { get; set; }
    }
}
