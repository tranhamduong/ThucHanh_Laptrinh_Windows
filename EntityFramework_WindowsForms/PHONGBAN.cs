namespace EntityFramework_WindowsForms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHONGBAN")]
    public partial class PHONGBAN
    {
        [Key]
        [StringLength(5)]
        public string MAPH { get; set; }

        [Required]
        [StringLength(30)]
        public string TENPH { get; set; }

        [StringLength(40)]
        public string DIADIEM { get; set; }
    }
}
