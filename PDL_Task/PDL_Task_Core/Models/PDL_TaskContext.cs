using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PDL_Task_Core.Models
{
    public partial class PDL_TaskContext : DbContext
    {
        public PDL_TaskContext()
        {
        }

        public PDL_TaskContext(DbContextOptions<PDL_TaskContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Retailers> Retailers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=PDL_Task;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departments>(entity =>
            {
                entity.HasKey(e => e.DepartmentId)
                    .HasName("PK__Departme__B2079BED951D3326");

                entity.HasIndex(e => e.DepartmentCode)
                    .HasName("UQ__Departme__6EA8896D26210AAE")
                    .IsUnique();

                entity.Property(e => e.DepartmentCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<Retailers>(entity =>
            {
                entity.HasKey(e => e.RetailerId)
                    .HasName("PK__Retailer__91152A47676F6D9E");

                entity.HasIndex(e => e.RetailerCode)
                    .HasName("UQ__Retailer__9BE174E931FA91CB")
                    .IsUnique();

                entity.Property(e => e.RetailerCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.RetailerName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Retailers)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Retailers__Depar__276EDEB3");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
