namespace EntityFramework_WindowsForms
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
        [StringLength(6)]
        public string MANV { get; set; }

        [StringLength(40)]
        public string HOTEN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYSINH { get; set; }

        [StringLength(3)]
        public string PHAI { get; set; }

        [StringLength(40)]
        public string DIACHI { get; set; }

        public double? LUONG { get; set; }

        [StringLength(6)]
        public string MANQL { get; set; }

        [StringLength(5)]
        public string MAPH { get; set; }
    }
}
