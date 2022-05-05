using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EntityFramework_WindowsForms
{
    public partial class NhanVienModel : DbContext
    {
        public NhanVienModel()
            : base("name=NhanVienModel")
        {
        }

        public virtual DbSet<DEAN> DEANs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHANCONG> PHANCONGs { get; set; }
        public virtual DbSet<PHONGBAN> PHONGBANs { get; set; }
        public virtual DbSet<THANNHAN> THANNHANs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DEAN>()
                .Property(e => e.MADA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.PHAI)
                .IsFixedLength();

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MANQL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MAPH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHANCONG>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHANCONG>()
                .Property(e => e.MADA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHONGBAN>()
                .Property(e => e.MAPH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THANNHAN>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THANNHAN>()
                .Property(e => e.PHAI)
                .IsFixedLength();
        }
    }
}
