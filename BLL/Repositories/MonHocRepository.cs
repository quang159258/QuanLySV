using System.Linq.Expressions;
using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL.Repositories
{
    public class MonHocRepository : Repository<MonHoc>
    {
        public MonHocRepository(AppDbContext db) : base(db)
        {
        }

    }
}
