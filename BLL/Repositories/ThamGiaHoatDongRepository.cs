using System.Linq.Expressions;
using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL.Repositories
{
    public class ThamGiaHoatDongRepository
    {
        protected readonly AppDbContext _db;
        internal DbSet<ThamGiaHoatDong> dbSet;
        public ThamGiaHoatDongRepository(AppDbContext db)
        {
            _db = db;
            dbSet = _db.Set<ThamGiaHoatDong>();
        }

        public async Task AddAsync(ThamGiaHoatDong entity)
        {
            await dbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<ThamGiaHoatDong> entities)
        {
            await dbSet.AddRangeAsync(entities);
        }

        public IEnumerable<ThamGiaHoatDong> Find(Expression<Func<ThamGiaHoatDong, bool>> expression)
        {
            return dbSet.Where(expression).AsNoTracking();
        }

        public async Task<IEnumerable<ThamGiaHoatDong>> GetAllAsync()
        {
            return await dbSet.AsNoTracking().ToListAsync();
        }

        public async Task<ThamGiaHoatDong> GetByIdAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public void Remove(ThamGiaHoatDong entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<ThamGiaHoatDong> entities)
        {
            dbSet.RemoveRange(entities);
        }

        public void Update(ThamGiaHoatDong entity)
        {
            dbSet.Update(entity);
        }
    }
}
