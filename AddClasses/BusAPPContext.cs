using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BusAPP.AddClasses
{
    public partial class BusAPPContext : DbContext
    {
        public BusAPPContext()
        {

        }

        public BusAPPContext(DbContextOptions<BusAPPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BlueCard> BlueCards { get; set; }
        public virtual DbSet<ElectronicCard> ElectronicCards { get; set; }
        public virtual DbSet<IstanbulCard> IstanbulCards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-KTDGKM4;Database=BusAPP;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<BlueCard>(entity =>
            {
                entity.HasKey(e => e.CardId);

                entity.ToTable("BlueCard");

                entity.Property(e => e.CardId).ValueGeneratedNever();

                entity.Property(e => e.CustomerName).HasMaxLength(50);
            });

            modelBuilder.Entity<ElectronicCard>(entity =>
            {
                entity.HasKey(e => e.CardId);

                entity.ToTable("ElectronicCard");

                entity.Property(e => e.CardId).ValueGeneratedNever();
            });

            modelBuilder.Entity<IstanbulCard>(entity =>
            {
                entity.HasKey(e => e.CardId);

                entity.ToTable("IstanbulCard");

                entity.Property(e => e.CardId).ValueGeneratedNever();

                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.CustomerType).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
