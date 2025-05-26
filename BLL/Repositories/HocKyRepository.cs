using System.Linq.Expressions;
using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL.Repositories
{
    public class HocKyRepository
    {
        protected readonly AppDbContext _db;
        internal DbSet<HocKy> dbSet;
        public HocKyRepository(AppDbContext db)
        {
            _db = db;
            dbSet = _db.Set<HocKy>();
        }

        public async Task AddAsync(HocKy entity)
        {
            await dbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<HocKy> entities)
        {
            await dbSet.AddRangeAsync(entities);
        }

        public IEnumerable<HocKy> Find(Expression<Func<HocKy, bool>> expression)
        {
            return dbSet.Where(expression).AsNoTracking();
        }

        public async Task<IEnumerable<HocKy>> GetAllAsync()
        {
            return await dbSet.AsNoTracking().ToListAsync();
        }

        public async Task<HocKy> GetByIdAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public void Remove(HocKy entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<HocKy> entities)
        {
            dbSet.RemoveRange(entities);
        }

        public void Update(HocKy entity)
        {
            dbSet.Update(entity);
        }
    }
}
