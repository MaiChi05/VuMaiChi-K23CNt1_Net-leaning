using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Vmclesson11.Models
{
    public partial class DemoMaiChi2310900013Context : DbContext
    {
        public DemoMaiChi2310900013Context()
        {
        }

        public DemoMaiChi2310900013Context(DbContextOptions<DemoMaiChi2310900013Context> options)
            : base(options)
        {
        }

        public virtual DbSet<VmcEmployee> VmcEmployees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
            => optionsBuilder.UseSqlServer("server=MAICHI; Database=DemoMaiCHi_2310900013; uid=sa; PWD=123456; MultipleActiveResultSets=True; TrustServerCertificate=True ");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VmcEmployee>(entity =>
            {
                entity.HasKey(e => e.VmcEmpId).HasName("PK__VmcEmplo__C5EC78DDCC71FAF9");

                entity.ToTable("VmcEmployee");

                entity.Property(e => e.VmcEmpLevel).HasMaxLength(50);
                entity.Property(e => e.VmcEmpName).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
