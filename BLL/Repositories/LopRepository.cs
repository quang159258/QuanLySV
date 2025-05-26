using System.Linq.Expressions;
using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL.Repositories
{
    public class LopRepository:Repository<Lop>
    {
        public LopRepository(AppDbContext db) : base(db)
        {
        }

    }
}
