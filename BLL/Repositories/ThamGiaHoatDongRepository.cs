using System.Linq.Expressions;
using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL.Repositories
{
    public class ThamGiaHoatDongRepository : Repository<ThamGiaHoatDong>
    {
        public ThamGiaHoatDongRepository(AppDbContext db):base(db)
        {
        }

    }
}
