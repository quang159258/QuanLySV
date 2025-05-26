using System.Linq.Expressions;
using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL.Repositories
{
    public class SinhVienRepository
    {
        protected readonly AppDbContext _db;
        internal DbSet<SinhVien> dbSet;
        public SinhVienRepository(AppDbContext db)
        {
            _db = db;
            dbSet = _db.Set<SinhVien>();
        }

        public async Task AddAsync(SinhVien entity)
        {
            await dbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<SinhVien> entities)
        {
            await dbSet.AddRangeAsync(entities);
        }

        public IEnumerable<SinhVien> Find(Expression<Func<SinhVien, bool>> expression)
        {
            return dbSet.Where(expression).AsNoTracking();
        }

        public async Task<IEnumerable<SinhVien>> GetAllAsync()
        {
            return await dbSet.AsNoTracking().ToListAsync();
        }

        public async Task<SinhVien> GetByIdAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public void Remove(SinhVien entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<SinhVien> entities)
        {
            dbSet.RemoveRange(entities);
        }

        public void Update(SinhVien entity)
        {
            dbSet.Update(entity);
        }
    }
}
