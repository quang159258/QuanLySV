using System.Linq.Expressions;
using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL.Repositories
{
    public class QuyenRepository
    {
        protected readonly AppDbContext _db;
        internal DbSet<Quyen> dbSet;
        public QuyenRepository(AppDbContext db)
        {
            _db = db;
            dbSet = _db.Set<Quyen>();
        }

        public async Task AddAsync(Quyen entity)
        {
            await dbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<Quyen> entities)
        {
            await dbSet.AddRangeAsync(entities);
        }

        public IEnumerable<Quyen> Find(Expression<Func<Quyen, bool>> expression)
        {
            return dbSet.Where(expression).AsNoTracking();
        }

        public async Task<IEnumerable<Quyen>> GetAllAsync()
        {
            return await dbSet.AsNoTracking().ToListAsync();
        }

        public async Task<Quyen> GetByIdAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public void Remove(Quyen entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<Quyen> entities)
        {
            dbSet.RemoveRange(entities);
        }

        public void Update(Quyen entity)
        {
            dbSet.Update(entity);
        }
    }
}
