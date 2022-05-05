namespace EntityFramework_WindowsForms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THANNHAN")]
    public partial class THANNHAN
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string MANV { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string TENTN { get; set; }

        [StringLength(3)]
        public string PHAI { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYSINH { get; set; }

        [StringLength(15)]
        public string QUANHE { get; set; }
    }
}
