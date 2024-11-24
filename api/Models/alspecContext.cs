using Microsoft.EntityFrameworkCore;

namespace api.Models
{
    public partial class alspecContext : DbContext
    {
        public alspecContext()
        {
        }

        public alspecContext(DbContextOptions<alspecContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Job> Jobs { get; set; } = null!;
        public virtual DbSet<SubItem> Subitems { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("job");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Title).HasColumnName("title");
                entity.Property(e => e.Description).HasColumnName("description");
                entity.HasMany(j => j.SubItems)
                    .WithOne(s => s.Job)
                    .HasForeignKey(s => s.JobId);
            });

            modelBuilder.Entity<SubItem>(entity =>
            {
                entity.ToTable("subitem");
                entity.HasKey(e => e.ItemId);
                entity.Property(e => e.ItemId).HasColumnName("itemid");
                entity.Property(e => e.Title).HasColumnName("title");
                entity.Property(e => e.Description).HasColumnName("description");
                entity.Property(e => e.Status).HasColumnName("status");
                entity.Property(e => e.JobId).HasColumnName("jobid");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
