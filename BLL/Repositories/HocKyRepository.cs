using System.Linq.Expressions;
using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL.Repositories
{
    public class HocKyRepository:Repository<HocKy>
    {
        public HocKyRepository(AppDbContext db):base(db)
        {
        }

    }
}
