using Microsoft.EntityFrameworkCore;
using DAL.Models;
namespace DAL
{
    public class AppDbContext: DbContext
    {
        public DbSet<VaiTro> VaiTros { get; set; }
        public DbSet<Quyen> Quyens { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<VaiTro>()
                .HasMany(v => v.Quyens)
                .WithMany(q => q.VaiTros)
                .UsingEntity(j => j.ToTable("VaiTroQuyen"));
        }
    }
}
