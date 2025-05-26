using System.Linq.Expressions;
using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL.Repositories
{
    public class LopRepository
    {
        protected readonly AppDbContext _db;
        internal DbSet<Lop> dbSet;
        public LopRepository(AppDbContext db)
        {
            _db = db;
            dbSet = _db.Set<Lop>();
        }

        public async Task AddAsync(Lop entity)
        {
            await dbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<Lop> entities)
        {
            await dbSet.AddRangeAsync(entities);
        }

        public IEnumerable<Lop> Find(Expression<Func<Lop, bool>> expression)
        {
            return dbSet.Where(expression).AsNoTracking();
        }

        public async Task<IEnumerable<Lop>> GetAllAsync()
        {
            return await dbSet.AsNoTracking().ToListAsync();
        }

        public async Task<Lop> GetByIdAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public void Remove(Lop entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<Lop> entities)
        {
            dbSet.RemoveRange(entities);
        }

        public void Update(Lop entity)
        {
            dbSet.Update(entity);
        }
    }
}
