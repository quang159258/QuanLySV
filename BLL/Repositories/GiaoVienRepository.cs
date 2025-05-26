using System.Linq.Expressions;
using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL.Repositories
{
    public class GiaoVienRepository
    {
        protected readonly AppDbContext _db;
        internal DbSet<GiaoVien> dbSet;
        public GiaoVienRepository(AppDbContext db)
        {
            _db = db;
            dbSet = _db.Set<GiaoVien>();
        }

        public async Task AddAsync(GiaoVien entity)
        {
            await dbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<GiaoVien> entities)
        {
            await dbSet.AddRangeAsync(entities);
        }

        public IEnumerable<GiaoVien> Find(Expression<Func<GiaoVien, bool>> expression)
        {
            return dbSet.Where(expression).AsNoTracking();
        }

        public async Task<IEnumerable<GiaoVien>> GetAllAsync()
        {
            return await dbSet.AsNoTracking().ToListAsync();
        }

        public async Task<GiaoVien> GetByIdAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public void Remove(GiaoVien entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<GiaoVien> entities)
        {
            dbSet.RemoveRange(entities);
        }

        public void Update(GiaoVien entity)
        {
            dbSet.Update(entity);
        }
    }
}
