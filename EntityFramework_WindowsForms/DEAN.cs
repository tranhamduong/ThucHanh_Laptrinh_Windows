namespace EntityFramework_WindowsForms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEAN")]
    public partial class DEAN
    {
        [Key]
        [StringLength(5)]
        public string MADA { get; set; }

        [StringLength(50)]
        public string TENDA { get; set; }

        [StringLength(30)]
        public string DIADIEMDA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYBD { get; set; }
    }
}
