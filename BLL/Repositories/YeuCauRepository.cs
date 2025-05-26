using System.Linq.Expressions;
using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL.Repositories
{
    public class YeuCauRepository : Repository<YeuCau>
    {
        public YeuCauRepository(AppDbContext db):base(db)
        {
        }

    }
}
