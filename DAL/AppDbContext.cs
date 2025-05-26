using Microsoft.EntityFrameworkCore;
using DAL.Models;
namespace DAL
{
    public class AppDbContext: DbContext
    {
        public DbSet<GiaoVien> GiaoViens { get; set; }
        public DbSet<HoatDong> HoatDongs { get; set; }
        public DbSet<HocKy> HocKys { get; set; }
        public DbSet<KetQua> KetQuas { get; set; }
        public DbSet<Lop> Lops { get; set; }
        public DbSet<MonHoc> MonHocs { get; set; }
        public DbSet<Quyen> Quyens { get; set; }
        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<ThamGiaHoatDong> ThamGiaHoatDongs { get; set; }
        public DbSet<VaiTro> VaiTros { get; set; }
        public DbSet<YeuCau> YeuCaus { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // --- Composite Key for ThamGiaHoatDong ---
            modelBuilder.Entity<ThamGiaHoatDong>()
                .HasKey(tghd => new { tghd.MaSV, tghd.MaHoatDong }); 

            // --- Relationships for ThamGiaHoatDong ---
            // SinhVien (One) to ThamGiaHoatDong (Many)
            modelBuilder.Entity<ThamGiaHoatDong>()
                .HasOne(tghd => tghd.SinhVien)
                .WithMany(sv => sv.ThamGiaHoatDongs)
                .HasForeignKey(tghd => tghd.MaSV)
                .OnDelete(DeleteBehavior.Restrict); // Or Cascade, depending on your rules

            // HoatDong (One) to ThamGiaHoatDong (Many)
            modelBuilder.Entity<ThamGiaHoatDong>()
                .HasOne(tghd => tghd.HoatDong)
                .WithMany(hd => hd.ThamGiaHoatDongs)
                .HasForeignKey(tghd => tghd.MaHoatDong)
                .OnDelete(DeleteBehavior.Restrict); // Or Cascade

            // --- Composite Key for KetQua ---
            modelBuilder.Entity<KetQua>()
                .HasKey(kq => new { kq.MaSV, kq.MaMonHoc });

            // --- Relationships for KetQua ---
            // SinhVien (One) to KetQua (Many)
            modelBuilder.Entity<KetQua>()
                .HasOne(kq => kq.SinhVien)
                .WithMany(sv => sv.KetQuas)
                .HasForeignKey(kq => kq.MaSV)
                .OnDelete(DeleteBehavior.Restrict);

            // MonHoc (One) to KetQua (Many)
            modelBuilder.Entity<KetQua>()
                .HasOne(kq => kq.MonHoc)
                .WithMany(mh => mh.KetQuas)
                .HasForeignKey(kq => kq.MaMonHoc)
                .OnDelete(DeleteBehavior.Restrict);

            // --- Relationship for GiaoVien ---
            // VaiTro (One) to GiaoVien (Many)
            modelBuilder.Entity<GiaoVien>()
                .HasOne(gv => gv.VaiTro)
                .WithMany(vt => vt.GiaoViens) 
                .HasForeignKey(gv => gv.MaVaiTro)
                .OnDelete(DeleteBehavior.Restrict);

            // --- Relationship for Lop ---
            // GiaoVien (One) to Lop (Many)
            modelBuilder.Entity<Lop>()
                .HasOne(l => l.GiaoVien)
                .WithMany(gv => gv.Lops) 
                .HasForeignKey(l => l.GiaoVienId)
                .OnDelete(DeleteBehavior.Restrict);

            // --- Relationship for MonHoc ---
            // HocKy (One) to MonHoc (Many)
            modelBuilder.Entity<MonHoc>()
                .HasOne(mh => mh.HocKyDeXuat)
                .WithMany(hk => hk.MonHocs) 
                .HasForeignKey(mh => mh.HocKyId)
                .OnDelete(DeleteBehavior.Restrict);

            // --- Relationship for SinhVien ---
            // Lop (One) to SinhVien (Many)
            modelBuilder.Entity<SinhVien>()
                .HasOne(sv => sv.Lop)
                .WithMany(l => l.SinhViens) 
                .HasForeignKey(sv => sv.LopId)
                .OnDelete(DeleteBehavior.Restrict); 

            // --- Relationship for YeuCau ---
            // SinhVien (One) to YeuCau (Many)
            modelBuilder.Entity<YeuCau>()
                .HasOne(yc => yc.SinhVien)
                .WithMany(sv => sv.YeuCaus) 
                .HasForeignKey(yc => yc.MaSV)
                .OnDelete(DeleteBehavior.Cascade); 

            // GiaoVien (One) to YeuCau (Many)
            modelBuilder.Entity<YeuCau>()
                .HasOne(yc => yc.GiaoVien)
                .WithMany(gv => gv.YeuCaus) 
                .HasForeignKey(yc => yc.GiaoVienId)
                .OnDelete(DeleteBehavior.Restrict); 

            // --- Many-to-Many for VaiTro and Quyen ---
            modelBuilder.Entity<VaiTro>()
                .HasMany(v => v.Quyens)
                .WithMany(q => q.VaiTros)
                .UsingEntity<Dictionary<string, object>>( 
                    "VaiTroQuyen", 
                    j => j.HasOne<Quyen>().WithMany().HasForeignKey("QuyenId"), 
                    j => j.HasOne<VaiTro>().WithMany().HasForeignKey("VaiTroId"), 
                    j =>
                    {
                        j.HasKey("VaiTroId", "QuyenId");
                        j.ToTable("VaiTroQuyen"); 
                    }
                );
        }
    }
}
