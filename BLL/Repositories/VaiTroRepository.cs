using System.Linq.Expressions;
using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL.Repositories
{
    public class VaiTroRepository
    {
        protected readonly AppDbContext _db;
        internal DbSet<VaiTro> dbSet;
        public VaiTroRepository(AppDbContext db)
        {
            _db = db;
            dbSet = _db.Set<VaiTro>();
        }

        public async Task AddAsync(VaiTro entity)
        {
            await dbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<VaiTro> entities)
        {
            await dbSet.AddRangeAsync(entities);
        }

        public IEnumerable<VaiTro> Find(Expression<Func<VaiTro, bool>> expression)
        {
            return dbSet.Where(expression).AsNoTracking();
        }

        public async Task<IEnumerable<VaiTro>> GetAllAsync()
        {
            return await dbSet.AsNoTracking().ToListAsync();
        }

        public async Task<VaiTro> GetByIdAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public void Remove(VaiTro entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<VaiTro> entities)
        {
            dbSet.RemoveRange(entities);
        }

        public void Update(VaiTro entity)
        {
            dbSet.Update(entity);
        }
    }
}
