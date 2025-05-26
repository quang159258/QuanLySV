using System.Linq.Expressions;
using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL.Repositories
{
    public class HoatDongRepository
    {
        protected readonly AppDbContext _db;
        internal DbSet<HoatDong> dbSet;
        public HoatDongRepository(AppDbContext db)
        {
            _db = db;
            dbSet = _db.Set<HoatDong>();
        }

        public async Task AddAsync(HoatDong entity)
        {
            await dbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<HoatDong> entities)
        {
            await dbSet.AddRangeAsync(entities);
        }

        public IEnumerable<HoatDong> Find(Expression<Func<HoatDong, bool>> expression)
        {
            return dbSet.Where(expression).AsNoTracking();
        }

        public async Task<IEnumerable<HoatDong>> GetAllAsync()
        {
            return await dbSet.AsNoTracking().ToListAsync();
        }

        public async Task<HoatDong> GetByIdAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public void Remove(HoatDong entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<HoatDong> entities)
        {
            dbSet.RemoveRange(entities);
        }

        public void Update(HoatDong entity)
        {
            dbSet.Update(entity);
        }
    }
}
