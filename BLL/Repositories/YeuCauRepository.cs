using System.Linq.Expressions;
using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL.Repositories
{
    public class YeuCauRepository
    {
        protected readonly AppDbContext _db;
        internal DbSet<YeuCau> dbSet;
        public YeuCauRepository(AppDbContext db)
        {
            _db = db;
            dbSet = _db.Set<YeuCau>();
        }

        public async Task AddAsync(YeuCau entity)
        {
            await dbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<YeuCau> entities)
        {
            await dbSet.AddRangeAsync(entities);
        }

        public IEnumerable<YeuCau> Find(Expression<Func<YeuCau, bool>> expression)
        {
            return dbSet.Where(expression).AsNoTracking();
        }

        public async Task<IEnumerable<YeuCau>> GetAllAsync()
        {
            return await dbSet.AsNoTracking().ToListAsync();
        }

        public async Task<YeuCau> GetByIdAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public void Remove(YeuCau entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<YeuCau> entities)
        {
            dbSet.RemoveRange(entities);
        }

        public void Update(YeuCau entity)
        {
            dbSet.Update(entity);
        }
    }
}
