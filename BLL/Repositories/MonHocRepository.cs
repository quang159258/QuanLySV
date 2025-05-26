using System.Linq.Expressions;
using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL.Repositories
{
    public class MonHocRepository
    {
        protected readonly AppDbContext _db;
        internal DbSet<MonHoc> dbSet;
        public MonHocRepository(AppDbContext db)
        {
            _db = db;
            dbSet = _db.Set<MonHoc>();
        }

        public async Task AddAsync(MonHoc entity)
        {
            await dbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<MonHoc> entities)
        {
            await dbSet.AddRangeAsync(entities);
        }

        public IEnumerable<MonHoc> Find(Expression<Func<MonHoc, bool>> expression)
        {
            return dbSet.Where(expression).AsNoTracking();
        }

        public async Task<IEnumerable<MonHoc>> GetAllAsync()
        {
            return await dbSet.AsNoTracking().ToListAsync();
        }

        public async Task<MonHoc> GetByIdAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public void Remove(MonHoc entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<MonHoc> entities)
        {
            dbSet.RemoveRange(entities);
        }

        public void Update(MonHoc entity)
        {
            dbSet.Update(entity);
        }
    }
}
