using System.Linq.Expressions;
using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL.Repositories
{
    public class KetQuaRepository
    {
        protected readonly AppDbContext _db;
        internal DbSet<KetQua> dbSet;
        public KetQuaRepository(AppDbContext db)
        {
            _db = db;
            dbSet = _db.Set<KetQua>();
        }

        public async Task AddAsync(KetQua entity)
        {
            await dbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<KetQua> entities)
        {
            await dbSet.AddRangeAsync(entities);
        }

        public IEnumerable<KetQua> Find(Expression<Func<KetQua, bool>> expression)
        {
            return dbSet.Where(expression).AsNoTracking();
        }

        public async Task<IEnumerable<KetQua>> GetAllAsync()
        {
            return await dbSet.AsNoTracking().ToListAsync();
        }

        public async Task<KetQua> GetByIdAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public void Remove(KetQua entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<KetQua> entities)
        {
            dbSet.RemoveRange(entities);
        }

        public void Update(KetQua entity)
        {
            dbSet.Update(entity);
        }
    }
}
